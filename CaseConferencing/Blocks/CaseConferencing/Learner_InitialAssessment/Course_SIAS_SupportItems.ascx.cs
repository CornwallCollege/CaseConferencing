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


namespace ssCaseConferencing.Flows.FlowLearner_InitialAssessment {
	public abstract class WBlkCourse_SIAS_SupportItems: OSUserControl, IWebScreen, INegotiateTabIndexes, IAjaxNotifyEvent {

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
		/// Screen Input Parameter inParamStudentId. Description:
		/// </summary>
		public string inParamStudentId = "";
		/// <summary>
		/// Screen Input Parameter inParamWidth. Description:
		/// </summary>
		public int inParamWidth = 0;
		private RLSIASSupportTypeRecordList _ssListRecordsCardsList = new RLSIASSupportTypeRecordList();
		public RLSIASSupportTypeRecordList ssListRecordsCardsList {
			get {
				return _ssListRecordsCardsList; 
			}
			set {
				_ssListRecordsCardsList = value;
				wtListRecordsCards.DataSource = value;
				ssListRecordsCardsListDataBound = false;
			}
		}
		protected OutSystems.HubEdition.WebWidgets.Iterator wtListRecordsCards;
		public ArrayList wtListRecordsCards_storage = new ArrayList();
		protected bool ssListRecordsCardsList_notUsedYet = true;
		protected bool ssListRecordsCardsListDoDataBind;
		protected bool ssListRecordsCardsListDataBound;
		protected OutSystems.HubEdition.WebWidgets.Container wt_Container5;
		/// <summary>
		/// Variable wt_WebBlockInstance3
		/// </summary>
		protected ssCaseConferencing.Flows.FlowLearner_InitialAssessment.WBlkCard wt_WebBlockInstance3;
		private bool _isRendering = false;
		public HeContext heContext;
		private static Hashtable htTabIndexGroups = new Hashtable();
		private Hashtable htTabIndexGroupsTI = new Hashtable();
		public string InstanceID;
		public string RuntimeID= "";
		RLSIASSupportTypeRecordList queryResGEtSupportTypes_outParamList = new RLSIASSupportTypeRecordList();
		int queryResGEtSupportTypes_outParamCount = 0;
		/// <summary>
		/// Action <code>Preparation</code> that represents the Service Studio preparation
		///  <code>Preparation</code> <p> Description: </p>
		/// </summary>
		public void Preparation(HeContext heContext) {
			CheckPermissions(heContext);
			// Query QueryGEtSupportTypes
			int QueryGEtSupportTypes_maxRecords = Math.Max(wtListRecordsCards.StartIndex + wtListRecordsCards.LineCount + 1, 0);
			queryResGEtSupportTypes_outParamList = FuncssPreparation.QueryGEtSupportTypes(heContext, QueryGEtSupportTypes_maxRecords, IterationMultiplicity.Single, out queryResGEtSupportTypes_outParamCount, inParamStudentId
			);
		}
		static WBlkCourse_SIAS_SupportItems() {
		}
		override protected void OnInit(EventArgs e) {
			InitializeComponent();
			base.OnInit(e);
		}
		private void InitializeComponent() {
			wtListRecordsCards.StartIndexExpression = () => 0;
			wtListRecordsCards.LineCountExpression = () => 50;
			wt_WebBlockInstance3 = (ssCaseConferencing.Flows.FlowLearner_InitialAssessment.WBlkCard) FindControl("wt_WebBlockInstance3");
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
					ssListRecordsCardsListDoDataBind = true;
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
				recListListRecordsCards_Rebuild((ssListRecordsCardsListDataBound ? wtListRecordsCards.StartIndexLastEvaluation.GetValueOrDefault(): 0), wtListRecordsCards.LineCount);
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
				recListListRecordsCards_Restore();
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
			string blockId = "CaseConferencing.KOGOT9r9dWkuWGzFJmi9_ww";
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
			ssCaseConferencing.Flows.FlowLearner_InitialAssessment.WBlkCard.GetCss(writer, inline, visited);
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
				return ObjectKey.Parse("OGOT9r9dWkuWGzFJmi9_ww"); 
			}
		}
		public bool isSecure {
			get {
				return ((IWebScreen) Page).isSecure; 
			}
		}
		public void recListListRecordsCards_onDataBinding(object sender, System.EventArgs e) {
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ssCaseConferencing.Global.eSpaceId;
				// widget wtListRecordsCards
				ssListRecordsCardsList = queryResGEtSupportTypes_outParamList;
				ssListRecordsCardsListDoDataBind = false;
				ssListRecordsCardsListDataBound = true;
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}
		public void recListListRecordsCards_Select(object sender, IteratorCommandEventArgs e) {
			if (e.SelectedIndex != -1) {
				if (ssListRecordsCardsList.Length > 0) {
					ssListRecordsCardsList.CurrentRec = ssListRecordsCardsList[ssListRecordsCardsList.CurrentRowNumber];
				}
				if (ssListRecordsCardsList.Length > e.SelectedIndex) {
					ssListRecordsCardsList.CurrentRec = ssListRecordsCardsList[e.SelectedIndex];
					ssListRecordsCardsList.CurrentRowNumber = e.SelectedIndex;
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
		public string recListListRecordsCards_Store(object dataItem, int index) {
			return "";
		}
		public void recListListRecordsCards_Restore() {
		}
		/// <summary>
		/// Function to clear current widget information to be stored in view state
		/// </summary>
		public void recListListRecordsCards_Clear(object sender, EventArgs e) {
			wtListRecordsCards_storage.Clear();
		}
		/// <summary>
		/// Function to rebuild storage widget information from a list in the viewstate
		/// </summary>
		public void recListListRecordsCards_Rebuild(int startIndex, int lineCount) {
			if (ssListRecordsCardsList.Length != -1) {
				wtListRecordsCards_storage.Clear();
				for (int i=startIndex; i<ssListRecordsCardsList.Data.Count && i<startIndex+lineCount; i++) {
					recListListRecordsCards_Store(ssListRecordsCardsList.Data[i], wtListRecordsCards_storage.Count);
				}
			}
		}
		public void recListListRecordsCards_ListRefreshDataBind(object sender, EventArgs e) {
		}
		/// <summary>
		/// Function that returns the list of the wtListRecordsCards widget
		/// </summary>
		/// <returns>The list associated with the widget</returns>
		public RLSIASSupportTypeRecordList getWtListRecordsCardsList() {
			if (ssListRecordsCardsListDoDataBind) {
				recListListRecordsCards_onDataBinding(this, null);
			}

			return ssListRecordsCardsList;
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
				{
					string newstyledef;
					string oldstyledef;
					newstyledef = (("line-height:20px;height:35px;width:" +Convert.ToString(inParamWidth)) + "px;");
					oldstyledef = ((IAttributeAccessor) sender).GetAttribute("style");
					if (oldstyledef != null) {
						if (!oldstyledef.TrimEnd().EndsWith(";")) newstyledef = ";" + newstyledef;
						((IAttributeAccessor) sender).SetAttribute("style", oldstyledef + newstyledef.ToString());
					} else {
						((IAttributeAccessor) sender).SetAttribute("style", newstyledef.ToString());
					}
				}
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

		public void webBlck_WebBlockInstance3_onDataBinding(object sender, System.EventArgs e) {
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ssCaseConferencing.Global.eSpaceId;
				ssCaseConferencing.Flows.FlowLearner_InitialAssessment.WBlkCard widget = (ssCaseConferencing.Flows.FlowLearner_InitialAssessment.WBlkCard) sender;
				widget.inParamIsSmall = true;
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}
		/// <summary>
		/// Function to dump expression (Key = IaHRzVT3v06mLLzv+AVb6w) Expression:
		///  ListRecordsCards.List.Current.SIASSupportType.Label
		/// </summary>
		/// <returns>Returns the value of the Expression</returns>
		public string expression_InlineExpression4() {
			return getWtListRecordsCardsList().CurrentRec.ssENSIASSupportType.ssLabel;
		}
		public static class FuncssPreparation {

			/// <summary>
			/// Query Function "GEtSupportTypes" of Action "Preparation"
			/// </summary>
			public static RLSIASSupportTypeRecordList QueryGEtSupportTypes(HeContext heContext, int maxRecords, IterationMultiplicity multiplicity, out int outParamCount, string qpstStudentId) {
				// Query Iterations: Single {ListRecordsCards}
				// Uses binary data: False
				if (multiplicity == IterationMultiplicity.Never) {
					maxRecords = 1;
				}
				outParamCount = -1;
				bool useMainTransaction = (multiplicity != IterationMultiplicity.Single || (maxRecords == 1));
				Transaction trans = useMainTransaction? DatabaseAccess.ForCurrentDatabase.GetRequestTransaction(): DatabaseAccess.ForCurrentDatabase.GetReadOnlyTransaction();
				Command sqlCmd = trans.CreateCommand();
				sqlCmd.CreateParameter("@qpstStudentId", DbType.String, qpstStudentId);
				string advSql = "SELECT  {SIASSupportType}.[ID], {SIASSupportType}.[LABEL], {SIASSupportType}.[ORDER], {SIASSupportType}.[IS_ACTIVE] From  {SIASSupport}   " +
				 "INNER JOIN  {SIASSupportType} ON  {SIASSupport}.[SUPPORTTYPE1] =  {SIASSupportType}.[ID] OR  {SIASSupport}.[SUPPORTTYPE2] =  {SIASSupportType}.[ID] OR  {SIASSupport}.[SUPPORTTYPE3] =  {SIASSupportType}.[ID]  " +
				 "WHERE  {SIASSupport}.[STUDENTID] = @qpstStudentId";
				string sql = AppUtils.Instance.ReplaceEntityReferences(heContext, advSql);
				AppUtils.Instance.CheckReadOnlyEntityReferences(advSql);
				sqlCmd.CommandText = sql;
				try {
					RLSIASSupportTypeRecordList outParamList = new RLSIASSupportTypeRecordList();
					outParamList.Transaction = trans;
					BitArray[] opt = new BitArray[1];
					opt[0] = new BitArray(new bool[] {
						false, false, false, false
					}
					);
					outParamList.AllOptimizedAttributes = opt;
					if (multiplicity == IterationMultiplicity.Multiple) {
						RLSIASSupportTypeRecordList _tmp = new RLSIASSupportTypeRecordList();
						_tmp.Transaction = trans;
						_tmp.AllOptimizedAttributes = opt;
						_tmp.MaxRecords = maxRecords;
						try {
							DatabaseAccess.ForCurrentDatabase.ExecuteQuery(sqlCmd, _tmp, "Query Learner_InitialAssessment.Course_SIAS_SupportItems.Preparation.GEtSupportTypes.List");
							outParamList = (RLSIASSupportTypeRecordList) _tmp.Duplicate();
							_tmp.CloseDataReader();
							return outParamList;
						} finally {
							_tmp.CloseDataReader();
						}
					} else if (multiplicity == IterationMultiplicity.Never) {
						try {
							DatabaseAccess.ForCurrentDatabase.ExecuteQuery(sqlCmd, outParamList, "Query Learner_InitialAssessment.Course_SIAS_SupportItems.Preparation.GEtSupportTypes.List");
							outParamList.MaxRecords = maxRecords;
							return outParamList;
						} finally {
							outParamList.CloseDataReader();
						}
					} else {
						try {
							DatabaseAccess.ForCurrentDatabase.ExecuteQuery(sqlCmd, outParamList, "Query Learner_InitialAssessment.Course_SIAS_SupportItems.Preparation.GEtSupportTypes.List");
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
						throw new DataBaseException("Problems accessing parameters in advanced query GEtSupportTypes in Preparation in Course_SIAS_SupportItems in Learner_InitialAssessment in CaseConferencing (SELECT {SIASSupportType}.* From {SIASSupport}   INNER JOIN {SIASSupportType} ON {SIASSupport}.[SupportType1] = {SIASSupportType}.[Id] OR {SIASSupport}.[SupportType2] = {SIASSupportType}.[Id] OR {SIASSupport}.[SupportType3] = {SIASSupportType}.[Id]  WHERE {SIASSupport}.[StudentId] = @StudentId ): " + aqExcep.Message);
					}
					throw new DataBaseException("Error in advanced query GEtSupportTypes in Preparation in Course_SIAS_SupportItems in Learner_InitialAssessment in CaseConferencing (SELECT {SIASSupportType}.* From {SIASSupport}   INNER JOIN {SIASSupportType} ON {SIASSupport}.[SupportType1] = {SIASSupportType}.[Id] OR {SIASSupport}.[SupportType2] = {SIASSupportType}.[Id] OR {SIASSupport}.[SupportType3] = {SIASSupportType}.[Id]  WHERE {SIASSupport}.[StudentId] = @StudentId ): " + aqExcep.Message);
				} catch (Exception aqExcep) {
					throw new DataBaseException("Error in advanced query GEtSupportTypes in Preparation in Course_SIAS_SupportItems in Learner_InitialAssessment in CaseConferencing (SELECT {SIASSupportType}.* From {SIASSupport}   INNER JOIN {SIASSupportType} ON {SIASSupport}.[SupportType1] = {SIASSupportType}.[Id] OR {SIASSupport}.[SupportType2] = {SIASSupportType}.[Id] OR {SIASSupport}.[SupportType3] = {SIASSupportType}.[Id]  WHERE {SIASSupport}.[StudentId] = @StudentId ): " + aqExcep.Message);
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
				return "CaseConferencing.KOGOT9r9dWkuWGzFJmi9_ww";
			}
		}
	}

}
