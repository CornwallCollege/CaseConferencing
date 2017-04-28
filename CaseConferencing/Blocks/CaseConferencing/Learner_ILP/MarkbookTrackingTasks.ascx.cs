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
	public abstract class WBlkMarkbookTrackingTasks: OSUserControl, IWebScreen, INegotiateTabIndexes, IAjaxNotifyEvent {

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
		/// Screen Input Parameter inParamMarkbookTasksList. Description:
		/// </summary>
		public RLMarkbookTasksList inParamMarkbookTasksList = new RLMarkbookTasksList();
		private RLMarkbookTasksList _ssTasksListList = new RLMarkbookTasksList();
		public RLMarkbookTasksList ssTasksListList {
			get {
				return _ssTasksListList; 
			}
			set {
				_ssTasksListList = value;
				wtTasksList.DataSource = value;
				ssTasksListListDataBound = false;
			}
		}
		protected OutSystems.HubEdition.WebWidgets.Iterator wtTasksList;
		public ArrayList wtTasksList_storage = new ArrayList();
		protected bool ssTasksListList_notUsedYet = true;
		protected bool ssTasksListListDoDataBind;
		protected bool ssTasksListListDataBound;
		protected OutSystems.HubEdition.WebWidgets.Container wt_Container2;
		protected OutSystems.HubEdition.WebWidgets.Container wt_Container3;
		protected OutSystems.HubEdition.WebWidgets.Container wt_Container4;
		protected OutSystems.HubEdition.WebWidgets.Container wt_Container9;
		protected OutSystems.HubEdition.WebWidgets.Container wt_Container8;
		private bool _isRendering = false;
		public HeContext heContext;
		private static Hashtable htTabIndexGroups = new Hashtable();
		private Hashtable htTabIndexGroupsTI = new Hashtable();
		public string InstanceID;
		public string RuntimeID= "";
		static WBlkMarkbookTrackingTasks() {
		}
		override protected void OnInit(EventArgs e) {
			InitializeComponent();
			base.OnInit(e);
		}
		private void InitializeComponent() {
			wtTasksList.StartIndexExpression = () => 0;
			wtTasksList.LineCountExpression = () => 50;
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
					ssTasksListListDoDataBind = true;
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
			if (IsAjaxRequest) {
				recListTasksList_Rebuild((ssTasksListListDataBound ? wtTasksList.StartIndexLastEvaluation.GetValueOrDefault(): 0), wtTasksList.LineCount);
			}
			ViewStateAttributes.EnsureNotEmpty();
		}
		/// <summary>
		/// Restore widget and variable data from the viewstate
		/// </summary>
		protected override void FetchViewState() {
			base.FetchViewState();
			if (IsViewStateEmpty) return;
			try {
				recListTasksList_Restore();
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
			string blockId = "CaseConferencing.KlQiCMkhBl0eXcUBYrz68yg";
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
			CssHelper.WriteCssInclude(writer, AppUtils.Instance.getImagePath() + "Blocks/CaseConferencing/Learner_ILP/MarkbookTrackingTasks.css" + AppUtils.Instance.CacheInvalidationSuffix);
		}

		private static void GetInlineCss(TextWriter writer, HashSet<string> visited) {
			StringWriter localCssWriter = new StringWriter();
			localCssWriter.NewLine = writer.NewLine;
			string localCss = Environment.NewLine;
			InnerGetCss(localCssWriter, true, visited);
			localCss += localCssWriter.ToString();
			HashSet<string> cssVisited = new HashSet<string>();
			string read;
			AppUtils.getResourceFileContent(out read, "Blocks\\CaseConferencing\\Learner_ILP\\MarkbookTrackingTasks.css");
			localCss += OutSystems.HubEdition.RuntimePlatform.Email.EmailHelper.FlattenCSSFile(read, "Blocks\\CaseConferencing\\Learner_ILP\\MarkbookTrackingTasks.css", cssVisited);
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
				return ObjectKey.Parse("lQiCMkhBl0eXcUBYrz68yg"); 
			}
		}
		public bool isSecure {
			get {
				return ((IWebScreen) Page).isSecure; 
			}
		}
		public void recListTasksList_onDataBinding(object sender, System.EventArgs e) {
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ssCaseConferencing.Global.eSpaceId;
				// widget wtTasksList
				ssTasksListList = inParamMarkbookTasksList;
				ssTasksListListDoDataBind = false;
				ssTasksListListDataBound = true;
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}
		public void recListTasksList_Select(object sender, IteratorCommandEventArgs e) {
			if (e.SelectedIndex != -1) {
				if (ssTasksListList.Length > 0) {
					ssTasksListList.CurrentRec = ssTasksListList[ssTasksListList.CurrentRowNumber];
				}
				if (ssTasksListList.Length > e.SelectedIndex) {
					ssTasksListList.CurrentRec = ssTasksListList[e.SelectedIndex];
					ssTasksListList.CurrentRowNumber = e.SelectedIndex;
				}
			}
			if (e is IteratorCommandAjaxEventArgs) {
				((IteratorCommandAjaxEventArgs) e).InvokeHandler();
			} else {
				var owner = Utils.GetOwnerOfControl((Control) e.CommandSource);
				owner.GetType().GetMethod(((WebControl) e.CommandSource).ID + "_Click").Invoke(owner, new Object[2] {
					e.CommandSource, new CommandEventArgs("", this)
				}
				);
			}
		}
		/// <summary>
		/// Function to Prepare Widget information to be stored in view State
		/// </summary>
		/// <param name="dataItem"> Item to be stored in view state</param>
		/// <param name="index"> Record list index of the item to be stored</param>
		public string recListTasksList_Store(object dataItem, int index) {
			return "";
		}
		public void recListTasksList_Restore() {
		}
		/// <summary>
		/// Function to clear current widget information to be stored in view state
		/// </summary>
		public void recListTasksList_Clear(object sender, EventArgs e) {
			wtTasksList_storage.Clear();
		}
		/// <summary>
		/// Function to rebuild storage widget information from a list in the viewstate
		/// </summary>
		public void recListTasksList_Rebuild(int startIndex, int lineCount) {
			if (ssTasksListList.Length != -1) {
				wtTasksList_storage.Clear();
				for (int i=startIndex; i<ssTasksListList.Data.Count && i<startIndex+lineCount; i++) {
					recListTasksList_Store(ssTasksListList.Data[i], wtTasksList_storage.Count);
				}
			}
		}
		public void recListTasksList_ListRefreshDataBind(object sender, EventArgs e) {
		}
		/// <summary>
		/// Function that returns the list of the wtTasksList widget
		/// </summary>
		/// <returns>The list associated with the widget</returns>
		public RLMarkbookTasksList getWtTasksListList() {
			if (ssTasksListListDoDataBind) {
				recListTasksList_onDataBinding(this, null);
			}

			return ssTasksListList;
		}
		public void cnt_Container2_onDataBinding(object sender, System.EventArgs e) {
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ssCaseConferencing.Global.eSpaceId;
				cnt_Container2_setInlineAttributes(sender, e);
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}
		public string cnt_Container2_setInlineAttributes(object sender, System.EventArgs e) {
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ssCaseConferencing.Global.eSpaceId;
				{
					string newstyledef;
					string oldstyledef;
					newstyledef = "style";
					oldstyledef = ((IAttributeAccessor) sender).GetAttribute("style");
					if (oldstyledef != null) {
						if (!oldstyledef.TrimEnd().EndsWith(";")) newstyledef = ";" + newstyledef;
						((IAttributeAccessor) sender).SetAttribute("style", oldstyledef + newstyledef.ToString());
					} else {
						((IAttributeAccessor) sender).SetAttribute("style", newstyledef.ToString());
					}
				}
				if (!cnt_Container2_isVisible()) {
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
		/// Gets the visible state of component (wt_Container2)
		/// </summary>
		/// <returns>The Visible State of wt_Container2</returns>
		public bool cnt_Container2_isVisible() {
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ssCaseConferencing.Global.eSpaceId;
				return true;
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}

		public void cnt_Container3_onDataBinding(object sender, System.EventArgs e) {
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ssCaseConferencing.Global.eSpaceId;
				cnt_Container3_setInlineAttributes(sender, e);
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}
		public string cnt_Container3_setInlineAttributes(object sender, System.EventArgs e) {
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ssCaseConferencing.Global.eSpaceId;
				{
					string newstyledef;
					string oldstyledef;
					newstyledef = ("background-color:" + ((getWtTasksListList().CurrentRec.ssTaskCompleted) ?("#27ae60;"):("#2c3e50;")));
					oldstyledef = ((IAttributeAccessor) sender).GetAttribute("style");
					if (oldstyledef != null) {
						if (!oldstyledef.TrimEnd().EndsWith(";")) newstyledef = ";" + newstyledef;
						((IAttributeAccessor) sender).SetAttribute("style", oldstyledef + newstyledef.ToString());
					} else {
						((IAttributeAccessor) sender).SetAttribute("style", newstyledef.ToString());
					}
				}
				if (!cnt_Container3_isVisible()) {
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
		/// Gets the visible state of component (wt_Container3)
		/// </summary>
		/// <returns>The Visible State of wt_Container3</returns>
		public bool cnt_Container3_isVisible() {
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ssCaseConferencing.Global.eSpaceId;
				return true;
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
		/// Function to dump expression (Key = 1v5Wu9iYRUu_lMEBkOAzaQ) Expression: "Task : " +
		///  TasksList.List.Current.TaskName
		/// </summary>
		/// <returns>Returns the value of the Expression</returns>
		public string expression_InlineExpression6() {
			return ("Task : " +getWtTasksListList().CurrentRec.ssTaskName);
		}
		public void cnt_Container9_onDataBinding(object sender, System.EventArgs e) {
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ssCaseConferencing.Global.eSpaceId;
				cnt_Container9_setInlineAttributes(sender, e);
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}
		public string cnt_Container9_setInlineAttributes(object sender, System.EventArgs e) {
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ssCaseConferencing.Global.eSpaceId;
				if (!cnt_Container9_isVisible()) {
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
		/// Gets the visible state of component (wt_Container9)
		/// </summary>
		/// <returns>The Visible State of wt_Container9</returns>
		public bool cnt_Container9_isVisible() {
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ssCaseConferencing.Global.eSpaceId;
				return true;
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}

		/// <summary>
		/// Function to dump expression (Key = 7QBTRRTLzEGPBW40W7+t1g) Expression: internalIf
		/// </summary>
		/// <returns>Returns the value of the Expression</returns>
		public string expression_InlineExpression1() {
			return ((getWtTasksListList().CurrentRec.ssTaskCompleted) ?(("Grade / Mark : " + (((getWtTasksListList().CurrentRec.ssTaskGrade!= "")) ?(getWtTasksListList().CurrentRec.ssTaskGrade):("No grade")))):(" "));
		}
		public void cnt_Container8_onDataBinding(object sender, System.EventArgs e) {
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ssCaseConferencing.Global.eSpaceId;
				cnt_Container8_setInlineAttributes(sender, e);
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}
		public string cnt_Container8_setInlineAttributes(object sender, System.EventArgs e) {
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ssCaseConferencing.Global.eSpaceId;
				if (!cnt_Container8_isVisible()) {
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
		/// Gets the visible state of component (wt_Container8)
		/// </summary>
		/// <returns>The Visible State of wt_Container8</returns>
		public bool cnt_Container8_isVisible() {
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ssCaseConferencing.Global.eSpaceId;
				return true;
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}

		/// <summary>
		/// Function to dump expression (Key = xv4Ss8oFRka8w6cagqauAA) Expression: internalIf
		/// </summary>
		/// <returns>Returns the value of the Expression</returns>
		public string expression_InlineExpression5() {
			return ((getWtTasksListList().CurrentRec.ssTaskCompleted) ?(("Completed on " +BuiltInFunction.FormatShortDate(Convert.ToDateTime(getWtTasksListList().CurrentRec.ssTaskDateCompleted.ToString("yyyy-M-d")), "-"))):("Task not yet completed."));
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
				return "CaseConferencing.KlQiCMkhBl0eXcUBYrz68yg";
			}
		}
	}

}