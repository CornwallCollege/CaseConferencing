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


namespace ssCaseConferencing.Flows.FlowLearner_ILP {
	public abstract class WBlkjQuery_Easing: OSUserControl, IWebScreen, INegotiateTabIndexes, IAjaxNotifyEvent {

		/// <summary>
		/// Delegate Definitions
		/// </summary>
		/// <summary>
		/// Custom Events Definitions
		/// </summary>
		/// <summary>
		/// Parameters and Local Variables Definitions
		/// </summary>
		/// <summary>
		/// Variable SilkUIFramework_wt_WebBlockInstance2
		/// </summary>
		protected proxy_CaseConferencing_SilkUIFramework.Flows.FlowDevelopment.WBlkjQuery SilkUIFramework_wt_WebBlockInstance2;
		private bool _isRendering = false;
		public HeContext heContext;
		private static Hashtable htTabIndexGroups = new Hashtable();
		private Hashtable htTabIndexGroupsTI = new Hashtable();
		public string InstanceID;
		public string RuntimeID= "";
		static WBlkjQuery_Easing() {
		}
		override protected void OnInit(EventArgs e) {
			InitializeComponent();
			base.OnInit(e);
		}
		private void InitializeComponent() {
			SilkUIFramework_wt_WebBlockInstance2 = (proxy_CaseConferencing_SilkUIFramework.Flows.FlowDevelopment.WBlkjQuery) FindControl("SilkUIFramework_wt_WebBlockInstance2");
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
			string blockId = "CaseConferencing.KRtZlICBcskiWKbPV0mNDOw";
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
		}

		private static void GetInlineCss(TextWriter writer, HashSet<string> visited) {
			StringWriter localCssWriter = new StringWriter();
			localCssWriter.NewLine = writer.NewLine;
			string localCss = Environment.NewLine;
			InnerGetCss(localCssWriter, true, visited);
			localCss += localCssWriter.ToString();
			writer.Write(localCss);
		}

		private static void InnerGetCss(TextWriter writer, bool inline, HashSet<string> visited) {
			proxy_CaseConferencing_SilkUIFramework.Flows.FlowDevelopment.WBlkjQuery.GetCss(writer, inline, visited);
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
				return ObjectKey.Parse("RtZlICBcskiWKbPV0mNDOw"); 
			}
		}
		public bool isSecure {
			get {
				return ((IWebScreen) Page).isSecure; 
			}
		}
		public void SilkUIFramework_webBlck_WebBlockInstance2_onDataBinding(object sender, System.EventArgs e) {
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ssCaseConferencing.Global.eSpaceId;
				proxy_CaseConferencing_SilkUIFramework.Flows.FlowDevelopment.WBlkjQuery widget = (proxy_CaseConferencing_SilkUIFramework.Flows.FlowDevelopment.WBlkjQuery) sender;
				widget.inParamJavascript = "";
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}

		public override Control FindControl(string id) {
			if (id == "wt_Text3") {
				return SilkUIFramework_wt_WebBlockInstance2.wtDescription.FindControl("wt_Text3");
			}
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
				return "CaseConferencing.KRtZlICBcskiWKbPV0mNDOw";
			}
		}
		public override string JavaScriptFileName {
			get {
				return AppRelativeVirtualPath.Replace(".ascx", string.Empty) + ".js" + AppUtils.Instance.CacheInvalidationSuffix;
			}
		}
	}

}
