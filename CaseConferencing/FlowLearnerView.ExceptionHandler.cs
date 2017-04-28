﻿/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

using System;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.Internal.Db;
using OutSystems.HubEdition.RuntimePlatform.Log;
using OutSystems.HubEdition.RuntimePlatform.Web;
using OutSystems.HubEdition.WebWidgets;

namespace ssCaseConferencing.Flows.FlowLearnerView {

	public class ExceptionHandler {

		private readonly bool isEmailScreen;
		private readonly OSPage page;

		public ExceptionHandler(OSPage page, bool isEmailScreen) {
			this.page = page;
			this.isEmailScreen = isEmailScreen;
		}

		private OSPage Page {
			get {
				return page; 
			}
		}

		private HttpServerUtility Server {
			get {
				return Page.Server; 
			}
		}

		private string GetRedirectionProtocol(bool destinationIsSecure) {
			return Page.GetRedirectionProtocol(destinationIsSecure);
		}

		private HttpRequest Request {
			get {
				return Page.Request; 
			}
		}

		private HttpResponse Response {
			get {
				return Page.Response; 
			}
		}

		private HttpSessionState Session {
			get {
				return Page.Session; 
			}
		}

		public bool HandleException() {
			LocalState dummy = null;
			return HandleException(ref dummy);
		}

		public bool HandleException(ref LocalState flowState) {
			Exception excep = Server.GetLastError();
			if (excep is LicensingException) {
				return true;
			}

			HeContext heContext = Global.App.OsContext;
			if (heContext.VisitedExceptionHandlerFlows.Contains("LearnerView")) {
				return false;
			}
			heContext.VisitedExceptionHandlerFlows.Add("LearnerView");

			if (heContext.Session.EntryPoint == null) {
				heContext.Session.EntryPoint = HeContext.UnknownEntryPoint;
			}
			while (excep != null) {
				if (excep is System.Threading.ThreadAbortException) {
					return true;
				}
				excep = excep.InnerException;
			}
			excep = Server.GetLastError();
			if (excep is System.Reflection.TargetInvocationException) {
				excep = excep.InnerException;
			}
			heContext.Session["ExceptionMessage"] = excep.Message;
			heContext.Session[BuiltInFunction.ExceptionURLSessionName] = BuiltInFunction.GetBookmarkableURL();
			Response.Clear();

			if (isEmailScreen) {
				ErrorLog.LogApplicationError(excep, heContext, "");
				return true;
			}

			if (heContext.CanUseCustomErrorHandler(excep)) {
				if (new RsseSpaceThemeProvider.Themes.ThemeThemeProvider.ExceptionHandler(Page, isEmailScreen).HandleException()) {
					return true;
				}

			}
			DatabaseAccess.FreeupResources(false);

			Server.Transfer("_WebErrorPage.aspx");
			return true;
		}
	}
}