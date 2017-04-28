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
		public class lcvCreateStudentAttendanceTableOverviewLayout: VarsBag {
			public string inParamStudentReference;
			public string inParamDateRange;
			public string inParamOfferingCode;
			/// <summary>
			/// Variable <code>varLcCurrentDateToBuild</code> that represents the Service Studio local variable
			///  <code>CurrentDateToBuild</code> <p>Description: </p>
			/// </summary>
			public DateTime varLcCurrentDateToBuild = new DateTime(1900, 1, 1, 0, 0, 0);

			/// <summary>
			/// Variable <code>varLcStartPos</code> that represents the Service Studio local variable
			///  <code>StartPos</code> <p>Description: </p>
			/// </summary>
			public int varLcStartPos = 0;

			/// <summary>
			/// Variable <code>varLcEndPos</code> that represents the Service Studio local variable
			///  <code>EndPos</code> <p>Description: </p>
			/// </summary>
			public int varLcEndPos = 0;

			/// <summary>
			/// Variable <code>varLcRow</code> that represents the Service Studio local variable <code>Row</code>
			///  <p>Description: </p>
			/// </summary>
			public RLTDTagRecordList varLcRow = new RLTDTagRecordList();

			/// <summary>
			/// Variable <code>varLcCurrentPos</code> that represents the Service Studio local variable
			///  <code>CurrentPos</code> <p>Description: </p>
			/// </summary>
			public int varLcCurrentPos = 0;

			/// <summary>
			/// Variable <code>varLcAltRow</code> that represents the Service Studio local variable
			///  <code>AltRow</code> <p>Description: </p>
			/// </summary>
			public bool varLcAltRow = false;

			/// <summary>
			/// Variable <code>varLcStartDate</code> that represents the Service Studio local variable
			///  <code>StartDate</code> <p>Description: </p>
			/// </summary>
			public DateTime varLcStartDate = new DateTime(1900, 1, 1, 0, 0, 0);

			/// <summary>
			/// Variable <code>varLcEndDate</code> that represents the Service Studio local variable
			///  <code>EndDate</code> <p>Description: </p>
			/// </summary>
			public DateTime varLcEndDate = new DateTime(1900, 1, 1, 0, 0, 0);

			public RLStudentAttendanceForCourseRecordList resGetStudentAttendanceByCourseDetail_outParamStudentAttendance = new RLStudentAttendanceForCourseRecordList();

			public lcoCreateOVPopulatedRow resCreateOVPopulatedRow = new lcoCreateOVPopulatedRow();
			public lcoGetStudentAttendanceColumnsAndRows resGetStudentAttendanceColumnsAndRows = new lcoGetStudentAttendanceColumnsAndRows();
			public string resStringBuilder_ToString_outParamString = "";

			public object resStringBuilder_Create_outParamStringBuilder = null;

			public lcoCreateOVHeaderRow resCreateOVHeaderRow = new lcoCreateOVHeaderRow();
			public lcvCreateStudentAttendanceTableOverviewLayout(string inParamStudentReference, string inParamDateRange, string inParamOfferingCode) {
				this.inParamStudentReference = inParamStudentReference;
				this.inParamDateRange = inParamDateRange;
				this.inParamOfferingCode = inParamOfferingCode;
			}
		}
		public class lcoCreateStudentAttendanceTableOverviewLayout: VarsBag {
			public string outParamTableHTML = "";

			public lcoCreateStudentAttendanceTableOverviewLayout() {
			}
		}
		/// <summary>
		/// Action <code>ActionCreateStudentAttendanceTableOverviewLayout</code> that represents the Service
		///  Studio user action <code>CreateStudentAttendanceTableOverviewLayout</code> <p> Description: </p>
		/// </summary>
		public static void ActionCreateStudentAttendanceTableOverviewLayout(HeContext heContext, string inParamStudentReference, string inParamDateRange, string inParamOfferingCode, out string outParamTableHTML) {
			lcoCreateStudentAttendanceTableOverviewLayout result = new lcoCreateStudentAttendanceTableOverviewLayout();
			lcvCreateStudentAttendanceTableOverviewLayout localVars = new lcvCreateStudentAttendanceTableOverviewLayout(inParamStudentReference, inParamDateRange, inParamOfferingCode);
			try {
				localVars.varLcStartDate = BuiltInFunction.TextToDate(BuiltInFunction.Substr(localVars.inParamDateRange, 0, BuiltInFunction.Index(localVars.inParamDateRange, "|", 0, false, false))); // StartDate = TextToDate
				localVars.varLcEndDate = BuiltInFunction.TextToDate(BuiltInFunction.Substr(localVars.inParamDateRange, (BuiltInFunction.Index(localVars.inParamDateRange, "|", 0, false, false) +1), BuiltInFunction.Length(localVars.inParamDateRange))); // EndDate = TextToDate
				// StringBuilder_Create
				Actions.ActionStringBuilder_Create(heContext, 10000, out localVars.resStringBuilder_Create_outParamStringBuilder);
				// CreateTableTag
				Actions.ActionStringBuilder_Append(heContext, localVars.resStringBuilder_Create_outParamStringBuilder, "<table class=\'AttendanceOverviewTable\'>");
				// GetStudentAttendanceByCourseDetail
				Actions.ActionGetStudentAttendanceByCourseDetail(heContext, localVars.inParamStudentReference, localVars.inParamOfferingCode, localVars.varLcStartDate, localVars.varLcEndDate, "Overview", out localVars.resGetStudentAttendanceByCourseDetail_outParamStudentAttendance);
				// GetStudentAttendanceColumnsAndRows
				Actions.ActionGetStudentAttendanceColumnsAndRows(heContext, localVars.resGetStudentAttendanceByCourseDetail_outParamStudentAttendance, out localVars.resGetStudentAttendanceColumnsAndRows.outParamAttendanceColumns, out localVars.resGetStudentAttendanceColumnsAndRows.outParamAttendanceRows);
				// CreateOVHeaderRow
				Actions.ActionCreateOVHeaderRow(heContext, localVars.resGetStudentAttendanceColumnsAndRows.outParamAttendanceColumns, out localVars.resCreateOVHeaderRow.outParamHeaderHTML);
				// StringBuilder_Append
				Actions.ActionStringBuilder_Append(heContext, localVars.resStringBuilder_Create_outParamStringBuilder, localVars.resCreateOVHeaderRow.outParamHeaderHTML);
				// Foreach GetStudentAttendanceColumnsAndRows.AttendanceRows
				localVars.resGetStudentAttendanceColumnsAndRows.outParamAttendanceRows.StartIteration();
				try {
					while (! localVars.resGetStudentAttendanceColumnsAndRows.outParamAttendanceRows.Eof) {
						if (!((localVars.resGetStudentAttendanceColumnsAndRows.outParamAttendanceRows.CurrentRowNumber==0))) {
							// CreateOVPopulatedRow
							Actions.ActionCreateOVPopulatedRow(heContext, localVars.resGetStudentAttendanceByCourseDetail_outParamStudentAttendance, localVars.resGetStudentAttendanceColumnsAndRows.outParamAttendanceRows.CurrentRec, localVars.resGetStudentAttendanceColumnsAndRows.outParamAttendanceColumns, out localVars.resCreateOVPopulatedRow.outParamRowHTML);
							// StringBuilder_Append3
							Actions.ActionStringBuilder_Append(heContext, localVars.resStringBuilder_Create_outParamStringBuilder, localVars.resCreateOVPopulatedRow.outParamRowHTML);

						}
						localVars.resGetStudentAttendanceColumnsAndRows.outParamAttendanceRows.Advance();
					}
				} finally {
					localVars.resGetStudentAttendanceColumnsAndRows.outParamAttendanceRows.EndIteration();
				}
				// StringBuilder_Append2
				Actions.ActionStringBuilder_Append(heContext, localVars.resStringBuilder_Create_outParamStringBuilder, "</table>");
				// StringBuilder_ToString
				Actions.ActionStringBuilder_ToString(heContext, localVars.resStringBuilder_Create_outParamStringBuilder, out localVars.resStringBuilder_ToString_outParamString);
				result.outParamTableHTML = localVars.resStringBuilder_ToString_outParamString; // TableHTML = StringBuilder_ToString.String
			} // try

			finally {
				outParamTableHTML = result.outParamTableHTML;
			}
		}

		public static class FuncActionCreateStudentAttendanceTableOverviewLayout {


		}


	}


}