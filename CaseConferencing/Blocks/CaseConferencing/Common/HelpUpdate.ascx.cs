﻿/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

using System;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Web.SessionState;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.HubEdition.RuntimePlatform.Log;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.Internal.Db;
using OutSystems.HubEdition.RuntimePlatform.Web;
using OutSystems.HubEdition.RuntimePlatform.Email;
using OutSystems.HubEdition.WebWidgets;
using OutSystems.HubEdition.WebWidgets.Behaviors;
using OutSystems.RuntimeCommon;
using OutSystems.ObjectKeys;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Runtime.Serialization;
using System.Web.Caching;
using System.Text;


namespace ssCaseConferencing.Flows.FlowCommon {
	public abstract class WBlkHelpUpdate: OSUserControl, IWebScreen, INegotiateTabIndexes, IAjaxNotifyEvent {

		/// <summary>
		/// Delegate Definitions
		/// </summary>
		/// <summary>
		/// Custom Events Definitions
		/// </summary>
		/// <summary>
		/// Parameters and Local Variables Definitions
		/// </summary>
		protected OutSystems.HubEdition.WebWidgets.Container wt_Container5;
		/// <summary>
		/// Variable (wt_Link2) with Link component
		/// </summary>
		protected OutSystems.HubEdition.WebWidgets.LinkButton wt_Link2;
		protected OutSystems.HubEdition.WebWidgets.Container wtUpdateIndicatorBackground;
		protected OutSystems.HubEdition.WebWidgets.Container wt_Container4;
		private bool _isRendering = false;
		public HeContext heContext;
		private static Hashtable htTabIndexGroups = new Hashtable();
		private Hashtable htTabIndexGroupsTI = new Hashtable();
		public string InstanceID;
		public string RuntimeID= "";
		RLUpdateCountRecordList queryResGetUpdateCount_outParamList = new RLUpdateCountRecordList();
		int queryResGetUpdateCount_outParamCount = 0;
		/// <summary>
		/// Action <code>Preparation</code> that represents the Service Studio preparation
		///  <code>Preparation</code> <p> Description: </p>
		/// </summary>
		public void Preparation(HeContext heContext) {
			CheckPermissions(heContext);
			// Query QueryGetUpdateCount
			int QueryGetUpdateCount_maxRecords = 0;
			queryResGetUpdateCount_outParamList = FuncssPreparation.QueryGetUpdateCount(heContext, QueryGetUpdateCount_maxRecords, IterationMultiplicity.Never, out queryResGetUpdateCount_outParamCount, ((int) Global.App.OsContext.Session["UserID"])
			);
		}
		static WBlkHelpUpdate() {
		}
		override protected void OnInit(EventArgs e) {
			InitializeComponent();
			base.OnInit(e);
		}
		private void InitializeComponent() {
			if (this.wt_Link2 != null) {
				this.wt_Link2.Click += new System.EventHandler(this.wt_Link2_Click);
			}
			this.Load += new System.EventHandler(this.Page_Load);
			this.Unload += new System.EventHandler(this.Page_Unload);
		}
		private void Page_Load(object sender, System.EventArgs e) {
			heContext = Global.App.OsContext;
			RuntimeID = ClientID;
			if (!Visible) return;
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ssCaseConferencing.Global.eSpaceId;
				if (!IsPostBack || _isRendering) {
					// register this block in the page so for later outputting the block javascript includes in their correct order
					((OSPage) Page).RegisterBlock(this);
					if (_isRendering) {
						Preparation(heContext);
					}
					bool bindEditRecords = IsViewStateEmpty;
				} else {
					FetchViewState();
				}
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}

		}
		/// <summary>
		/// This method is called when there is a submit. So it should validate input values and call the
		///  correct system event user action if needed
		/// </summary>
		public void OnSubmit(string parentEditRecord, bool validate) {
			if (!WasRendered) {
				return;
			}
			CallOnSubmitOnChildren(Controls, parentEditRecord, validate);
		}
		public void CallOnSubmitOnChildren(ControlCollection children, string parentEditRecord, bool validate) {
			foreach(Control ctrl in children) {
				IWebScreen screen = ctrl as IWebScreen;

				if (screen != null) {
					screen.OnSubmit(parentEditRecord, validate);
				} else {
					CallOnSubmitOnChildren(ctrl.Controls, parentEditRecord, validate);
				}
			}
		}
		public short NegotiateTabIndexes(short tabindex, bool setTabIndex) {
			Control rootCtrl = this;
			if ((this.Controls.Count == 1) && (typeof(HtmlForm).IsInstanceOfType(this.Controls[0]))) {
				rootCtrl = this.Controls[0];
			} else {
				rootCtrl = this;
			}
			tabindex = NegotiateTabIndexesRecursively(tabindex, rootCtrl, setTabIndex);
			return tabindex;
		}

		public short NegotiateTabIndexesRecursively(short tabindex, Control rootCtrl, bool setTabIndex) {

			bool bAssignTabIndex = false;
			WebControl ctrl = null;
			HtmlControl htmlCtrl = null;
			foreach(Control child in rootCtrl.Controls) {
				if (child is INegotiateTabIndexes) {
					tabindex = ((INegotiateTabIndexes) child).NegotiateTabIndexes(tabindex, setTabIndex);
					continue;
				}
				if (typeof(WebControl).IsInstanceOfType(child)) {
					ctrl = (WebControl) child;
					bAssignTabIndex = false;
					if (ctrl is OutSystems.HubEdition.WebWidgets.TextBox | ctrl is OutSystems.HubEdition.WebWidgets.CheckBox | ctrl is OutSystems.HubEdition.WebWidgets.RadioButton | ctrl is OutSystems.HubEdition.WebWidgets.DropDownList) {

						bAssignTabIndex = true;
					} else if (ctrl is System.Web.UI.WebControls.LinkButton | ctrl is System.Web.UI.WebControls.Button | ctrl is System.Web.UI.WebControls.HyperLink | ctrl is System.Web.UI.WebControls.ListBox) {
						bAssignTabIndex = true;
					}
					else if (ctrl is PlaceholderContainer)
					{
						INegotiateTabIndexes placeholderOwner = (INegotiateTabIndexes) Utils.GetOwnerOfControl(ctrl);
						tabindex = placeholderOwner.NegotiateTabIndexesRecursively(tabindex, ctrl, setTabIndex);
						continue;
					}

					short prevTabIndex = ViewStateAttributes.GetTabIndex(ctrl);
					if (bAssignTabIndex && setTabIndex) {
						object b = htTabIndexGroups[ctrl.ID];
						if (b != null) {
							string groupid = b.ToString();
							if (htTabIndexGroupsTI[groupid] == null) {
								htTabIndexGroupsTI[groupid] = tabindex++;
							}
							ViewStateAttributes.SetTabIndex(ctrl, prevTabIndex <= 0 ? Convert.ToInt16(htTabIndexGroupsTI[groupid]): prevTabIndex++);
						} else {
							ViewStateAttributes.SetTabIndex(ctrl, prevTabIndex <= 0 ? tabindex++: prevTabIndex++);
						}
					}
					tabindex = Math.Max(tabindex, prevTabIndex);
				} else if (child is HtmlControl && setTabIndex) {
					htmlCtrl = (HtmlControl) child;
					if (htmlCtrl is System.Web.UI.HtmlControls.HtmlInputFile) {
						htmlCtrl.Attributes.Add("tabIndex", Convert.ToString(tabindex++));
					}
				}
				if (child.Controls.Count > 0) {
					tabindex = NegotiateTabIndexesRecursively(tabindex, child, setTabIndex);
				}
			}
			return tabindex;
		}


		/// <summary>
		/// Store widget and variable data in the viewstate
		/// </summary>
		protected override void StoreViewState() {
			base.StoreViewState();
			ViewStateAttributes.EnsureNotEmpty();
		}
		/// <summary>
		/// Restore widget and variable data from the viewstate
		/// </summary>
		protected override void FetchViewState() {
			base.FetchViewState();
			if (IsViewStateEmpty) return;
			try {
			} catch (Exception e) {
				throw new Exception("Error Deserializing ViewState", e); 
			}
		}

		/// <summary>
		/// Store visibility information of the web block and input widgets in the viewstate
		/// </summary>
		protected override void StoreInputsAndWebBlockVisibility() {
			ViewStateAttributes.EnsureNotEmpty();
		}
		/// <summary>
		/// Restore visibility information of the web block and input widgets from the viewstate
		/// </summary>
		protected override void RestoreInputsAndWebBlockVisibility() {
			WasRendered = true;
		}

		private void Page_Unload(object sender, System.EventArgs e) {
		}

		public LocalState PushStack() {
			throw new NotImplementedException();
		}

		public void doRefreshScreen(HeContext heContext) {
			((IWebScreen) this.Parent.Page).doRefreshScreen(heContext);
		}

		public void doAJAXRefreshScreen(HeContext heContext) {
			StoreViewState();
			((IWebScreen) this.Parent.Page).doAJAXRefreshScreen(heContext);
		}

		public static void GetCss(TextWriter writer, bool inline, HashSet<string> visited) {
			string blockId = "CaseConferencing.KfpAa79RrRUaQSPrU6XYoGA";
			if (visited.Contains(blockId)) {
				return; 
			}
			visited.Add(blockId);
			if (!inline) {
				GetCssIncludes(writer, visited);
			} else {
				GetInlineCss(writer, visited);
			}
		}

		private static void GetCssIncludes(TextWriter writer, HashSet<string> visited) {
			InnerGetCss(writer, false, visited);
			CssHelper.WriteCssInclude(writer, AppUtils.Instance.getImagePath() + "Blocks/CaseConferencing/Common/HelpUpdate.css" + AppUtils.Instance.CacheInvalidationSuffix);
		}

		private static void GetInlineCss(TextWriter writer, HashSet<string> visited) {
			StringWriter localCssWriter = new StringWriter();
			localCssWriter.NewLine = writer.NewLine;
			string localCss = Environment.NewLine;
			InnerGetCss(localCssWriter, true, visited);
			localCss += localCssWriter.ToString();
			HashSet<string> cssVisited = new HashSet<string>();
			string read;
			AppUtils.getResourceFileContent(out read, "Blocks\\CaseConferencing\\Common\\HelpUpdate.css");
			localCss += OutSystems.HubEdition.RuntimePlatform.Email.EmailHelper.FlattenCSSFile(read, "Blocks\\CaseConferencing\\Common\\HelpUpdate.css", cssVisited);
			writer.Write(localCss);
		}

		private static void InnerGetCss(TextWriter writer, bool inline, HashSet<string> visited) {
		}

		private void Page_Error(object sender, System.EventArgs e) {
		}
		public void CheckPermissions(HeContext heContext) {
			((IWebScreen) this.Page).CheckPermissions(heContext);
		}
		protected static string GetString(string key, string defaultValue) {
			return Global.GetStringResource(key, defaultValue);
		}

		public ObjectKey Key {
			get {
				return ObjectKey.Parse("fpAa79RrRUaQSPrU6XYoGA"); 
			}
		}
		public bool isSecure {
			get {
				return ((IWebScreen) Page).isSecure; 
			}
		}
		/// <summary>
		/// Action <code>CommandRedirectToMessages</code> that represents the Service Studio screen action
		///  <code>RedirectToMessages</code> <p> Description: </p>
		/// </summary>
		private bool CommandRedirectToMessages(HeContext heContext) {
			CheckPermissions(heContext);
			try {
				// Destination = ExternalURL

				if (OSPage.IsAjaxRequest) {
					// go to target page
					{

						if ((((IWebScreen) Page).isSecure || RuntimePlatformUtils.RequestIsSecure(Request)) && (heContext.AppInfo.eSpaceId == Global.eSpaceId)) {
							((OSPage) Page).ClearErrorHandler();
							if (heContext.AppInfo.eSpaceId==Global.eSpaceId) {
								string sURL = Functions.rssextensionhttprequesthandler_ActionGetEntryURL(heContext, "HelpUpdatesMessages", "Caseconferencing", "", "", "", "", "", "", "", "", "", "");
								sURL = sURL.Replace("&amp;", "&");
								sURL = RuntimePlatformUtils.GetURL(sURL, AppUtils.Instance, Global.App.eSpaceName);
								((OSPageViewState) Page).RedirectLocation = sURL;
							} else {
								string sURL = Functions.rssextensionhttprequesthandler_ActionGetEntryURL(heContext, "HelpUpdatesMessages", "Caseconferencing", "", "", "", "", "", "", "", "", "", "");
								sURL = sURL.Replace("&amp;", "&");
								sURL = RuntimePlatformUtils.GetURL(sURL, AppUtils.Instance, Global.App.eSpaceName);
								((OSPage) Page).ClearErrorHandler();
								Response.BufferOutput = true;
								if (!OSPage.IsAjaxRequest) {
									Response.Redirect(sURL);
								} else {
									((OSPageViewState) Page).RedirectLocation = sURL;
								}
							}
							return false;

						} else {
							string sURL = Functions.rssextensionhttprequesthandler_ActionGetEntryURL(heContext, "HelpUpdatesMessages", "Caseconferencing", "", "", "", "", "", "", "", "", "", "");
							sURL = sURL.Replace("&amp;", "&");
							sURL = RuntimePlatformUtils.GetURL(sURL, AppUtils.Instance, Global.App.eSpaceName);
							((OSPage) Page).ClearErrorHandler();
							Response.BufferOutput = true;
							if (!OSPage.IsAjaxRequest) {
								Response.Redirect(sURL);
							} else {
								((OSPageViewState) Page).RedirectLocation = sURL;
							}
							return false;

						}
					}
				} else {
					// go to target page
					{

						if ((((IWebScreen) Page).isSecure || RuntimePlatformUtils.RequestIsSecure(Request)) && (heContext.AppInfo.eSpaceId == Global.eSpaceId)) {
							((OSPage) Page).ClearErrorHandler();
							if (heContext.AppInfo.eSpaceId==Global.eSpaceId) {
								string sURL = Functions.rssextensionhttprequesthandler_ActionGetEntryURL(heContext, "HelpUpdatesMessages", "Caseconferencing", "", "", "", "", "", "", "", "", "", "");
								sURL = sURL.Replace("&amp;", "&");
								sURL = RuntimePlatformUtils.GetURL(sURL, AppUtils.Instance, Global.App.eSpaceName);
								Response.BufferOutput = true;
								Response.Redirect(sURL, true);
							} else {
								string sURL = Functions.rssextensionhttprequesthandler_ActionGetEntryURL(heContext, "HelpUpdatesMessages", "Caseconferencing", "", "", "", "", "", "", "", "", "", "");
								sURL = sURL.Replace("&amp;", "&");
								sURL = RuntimePlatformUtils.GetURL(sURL, AppUtils.Instance, Global.App.eSpaceName);
								((OSPage) Page).ClearErrorHandler();
								Response.BufferOutput = true;
								if (!OSPage.IsAjaxRequest) {
									Response.Redirect(sURL);
								} else {
									((OSPageViewState) Page).RedirectLocation = sURL;
								}
							}
							return false;

						} else {
							string sURL = Functions.rssextensionhttprequesthandler_ActionGetEntryURL(heContext, "HelpUpdatesMessages", "Caseconferencing", "", "", "", "", "", "", "", "", "", "");
							sURL = sURL.Replace("&amp;", "&");
							sURL = RuntimePlatformUtils.GetURL(sURL, AppUtils.Instance, Global.App.eSpaceName);
							((OSPage) Page).ClearErrorHandler();
							Response.BufferOutput = true;
							if (!OSPage.IsAjaxRequest) {
								Response.Redirect(sURL);
							} else {
								((OSPageViewState) Page).RedirectLocation = sURL;
							}
							return false;

						}
					}
				}
			} // try

			catch (System.Threading.ThreadAbortException) {
				return false;
			}
			catch (Exception exception) {
				ErrorLog.LogApplicationError(exception, heContext, "");
				Global.App.OsContext.Session["ExceptionMessage"] = exception.Message;
				heContext.LastException = exception;
				// Error Handler
				DatabaseAccess.RollbackAllTransactions();
				// ExceptionFeedbackMessage
				Actions.ActionFeedback_Message(heContext, ((string) Global.App.OsContext.Session["ExceptionMessage"]), ENMessageTypeEntity.GetRecordByKey(ObjectKey.Parse("htKb+xw1b0eZ4Wacii2S8w")).ssId);
				// Update Screen
				return true;
			} // Catch
		}
		public void cnt_Container5_onDataBinding(object sender, System.EventArgs e) {
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ssCaseConferencing.Global.eSpaceId;
				cnt_Container5_setInlineAttributes(sender, e);
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}
		public string cnt_Container5_setInlineAttributes(object sender, System.EventArgs e) {
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ssCaseConferencing.Global.eSpaceId;
				if (!cnt_Container5_isVisible()) {
					string stylevalue = ((IAttributeAccessor) sender).GetAttribute("style");
					{
						string newstyledef;
						string oldstyledef;
						newstyledef = stylevalue + ((stylevalue!=null && !stylevalue.TrimEnd().EndsWith(";")) ? ";": "") + "display:none";
						oldstyledef = ((IAttributeAccessor) sender).GetAttribute("style");
						if (oldstyledef != null) {
							if (!oldstyledef.TrimEnd().EndsWith(";")) newstyledef = ";" + newstyledef;
							((IAttributeAccessor) sender).SetAttribute("style", oldstyledef + newstyledef.ToString());
						} else {
							((IAttributeAccessor) sender).SetAttribute("style", newstyledef.ToString());
						}
					}
				} else {
					string stylevalue = ((IAttributeAccessor) sender).GetAttribute("style");
					if (stylevalue != null) {
						((IAttributeAccessor) sender).SetAttribute("style", stylevalue.Replace("display:none;", "").Replace("display:none", "").ToString());
					}
				}
				return "";
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}
		/// <summary>
		/// Gets the visible state of component (wt_Container5)
		/// </summary>
		/// <returns>The Visible State of wt_Container5</returns>
		public bool cnt_Container5_isVisible() {
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ssCaseConferencing.Global.eSpaceId;
				return true;
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}

		/// <summary>
		/// Action to be taken at a Link submit action)
		/// </summary>
		/// <param name="sender"> The associated sender components</param>
		/// <param name="e"> The associated event arguments</param>
		public void wt_Link2_Click(object sender, System.EventArgs e) {
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ssCaseConferencing.Global.eSpaceId;
				((IWebScreen) ((System.Web.UI.Control) sender).Page).OnSubmit(((IParentEditRecordProp) sender).GetParentEditRecordClientId(), false);
				if (CommandRedirectToMessages(heContext)) {
					doRefreshScreen(heContext);
				}
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}
		/// <summary>
		/// Gets the title of the link (wt_Link2)
		/// </summary>
		/// <returns>title of the Link (wt_Link2)</returns>
		public string
		lnk_Link2_getTitle() {
			return "Help/Updates";
		}
		/// <summary>
		/// Gets the visible state of component (wt_Link2)
		/// </summary>
		/// <returns>The Visible State of wt_Link2</returns>
		public bool lnk_Link2_isVisible() {
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ssCaseConferencing.Global.eSpaceId;
				return true;
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}

		/// <summary>
		/// Gets the enabled state of component (wt_Link2)
		/// </summary>
		/// <returns>The Enabled State of wt_Link2</returns>
		public bool lnk_Link2_isEnabled() {
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ssCaseConferencing.Global.eSpaceId;
				return true; 
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}
		public void cntUpdateIndicatorBackground_onDataBinding(object sender, System.EventArgs e) {
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ssCaseConferencing.Global.eSpaceId;
				cntUpdateIndicatorBackground_setInlineAttributes(sender, e);
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}
		public string cntUpdateIndicatorBackground_setInlineAttributes(object sender, System.EventArgs e) {
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ssCaseConferencing.Global.eSpaceId;
				if (!cntUpdateIndicatorBackground_isVisible()) {
					string stylevalue = ((IAttributeAccessor) sender).GetAttribute("style");
					{
						string newstyledef;
						string oldstyledef;
						newstyledef = stylevalue + ((stylevalue!=null && !stylevalue.TrimEnd().EndsWith(";")) ? ";": "") + "display:none";
						oldstyledef = ((IAttributeAccessor) sender).GetAttribute("style");
						if (oldstyledef != null) {
							if (!oldstyledef.TrimEnd().EndsWith(";")) newstyledef = ";" + newstyledef;
							((IAttributeAccessor) sender).SetAttribute("style", oldstyledef + newstyledef.ToString());
						} else {
							((IAttributeAccessor) sender).SetAttribute("style", newstyledef.ToString());
						}
					}
				} else {
					string stylevalue = ((IAttributeAccessor) sender).GetAttribute("style");
					if (stylevalue != null) {
						((IAttributeAccessor) sender).SetAttribute("style", stylevalue.Replace("display:none;", "").Replace("display:none", "").ToString());
					}
				}
				return "";
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}
		/// <summary>
		/// Gets the visible state of component (wtUpdateIndicatorBackground)
		/// </summary>
		/// <returns>The Visible State of wtUpdateIndicatorBackground</returns>
		public bool cntUpdateIndicatorBackground_isVisible() {
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ssCaseConferencing.Global.eSpaceId;
				return (((queryResGetUpdateCount_outParamList.CurrentRec.ssSTUpdateCount.ssUpdateCount>0)) ?(true):(false));
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}

		public void cnt_Container4_onDataBinding(object sender, System.EventArgs e) {
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ssCaseConferencing.Global.eSpaceId;
				cnt_Container4_setInlineAttributes(sender, e);
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}
		public string cnt_Container4_setInlineAttributes(object sender, System.EventArgs e) {
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ssCaseConferencing.Global.eSpaceId;
				if (!cnt_Container4_isVisible()) {
					string stylevalue = ((IAttributeAccessor) sender).GetAttribute("style");
					{
						string newstyledef;
						string oldstyledef;
						newstyledef = stylevalue + ((stylevalue!=null && !stylevalue.TrimEnd().EndsWith(";")) ? ";": "") + "display:none";
						oldstyledef = ((IAttributeAccessor) sender).GetAttribute("style");
						if (oldstyledef != null) {
							if (!oldstyledef.TrimEnd().EndsWith(";")) newstyledef = ";" + newstyledef;
							((IAttributeAccessor) sender).SetAttribute("style", oldstyledef + newstyledef.ToString());
						} else {
							((IAttributeAccessor) sender).SetAttribute("style", newstyledef.ToString());
						}
					}
				} else {
					string stylevalue = ((IAttributeAccessor) sender).GetAttribute("style");
					if (stylevalue != null) {
						((IAttributeAccessor) sender).SetAttribute("style", stylevalue.Replace("display:none;", "").Replace("display:none", "").ToString());
					}
				}
				return "";
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}
		/// <summary>
		/// Gets the visible state of component (wt_Container4)
		/// </summary>
		/// <returns>The Visible State of wt_Container4</returns>
		public bool cnt_Container4_isVisible() {
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ssCaseConferencing.Global.eSpaceId;
				return true;
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}

		/// <summary>
		/// Function to dump expression (Key = IenBziXRd0esYXLBRkRWCQ) Expression:
		///  GetUpdateCount.List.Current.UpdateCount.UpdateCount
		/// </summary>
		/// <returns>Returns the value of the Expression</returns>
		public string expression_InlineExpression7() {
			return Convert.ToString(queryResGetUpdateCount_outParamList.CurrentRec.ssSTUpdateCount.ssUpdateCount);
		}
		public void wt_Text3_onDataBinding(object sender, System.EventArgs e) {
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ssCaseConferencing.Global.eSpaceId;
				wt_Text3_setInlineAttributes(sender, e);
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}
		public string wt_Text3_setInlineAttributes(object sender, System.EventArgs e) {
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ssCaseConferencing.Global.eSpaceId;
				{
					string newstyledef;
					string oldstyledef;
					newstyledef = "position:relative;top:-1px;";
					oldstyledef = ((IAttributeAccessor) sender).GetAttribute("style");
					if (oldstyledef != null) {
						if (!oldstyledef.TrimEnd().EndsWith(";")) newstyledef = ";" + newstyledef;
						((IAttributeAccessor) sender).SetAttribute("style", oldstyledef + newstyledef.ToString());
					} else {
						((IAttributeAccessor) sender).SetAttribute("style", newstyledef.ToString());
					}
				}
				return "";
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}
		public static class FuncCommandRedirectToMessages {
		}
		public static class FuncssPreparation {

			/// <summary>
			/// Query Function "GetUpdateCount" of Action "Preparation"
			/// </summary>
			public static RLUpdateCountRecordList QueryGetUpdateCount(HeContext heContext, int maxRecords, IterationMultiplicity multiplicity, out int outParamCount, int qpinUser) {
				// Query Iterations: Never {-unbound-}
				// Uses binary data: False
				if (multiplicity == IterationMultiplicity.Never) {
					maxRecords = 1;
				}
				outParamCount = -1;
				bool useMainTransaction = (multiplicity != IterationMultiplicity.Single || (maxRecords == 1));
				Transaction trans = useMainTransaction? DatabaseAccess.ForCurrentDatabase.GetRequestTransaction(): DatabaseAccess.ForCurrentDatabase.GetReadOnlyTransaction();
				Command sqlCmd = trans.CreateCommand();
				sqlCmd.CreateParameter("@qpinUser", DbType.Int32, qpinUser);
				string advSql = "SELECT COUNT( {Updates}.[ID]) FROM  {Updates}   " +
				 "WHERE  {Updates}.[ID]   " +
				 "NOT IN (SELECT  {UpdatesSeenBy}.[UPDATE] FROM  {UpdatesSeenBy} WHERE  {UpdatesSeenBy}.[USER] = @qpinUser)  " +
				 "AND  {Updates}.[ACTIVE] =1";
				string sql = AppUtils.Instance.ReplaceEntityReferences(heContext, advSql);
				AppUtils.Instance.CheckReadOnlyEntityReferences(advSql);
				sqlCmd.CommandText = sql;
				try {
					RLUpdateCountRecordList outParamList = new RLUpdateCountRecordList();
					outParamList.Transaction = trans;
					BitArray[] opt = new BitArray[1];
					opt[0] = new BitArray(new bool[] {
						false
					}
					);
					outParamList.AllOptimizedAttributes = opt;
					if (multiplicity == IterationMultiplicity.Multiple) {
						RLUpdateCountRecordList _tmp = new RLUpdateCountRecordList();
						_tmp.Transaction = trans;
						_tmp.AllOptimizedAttributes = opt;
						_tmp.MaxRecords = maxRecords;
						try {
							DatabaseAccess.ForCurrentDatabase.ExecuteQuery(sqlCmd, _tmp, "Query Common.HelpUpdate.Preparation.GetUpdateCount.List");
							outParamList = (RLUpdateCountRecordList) _tmp.Duplicate();
							_tmp.CloseDataReader();
							return outParamList;
						} finally {
							_tmp.CloseDataReader();
						}
					} else if (multiplicity == IterationMultiplicity.Never) {
						try {
							DatabaseAccess.ForCurrentDatabase.ExecuteQuery(sqlCmd, outParamList, "Query Common.HelpUpdate.Preparation.GetUpdateCount.List");
							outParamList.MaxRecords = maxRecords;
							return outParamList;
						} finally {
							outParamList.CloseDataReader();
						}
					} else {
						try {
							DatabaseAccess.ForCurrentDatabase.ExecuteQuery(sqlCmd, outParamList, "Query Common.HelpUpdate.Preparation.GetUpdateCount.List");
							outParamList.MaxRecords = maxRecords;
							return outParamList;
						} finally {
							if (maxRecords == 1) {
								outParamList.CloseDataReader();
							}
						}
					}
				} catch (System.InvalidOperationException aqExcep) {
					if (aqExcep.Message.StartsWith("Command parameter[")) {
						throw new DataBaseException("Problems accessing parameters in advanced query GetUpdateCount in Preparation in HelpUpdate in Common in CaseConferencing (SELECT COUNT({Updates}.[Id]) FROM {Updates}   WHERE {Updates}.[Id]   NOT IN (SELECT {UpdatesSeenBy}.[Update] FROM {UpdatesSeenBy} WHERE {UpdatesSeenBy}.[User] = @User)  AND {Updates}.[Active] =1  ): " + aqExcep.Message);
					}
					throw new DataBaseException("Error in advanced query GetUpdateCount in Preparation in HelpUpdate in Common in CaseConferencing (SELECT COUNT({Updates}.[Id]) FROM {Updates}   WHERE {Updates}.[Id]   NOT IN (SELECT {UpdatesSeenBy}.[Update] FROM {UpdatesSeenBy} WHERE {UpdatesSeenBy}.[User] = @User)  AND {Updates}.[Active] =1  ): " + aqExcep.Message);
				} catch (Exception aqExcep) {
					throw new DataBaseException("Error in advanced query GetUpdateCount in Preparation in HelpUpdate in Common in CaseConferencing (SELECT COUNT({Updates}.[Id]) FROM {Updates}   WHERE {Updates}.[Id]   NOT IN (SELECT {UpdatesSeenBy}.[Update] FROM {UpdatesSeenBy} WHERE {UpdatesSeenBy}.[User] = @User)  AND {Updates}.[Active] =1  ): " + aqExcep.Message);
				}
			}
		}

		public override Control FindControl(string id) {
			return base.FindControl(id);
		}
		public String BreakpointHook(String breakpointId) {
			return "";
		}

		public String BreakpointHook(String breakpointId, bool isExpressionlessWidget) {
			return "";
		}

		public String PageStartHook() {
			_isRendering = true;
			Page_Load(null, null); _isRendering = false;
			this.Load -= new System.EventHandler(this.Page_Load);
			return "";
		}
		public String PageEndHook() {
			return "";
		}
		public override string WebBlockIdentifier {
			get {
				return "CaseConferencing.KfpAa79RrRUaQSPrU6XYoGA";
			}
		}
	}

}
