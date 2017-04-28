using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Messaging;
using System.Text;
using System.Web;

/*
 * THIS IS A PUBLIC DLL USED BY SMSGATEWAY ADAPTER CUSTOMIZATIONS
 * Do not change the signature/behavior of these classes without
 * approval. Check who needs to be warned after the changes are made.
 * 
 */

namespace OutSystems.HubEdition.SMS {

    public class SmsUtils {
		public static string BuildSession( string sender, string receiver) {
			return BuildSession (sender, receiver, SMSSettings.Get(SMSSettings.Configs.Kannel_UnifiedPrefix));
		}

		public static string BuildSession( string sender, string receiver, string unifiedPrefix) {
			if( sender == null) sender = "";
			if( receiver == null) receiver = "";
			sender = NormalizeNumber (sender, unifiedPrefix);
			receiver = NormalizeNumber (receiver, unifiedPrefix);
			string res="";
			int k = sender.Length - 1;
			for (int i=0; i < 12; i++) {
				if (k >= 0 && ((sender[k]>='0' && sender[k]<='9') || sender[k]=='+')) {
					res += (sender[k]=='+' ? 'p' : (char)(sender[k] + 'a' - '0'));
				} else if (k < 0) {
					res += '0';
				} else {
					i--;
				}
				k--;
			}
			k = receiver.Length - 1;
			for (int i=0; i < 12; i++) {
				if (k >= 0 && ((receiver[k]>='0' && receiver[k]<='9') || receiver[k]=='+')) {
					res += (receiver[k]=='+' ? 'p' : (char)(receiver[k] + 'a' - '0'));
				} else if (k < 0) {
					res += '0';
				} else {
					i--;
				}
				k--;
			}
            // #49674 hardcoded values! this project can't reference runtime nor common (cyclic refs)
            // these must correspond to RuntimePlatformUtils.SessionPrefixDotNET and RuntimePlatformUtils.SessionSuffixDotNET
            // if SMS is converted to Java this must change
            // if this class was moved to the runtime platform it could use decent constants
            // but it would impact existing sms gateway adapter customizations... so I'll leave it be
            return "(S(" + res + "))";  
		}

		private static char IntToHex(int n) {
			if (n <= 9) {
				return(char)(n + (int)'0');
			} else {
				return(char)(n - 10 + (int)'a');
			}
		}

		private static int HexToInt(char c) {
			if( c >= '0' && c <= '9') {
				return (int)c-(int)'0';
			}
			if( c >= 'a' && c <= 'f') {
				return (int)c-(int)'a'+10;
			}
			if( c >= 'A' && c <= 'F') {
				return (int)c-(int)'A'+10;
			}
			throw new Exception( "Invalid hex character '" + c + "'");
		}

		public static byte[] HexToBin( string hex) {
			if( hex.Length % 2 == 1) {
				throw new Exception( "Invalid hexadecimal string (contains an odd number of chars)");
			}
			byte[] result = new byte[hex.Length >> 1];
			for( int i=0; i<hex.Length; i=i+2) {
				result[i>>1] = (byte)((HexToInt(hex[i])<<4) + HexToInt(hex[i+1]));
			}
			return result;
		}

		public static string BinToHex( byte[] arr) {
			string result = "";
			foreach( byte b in arr) {
				result = result + (IntToHex((b >>  4) & 0xf)) + (IntToHex(b & 0xf));
			}		
			return result;
		}

		public static byte[] GsmEncode( string s) {
			s = s.Replace("€", "\u0080");
			return Encoding.ASCII.GetBytes(s);
		}

		public static string GsmDecode( byte[] arr) {
			string s = Encoding.ASCII.GetString(arr);
			s = s.Replace("\u0080", "€");
			return s;
		}

		public static string NormalizeNumber (string number, string unifiedPrefix) {
			if (number.StartsWith (unifiedPrefix)) {
				number = number.Substring (unifiedPrefix.Length);
			}
			return number;
		}

		public static string NormalizeNumber (string number) {
            return NormalizeNumber(number, SMSSettings.Get(SMSSettings.Configs.Kannel_UnifiedPrefix));
		}

		public static string QueryStringFromMsg(MobileOriginatedMessage mo) {
			string qs="";
			if (!IsNull(mo.Connection)) {
				qs += "connection=" + HttpUtility.UrlEncode(mo.Connection, Encoding.UTF8) + "&";
			}
			if (!IsNull(mo.Custom1)) {
				qs += "custom1=" + HttpUtility.UrlEncode(mo.Custom1, Encoding.UTF8) + "&";
			}
			if (!IsNull(mo.Custom2)) {
				qs += "custom2=" + HttpUtility.UrlEncode(mo.Custom2, Encoding.UTF8) + "&";
			}
			if (!IsNull(mo.Custom3)) {
				qs += "custom3=" + HttpUtility.UrlEncode(mo.Custom3, Encoding.UTF8) + "&";
			}
			qs += "encoding=";
			switch (mo.Encoding) {
				case SmsEncoding.Default7Bit: {
					qs += HttpUtility.UrlEncode("7bit", Encoding.UTF8) + "&";
					break;
				}
                case SmsEncoding.Utf8: {
                    qs += HttpUtility.UrlEncode("utf-8", Encoding.UTF8) + "&";
                    break;
                }
				case SmsEncoding.Data8Bit: {
					qs += HttpUtility.UrlEncode("8bit", Encoding.UTF8) + "&";
					break;
				}
				case SmsEncoding.Ucs2: {
					qs += HttpUtility.UrlEncode("ucs2", Encoding.UTF8) + "&";
					break;
				}
			}
			if (!IsNull(mo.LargeAccount)) {
				qs += "la=" + HttpUtility.UrlEncode(mo.LargeAccount, Encoding.UTF8) + "&";
			}
			if (!IsNull(mo.MessageId)) {
				qs += "msgid=" + HttpUtility.UrlEncode(mo.MessageId, Encoding.UTF8) + "&";
			}
			if (!IsNull(mo.MSISDN)) {
				qs += "msisdn=" + HttpUtility.UrlEncode(mo.MSISDN, Encoding.UTF8) + "&";
			}
			if (!IsNull(mo.OperatorCode)) {
				qs += "opcode=" + HttpUtility.UrlEncode(mo.OperatorCode, Encoding.UTF8) + "&";
			}
			qs += "priority=" + HttpUtility.UrlEncode(mo.Priority.ToString(), Encoding.UTF8) + "&";
			if (mo.Sent != DateTime.MinValue) {
				qs += "sent=" + HttpUtility.UrlEncode(mo.Sent.ToString("yyyyMMddHHmmss"), Encoding.UTF8) + "&";
			}
			if (!IsNull(mo.UDH)) {
				qs += "udh=" + HttpUtility.UrlEncode(mo.UDH, Encoding.UTF8) + "&";
			}
			if (!IsNull(mo.Message)) {
				qs += "message=" + HttpUtility.UrlEncode(mo.Message, Encoding.UTF8) + "&";
			}
			if (!IsNull(mo.BinaryMessage)) {
				qs += "bin=" + HttpUtility.UrlEncode(mo.BinaryMessage, Encoding.UTF8) + "&";
			}
			qs.TrimEnd(new char[] {'&'});
			return qs;
		}

		public static string QueryStringFromMsg(DeliveryReport dr) {
			string qs="";
			qs += "dlrstatus=" + HttpUtility.UrlEncode(dr.DlrStatus.ToString(), Encoding.UTF8) + "&";
			qs += "msgid=" + HttpUtility.UrlEncode(dr.MessageId, Encoding.UTF8) + "&";
			if (dr.MSISDN != null) {
				qs += "msisdn=" + HttpUtility.UrlEncode(dr.MSISDN, Encoding.UTF8) + "&";
			}
			if (dr.ResultCode != null) {
				qs += "rescode=" + HttpUtility.UrlEncode(dr.ResultCode, Encoding.UTF8) + "&";
			}
			if (dr.ResultDescription != null) {
				qs += "resdesc=" + HttpUtility.UrlEncode(dr.ResultDescription, Encoding.UTF8) + "&";
			}
			qs.TrimEnd(new char[] {'&'});
			return qs;
		}

		public static MobileOriginatedMessage BuildMsgFromRequest(HttpRequest request) {
			return BuildMsgFromCollection(request.QueryString);
		}

		private static bool IsNull(string s) {
			if ((s == null) || (s == "")) {
				return true;
			}
			return false;
		}

		public static MobileOriginatedMessage BuildMsgFromCollection(NameValueCollection col) {
			MobileOriginatedMessage mo = new MobileOriginatedMessage();
			if (!IsNull(col["connection"])) {
				mo.Connection = col["connection"];
			}
			if (!IsNull(col["custom1"])) {
				mo.Custom1 = col["custom1"];
			}
			if (!IsNull(col["custom2"])) {
				mo.Custom2 = col["custom2"];
			}
			if (!IsNull(col["custom3"])) {
				mo.Custom3 = col["custom3"];
			}
			if (!IsNull(col["encoding"]) || !IsNull(col["coding"])) {
				string enc = col["encoding"];
                if (IsNull(enc)) enc = col["coding"];

                enc = enc.ToLowerInvariant();

				if (enc == "7bit") {
					mo.Encoding = SmsEncoding.Default7Bit;
                } else if (enc == "utf-8") {
                    mo.Encoding = SmsEncoding.Utf8;
                } else if (enc == "8bit") {
					mo.Encoding = SmsEncoding.Data8Bit;
                } else if (enc == "ucs2") {
					mo.Encoding = SmsEncoding.Ucs2;
				} else { 
					throw new Exception("Invalid sms encoding type");
				}
			}
			if (!IsNull(col["la"])) {
				mo.LargeAccount = col["la"];
			}
			if (!IsNull(col["msgid"])) {
				mo.MessageId = col["msgid"];
			}
			if (!IsNull(col["msisdn"])) {
				mo.MSISDN = col["msisdn"];
			}
			if (!IsNull(col["opcode"])) {
				mo.OperatorCode = col["opcode"];
			}
			if (!IsNull(col["priority"])) {
				mo.Priority = Convert.ToInt32(col["priority"]);
			}
			if (!IsNull(col["sent"])) {
				string d = col["sent"].ToString();
				mo.Sent = new DateTime(Convert.ToInt32(d.Substring(0, 4)), Convert.ToInt32(d.Substring(4, 2)), Convert.ToInt32(d.Substring(6, 2)), Convert.ToInt32(d.Substring(8, 2)), Convert.ToInt32(d.Substring(10, 2)), Convert.ToInt32(d.Substring(12, 2)));
			}
			if (!IsNull(col["udh"])) {
				mo.UDH = col["udh"];
			}
			if (!IsNull(col["message"])) {
				mo.Message = col["message"];
			}
			if (!IsNull(col["bin"])) {
				mo.BinaryMessage = col["bin"];
			}
			return mo;
		}
	}

	// new enum values for kannel 1.4.1
    // new SMSGatewayAdapter should convert these values into the old enums
    //public enum SmsEncoding : int {
    //    Default7Bit=0,
    //    Data8Bit=1,
    //    Ucs2=2,
    //}

    //public enum SmsMessageClass : int {
    //    NoClass = -1,
    //    Alert = 0,
    //    Me = 1,
    //    Sim = 2,
    //    TE = 3,
    //}	

    // * -- old values (kannel <= 1.3.2) -- *
    // we keep using these for full retro-compatibility
    // of any custom gateway adapters around.
    public enum SmsEncoding : int {
		Default7Bit=1,
		Data8Bit=2,
		Ucs2=3,
        Utf8=1000,
	}

	public enum SmsMessageClass : int {
		NoClass = 0,
		Alert = 1,
		Me = 2,
		Sim = 3,
		TE = 4,
	}	
	// */

	public enum DeliveryReportType {
		Off,
		FailureOnly,
		On
	}

	/// <summary>
	/// Mobile Message
	/// </summary>
	[Serializable()]
	public abstract class MobileMessage {
		public MobileMessage() {
			MessageId = System.Guid.NewGuid().ToString();
		}

		/// <summary>
		/// User phone number. Can also be a space separated list of numbers.
		/// The maximum number of phones in this field is defined in the 
		/// Platform Server configuration
		/// </summary>
		public string MSISDN = "";
		
		/// <summary>
		/// Service Large Account phone number (sometimes called Short Code)
		/// </summary>
		public string LargeAccount = "";

		/// <summary>
		/// Text message. It is assumed the message is already 
		/// converted to the internal encoding (unicode)
		/// </summary>
		public string Message = "";

		/// <summary>
		/// Original message in semi octet format (hex). When specified, the
		/// message is assumed to be binary and the "Message" property is
		/// ignored in favor of "BinaryMessage".
		/// </summary>
		public string BinaryMessage = "";

		/// <summary>
		/// User Defined Header in semi octet format (hex)
		/// </summary>
		public string UDH = "";

		/// <summary>
		/// Message Identifier as specified by the caller 
		/// or unique identifier provided by the Platform Server
		/// </summary>
		public string MessageId = "";

		/// <summary>
		/// Message priority (1-Top, 2-High, 3-Normal, 4-Low)
		/// </summary>
		public int Priority = 3;

		/// <summary>
		/// Message encoding (7bits, 8bits, ucs2)
		/// </summary>
		public SmsEncoding Encoding = SmsEncoding.Default7Bit;

		/// <summary>
		/// SMSC connection
		/// </summary>
		public string Connection = "";

		/// <summary>
		/// A set of custom SMS properties provided by the sms gateway
		/// </summary>
		public string Custom1 = "";
		public string Custom2 = "";
		public string Custom3 = "";
	}

	/// <summary>
	/// Mobile Originated Message 
	/// </summary>
	[Serializable()]
	public class MobileOriginatedMessage : MobileMessage { 

		/// <summary>
		/// Network or Operator code
		/// </summary>
		public string OperatorCode = "";

		/// <summary>
		/// Date and time the message was sent by the mobile
		/// </summary>
		public DateTime Sent = DateTime.Now;
		
	}

	/// <summary>
	/// Mobile Originated Message 
	/// </summary>
	[Serializable()]
	public class MobileTerminatedMessage : MobileMessage {
		
		/// <summary>
		/// When replying to a MobileOriginatedMessage, this property contains the 
		/// MessageId from the MobileOriginatedMessage.
		/// </summary>
		public string OriginalMessageId = "";

		/// <summary>
		/// TP-Protocol-Identifier
		/// </summary>
		public int Pid = -1;

		/// <summary>
		/// Message Class
		/// </summary>
		public SmsMessageClass MClass = SmsMessageClass.NoClass;

		/// <summary>
		/// Network or Operator code
		/// </summary>
		public string OperatorCode = "";

		/// <summary>
		/// Billing description
		/// </summary>
		public string BillingDescription = "";

		/// <summary>
		/// To be used for billing purposes to define the tariff
		/// </summary>
		public string BillingCode = "";

		/// <summary>
		/// eSpace Identitifier (to be used when logging errors)
		/// </summary>
		public int eSpaceId = 0;

		/// <summary>
		/// Tenant Identitifier (to be used when logging errors)
		/// </summary>
		public int TenantId = 0;

		/// <summary>
		/// [espacename] for single tenant espaces or [espace_name]/[tenant_name] 
		/// for multitenant espaces
		/// </summary>
		public string TenantPath = "";

		public DeliveryReportType DeliveryReport = DeliveryReportType.Off;

		/// <summary>
		/// eSpace screen name containing the message
		/// </summary>
		public string ScreenName = "";


		/// <summary>
		/// To be used for error logging purposes
		/// </summary>
		public int UserId = 0;


		/// <summary>
		/// For compatibility purposes
		/// </summary>
		public int CustomId = 0;


		/// <summary>
		/// It is assumed the sms gateway breaks the message into several SMS. 
		/// This parameter defines the maximum number of sms parts.
		/// </summary>
		public int MaximumParts = 1;

		public MobileTerminatedMessage() {
			MessageId = System.Guid.NewGuid().ToString();
		}
	}

	public enum DlrStatusType {
		Delivered = 1,
		NotDelivered = 2,
		QueuedOnSMSC = 4, 
		DeliveredToSMSC = 8, 
		NotDeliveredToSMSC = 16,
		InternalError = 128
	}

	[Serializable()]
	public class DeliveryReport {
		public string MSISDN = "";
		public string MessageId = "";
		public string ResultCode = "";
		public string ResultDescription = "";
		public DlrStatusType DlrStatus;
	}

	public class SMSInterface {
		private static PerformanceCounter InboundSms;
		private static PerformanceCounter InboundSmsPerSec;
		private static string InboundQueueName = null;
		private static string OutboundQueueName = null;

		public static void Init() {

			if( InboundQueueName == null) {
				InboundQueueName = SMSSettings.Get(SMSSettings.Configs.SMSConnector_InboundQueue);
			}

			if( OutboundQueueName == null) {
				OutboundQueueName = SMSSettings.Get(SMSSettings.Configs.SMSConnector_OutboundQueue);
			}

			if( InboundQueueName == null || InboundQueueName == "") {
                throw new Exception("Invalid value in " + SMSSettings.Configs.SMSConnector_InboundQueue);
			}

			if( OutboundQueueName == null || OutboundQueueName == "") {
                throw new Exception("Invalid value in " + SMSSettings.Configs.SMSConnector_OutboundQueue);
			}

			if( InboundSms == null) {
				InboundSms = newCounter("Inbound SMS");
			}

			if( InboundSmsPerSec == null) {
				InboundSmsPerSec = newCounter("Inbound SMS/sec");
			}
		}
        //There's no dependency to RuntimePlatform in this project, so no PerformanceCountersUtils.newCounter
		private static PerformanceCounter newCounter( string counterName) {
            try {
			    PerformanceCounter c = new PerformanceCounter();
			    c.BeginInit();
			    c.CategoryName = "OutSystems";
			    c.CounterName = counterName;
			    c.MachineName = ".";
			    c.ReadOnly = false;
			    c.EndInit();
			    return c;
            } catch {
                return null;
            }
		}

		public static void QueueInboundSMS( MobileOriginatedMessage msg) {
			MessageQueue _mq = null;

			_mq = new MessageQueue ( InboundQueueName);
			_mq.Formatter = new BinaryMessageFormatter();

			if( msg.MessageId == null || msg.MessageId == "") {
				msg.MessageId = System.Guid.NewGuid().ToString();
			}

			Message qmsg = new Message( msg, new BinaryMessageFormatter()); 
			qmsg.Recoverable = true;
			switch (msg.Priority) {
				case 1:
					qmsg.Priority = MessagePriority.Highest;
					break;
				case 2:
					qmsg.Priority = MessagePriority.High;
					break;
				// case 3 is below
				case 4:
					qmsg.Priority = MessagePriority.Low;
					break;
				default:
				case 3:
					qmsg.Priority = MessagePriority.Normal;
					break;
			}
			qmsg.Label = "MobileOriginatedMessage";
			_mq.Send( qmsg);
			qmsg.Dispose();

			InboundSms.Increment();
			InboundSmsPerSec.Increment();
		}

		public static void QueueDeliveryReport( DeliveryReport dlr ) {
			MessageQueue _mq = null;

			_mq = new MessageQueue ( InboundQueueName);
			_mq.Formatter = new BinaryMessageFormatter();

			if( dlr.MessageId == null || dlr.MessageId == "") {
				throw new Exception("Empty MessageId in delivery report.\nMSIDN : " + dlr.MSISDN + "\nDlr Status : " + dlr.DlrStatus.ToString() + "\nResult Code : " + dlr.ResultCode + "\nResult Code Description : " + dlr.ResultDescription);
			}

			Message qmsg = new Message( dlr, new BinaryMessageFormatter()); 
			qmsg.Recoverable = true;
			qmsg.Priority = MessagePriority.Low;
			qmsg.Label = "DeliveryReport";
			_mq.Send( qmsg);
			qmsg.Dispose();
		}

		public static void QueueOutboundSMS( MobileTerminatedMessage msg) {
			MessageQueue _mq = null;

			_mq = new MessageQueue ( OutboundQueueName);
			_mq.Formatter = new BinaryMessageFormatter();

			if( msg.MessageId == null || msg.MessageId == "") {
				msg.MessageId = System.Guid.NewGuid().ToString();
			}

			Message qmsg = new Message( msg, new BinaryMessageFormatter()); 
			qmsg.Recoverable = true;
			switch (msg.Priority) {
				case 1:
					qmsg.Priority = MessagePriority.Highest;
					break;
				case 2:
					qmsg.Priority = MessagePriority.High;
					break;
				// case 3 is below
				case 4:
					qmsg.Priority = MessagePriority.Low;
					break;
				default:
				case 3:
					qmsg.Priority = MessagePriority.Normal;
					break;
			}
			qmsg.Label = "MobileTerminatedMessage";
			_mq.Send( qmsg);
			qmsg.Dispose();
		}
	}

	public enum SubmitResult { 
		Success,
		MustRetryLater,
		FatalError
	}

	public interface ISMSGatewayAdapter {
		/// <summary>
		/// Each return result has a specific meaning:
		/// Success - The message has been successfully submitted. 
		///			No error is logged and the message is removed from the queue.
		/// MustRetryLater - Temporary error submitting the message.
		///			No error is logged. The message is kept in the queue to be
		///			processed later. After a fixed number of retries the message
		///			is discarded and an error specified in resultMessage is logged.
		///	FatalError - This has the same behavior as raising an exception. The 
		///			message is removed from the queue and the error message specified 
		///			is logged.
		/// </summary>
		SubmitResult Process( MobileTerminatedMessage msg, out string resultMessage);
	}
}
