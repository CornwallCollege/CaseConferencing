﻿/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

// Proxy for reference eSpace with name CornwallCollegeFunct and key UZpTYZyWVkqBt8HEmzJhvg
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
	/// Class: RsseSpaceCornwallCollegeFunct
	/// </summary>
	public class RsseSpaceCornwallCollegeFunct {
		protected static int _maxExtensionLogsPerRequest = OutSystems.HubEdition.RuntimePlatform.Settings.GetInt(OutSystems.HubEdition.RuntimePlatform.Settings.Configs.Log_MaxLogsPerRequest_Extension);
		public static void MssOnSessionStart(HeContext heContext) {
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ssCornwallCollegeFunct.Global.eSpaceId;
				if (RuntimePlatformUtils.TestAndSetProducerSession("CornwallCollegeFunct")) {
					ssCornwallCollegeFunct.Actions.ActionOnSessionStart(heContext);
				}
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}


		public static void MssStudent_GetAttendancesByStudentReference(HeContext heContext, string inParamStudentReference, string inParamEnrolmentStatus, string inParamAcademicYear, out RecordList outParamStudentAttenndance_List) {
			outParamStudentAttenndance_List = ssCaseConferencing.RsseSpaceCornwallCollegeFunct.Factory.FactoryRLStudentAttenndance_ListListSingleton.CreateRsseSpaceCornwallCollegeFunctRLStudentAttenndance_ListList();
			ssCornwallCollegeFunct.RLStudentAttenndance_ListList _proxyoutParamStudentAttenndance_List = new ssCornwallCollegeFunct.RLStudentAttenndance_ListList();
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ssCornwallCollegeFunct.Global.eSpaceId;
				RsseSpaceCornwallCollegeFunct.MssOnSessionStart(heContext);
				ssCornwallCollegeFunct.Actions.ActionStudent_GetAttendancesByStudentReference(heContext, inParamStudentReference, inParamEnrolmentStatus, inParamAcademicYear, out _proxyoutParamStudentAttenndance_List);
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
			outParamStudentAttenndance_List.FillFromOther(_proxyoutParamStudentAttenndance_List);
		}


		public static void MssStudent_FormatName(HeContext heContext, IRecord inParamStudent, out string outParamNameFormated) {
			ssCornwallCollegeFunct.ENStudentEntityRecord _proxyinParamStudent = new ssCornwallCollegeFunct.ENStudentEntityRecord(null);
			_proxyinParamStudent.FillFromOther(inParamStudent);
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ssCornwallCollegeFunct.Global.eSpaceId;
				RsseSpaceCornwallCollegeFunct.MssOnSessionStart(heContext);
				ssCornwallCollegeFunct.Actions.ActionStudent_FormatName(heContext, _proxyinParamStudent, out outParamNameFormated);
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}


		public static void MssStudentLog_GetCurrentValues(HeContext heContext, string inParamStudentReference, out IRecord outParamStudentLog) {
			outParamStudentLog = ssCaseConferencing.RsseSpaceCornwallCollegeFunct.Factory.FactoryRCStudentStudentLogRecordSingleton.CreateRsseSpaceCornwallCollegeFunctRCStudentStudentLogRecord();
			ssCornwallCollegeFunct.RCStudentStudentLogRecord _proxyoutParamStudentLog = new ssCornwallCollegeFunct.RCStudentStudentLogRecord(null);
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ssCornwallCollegeFunct.Global.eSpaceId;
				RsseSpaceCornwallCollegeFunct.MssOnSessionStart(heContext);
				ssCornwallCollegeFunct.Actions.ActionStudentLog_GetCurrentValues(heContext, inParamStudentReference, out _proxyoutParamStudentLog);
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
			outParamStudentLog.FillFromOther(_proxyoutParamStudentLog);
		}


		public static void MssStudentLog_Create(HeContext heContext, string inParamStudentReference, int inParamUserId, string inParamDescription, string inParamLogTypeId, string inParamUserDescription, string inParamLogRAGStatusId, bool inParamRewardType, int inParamCategoryId, string inParamDescriptionType, string inParamDisciplinaryType, int inParamCCSessionId, int inParamCommunicationId, string inParamMLWCompetenciesId, int inParamMLWCompetenciesCurrLevel, out int outParamStudentLogId) {
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ssCornwallCollegeFunct.Global.eSpaceId;
				RsseSpaceCornwallCollegeFunct.MssOnSessionStart(heContext);
				ssCornwallCollegeFunct.Actions.ActionStudentLog_Create(heContext, inParamStudentReference, inParamUserId, inParamDescription, inParamLogTypeId, inParamUserDescription, inParamLogRAGStatusId, inParamRewardType, inParamCategoryId, inParamDescriptionType, inParamDisciplinaryType, inParamCCSessionId, inParamCommunicationId, inParamMLWCompetenciesId, inParamMLWCompetenciesCurrLevel, out outParamStudentLogId);
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}


		public interface IRLStudentAttenndance_ListListTypeFactory {
			RecordList CreateRsseSpaceCornwallCollegeFunctRLStudentAttenndance_ListList();
		}
		public interface ISTStudentAttenndance_ListStructureTypeFactory {
			IRecord CreateRsseSpaceCornwallCollegeFunctSTStudentAttenndance_ListStructure();
		}
		public interface IENStudentEntityRecordTypeFactory {
			IRecord CreateRsseSpaceCornwallCollegeFunctENStudentEntityRecord();
		}
		public interface IRCStudentStudentLogRecordTypeFactory {
			IRecord CreateRsseSpaceCornwallCollegeFunctRCStudentStudentLogRecord();
		}
		public interface IENStudentLogEntityRecordTypeFactory {
			IRecord CreateRsseSpaceCornwallCollegeFunctENStudentLogEntityRecord();
		}


		public class Factory {
			public static IENStudentEntityRecordTypeFactory FactoryENStudentEntityRecordSingleton;
			public static ISTStudentAttenndance_ListStructureTypeFactory FactorySTStudentAttenndance_ListStructureSingleton;
			public static IRLStudentAttenndance_ListListTypeFactory FactoryRLStudentAttenndance_ListListSingleton;
			public static IENStudentLogEntityRecordTypeFactory FactoryENStudentLogEntityRecordSingleton;
			public static IRCStudentStudentLogRecordTypeFactory FactoryRCStudentStudentLogRecordSingleton;
		}
		public class DefaultValues {
			public static string ReferenceActionFolder_Student_ReferenceActionInsideFolder_Student_GetAttendancesByStudentReference_Variables_ReferenceGenericInputParameter_StudentReference {
				get {
					return ssCornwallCollegeFunct.DefaultValues.ReferenceActionFolder_Student_ReferenceActionInsideFolder_Student_GetAttendancesByStudentReference_Variables_ReferenceGenericInputParameter_StudentReference; 
				}
			}
			public static string ReferenceActionFolder_Log_ReferenceActionInsideFolder_StudentLog_GetCurrentValues_Variables_ReferenceGenericInputParameter_StudentReference {
				get {
					return ssCornwallCollegeFunct.DefaultValues.ReferenceActionFolder_Log_ReferenceActionInsideFolder_StudentLog_GetCurrentValues_Variables_ReferenceGenericInputParameter_StudentReference; 
				}
			}
			public static string ReferenceActionFolder_Log_ReferenceActionInsideFolder_StudentLog_Create_Variables_ReferenceGenericInputParameter_StudentReference {
				get {
					return ssCornwallCollegeFunct.DefaultValues.ReferenceActionFolder_Log_ReferenceActionInsideFolder_StudentLog_Create_Variables_ReferenceGenericInputParameter_StudentReference; 
				}
			}
			public static int ReferenceActionFolder_Log_ReferenceActionInsideFolder_StudentLog_Create_Variables_ReferenceGenericInputParameter_UserId {
				get {
					return ssCornwallCollegeFunct.DefaultValues.ReferenceActionFolder_Log_ReferenceActionInsideFolder_StudentLog_Create_Variables_ReferenceGenericInputParameter_UserId; 
				}
			}
			public static string ReferenceActionFolder_Log_ReferenceActionInsideFolder_StudentLog_Create_Variables_ReferenceGenericInputParameter_LogTypeId {
				get {
					return ssCornwallCollegeFunct.DefaultValues.ReferenceActionFolder_Log_ReferenceActionInsideFolder_StudentLog_Create_Variables_ReferenceGenericInputParameter_LogTypeId; 
				}
			}
			public static string ReferenceActionFolder_Log_ReferenceActionInsideFolder_StudentLog_Create_Variables_ReferenceGenericInputParameter_LogRAGStatusId {
				get {
					return ssCornwallCollegeFunct.DefaultValues.ReferenceActionFolder_Log_ReferenceActionInsideFolder_StudentLog_Create_Variables_ReferenceGenericInputParameter_LogRAGStatusId; 
				}
			}
			public static int ReferenceActionFolder_Log_ReferenceActionInsideFolder_StudentLog_Create_Variables_ReferenceGenericInputParameter_CategoryId {
				get {
					return ssCornwallCollegeFunct.DefaultValues.ReferenceActionFolder_Log_ReferenceActionInsideFolder_StudentLog_Create_Variables_ReferenceGenericInputParameter_CategoryId; 
				}
			}
			public static string ReferenceActionFolder_Log_ReferenceActionInsideFolder_StudentLog_Create_Variables_ReferenceGenericInputParameter_DisciplinaryType {
				get {
					return ssCornwallCollegeFunct.DefaultValues.ReferenceActionFolder_Log_ReferenceActionInsideFolder_StudentLog_Create_Variables_ReferenceGenericInputParameter_DisciplinaryType; 
				}
			}
			public static int ReferenceActionFolder_Log_ReferenceActionInsideFolder_StudentLog_Create_Variables_ReferenceGenericInputParameter_CCSessionId {
				get {
					return ssCornwallCollegeFunct.DefaultValues.ReferenceActionFolder_Log_ReferenceActionInsideFolder_StudentLog_Create_Variables_ReferenceGenericInputParameter_CCSessionId; 
				}
			}
			public static int ReferenceActionFolder_Log_ReferenceActionInsideFolder_StudentLog_Create_Variables_ReferenceGenericInputParameter_CommunicationId {
				get {
					return ssCornwallCollegeFunct.DefaultValues.ReferenceActionFolder_Log_ReferenceActionInsideFolder_StudentLog_Create_Variables_ReferenceGenericInputParameter_CommunicationId; 
				}
			}
			public static string ReferenceActionFolder_Log_ReferenceActionInsideFolder_StudentLog_Create_Variables_ReferenceGenericInputParameter_MLWCompetenciesId {
				get {
					return ssCornwallCollegeFunct.DefaultValues.ReferenceActionFolder_Log_ReferenceActionInsideFolder_StudentLog_Create_Variables_ReferenceGenericInputParameter_MLWCompetenciesId; 
				}
			}
			public static int ReferenceActionFolder_Log_ReferenceActionInsideFolder_StudentLog_Create_Variables_ReferenceGenericOutputParameter_StudentLogId {
				get {
					return ssCornwallCollegeFunct.DefaultValues.ReferenceActionFolder_Log_ReferenceActionInsideFolder_StudentLog_Create_Variables_ReferenceGenericOutputParameter_StudentLogId; 
				}
			}
			public static string ReferenceWebFlow_Common_WB_ReferenceWebBlock_MLW_PSR_Competencies_Progression_Chart_Variables_ReferenceSerializableInputParameter_Selected_StageId {
				get {
					return ssCornwallCollegeFunct.DefaultValues.ReferenceWebFlow_Common_WB_ReferenceWebBlock_MLW_PSR_Competencies_Progression_Chart_Variables_ReferenceSerializableInputParameter_Selected_StageId; 
				}
			}
			public static string ReferenceWebFlow_Common_WB_ReferenceWebBlock_MLW_PSR_Competencies_Progression_Chart_Variables_ReferenceSerializableInputParameter_StudentId {
				get {
					return ssCornwallCollegeFunct.DefaultValues.ReferenceWebFlow_Common_WB_ReferenceWebBlock_MLW_PSR_Competencies_Progression_Chart_Variables_ReferenceSerializableInputParameter_StudentId; 
				}
			}
		}
	}
}
namespace proxy_CaseConferencing_CornwallCollegeFunct.Flows.FlowCommon_WB {
	public class WBlkMLW_PSR_Competencies_Progression_Chart: OSUserControl, INegotiateTabIndexes, IWebScreen
	{
		protected ssCornwallCollegeFunct.Flows.FlowCommon_WB.WBlkMLW_PSR_Competencies_Progression_Chart block;
		static WBlkMLW_PSR_Competencies_Progression_Chart() {
			HeContext heContext = AppInfo.GetAppInfo().OsContext;
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ssCornwallCollegeFunct.Global.eSpaceId;
				ssCaseConferencing.RsseSpaceCornwallCollegeFunct.MssOnSessionStart(AppInfo.GetAppInfo().OsContext);
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}


		// override OSUserControl IsProxy()
		public override bool IsProxy() {
			return true;
		}

		// proxy implementation for WebScreen interface methods

		public override event EventHandler EvaluateParameters;

		public override string ClientID {
			get {
				return block.ClientID;
			}
		}

		public LocalState PushStack() {
			return block.PushStack();
		}

		public void doRefreshScreen(HeContext context) {
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = 45;
				block.doRefreshScreen(context);
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}

		public void doAJAXRefreshScreen(HeContext context) {
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = 45;
				block.doAJAXRefreshScreen(context);
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}

		public void OnSubmit(String parentEditRecord, bool validate) {
			block.OnSubmit(parentEditRecord, validate);
		}

		public void CheckPermissions(HeContext context) {
			block.CheckPermissions(context);
		}

		public ObjectKey Key {
			get {
				return block.Key;
			}
		}
		public bool isSecure {
			get {
				return block.isSecure;
			}
		}

		public string InstanceID {
			get {
				return block.InstanceID;
			}
			set {
				block.InstanceID = value;
			}
		}

		public HeContext heContext {
			get {
				return block.heContext;
			}
			set {
				block.heContext = value;
			}
		}

		// proxy implementation INegociateTabs interface method

		public short NegotiateTabIndexes(short tabindex, bool setTabIndex) {
			return block.NegotiateTabIndexes(tabindex, setTabIndex);
		}

		public short NegotiateTabIndexesRecursively(short tabindex, System.Web.UI.Control rootControl, bool setTabIndex) {
			return block.NegotiateTabIndexesRecursively(tabindex, rootControl, setTabIndex);
		}

		public override void DataBind() {
			HandleBreakpoint();
			if (EvaluateParameters != null) {
				EvaluateParameters(this, null);
			}
			block.DataBind();
		}

		public override bool IncludeSpan {
			get {
				return block.IncludeSpan; 
			}
			set {
				block.IncludeSpan = value; 
			}
		}

		public void BindProxyDelegates(object sender, BindDelegatesEventArgs e) {
			BindDelegatesIfNeeded();
			ssCornwallCollegeFunct.Flows.FlowCommon_WB.WBlkMLW_PSR_Competencies_Progression_Chart webBlock = (ssCornwallCollegeFunct.Flows.FlowCommon_WB.WBlkMLW_PSR_Competencies_Progression_Chart) e.UserControl;

		}

		public override string ParentEditRecord {
			get {
				return block.ParentEditRecord;
			}
			set {
				block.ParentEditRecord = value;
			}
		}

		public static void GetCss(System.IO.TextWriter writer, bool inline, HashSet<string> visited) {
			ssCornwallCollegeFunct.Flows.FlowCommon_WB.WBlkMLW_PSR_Competencies_Progression_Chart.GetCss(writer, inline, visited);
		}

		public override string GridCssClasses {
			get {
				return block.GridCssClasses;
			}
			set {
				block.GridCssClasses = value;
			}
		}

		public override string Style {
			get {
				return block.Style;
			}
			set {
				block.Style = value;
			}
		}

		public override string WebBlockIdentifier {
			get {
				return "Proxy." + block.WebBlockIdentifier;
			}
		}

		/// <summary>
		/// Delegate Definitions
		/// </summary>

		// web block public declarations

		// block input variable Selected_StageId
		public string inParamSelected_StageId {
			get {
				return block.inParamSelected_StageId;
			}
			set {
				block.inParamSelected_StageId = value;
			}
		}

		// block input variable StudentId
		public string inParamStudentId {
			get {
				return block.inParamStudentId;
			}
			set {
				block.inParamStudentId = value;
			}
		}

		// block input variable Title
		public string inParamTitle {
			get {
				return block.inParamTitle;
			}
			set {
				block.inParamTitle = value;
			}
		}

	}

}
