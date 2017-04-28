﻿/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

// Proxy for reference Extension with name HTTPRequestHandler and key DA_Wy4yEUkaF0IjTCm06Rw
using System;
using System.Data;
using System.Reflection;
using System.Collections;
using System.Runtime.Serialization;
using OutSystems.ObjectKeys;
using OutSystems.RuntimeCommon;
using OutSystems.HubEdition.RuntimePlatform;
using System.Collections.Generic;
using System.Xml;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.Internal.Db;
using OutSystems.HubEdition.RuntimePlatform.Log;
using System.Web.UI;
using OutSystems.HubEdition.WebWidgets;
using OutSystems.HubEdition.RuntimePlatform.Web;
using ssCaseConferencing;
namespace ssCaseConferencing {
	/// <summary>
	/// Class: RssExtensionHTTPRequestHandler
	/// </summary>
	public class RssExtensionHTTPRequestHandler {
		/// <summary>
		/// Extension Variable: issHTTPRequestHandler
		/// </summary>
		protected static OutSystems.NssHTTPRequestHandler.IssHTTPRequestHandler issHTTPRequestHandler = (OutSystems.NssHTTPRequestHandler.IssHTTPRequestHandler) new OutSystems.NssHTTPRequestHandler.CssHTTPRequestHandler();
		protected static int _maxExtensionLogsPerRequest = OutSystems.HubEdition.RuntimePlatform.Settings.GetInt(OutSystems.HubEdition.RuntimePlatform.Settings.Configs.Log_MaxLogsPerRequest_Extension);
		public static void MssMakeAbsoluteURL(HeContext heContext, string inParamURL, out string outParamAbsoluteURL) {
			DateTime startTime = DateTime.Now;
			String errorLogId = "";
			try {
				issHTTPRequestHandler.MssMakeAbsoluteURL(inParamURL, out outParamAbsoluteURL);
			} catch (Exception ex) {
				errorLogId = ErrorLog.LogApplicationError(ex, heContext, "Extension method execution: HTTPRequestHandler.MakeAbsoluteURL");
				throw ex;
			} finally {
				if (errorLogId != string.Empty || (!heContext.AppInfo.SelectiveLoggingEnabled ||
				(heContext.AppInfo.ExtensionProperties.AllowLogging(12) && heContext.AppInfo.Properties.AllowLogging))) {

					int extLogCount = heContext.ExtensionLogCount;
					if (extLogCount == _maxExtensionLogsPerRequest) {
						// issue warning
						GeneralLog.StaticWrite(
						DateTime.Now, heContext.Session.SessionID, heContext.AppInfo.eSpaceId, heContext.AppInfo.Tenant.Id,
						heContext.Session.UserId, "The maximum number (" + _maxExtensionLogsPerRequest + ") of allowed Extension Log entries per request has been exceeded. No more entries will be logged in this request.",
						 "WARNING", "SLOWEXTENSION", "");
						heContext.ExtensionLogCount = extLogCount + 1;
					} else if (extLogCount < _maxExtensionLogsPerRequest) {
						ExtensionLog.StaticWrite(
						DateTime.Now, Convert.ToInt32(DateTime.Now.Subtract(startTime).TotalMilliseconds), "MakeAbsoluteURL",
						heContext.Session.SessionID, heContext.AppInfo.eSpaceId, heContext.AppInfo.Tenant.Id,
						heContext.Session.UserId, 12, Environment.MachineName, errorLogId);
						heContext.ExtensionLogCount = extLogCount + 1;
					}
				}
				RuntimePlatformUtils.LogSlowExtensionCall(startTime, "HTTPRequestHandler.MakeAbsoluteURL");
			}
		}


		public static void MssAddHeader(HeContext heContext, string inParamName, string inParamValue) {
			DateTime startTime = DateTime.Now;
			String errorLogId = "";
			try {
				issHTTPRequestHandler.MssAddHeader(inParamName, inParamValue);
			} catch (Exception ex) {
				errorLogId = ErrorLog.LogApplicationError(ex, heContext, "Extension method execution: HTTPRequestHandler.AddHeader");
				throw ex;
			} finally {
				if (errorLogId != string.Empty || (!heContext.AppInfo.SelectiveLoggingEnabled ||
				(heContext.AppInfo.ExtensionProperties.AllowLogging(12) && heContext.AppInfo.Properties.AllowLogging))) {

					int extLogCount = heContext.ExtensionLogCount;
					if (extLogCount == _maxExtensionLogsPerRequest) {
						// issue warning
						GeneralLog.StaticWrite(
						DateTime.Now, heContext.Session.SessionID, heContext.AppInfo.eSpaceId, heContext.AppInfo.Tenant.Id,
						heContext.Session.UserId, "The maximum number (" + _maxExtensionLogsPerRequest + ") of allowed Extension Log entries per request has been exceeded. No more entries will be logged in this request.",
						 "WARNING", "SLOWEXTENSION", "");
						heContext.ExtensionLogCount = extLogCount + 1;
					} else if (extLogCount < _maxExtensionLogsPerRequest) {
						ExtensionLog.StaticWrite(
						DateTime.Now, Convert.ToInt32(DateTime.Now.Subtract(startTime).TotalMilliseconds), "AddHeader",
						heContext.Session.SessionID, heContext.AppInfo.eSpaceId, heContext.AppInfo.Tenant.Id,
						heContext.Session.UserId, 12, Environment.MachineName, errorLogId);
						heContext.ExtensionLogCount = extLogCount + 1;
					}
				}
				RuntimePlatformUtils.LogSlowExtensionCall(startTime, "HTTPRequestHandler.AddHeader");
			}
		}


		public static void MssAddMetaHttpEquivTag(HeContext heContext, string inParamHttpEquiv, string inParamContent) {
			DateTime startTime = DateTime.Now;
			String errorLogId = "";
			try {
				issHTTPRequestHandler.MssAddMetaHttpEquivTag(inParamHttpEquiv, inParamContent);
			} catch (Exception ex) {
				errorLogId = ErrorLog.LogApplicationError(ex, heContext, "Extension method execution: HTTPRequestHandler.AddMetaHttpEquivTag");
				throw ex;
			} finally {
				if (errorLogId != string.Empty || (!heContext.AppInfo.SelectiveLoggingEnabled ||
				(heContext.AppInfo.ExtensionProperties.AllowLogging(12) && heContext.AppInfo.Properties.AllowLogging))) {

					int extLogCount = heContext.ExtensionLogCount;
					if (extLogCount == _maxExtensionLogsPerRequest) {
						// issue warning
						GeneralLog.StaticWrite(
						DateTime.Now, heContext.Session.SessionID, heContext.AppInfo.eSpaceId, heContext.AppInfo.Tenant.Id,
						heContext.Session.UserId, "The maximum number (" + _maxExtensionLogsPerRequest + ") of allowed Extension Log entries per request has been exceeded. No more entries will be logged in this request.",
						 "WARNING", "SLOWEXTENSION", "");
						heContext.ExtensionLogCount = extLogCount + 1;
					} else if (extLogCount < _maxExtensionLogsPerRequest) {
						ExtensionLog.StaticWrite(
						DateTime.Now, Convert.ToInt32(DateTime.Now.Subtract(startTime).TotalMilliseconds), "AddMetaHttpEquivTag",
						heContext.Session.SessionID, heContext.AppInfo.eSpaceId, heContext.AppInfo.Tenant.Id,
						heContext.Session.UserId, 12, Environment.MachineName, errorLogId);
						heContext.ExtensionLogCount = extLogCount + 1;
					}
				}
				RuntimePlatformUtils.LogSlowExtensionCall(startTime, "HTTPRequestHandler.AddMetaHttpEquivTag");
			}
		}


		public static void MssRunJavaScript(HeContext heContext, string inParamScript) {
			DateTime startTime = DateTime.Now;
			String errorLogId = "";
			try {
				issHTTPRequestHandler.MssRunJavaScript(inParamScript);
			} catch (Exception ex) {
				errorLogId = ErrorLog.LogApplicationError(ex, heContext, "Extension method execution: HTTPRequestHandler.RunJavaScript");
				throw ex;
			} finally {
				if (errorLogId != string.Empty || (!heContext.AppInfo.SelectiveLoggingEnabled ||
				(heContext.AppInfo.ExtensionProperties.AllowLogging(12) && heContext.AppInfo.Properties.AllowLogging))) {

					int extLogCount = heContext.ExtensionLogCount;
					if (extLogCount == _maxExtensionLogsPerRequest) {
						// issue warning
						GeneralLog.StaticWrite(
						DateTime.Now, heContext.Session.SessionID, heContext.AppInfo.eSpaceId, heContext.AppInfo.Tenant.Id,
						heContext.Session.UserId, "The maximum number (" + _maxExtensionLogsPerRequest + ") of allowed Extension Log entries per request has been exceeded. No more entries will be logged in this request.",
						 "WARNING", "SLOWEXTENSION", "");
						heContext.ExtensionLogCount = extLogCount + 1;
					} else if (extLogCount < _maxExtensionLogsPerRequest) {
						ExtensionLog.StaticWrite(
						DateTime.Now, Convert.ToInt32(DateTime.Now.Subtract(startTime).TotalMilliseconds), "RunJavaScript",
						heContext.Session.SessionID, heContext.AppInfo.eSpaceId, heContext.AppInfo.Tenant.Id,
						heContext.Session.UserId, 12, Environment.MachineName, errorLogId);
						heContext.ExtensionLogCount = extLogCount + 1;
					}
				}
				RuntimePlatformUtils.LogSlowExtensionCall(startTime, "HTTPRequestHandler.RunJavaScript");
			}
		}


		public static void MssGetEntryURL(HeContext heContext, string inParamEntryName, string inParameSpaceName, string inParamFirstParameterName, string inParamFirstParameterValue, string inParamSecondParameterName, string inParamSecondParameterValue, string inParamThirdParameterName, string inParamThirdParameterValue, string inParamFourthParameterName, string inParamFourthParameterValue, string inParamFifthParameterName, string inParamFifthParameterValue, out string outParamURL) {
			DateTime startTime = DateTime.Now;
			String errorLogId = "";
			try {
				issHTTPRequestHandler.MssGetEntryURL(inParamEntryName, inParameSpaceName, inParamFirstParameterName, inParamFirstParameterValue, inParamSecondParameterName, inParamSecondParameterValue, inParamThirdParameterName, inParamThirdParameterValue, inParamFourthParameterName, inParamFourthParameterValue, inParamFifthParameterName, inParamFifthParameterValue, out outParamURL);
			} catch (Exception ex) {
				errorLogId = ErrorLog.LogApplicationError(ex, heContext, "Extension method execution: HTTPRequestHandler.GetEntryURL");
				throw ex;
			} finally {
				if (errorLogId != string.Empty || (!heContext.AppInfo.SelectiveLoggingEnabled ||
				(heContext.AppInfo.ExtensionProperties.AllowLogging(12) && heContext.AppInfo.Properties.AllowLogging))) {

					int extLogCount = heContext.ExtensionLogCount;
					if (extLogCount == _maxExtensionLogsPerRequest) {
						// issue warning
						GeneralLog.StaticWrite(
						DateTime.Now, heContext.Session.SessionID, heContext.AppInfo.eSpaceId, heContext.AppInfo.Tenant.Id,
						heContext.Session.UserId, "The maximum number (" + _maxExtensionLogsPerRequest + ") of allowed Extension Log entries per request has been exceeded. No more entries will be logged in this request.",
						 "WARNING", "SLOWEXTENSION", "");
						heContext.ExtensionLogCount = extLogCount + 1;
					} else if (extLogCount < _maxExtensionLogsPerRequest) {
						ExtensionLog.StaticWrite(
						DateTime.Now, Convert.ToInt32(DateTime.Now.Subtract(startTime).TotalMilliseconds), "GetEntryURL",
						heContext.Session.SessionID, heContext.AppInfo.eSpaceId, heContext.AppInfo.Tenant.Id,
						heContext.Session.UserId, 12, Environment.MachineName, errorLogId);
						heContext.ExtensionLogCount = extLogCount + 1;
					}
				}
				RuntimePlatformUtils.LogSlowExtensionCall(startTime, "HTTPRequestHandler.GetEntryURL");
			}
		}




		public class Factory {
		}
		public class DefaultValues {
		}
	}
}