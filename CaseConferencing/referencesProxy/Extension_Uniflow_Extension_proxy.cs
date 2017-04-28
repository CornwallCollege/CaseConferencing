﻿/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

// Proxy for reference Extension with name Uniflow_Extension and key LOqnYlm1mUKFuf92gVRx0A
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
	/// Class: RssExtensionUniflow_Extension
	/// </summary>
	public class RssExtensionUniflow_Extension {
		/// <summary>
		/// Extension Variable: issUniflow_Extension
		/// </summary>
		protected static OutSystems.NssUniflow_Extension.IssUniflow_Extension issUniflow_Extension = (OutSystems.NssUniflow_Extension.IssUniflow_Extension) new OutSystems.NssUniflow_Extension.CssUniflow_Extension();
		protected static int _maxExtensionLogsPerRequest = OutSystems.HubEdition.RuntimePlatform.Settings.GetInt(OutSystems.HubEdition.RuntimePlatform.Settings.Configs.Log_MaxLogsPerRequest_Extension);
		public static void MssGetPrintCreditBalanceForUser(HeContext heContext, string inParamUserName, out string outParamPrintCreditBalance) {
			DateTime startTime = DateTime.Now;
			String errorLogId = "";
			try {
				issUniflow_Extension.MssGetPrintCreditBalanceForUser(out outParamPrintCreditBalance, inParamUserName);
			} catch (Exception ex) {
				errorLogId = ErrorLog.LogApplicationError(ex, heContext, "Extension method execution: Uniflow_Extension.GetPrintCreditBalanceForUser");
				throw ex;
			} finally {
				if (errorLogId != string.Empty || (!heContext.AppInfo.SelectiveLoggingEnabled ||
				(heContext.AppInfo.ExtensionProperties.AllowLogging(33) && heContext.AppInfo.Properties.AllowLogging))) {

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
						DateTime.Now, Convert.ToInt32(DateTime.Now.Subtract(startTime).TotalMilliseconds), "GetPrintCreditBalanceForUser",
						heContext.Session.SessionID, heContext.AppInfo.eSpaceId, heContext.AppInfo.Tenant.Id,
						heContext.Session.UserId, 33, Environment.MachineName, errorLogId);
						heContext.ExtensionLogCount = extLogCount + 1;
					}
				}
				RuntimePlatformUtils.LogSlowExtensionCall(startTime, "Uniflow_Extension.GetPrintCreditBalanceForUser");
			}
		}




		public class Factory {
		}
		public class DefaultValues {
		}
	}
}