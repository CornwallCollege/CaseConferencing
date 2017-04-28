﻿/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

using System;
using System.Data;
using System.IO;
using System.Web;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using OutSystems.RuntimeCommon;
using System.Collections.Generic;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.HubEdition.RuntimePlatform.Email;
using OutSystems.HubEdition.RuntimePlatform.Sql;
using OutSystems.HubEdition.SMS;
using OutSystems.HubEdition.WebWidgets;

namespace ssCaseConferencing {

	public delegate void SimpleTimerCallback();

	public sealed class AppUtils: BaseAppUtils {


		public const int CurrentEspaceId = Global.eSpaceId;


		public static readonly AppUtils Instance = new AppUtils();

		protected override int GetTenantId(HeContext heContext) {
			return heContext.AppInfo.Tenant.Id;
		}

		public override string getImagePath(bool forInternalAccess, bool includeSessionIdIfNeeded, string nameOverride) {
			HttpRequest request = HttpContext.Current.Request;
			try {
				HeContext heContext = Global.App.OsContext;
				string path = heContext.OsISAPIFilter.GetHostSuffix(request, "");
				bool keepPTA = AppInfo.GetAppInfo().eSpaceId == Global.eSpaceId && nameOverride == null;
				if (!keepPTA || forInternalAccess) {
					path += RuntimePlatformUtils.GetEspacePrettyNamePath(nameOverride ?? "CaseConferencing", heContext);
				} else {
					path += (heContext.OsISAPIFilter.IsActiveInRequest(request) ? heContext.OsISAPIFilter.GetPath(request, "") + "/": "/CaseConferencing/");
				}
				if (keepPTA) {
					path += AppInfo.GetAppInfo().PtaPath;
				}
				return RuntimePlatformUtils.CheckUriSecurity(request, path);
			} catch {
				return "";
			}

		}



		public static void DoOnMobileOriginatedMessage(HeContext heContext, ref MobileOriginatedMessage Msg) {
			#if false
			RCSMSMORecord smsMoIn = new RCSMSMORecord();
			RCSMSMORecord smsMoOut;
			smsMoIn.ssSTSMSMO.ssMSISDN = Msg.MSISDN;
			smsMoIn.ssSTSMSMO.ssLargeAccount = Msg.LargeAccount;
			smsMoIn.ssSTSMSMO.ssMessage = Msg.Message;
			smsMoIn.ssSTSMSMO.ssBinaryMessage = Msg.BinaryMessage;
			smsMoIn.ssSTSMSMO.ssUDH = Msg.UDH;
			smsMoIn.ssSTSMSMO.ssMessageId = Msg.MessageId;
			smsMoIn.ssSTSMSMO.ssPriority = Msg.Priority;
			smsMoIn.ssSTSMSMO.ssEncoding = Msg.Encoding.ToString();
			smsMoIn.ssSTSMSMO.ssConnection = Msg.Connection;
			smsMoIn.ssSTSMSMO.ssOperatorCode = Msg.OperatorCode;
			smsMoIn.ssSTSMSMO.ssSent = Msg.Sent;
			smsMoIn.ssSTSMSMO.ssCustom1 = Msg.Custom1;
			smsMoIn.ssSTSMSMO.ssCustom2 = Msg.Custom2;
			smsMoIn.ssSTSMSMO.ssCustom3 = Msg.Custom3;
			Actions.ActionOnMobileOriginatedMessage(heContext, smsMoIn, out smsMoOut);
			Msg.MSISDN = smsMoOut.ssSTSMSMO.ssMSISDN;
			Msg.LargeAccount = smsMoOut.ssSTSMSMO.ssLargeAccount;
			Msg.Message = smsMoOut.ssSTSMSMO.ssMessage;
			Msg.BinaryMessage = smsMoOut.ssSTSMSMO.ssBinaryMessage;
			Msg.UDH = smsMoOut.ssSTSMSMO.ssUDH;
			Msg.MessageId = smsMoOut.ssSTSMSMO.ssMessageId;
			Msg.Priority = smsMoOut.ssSTSMSMO.ssPriority;
			try {
				Msg.Encoding = (SmsEncoding) Enum.Parse(typeof(SmsEncoding), smsMoOut.ssSTSMSMO.ssEncoding); 
			} catch {};
			Msg.Connection = smsMoOut.ssSTSMSMO.ssConnection;
			Msg.OperatorCode = smsMoOut.ssSTSMSMO.ssOperatorCode;
			Msg.Sent = smsMoOut.ssSTSMSMO.ssSent;
			Msg.Custom1 = smsMoOut.ssSTSMSMO.ssCustom1;
			Msg.Custom2 = smsMoOut.ssSTSMSMO.ssCustom2;
			Msg.Custom3 = smsMoOut.ssSTSMSMO.ssCustom3;
			#endif
		}

		public static void DoOnMobileTerminatedMessage(HeContext heContext, ref MobileTerminatedMessage Msg) {
			#if false
			RCSMSMTRecord smsMtIn = new RCSMSMTRecord();
			RCSMSMTRecord smsMtOut;
			smsMtIn.ssSTSMSMT.ssMSISDN = Msg.MSISDN;
			smsMtIn.ssSTSMSMT.ssLargeAccount = Msg.LargeAccount;
			smsMtIn.ssSTSMSMT.ssMessage = Msg.Message;
			smsMtIn.ssSTSMSMT.ssBinaryMessage = Msg.BinaryMessage;
			smsMtIn.ssSTSMSMT.ssUDH = Msg.UDH;
			smsMtIn.ssSTSMSMT.ssMessageId = Msg.MessageId;
			smsMtIn.ssSTSMSMT.ssOriginalMessageId = Msg.OriginalMessageId;
			smsMtIn.ssSTSMSMT.ssPriority = Msg.Priority;
			smsMtIn.ssSTSMSMT.ssEncoding = Msg.Encoding.ToString();
			smsMtIn.ssSTSMSMT.ssPid = Msg.Pid;
			smsMtIn.ssSTSMSMT.ssMClass = Msg.MClass.ToString();
			smsMtIn.ssSTSMSMT.ssConnection = Msg.Connection;
			smsMtIn.ssSTSMSMT.ssOperatorCode = Msg.OperatorCode;
			smsMtIn.ssSTSMSMT.ssBillingDescription = Msg.BillingDescription;
			smsMtIn.ssSTSMSMT.ssBillingCode = Msg.BillingCode;
			smsMtIn.ssSTSMSMT.ssCustom1 = Msg.Custom1;
			smsMtIn.ssSTSMSMT.ssCustom2 = Msg.Custom2;
			smsMtIn.ssSTSMSMT.ssCustom3 = Msg.Custom3;
			smsMtIn.ssSTSMSMT.ssDeliveryReport = Msg.DeliveryReport.ToString();
			smsMtIn.ssSTSMSMT.ssCustomId = Msg.CustomId;
			smsMtIn.ssSTSMSMT.ssMaximumParts = Msg.MaximumParts;
			Actions.ActionOnMobileTerminatedMessage(heContext, smsMtIn, out smsMtOut);
			Msg.MSISDN = smsMtOut.ssSTSMSMT.ssMSISDN;
			Msg.LargeAccount = smsMtOut.ssSTSMSMT.ssLargeAccount;
			Msg.Message = smsMtOut.ssSTSMSMT.ssMessage;
			Msg.BinaryMessage = smsMtOut.ssSTSMSMT.ssBinaryMessage;
			Msg.UDH = smsMtOut.ssSTSMSMT.ssUDH;
			Msg.MessageId = smsMtOut.ssSTSMSMT.ssMessageId;
			Msg.OriginalMessageId = smsMtOut.ssSTSMSMT.ssOriginalMessageId;
			Msg.Priority = smsMtOut.ssSTSMSMT.ssPriority;
			try {
				Msg.Encoding = (SmsEncoding) Enum.Parse(typeof(SmsEncoding), smsMtOut.ssSTSMSMT.ssEncoding); 
			} catch {};
			Msg.Pid = smsMtOut.ssSTSMSMT.ssPid;
			try {
				Msg.MClass = (SmsMessageClass) Enum.Parse(typeof(SmsMessageClass), smsMtOut.ssSTSMSMT.ssMClass); 
			} catch {};
			Msg.Connection = smsMtOut.ssSTSMSMT.ssConnection;
			Msg.OperatorCode = smsMtOut.ssSTSMSMT.ssOperatorCode;
			Msg.BillingDescription = smsMtOut.ssSTSMSMT.ssBillingDescription;
			Msg.BillingCode = smsMtOut.ssSTSMSMT.ssBillingCode;
			Msg.Custom1 = smsMtOut.ssSTSMSMT.ssCustom1;
			Msg.Custom2 = smsMtOut.ssSTSMSMT.ssCustom2;
			Msg.Custom3 = smsMtOut.ssSTSMSMT.ssCustom3;
			try {
				Msg.DeliveryReport = (DeliveryReportType) Enum.Parse(typeof(DeliveryReportType), smsMtOut.ssSTSMSMT.ssDeliveryReport); 
			} catch {};
			Msg.CustomId = smsMtOut.ssSTSMSMT.ssCustomId;
			Msg.MaximumParts = smsMtOut.ssSTSMSMT.ssMaximumParts;
			#endif
		}


		protected override string EntityToTablename(string entity, int tenantId) {
			string entityLC = entity.ToLowerInvariant();
			if (entityLC == "learnerdetailmenu") return ENLearnerDetailMenuEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "pdfreporttype") return ENPDFReportTypeEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "confirmationmessagebuttons") return ENConfirmationMessageButtonsEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "menusubitem") return ENMenuSubItemEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "confirmationmessageresponse") return ENConfirmationMessageResponseEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "attendanceviewtype") return ENAttendanceViewTypeEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "dashboardlastviewed") return ENDashboardLastViewedEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "colourbiased") return ENColourBiasedEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "menuitem") return ENMenuItemEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "user_role") return ENUser_RoleEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "group_role") return ENGroup_RoleEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "user") return ENUserEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "role") return ENRoleEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "espace") return ENEspaceEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "team") return ENTeamEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "targettype") return ENTargetTypeEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "tracking") return ENTrackingEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "cluster") return ENClusterEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "supporttype") return ENSupportTypeEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "support") return ENSupportEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "staff") return ENStaffEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "siassupporttype") return ENSIASSupportTypeEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "group") return ENGroupEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "category") return ENCategoryEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "studentannualvalues") return ENStudentAnnualValuesEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "student_group") return ENStudent_GroupEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "trackingtype") return ENTrackingTypeEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "target") return ENTargetEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "examentry") return ENExamEntryEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "ialevels") return ENIALevelsEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "grouptype") return ENGroupTypeEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "student") return ENStudentEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "curriculumlead") return ENCurriculumLeadEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "staff_group") return ENStaff_GroupEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "targetstatus") return ENTargetStatusEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "ialearningstyles") return ENIALearningStylesEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "safeguarding") return ENSafeguardingEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "examconcessions") return ENExamConcessionsEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "qualsonentry") return ENQualsOnEntryEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "safeguardingtype") return ENSafeguardingTypeEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "studentattendance") return ENStudentAttendanceEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "siassupport") return ENSIASSupportEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "siassupportneeds") return ENSIASSupportNeedsEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "siassupportneed") return ENSIASSupportNeedEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "safeguardingstatus") return ENSafeguardingStatusEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "supportneeds") return ENSupportNeedsEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "siasinitialassessment") return ENSIASInitialAssessmentEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "permissiontype") return ENPermissionTypeEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "rolepermissions") return ENRolePermissionsEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "applicationpermission") return ENApplicationPermissionEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "xaxisvaluestype") return ENXAxisValuesTypeEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "legendposition") return ENLegendPositionEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "stackingtype") return ENStackingTypeEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "tabs") return ENTabsEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "color") return ENColorEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "tilesize") return ENTileSizeEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "menuitem2") return ENMenuItem2Entity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "iconname") return ENIconNameEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "iconsize") return ENIconSizeEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "messagetype") return ENMessageTypeEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "academicyeartype2") return ENAcademicYearType2Entity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "academicyear2") return ENAcademicYear2Entity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "sizes") return ENSizesEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "reward") return ENRewardEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "progressreportsectiontype") return ENProgressReportSectionTypeEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "siassupportdocuments") return ENSIASSupportDocumentsEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "ragstatus") return ENRAGStatusEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "ccsessioncourse") return ENCCSessionCourseEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "studentlog") return ENStudentLogEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "studentpenportrait") return ENStudentPENPortraitEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "safeguardingdocumentsbinary") return ENSafeguardingDocumentsBinaryEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "riskassessmentsourceofevidence") return ENRiskAssessmentSourceOfEvidenceEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "siassupportneedsdocuments") return ENSIASSupportNeedsDocumentsEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "updatesseenby") return ENUpdatesSeenByEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "studentprocessnotes") return ENStudentProcessNotesEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "note") return ENNoteEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "tutorial") return ENTutorialEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "communicationdocuments") return ENCommunicationDocumentsEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "studentextraca") return ENStudentExtraCAEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "academicyears") return ENAcademicYearsEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "yesno") return ENYesNoEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "documents") return ENDocumentsEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "safeguardingissue") return ENSafeguardingIssueEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "studentmlwprocesscompetencies") return ENStudentMLWProcessCompetenciesEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "safeguardingdocuments") return ENSafeguardingDocumentsEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "notetype") return ENNoteTypeEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "communicationtype") return ENCommunicationTypeEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "shorttermragstatus") return ENShortTermRAGStatusEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "safeguardingagency") return ENSafeguardingAgencyEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "riskassessmentwhoisatrisk") return ENRiskAssessmentWhoIsAtRiskEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "studentrag") return ENStudentRAGEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "studentexemption") return ENStudentExemptionEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "studentpastoralsupport") return ENStudentPastoralSupportEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "studentlogtype") return ENStudentLogTypeEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "disciplinary") return ENDisciplinaryEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "mlwcompetencies") return ENMLWCompetenciesEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "riskassessmentmanagementofsupport") return ENRiskAssessmentManagementOfSupportEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "progressreport") return ENProgressReportEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "staffcoursefavourite") return ENStaffCourseFavouriteEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "riskassessmentsspreason") return ENRiskAssessmentSSPReasonEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "safeguardingissuetype") return ENSafeguardingIssueTypeEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "disciplinarydocuments") return ENDisciplinaryDocumentsEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "safeguardingpersonsinvolved") return ENSafeguardingPersonsInvolvedEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "ccsessiondocuments") return ENCCSessionDocumentsEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "progressreportsubsectiontype") return ENProgressReportSubSectionTypeEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "destinations") return ENDestinationsEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "riskassessmentexternalcontacts") return ENRiskAssessmentExternalContactsEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "safeguardingreferralmadeto") return ENSafeguardingReferralMadeToEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "staffstudentfavourite") return ENStaffStudentFavouriteEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "autocomplete_bank") return ENAutoComplete_BankEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "logo") return ENLogoEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "ccsessioncurriculumlead") return ENCCSessionCurriculumLeadEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "safeguardingoutcome") return ENSafeguardingOutcomeEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "internalmessagetype") return ENInternalMessageTypeEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "studentcareeraim") return ENStudentCareerAimEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "riskassessementrisks") return ENRiskAssessementRisksEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "studentcategoryrag") return ENStudentCategoryRAGEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "rewardreason") return ENRewardReasonEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "studentmlwprocess") return ENStudentMLWProcessEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "causeofconcernreason") return ENCauseOfConcernReasonEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "communication") return ENCommunicationEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "causeofconcernlearnernotes") return ENCauseOfConcernLearnerNotesEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "mlwstages") return ENMLWStagesEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "learningsupportdocuments") return ENLearningSupportDocumentsEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "progressreportsection") return ENProgressReportSectionEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "learningsupport") return ENLearningSupportEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "ccsessionteam") return ENCCSessionTeamEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "roledocumentpermissions") return ENRoleDocumentPermissionsEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "ccsession") return ENCCSessionEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "documenttype") return ENDocumentTypeEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "progressreportsections") return ENProgressReportSectionsEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "riskassessment") return ENRiskAssessmentEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "learningsupporttypes") return ENLearningSupportTypesEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "userdocumentpermissions") return ENUserDocumentPermissionsEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "riskassessmentkeepinformed") return ENRiskAssessmentKeepInformedEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "safeguardingagenciesinvolved") return ENSafeguardingAgenciesInvolvedEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "progressreporttype") return ENProgressReportTypeEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "causeofconcern") return ENCauseOfConcernEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "autocompletebanktype") return ENAutoCompleteBankTypeEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "safeguardingnatureofconcern") return ENSafeguardingNatureOfConcernEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "updates") return ENUpdatesEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());
			if (entityLC == "disciplinarytype") return ENDisciplinaryTypeEntity.LocalViewName(AppInfo.GetAppInfo().OsContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale());

			throw new DataBaseException("'" + entity + "' found in 'Expand Inline' parameter is an unknown Entity");
		}

		protected override bool CheckReadOnlyInvalidOperations(string entity) {
			string entityLC = entity.ToLowerInvariant();
			if (entityLC == "learnerdetailmenu")
			return true;
			if (entityLC == "pdfreporttype")
			return true;
			if (entityLC == "confirmationmessagebuttons")
			return true;
			if (entityLC == "menusubitem")
			return true;
			if (entityLC == "confirmationmessageresponse")
			return true;
			if (entityLC == "attendanceviewtype")
			return true;
			if (entityLC == "colourbiased")
			return true;
			if (entityLC == "menuitem")
			return true;
			if (entityLC == "targettype")
			return true;
			if (entityLC == "supporttype")
			return true;
			if (entityLC == "siassupporttype")
			return true;
			if (entityLC == "category")
			return true;
			if (entityLC == "trackingtype")
			return true;
			if (entityLC == "ialevels")
			return true;
			if (entityLC == "grouptype")
			return true;
			if (entityLC == "targetstatus")
			return true;
			if (entityLC == "ialearningstyles")
			return true;
			if (entityLC == "examconcessions")
			return true;
			if (entityLC == "safeguardingtype")
			return true;
			if (entityLC == "safeguardingstatus")
			return true;
			if (entityLC == "supportneeds")
			return true;
			if (entityLC == "permissiontype")
			return true;
			if (entityLC == "applicationpermission")
			return true;
			if (entityLC == "xaxisvaluestype")
			return true;
			if (entityLC == "legendposition")
			return true;
			if (entityLC == "stackingtype")
			return true;
			if (entityLC == "tabs")
			return true;
			if (entityLC == "color")
			return true;
			if (entityLC == "tilesize")
			return true;
			if (entityLC == "menuitem2")
			return true;
			if (entityLC == "iconname")
			return true;
			if (entityLC == "iconsize")
			return true;
			if (entityLC == "messagetype")
			return true;
			if (entityLC == "academicyeartype2")
			return true;
			if (entityLC == "academicyear2")
			return true;
			if (entityLC == "sizes")
			return true;
			if (entityLC == "progressreportsectiontype")
			return true;
			if (entityLC == "ragstatus")
			return true;
			if (entityLC == "riskassessmentsourceofevidence")
			return true;
			if (entityLC == "academicyears")
			return true;
			if (entityLC == "yesno")
			return true;
			if (entityLC == "notetype")
			return true;
			if (entityLC == "communicationtype")
			return true;
			if (entityLC == "shorttermragstatus")
			return true;
			if (entityLC == "safeguardingagency")
			return true;
			if (entityLC == "riskassessmentwhoisatrisk")
			return true;
			if (entityLC == "studentlogtype")
			return true;
			if (entityLC == "mlwcompetencies")
			return true;
			if (entityLC == "riskassessmentsspreason")
			return true;
			if (entityLC == "safeguardingissuetype")
			return true;
			if (entityLC == "progressreportsubsectiontype")
			return true;
			if (entityLC == "destinations")
			return true;
			if (entityLC == "safeguardingreferralmadeto")
			return true;
			if (entityLC == "logo")
			return true;
			if (entityLC == "safeguardingoutcome")
			return true;
			if (entityLC == "internalmessagetype")
			return true;
			if (entityLC == "rewardreason")
			return true;
			if (entityLC == "causeofconcernreason")
			return true;
			if (entityLC == "mlwstages")
			return true;
			if (entityLC == "documenttype")
			return true;
			if (entityLC == "learningsupporttypes")
			return true;
			if (entityLC == "progressreporttype")
			return true;
			if (entityLC == "autocompletebanktype")
			return true;
			if (entityLC == "safeguardingnatureofconcern")
			return true;
			if (entityLC == "disciplinarytype")
			return true;

			return false;
		}

		public override string[] GetAjaxJQueryFileNames() {
			string prefix = "";
			string osPageHeader = OsISAPIFilter.Instance.GetPage();
			if (osPageHeader != null && osPageHeader.IndexOf('/', 1) != -1) {
				prefix = AppUtils.Instance.getImagePath();
			}
			return new string[] {
				prefix + "_osjs.js"
			};

		}

		public override string GetGlobalJavaScriptInclude() {
			return "";
		}

		public override string CacheInvalidationPlatformSuffix {
			get {
				return "?9_0_1_3"; 
			}
		}

		public override string CacheInvalidationSuffix {
			get {
				return "?667"; 
			}
		}


	}
}