﻿/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Serialization;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.HubEdition.RuntimePlatform.Sms;
using OutSystems.HubEdition.RuntimePlatform.Log;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.Internal.Db;
using OutSystems.HubEdition.RuntimePlatform.Email;
using OutSystems.HubEdition.RuntimePlatform.Web;
using OutSystems.RuntimeCommon;
using OutSystems.ObjectKeys;
using System.Resources;

namespace ssCaseConferencing {

	public partial class Actions {
		public class lcvCourseList_GetActionsByRole: VarsBag {
			public int inParamUserId;
			/// <summary>
			/// Variable <code>varLcActionItem</code> that represents the Service Studio local variable
			///  <code>ActionItem</code> <p>Description: </p>
			/// </summary>
			public RCActionItemRecord varLcActionItem = new RCActionItemRecord(null);

			public int resUserCheck5_outParamPermissionType = 0;

			public int resUserCheck3_outParamPermissionType = 0;

			public int resUserCheck2_outParamPermissionType = 0;

			public int resUserCheck9_outParamPermissionType = 0;

			public int resUserCheck6_outParamPermissionType = 0;

			public int resUserCheck8_outParamPermissionType = 0;

			public int resUserCheck_outParamPermissionType = 0;

			public int resUserCheck7_outParamPermissionType = 0;

			public int resUserCheck4_outParamPermissionType = 0;

			public lcvCourseList_GetActionsByRole(int inParamUserId) {
				this.inParamUserId = inParamUserId;
			}
		}
		public class lcoCourseList_GetActionsByRole: VarsBag {
			public RLActionItemRecordList outParamActionItemList = new RLActionItemRecordList();

			public lcoCourseList_GetActionsByRole() {
			}
		}
		/// <summary>
		/// Action <code>ActionCourseList_GetActionsByRole</code> that represents the Service Studio user
		///  action <code>CourseList_GetActionsByRole</code> <p> Description: </p>
		/// </summary>
		public static void ActionCourseList_GetActionsByRole(HeContext heContext, int inParamUserId, out RLActionItemRecordList outParamActionItemList) {
			lcoCourseList_GetActionsByRole result = new lcoCourseList_GetActionsByRole();
			lcvCourseList_GetActionsByRole localVars = new lcvCourseList_GetActionsByRole(inParamUserId);
			try {
				// SelectAction
				localVars.varLcActionItem.ssSTActionItem.ssValue = "SelectAction"; // ActionItem.ActionItem.Value = "SelectAction"
				localVars.varLcActionItem.ssSTActionItem.ssText = "Select Action"; // ActionItem.ActionItem.Text = "Select Action"
				// ListAppend
				ExtendedActions.ListAppend(heContext, result.outParamActionItemList, localVars.varLcActionItem);
				// UserCheck
				Actions.ActionUserCheck(heContext, ((int) Global.App.OsContext.Session["UserID"]), ENApplicationPermissionEntity.GetRecordByKey(ObjectKey.Parse("_KYQXHHc8UGnRSwylLWQ0Q")).ssId, out localVars.resUserCheck_outParamPermissionType);
				if ((localVars.resUserCheck_outParamPermissionType!=BuiltInFunction.NullIdentifier())) {
					// ViewLearners
					localVars.varLcActionItem.ssSTActionItem.ssValue = "ViewLearners"; // ActionItem.ActionItem.Value = "ViewLearners"
					localVars.varLcActionItem.ssSTActionItem.ssText = "View Learners RAG"; // ActionItem.ActionItem.Text = "View Learners RAG"
					// ListAppend2
					ExtendedActions.ListAppend(heContext, result.outParamActionItemList, localVars.varLcActionItem);

				}
				// UserCheck2
				Actions.ActionUserCheck(heContext, ((int) Global.App.OsContext.Session["UserID"]), ENApplicationPermissionEntity.GetRecordByKey(ObjectKey.Parse("oDZDk7vbjky0HYuBDlfjVg")).ssId, out localVars.resUserCheck2_outParamPermissionType);
				if ((localVars.resUserCheck2_outParamPermissionType==ENPermissionTypeEntity.GetRecordByKey(ObjectKey.Parse("dcWAPDTdmEyjDYQI2aRLZw")).ssId)) {
					// AddOfferingTarget
					localVars.varLcActionItem.ssSTActionItem.ssValue = "AddOfferingTarget"; // ActionItem.ActionItem.Value = "AddOfferingTarget"
					localVars.varLcActionItem.ssSTActionItem.ssText = "Set Targets"; // ActionItem.ActionItem.Text = "Set Targets"
					// ListAppend3
					ExtendedActions.ListAppend(heContext, result.outParamActionItemList, localVars.varLcActionItem);

				}
				// UserCheck4
				Actions.ActionUserCheck(heContext, ((int) Global.App.OsContext.Session["UserID"]), ENApplicationPermissionEntity.GetRecordByKey(ObjectKey.Parse("0G0njdVIn0ucjJ6N1LzYDw")).ssId, out localVars.resUserCheck4_outParamPermissionType);
				if ((localVars.resUserCheck4_outParamPermissionType==ENPermissionTypeEntity.GetRecordByKey(ObjectKey.Parse("dcWAPDTdmEyjDYQI2aRLZw")).ssId)) {
					// SendEmail
					localVars.varLcActionItem.ssSTActionItem.ssValue = "SendEmail"; // ActionItem.ActionItem.Value = "SendEmail"
					localVars.varLcActionItem.ssSTActionItem.ssText = "Send Email"; // ActionItem.ActionItem.Text = "Send Email"
					// ListAppend5
					ExtendedActions.ListAppend(heContext, result.outParamActionItemList, localVars.varLcActionItem);

				}
				// UserCheck5
				Actions.ActionUserCheck(heContext, ((int) Global.App.OsContext.Session["UserID"]), ENApplicationPermissionEntity.GetRecordByKey(ObjectKey.Parse("S1Ew6xcAMkKJzXiUGmQuzQ")).ssId, out localVars.resUserCheck5_outParamPermissionType);
				if ((localVars.resUserCheck5_outParamPermissionType==ENPermissionTypeEntity.GetRecordByKey(ObjectKey.Parse("dcWAPDTdmEyjDYQI2aRLZw")).ssId)) {
					// SendSMS
					localVars.varLcActionItem.ssSTActionItem.ssValue = "SendSMS"; // ActionItem.ActionItem.Value = "SendSMS"
					localVars.varLcActionItem.ssSTActionItem.ssText = "Send Text"; // ActionItem.ActionItem.Text = "Send Text"
					// ListAppend6
					ExtendedActions.ListAppend(heContext, result.outParamActionItemList, localVars.varLcActionItem);

				}
				// UserCheck3
				Actions.ActionUserCheck(heContext, ((int) Global.App.OsContext.Session["UserID"]), ENApplicationPermissionEntity.GetRecordByKey(ObjectKey.Parse("BdSwjq8l9Uut8VgU4iW3KQ")).ssId, out localVars.resUserCheck3_outParamPermissionType);
				if ((localVars.resUserCheck3_outParamPermissionType==ENPermissionTypeEntity.GetRecordByKey(ObjectKey.Parse("dcWAPDTdmEyjDYQI2aRLZw")).ssId)) {
					// SIASSupportNeeds
					localVars.varLcActionItem.ssSTActionItem.ssValue = "SIASSupportNeeds"; // ActionItem.ActionItem.Value = "SIASSupportNeeds"
					localVars.varLcActionItem.ssSTActionItem.ssText = "View Initial Assessment"; // ActionItem.ActionItem.Text = "View Initial Assessment"
					// ListAppend4
					ExtendedActions.ListAppend(heContext, result.outParamActionItemList, localVars.varLcActionItem);

				}
				// UserCheck6
				Actions.ActionUserCheck(heContext, ((int) Global.App.OsContext.Session["UserID"]), ENApplicationPermissionEntity.GetRecordByKey(ObjectKey.Parse("13ZfNiegn0i11q3tspFIjA")).ssId, out localVars.resUserCheck6_outParamPermissionType);
				if ((localVars.resUserCheck6_outParamPermissionType==ENPermissionTypeEntity.GetRecordByKey(ObjectKey.Parse("dcWAPDTdmEyjDYQI2aRLZw")).ssId)) {
					// ProgressReports
					localVars.varLcActionItem.ssSTActionItem.ssValue = "ProgressReport"; // ActionItem.ActionItem.Value = "ProgressReport"
					localVars.varLcActionItem.ssSTActionItem.ssText = "Progress Reports"; // ActionItem.ActionItem.Text = "Progress Reports"
					// ListAppend7
					ExtendedActions.ListAppend(heContext, result.outParamActionItemList, localVars.varLcActionItem);

				}
				// UserCheck7
				Actions.ActionUserCheck(heContext, ((int) Global.App.OsContext.Session["UserID"]), ENApplicationPermissionEntity.GetRecordByKey(ObjectKey.Parse("_KYQXHHc8UGnRSwylLWQ0Q")).ssId, out localVars.resUserCheck7_outParamPermissionType);
				if ((localVars.resUserCheck7_outParamPermissionType==ENPermissionTypeEntity.GetRecordByKey(ObjectKey.Parse("dcWAPDTdmEyjDYQI2aRLZw")).ssId)) {
					localVars.varLcActionItem.ssSTActionItem.ssValue = "LearnerContactList"; // ActionItem.ActionItem.Value = "LearnerContactList"
					localVars.varLcActionItem.ssSTActionItem.ssText = "View Learner Contact List"; // ActionItem.ActionItem.Text = "View Learner Contact List"
					// ListAppend8
					ExtendedActions.ListAppend(heContext, result.outParamActionItemList, localVars.varLcActionItem);

				}
				// UserCheck8
				Actions.ActionUserCheck(heContext, ((int) Global.App.OsContext.Session["UserID"]), ENApplicationPermissionEntity.GetRecordByKey(ObjectKey.Parse("_KYQXHHc8UGnRSwylLWQ0Q")).ssId, out localVars.resUserCheck8_outParamPermissionType);
				if ((localVars.resUserCheck8_outParamPermissionType==ENPermissionTypeEntity.GetRecordByKey(ObjectKey.Parse("dcWAPDTdmEyjDYQI2aRLZw")).ssId)) {
					localVars.varLcActionItem.ssSTActionItem.ssValue = "IntendedDestinationReport"; // ActionItem.ActionItem.Value = "IntendedDestinationReport"
					localVars.varLcActionItem.ssSTActionItem.ssText = "View Intended Destination Report"; // ActionItem.ActionItem.Text = "View Intended Destination Report"
					// ListAppend9
					ExtendedActions.ListAppend(heContext, result.outParamActionItemList, localVars.varLcActionItem);

				}
				// UserCheck9
				Actions.ActionUserCheck(heContext, ((int) Global.App.OsContext.Session["UserID"]), ENApplicationPermissionEntity.GetRecordByKey(ObjectKey.Parse("_KYQXHHc8UGnRSwylLWQ0Q")).ssId, out localVars.resUserCheck9_outParamPermissionType);
				if ((localVars.resUserCheck9_outParamPermissionType==ENPermissionTypeEntity.GetRecordByKey(ObjectKey.Parse("dcWAPDTdmEyjDYQI2aRLZw")).ssId)) {
					localVars.varLcActionItem.ssSTActionItem.ssValue = "PENPortrait"; // ActionItem.ActionItem.Value = "PENPortrait"
					localVars.varLcActionItem.ssSTActionItem.ssText = "View Learners PEN Portraits"; // ActionItem.ActionItem.Text = "View Learners PEN Portraits"
					// ListAppend10
					ExtendedActions.ListAppend(heContext, result.outParamActionItemList, localVars.varLcActionItem);

				}
			} // try

			finally {
				outParamActionItemList = result.outParamActionItemList;
			}
		}

		public static class FuncActionCourseList_GetActionsByRole {


		}


	}


}