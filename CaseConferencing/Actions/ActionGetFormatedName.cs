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
		public class lcvGetFormatedName: VarsBag {
			public string inParamStudentId;
			public RLStudentRecordList queryResGetStudentByStudentReference_outParamList = new RLStudentRecordList();
			public int queryResGetStudentByStudentReference_outParamCount = 0;

			public lcvGetFormatedName(string inParamStudentId) {
				this.inParamStudentId = inParamStudentId;
			}
		}
		public class lcoGetFormatedName: VarsBag {
			public string outParamName = "";

			public lcoGetFormatedName() {
			}
		}
		/// <summary>
		/// Action <code>ActionGetFormatedName</code> that represents the Service Studio user action
		///  <code>GetFormatedName</code> <p> Description: </p>
		/// </summary>
		public static void ActionGetFormatedName(HeContext heContext, string inParamStudentId, out string outParamName) {
			lcoGetFormatedName result = new lcoGetFormatedName();
			lcvGetFormatedName localVars = new lcvGetFormatedName(inParamStudentId);
			try {
				// Query datasetGetStudentByStudentReference
				int datasetGetStudentByStudentReference_maxRecords = 0;
				localVars.queryResGetStudentByStudentReference_outParamList = FuncActionGetFormatedName.datasetGetStudentByStudentReference(heContext, datasetGetStudentByStudentReference_maxRecords, IterationMultiplicity.Never, out localVars.queryResGetStudentByStudentReference_outParamCount, localVars.inParamStudentId
				);
				result.outParamName = (((((BuiltInFunction.ToUpper(localVars.queryResGetStudentByStudentReference_outParamList.CurrentRec.ssENStudent.ssSurname) + ", ") +localVars.queryResGetStudentByStudentReference_outParamList.CurrentRec.ssENStudent.ssForenames) + "(") +localVars.queryResGetStudentByStudentReference_outParamList.CurrentRec.ssENStudent.ssStudentReference) + ")"); // Name = ToUpper + ", " + GetStudentByStudentReference.List.Current.Student.Forenames + "(" +
				// GetStudentByStudentReference.List.Current.Student.StudentReference + ")"
			} // try

			finally {
				outParamName = result.outParamName;
			}
		}

		public static class FuncActionGetFormatedName {

			/// <summary>
			/// Query Function "GetStudentByStudentReference" of Action "GetFormatedName"
			/// </summary>
			public static RLStudentRecordList datasetGetStudentByStudentReference(HeContext heContext, int maxRecords, IterationMultiplicity multiplicity, out int outParamCount, string qpstP) {
				// Query Iterations: Never {-unbound-}
				// Uses binary data: False
				if (multiplicity == IterationMultiplicity.Never) {
					maxRecords = 1;
				}
				outParamCount = -1;
				bool useMainTransaction = (multiplicity != IterationMultiplicity.Single || (maxRecords > 0 && maxRecords <= 150));
				Transaction trans = useMainTransaction? DatabaseAccess.ForCurrentDatabase.GetRequestTransaction(): DatabaseAccess.ForCurrentDatabase.GetReadOnlyTransaction();
				Command sqlCmd = trans.CreateCommand();
				string sql = "";
				StringBuilder selectBuilder = new StringBuilder();
				StringBuilder fromBuilder = new StringBuilder();
				StringBuilder whereBuilder = new StringBuilder();
				StringBuilder orderByBuilder = new StringBuilder();
				StringBuilder groupByBuilder = new StringBuilder();
				StringBuilder havingBuilder = new StringBuilder();
				selectBuilder.Append("SELECT ");
				if (maxRecords > 0) {
					selectBuilder.Append("TOP (");
					selectBuilder.Append(maxRecords);
					selectBuilder.Append(") ");
				}
				selectBuilder.Append("ENStudent.[STUDENTREFERENCE] o1, ENStudent.[FORENAMES] o2, ENStudent.[SURNAME] o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27");
				fromBuilder.Append(" FROM {Student} ENStudent");
				whereBuilder.Append(" WHERE ");
				if (qpstP.Trim() != "") {
					whereBuilder.Append("((ENStudent.[STUDENTREFERENCE] = @qpstP) AND (ENStudent.[STUDENTREFERENCE] IS NOT NULL))");
					sqlCmd.CreateParameterWithoutReplacements("@qpstP", DbType.String, qpstP);
				} else {
					whereBuilder.Append("(ENStudent.[STUDENTREFERENCE] IS NULL)");
				}

				sql = selectBuilder.ToString() + fromBuilder.ToString() + whereBuilder.ToString() + groupByBuilder.ToString() + havingBuilder.ToString() + orderByBuilder.ToString();
				string advSql = sql;
				sql = AppUtils.Instance.ReplaceEntityReferences(heContext, advSql);
				sqlCmd.CommandText = sql;
				RLStudentRecordList outParamList = new RLStudentRecordList();
				outParamList.Transaction = trans;
				BitArray[] opt = new BitArray[1];
				opt[0] = new BitArray(new bool[] {
					false, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true
				}
				);
				outParamList.AllOptimizedAttributes = opt;
				if (multiplicity == IterationMultiplicity.Multiple) {
					RLStudentRecordList _tmp = new RLStudentRecordList();
					_tmp.Transaction = trans;
					_tmp.AllOptimizedAttributes = opt;
					_tmp.MaxRecords = maxRecords;
					try {
						DatabaseAccess.ForCurrentDatabase.ExecuteQuery(sqlCmd, _tmp, "Query Student.GetFormatedName.GetStudentByStudentReference.List");
						outParamList = (RLStudentRecordList) _tmp.Duplicate();
						_tmp.CloseDataReader();
						return outParamList;
					} finally {
						_tmp.CloseDataReader();
					}
				} else if (multiplicity == IterationMultiplicity.Never) {
					try {
						DatabaseAccess.ForCurrentDatabase.ExecuteQuery(sqlCmd, outParamList, "Query Student.GetFormatedName.GetStudentByStudentReference.List");
						outParamList.MaxRecords = maxRecords;
						return outParamList;
					} finally {
						outParamList.CloseDataReader();
					}
				} else {
					if (maxRecords > 0 && maxRecords <= 150) {
						RLStudentRecordList _tmp = new RLStudentRecordList();
						_tmp.Transaction = trans;
						_tmp.AllOptimizedAttributes = opt;
						try {
							DatabaseAccess.ForCurrentDatabase.ExecuteQuery(sqlCmd, _tmp, "Query Student.GetFormatedName.GetStudentByStudentReference.List");
							outParamList = (RLStudentRecordList) _tmp.Duplicate();
							outParamList.AllOptimizedAttributes = opt;
							_tmp.CloseDataReader();
							return outParamList;
						} finally {
							_tmp.CloseDataReader();
						}
					} else {
						try {
							DatabaseAccess.ForCurrentDatabase.ExecuteQuery(sqlCmd, outParamList, "Query Student.GetFormatedName.GetStudentByStudentReference.List");
							outParamList.MaxRecords = maxRecords;
							return outParamList;
						} finally {
							if (maxRecords == 1) {
								outParamList.CloseDataReader();
							}
						}
					}
				}
			}


		}


	}


}