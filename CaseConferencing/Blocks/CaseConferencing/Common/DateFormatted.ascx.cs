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
	public abstract class WBlkDateFormatted: OSUserControl, IWebScreen, INegotiateTabIndexes, IAjaxNotifyEvent {

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
		/// Screen Input Parameter inParamDate. Description:
		/// </summary>
		public DateTime inParamDate = new DateTime(1900, 1, 1, 0, 0, 0);
		/// <summary>
		/// Variable <code>varLcunit</code> that represents the Service Studio local variable <code>unit</code>
		///  <p>Description: </p>
		/// </summary>
		int varLcunit = 0;

		/// <summary>
		/// Variable "True" if the Widget wt_If5
		/// </summary>
		protected OutSystems.HubEdition.WebWidgets.If wt_If5T;

		/// <summary>
		/// Variable "True" if the Widget wt_If5
		/// </summary>
		protected OutSystems.HubEdition.WebWidgets.If wt_If5F;
		private bool _isRendering = false;
		public HeContext heContext;
		private static Hashtable htTabIndexGroups = new Hashtable();
		private Hashtable htTabIndexGroupsTI = new Hashtable();
		public string InstanceID;
		public string RuntimeID= "";
		/// <summary>
		/// Action <code>Preparation</code> that represents the Service Studio preparation
		///  <code>Preparation</code> <p> Description: </p>
		/// </summary>
		public void Preparation(HeContext heContext) {
			CheckPermissions(heContext);
			varLcunit = ((int) BuiltInFunction.Mod(BuiltInFunction.Day(inParamDate), 10M)); // unit = Mod
		}
		static WBlkDateFormatted() {
		}
		override protected void OnInit(EventArgs e) {
			InitializeComponent();
			base.OnInit(e);
		}
		private void InitializeComponent() {
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
			string blockId = "CaseConferencing.K1tHu2scNhke0DPtNY_WdAQ";
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
				return ObjectKey.Parse("1tHu2scNhke0DPtNY_WdAQ"); 
			}
		}
		public bool isSecure {
			get {
				return ((IWebScreen) Page).isSecure; 
			}
		}
		bool if_wt_If5_hasRun=false;
		bool if_wt_If5_evalResult;
		public bool if_wt_If5() {
			if (if_wt_If5_hasRun) {
				if_wt_If5_hasRun = false;
				return if_wt_If5_evalResult;
			}
			if_wt_If5_hasRun = true;
			if_wt_If5_evalResult = (inParamDate==BuiltInFunction.NullDate());
			return if_wt_If5_evalResult;
		}

		/// <summary>
		/// Function to dump expression (Key = mPjIDpqihUeM0g4ZtKnOpA) Expression: Day
		/// </summary>
		/// <returns>Returns the value of the Expression</returns>
		public string expression_InlineExpression2() {
			return Convert.ToString(BuiltInFunction.Day(inParamDate));
		}
		public void expression_InlineExpression3_onDataBinding(object sender, System.EventArgs e) {
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ssCaseConferencing.Global.eSpaceId;
				expression_InlineExpression3_setInlineAttributes(sender, e);
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}
		public string expression_InlineExpression3_setInlineAttributes(object sender, System.EventArgs e) {
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ssCaseConferencing.Global.eSpaceId;
				{
					string newstyledef;
					string oldstyledef;
					newstyledef = "font-size:80%;position:relative;top:-.3em;";
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
		/// <summary>
		/// Function to dump expression (Key = mRQeIdJdE0+s1uKtnJEtiQ) Expression: internalIf
		/// </summary>
		/// <returns>Returns the value of the Expression</returns>
		public string expression_InlineExpression3() {
			return ((((varLcunit==1) && (BuiltInFunction.Day(inParamDate) !=11))) ?("st"):(((((varLcunit==2) && (BuiltInFunction.Day(inParamDate) !=12))) ?("nd"):(((((varLcunit==3) && (BuiltInFunction.Day(inParamDate) !=13))) ?("rd"):("th"))))));
		}
		/// <summary>
		/// Function to dump expression (Key = LJmpqqkjokqqppbqgsb0ww) Expression: Substr + " " + Year
		/// </summary>
		/// <returns>Returns the value of the Expression</returns>
		public string expression_InlineExpression7() {
			return ((BuiltInFunction.Substr(Functions.rssespacerichwidgets_ActionDate_MonthName(heContext, inParamDate), 0, 3) + " ") +Convert.ToString(BuiltInFunction.Year(inParamDate)));
		}
		public static class FuncssPreparation {
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
				return "CaseConferencing.K1tHu2scNhke0DPtNY_WdAQ";
			}
		}
	}

}