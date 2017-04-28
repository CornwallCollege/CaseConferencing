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
		public class lcvGetSafeguardingStats_ReferredTo: VarsBag {
			public RLReporting_SafeguardingStatsRecordList inParamSafeguardingList;
			/// <summary>
			/// Variable <code>varLcMARUTotal</code> that represents the Service Studio local variable
			///  <code>MARUTotal</code> <p>Description: </p>
			/// </summary>
			public int varLcMARUTotal = 0;

			/// <summary>
			/// Variable <code>varLcPoliceTotal</code> that represents the Service Studio local variable
			///  <code>PoliceTotal</code> <p>Description: </p>
			/// </summary>
			public int varLcPoliceTotal = 0;

			/// <summary>
			/// Variable <code>varLcHousingTotal</code> that represents the Service Studio local variable
			///  <code>HousingTotal</code> <p>Description: </p>
			/// </summary>
			public int varLcHousingTotal = 0;

			/// <summary>
			/// Variable <code>varLcGPTotal</code> that represents the Service Studio local variable
			///  <code>GPTotal</code> <p>Description: </p>
			/// </summary>
			public int varLcGPTotal = 0;

			/// <summary>
			/// Variable <code>varLcMentalHealthTotal</code> that represents the Service Studio local variable
			///  <code>MentalHealthTotal</code> <p>Description: </p>
			/// </summary>
			public int varLcMentalHealthTotal = 0;

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

			public lcvGetSafeguardingStats_ReferredTo(RLReporting_SafeguardingStatsRecordList inParamSafeguardingList) {
				this.inParamSafeguardingList = inParamSafeguardingList;
			}
		}
		public class lcoGetSafeguardingStats_ReferredTo: VarsBag {
			public RLGraphPointsRecordList outParamRecordList = new RLGraphPointsRecordList();

			public lcoGetSafeguardingStats_ReferredTo() {
			}
		}
		/// <summary>
		/// Action <code>ActionGetSafeguardingStats_ReferredTo</code> that represents the Service Studio user
		///  action <code>GetSafeguardingStats_ReferredTo</code> <p> Description: </p>
		/// </summary>
		public static void ActionGetSafeguardingStats_ReferredTo(HeContext heContext, RLReporting_SafeguardingStatsRecordList inParamSafeguardingList, out RLGraphPointsRecordList outParamRecordList) {
			lcoGetSafeguardingStats_ReferredTo result = new lcoGetSafeguardingStats_ReferredTo();
			lcvGetSafeguardingStats_ReferredTo localVars = new lcvGetSafeguardingStats_ReferredTo(inParamSafeguardingList);
			try {
				// Foreach SafeguardingList
				localVars.inParamSafeguardingList.StartIteration();
				try {
					while (! localVars.inParamSafeguardingList.Eof) {
						if ((localVars.inParamSafeguardingList.CurrentRec.ssSTReporting_SafeguardingStats.ssExternalAgencyReferral== "MARU")) {
							localVars.varLcMARUTotal = (localVars.varLcMARUTotal+1); // MARUTotal = MARUTotal + 1

						} else {
							if ((localVars.inParamSafeguardingList.CurrentRec.ssSTReporting_SafeguardingStats.ssExternalAgencyReferral== "Police")) {
								localVars.varLcPoliceTotal = (localVars.varLcPoliceTotal+1); // PoliceTotal = PoliceTotal + 1

							} else {
								if ((localVars.inParamSafeguardingList.CurrentRec.ssSTReporting_SafeguardingStats.ssExternalAgencyReferral== "Housing")) {
									localVars.varLcHousingTotal = (localVars.varLcHousingTotal+1); // HousingTotal = HousingTotal + 1

								} else {
									if ((localVars.inParamSafeguardingList.CurrentRec.ssSTReporting_SafeguardingStats.ssExternalAgencyReferral== "GP")) {
										localVars.varLcGPTotal = (localVars.varLcGPTotal+1); // GPTotal = GPTotal + 1

									} else {
										if ((localVars.inParamSafeguardingList.CurrentRec.ssSTReporting_SafeguardingStats.ssExternalAgencyReferral== "Mental Health")) {
											localVars.varLcMentalHealthTotal = (localVars.varLcMentalHealthTotal+1); // MentalHealthTotal = MentalHealthTotal + 1

										} else {
											localVars.varLcOtherTotal = (localVars.varLcOtherTotal+1); // OtherTotal = OtherTotal + 1

										}

									}

								}

							}

						}
						localVars.inParamSafeguardingList.Advance();
					}
				} finally {
					localVars.inParamSafeguardingList.EndIteration();
				}
				localVars.varLcDataRecord.ssSTGraphPoints.ssLabel = "MARU"; // DataRecord.GraphPoints.Label = "MARU"
				localVars.varLcDataRecord.ssSTGraphPoints.ssValue = localVars.varLcMARUTotal; // DataRecord.GraphPoints.Value = MARUTotal
				// ListAppend
				ExtendedActions.ListAppend(heContext, result.outParamRecordList, localVars.varLcDataRecord);
				localVars.varLcDataRecord.ssSTGraphPoints.ssLabel = "Police"; // DataRecord.GraphPoints.Label = "Police"
				localVars.varLcDataRecord.ssSTGraphPoints.ssValue = localVars.varLcPoliceTotal; // DataRecord.GraphPoints.Value = PoliceTotal
				// ListAppend2
				ExtendedActions.ListAppend(heContext, result.outParamRecordList, localVars.varLcDataRecord);
				localVars.varLcDataRecord.ssSTGraphPoints.ssLabel = "Housing"; // DataRecord.GraphPoints.Label = "Housing"
				localVars.varLcDataRecord.ssSTGraphPoints.ssValue = localVars.varLcHousingTotal; // DataRecord.GraphPoints.Value = HousingTotal
				// ListAppend3
				ExtendedActions.ListAppend(heContext, result.outParamRecordList, localVars.varLcDataRecord);
				localVars.varLcDataRecord.ssSTGraphPoints.ssLabel = "GP"; // DataRecord.GraphPoints.Label = "GP"
				localVars.varLcDataRecord.ssSTGraphPoints.ssValue = localVars.varLcGPTotal; // DataRecord.GraphPoints.Value = GPTotal
				// ListAppend4
				ExtendedActions.ListAppend(heContext, result.outParamRecordList, localVars.varLcDataRecord);
				localVars.varLcDataRecord.ssSTGraphPoints.ssLabel = "Mental Health"; // DataRecord.GraphPoints.Label = "Mental Health"
				localVars.varLcDataRecord.ssSTGraphPoints.ssValue = localVars.varLcMentalHealthTotal; // DataRecord.GraphPoints.Value = MentalHealthTotal
				// ListAppend5
				ExtendedActions.ListAppend(heContext, result.outParamRecordList, localVars.varLcDataRecord);
				localVars.varLcDataRecord.ssSTGraphPoints.ssLabel = "Other"; // DataRecord.GraphPoints.Label = "Other"
				localVars.varLcDataRecord.ssSTGraphPoints.ssValue = localVars.varLcOtherTotal; // DataRecord.GraphPoints.Value = OtherTotal
				// ListAppend6
				ExtendedActions.ListAppend(heContext, result.outParamRecordList, localVars.varLcDataRecord);
			} // try

			finally {
				outParamRecordList = result.outParamRecordList;
			}
		}

		public static class FuncActionGetSafeguardingStats_ReferredTo {


		}


	}


}