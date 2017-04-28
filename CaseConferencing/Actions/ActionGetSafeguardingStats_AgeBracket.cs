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
		public class lcvGetSafeguardingStats_AgeBracket: VarsBag {
			public RLReporting_SafeguardingStatsRecordList inParamSafeguardingList;
			/// <summary>
			/// Variable <code>varLcTotal1416</code> that represents the Service Studio local variable
			///  <code>Total1416</code> <p>Description: </p>
			/// </summary>
			public int varLcTotal1416 = 0;

			/// <summary>
			/// Variable <code>varLcTotal1618</code> that represents the Service Studio local variable
			///  <code>Total1618</code> <p>Description: </p>
			/// </summary>
			public int varLcTotal1618 = 0;

			/// <summary>
			/// Variable <code>varLcTotal19plus</code> that represents the Service Studio local variable
			///  <code>Total19plus</code> <p>Description: </p>
			/// </summary>
			public int varLcTotal19plus = 0;

			/// <summary>
			/// Variable <code>varLcOtherTotal</code> that represents the Service Studio local variable
			///  <code>OtherTotal</code> <p>Description: </p>
			/// </summary>
			public int varLcOtherTotal = 0;

			/// <summary>
			/// Variable <code>varLcDataRecord</code> that represents the Service Studio local variable
			///  <code>DataRecord</code> <p>Description: </p>
			/// </summary>
			public RCGraphPointsRecord varLcDataRecord = new RCGraphPointsRecord(null);

			public lcvGetSafeguardingStats_AgeBracket(RLReporting_SafeguardingStatsRecordList inParamSafeguardingList) {
				this.inParamSafeguardingList = inParamSafeguardingList;
			}
		}
		public class lcoGetSafeguardingStats_AgeBracket: VarsBag {
			public RLGraphPointsRecordList outParamRecordList = new RLGraphPointsRecordList();

			public lcoGetSafeguardingStats_AgeBracket() {
			}
		}
		/// <summary>
		/// Action <code>ActionGetSafeguardingStats_AgeBracket</code> that represents the Service Studio user
		///  action <code>GetSafeguardingStats_AgeBracket</code> <p> Description: </p>
		/// </summary>
		public static void ActionGetSafeguardingStats_AgeBracket(HeContext heContext, RLReporting_SafeguardingStatsRecordList inParamSafeguardingList, out RLGraphPointsRecordList outParamRecordList) {
			lcoGetSafeguardingStats_AgeBracket result = new lcoGetSafeguardingStats_AgeBracket();
			lcvGetSafeguardingStats_AgeBracket localVars = new lcvGetSafeguardingStats_AgeBracket(inParamSafeguardingList);
			try {
				// Foreach SafeguardingList
				localVars.inParamSafeguardingList.StartIteration();
				try {
					while (! localVars.inParamSafeguardingList.Eof) {
						if ((localVars.inParamSafeguardingList.CurrentRec.ssSTReporting_SafeguardingStats.ssAgeBracket== "16-18")) {
							localVars.varLcTotal1618 = (localVars.varLcTotal1618+1); // Total1618 = Total1618 + 1

						} else {
							if ((localVars.inParamSafeguardingList.CurrentRec.ssSTReporting_SafeguardingStats.ssAgeBracket== "14-16")) {
								localVars.varLcTotal1416 = (localVars.varLcTotal1416+1); // Total1416 = Total1416 + 1

							} else {
								if ((localVars.inParamSafeguardingList.CurrentRec.ssSTReporting_SafeguardingStats.ssAgeBracket== "19+")) {
									localVars.varLcTotal19plus = (localVars.varLcTotal19plus+1); // Total19plus = Total19plus + 1

								} else {
									localVars.varLcOtherTotal = (localVars.varLcOtherTotal+1); // OtherTotal = OtherTotal + 1

								}

							}

						}
						localVars.inParamSafeguardingList.Advance();
					}
				} finally {
					localVars.inParamSafeguardingList.EndIteration();
				}
				localVars.varLcDataRecord.ssSTGraphPoints.ssLabel = "14-16"; // DataRecord.GraphPoints.Label = "14-16"
				localVars.varLcDataRecord.ssSTGraphPoints.ssValue = localVars.varLcTotal1416; // DataRecord.GraphPoints.Value = Total1416
				// ListAppend
				ExtendedActions.ListAppend(heContext, result.outParamRecordList, localVars.varLcDataRecord);
				localVars.varLcDataRecord.ssSTGraphPoints.ssLabel = "16-18"; // DataRecord.GraphPoints.Label = "16-18"
				localVars.varLcDataRecord.ssSTGraphPoints.ssValue = localVars.varLcTotal1618; // DataRecord.GraphPoints.Value = Total1618
				// ListAppend2
				ExtendedActions.ListAppend(heContext, result.outParamRecordList, localVars.varLcDataRecord);
				localVars.varLcDataRecord.ssSTGraphPoints.ssLabel = "19+"; // DataRecord.GraphPoints.Label = "19+"
				localVars.varLcDataRecord.ssSTGraphPoints.ssValue = localVars.varLcTotal19plus; // DataRecord.GraphPoints.Value = Total19plus
				// ListAppend4
				ExtendedActions.ListAppend(heContext, result.outParamRecordList, localVars.varLcDataRecord);
				localVars.varLcDataRecord.ssSTGraphPoints.ssLabel = "Other"; // DataRecord.GraphPoints.Label = "Other"
				localVars.varLcDataRecord.ssSTGraphPoints.ssValue = localVars.varLcOtherTotal; // DataRecord.GraphPoints.Value = OtherTotal
				// ListAppend3
				ExtendedActions.ListAppend(heContext, result.outParamRecordList, localVars.varLcDataRecord);
			} // try

			finally {
				outParamRecordList = result.outParamRecordList;
			}
		}

		public static class FuncActionGetSafeguardingStats_AgeBracket {


		}


	}


}