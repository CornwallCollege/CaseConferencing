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
		public class lcvStudent_ChangeRAG: VarsBag {
			public string inParamStudentReference;
			public string inParamRAGStatusId;
			public string inParamDescription;
			public string resCreateOrUpdateStudentRAG_outParamId = "";

			public RLStudentRAGRecordList queryResGetStudentRAGByStudentReference_outParamList = new RLStudentRAGRecordList();
			public int queryResGetStudentRAGByStudentReference_outParamCount = 0;

			public lcvStudent_ChangeRAG(string inParamStudentReference, string inParamRAGStatusId, string inParamDescription) {
				this.inParamStudentReference = inParamStudentReference;
				this.inParamRAGStatusId = inParamRAGStatusId;
				this.inParamDescription = inParamDescription;
			}
		}
		/// <summary>
		/// Action <code>ActionStudent_ChangeRAG</code> that represents the Service Studio user action
		///  <code>Student_ChangeRAG</code> <p> Description: </p>
		/// </summary>
		public static void ActionStudent_ChangeRAG(HeContext heContext, string inParamStudentReference, string inParamRAGStatusId, string inParamDescription) {
			lcvStudent_ChangeRAG localVars = new lcvStudent_ChangeRAG(inParamStudentReference, inParamRAGStatusId, inParamDescription);
			// Query datasetGetStudentRAGByStudentReference
			int datasetGetStudentRAGByStudentReference_maxRecords = 0;
			localVars.queryResGetStudentRAGByStudentReference_outParamList = FuncActionStudent_ChangeRAG.datasetGetStudentRAGByStudentReference(heContext, datasetGetStudentRAGByStudentReference_maxRecords, IterationMultiplicity.Never, out localVars.queryResGetStudentRAGByStudentReference_outParamCount, localVars.inParamStudentReference
			);
			localVars.queryResGetStudentRAGByStudentReference_outParamList.CurrentRec.ssENStudentRAG.ssStudentReference = localVars.inParamStudentReference; // GetStudentRAGByStudentReference.List.Current.StudentRAG.StudentReference = StudentReference
			localVars.queryResGetStudentRAGByStudentReference_outParamList.CurrentRec.ssENStudentRAG.ssRAG = localVars.inParamRAGStatusId; // GetStudentRAGByStudentReference.List.Current.StudentRAG.RAG = RAGStatusId
			localVars.queryResGetStudentRAGByStudentReference_outParamList.CurrentRec.ssENStudentRAG.ssUpdatedBy = ((int) Global.App.OsContext.Session["UserID"]); // GetStudentRAGByStudentReference.List.Current.StudentRAG.UpdatedBy = UserID
			localVars.queryResGetStudentRAGByStudentReference_outParamList.CurrentRec.ssENStudentRAG.ssUpdatedAt = BuiltInFunction.CurrDateTime(); // GetStudentRAGByStudentReference.List.Current.StudentRAG.UpdatedAt = CurrDateTime
			localVars.queryResGetStudentRAGByStudentReference_outParamList.CurrentRec.ssENStudentRAG.ssDescription = localVars.inParamDescription; // GetStudentRAGByStudentReference.List.Current.StudentRAG.Description = Description
			// CreateOrUpdateStudentRAG
			ExtendedActions.CreateOrUpdateStudentRAG(heContext, localVars.queryResGetStudentRAGByStudentReference_outParamList.CurrentRec.ChangedAttributes, localVars.queryResGetStudentRAGByStudentReference_outParamList.CurrentRec, out localVars.resCreateOrUpdateStudentRAG_outParamId);
		}

		public static class FuncActionStudent_ChangeRAG {

			/// <summary>
			/// Query Function "GetStudentRAGByStudentReference" of Action "Student_ChangeRAG"
			/// </summary>
			public static RLStudentRAGRecordList datasetGetStudentRAGByStudentReference(HeContext heContext, int maxRecords, IterationMultiplicity multiplicity, out int outParamCount, string qpstP) {
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
				selectBuilder.Append("ENStudentRAG.[STUDENTREFERENCE] o1, ENStudentRAG.[RAG] o2, ENStudentRAG.[DESCRIPTION] o3, ENStudentRAG.[UPDATEDBY] o4, ENStudentRAG.[UPDATEDAT] o5");
				fromBuilder.Append(" FROM {StudentRAG} ENStudentRAG");
				whereBuilder.Append(" WHERE ");
				if (qpstP.Trim() != "") {
					whereBuilder.Append("((ENStudentRAG.[STUDENTREFERENCE] = @qpstP) AND (ENStudentRAG.[STUDENTREFERENCE] IS NOT NULL))");
					sqlCmd.CreateParameterWithoutReplacements("@qpstP", DbType.String, qpstP);
				} else {
					whereBuilder.Append("(ENStudentRAG.[STUDENTREFERENCE] IS NULL)");
				}

				sql = selectBuilder.ToString() + fromBuilder.ToString() + whereBuilder.ToString() + groupByBuilder.ToString() + havingBuilder.ToString() + orderByBuilder.ToString();
				string advSql = sql;
				sql = AppUtils.Instance.ReplaceEntityReferences(heContext, advSql);
				sqlCmd.CommandText = sql;
				RLStudentRAGRecordList outParamList = new RLStudentRAGRecordList();
				outParamList.Transaction = trans;
				BitArray[] opt = new BitArray[1];
				opt[0] = new BitArray(new bool[] {
					false, false, false, false, false
				}
				);
				outParamList.AllOptimizedAttributes = opt;
				if (multiplicity == IterationMultiplicity.Multiple) {
					RLStudentRAGRecordList _tmp = new RLStudentRAGRecordList();
					_tmp.Transaction = trans;
					_tmp.AllOptimizedAttributes = opt;
					_tmp.MaxRecords = maxRecords;
					try {
						DatabaseAccess.ForCurrentDatabase.ExecuteQuery(sqlCmd, _tmp, "Query Student_ChangeRAG.GetStudentRAGByStudentReference.List");
						outParamList = (RLStudentRAGRecordList) _tmp.Duplicate();
						_tmp.CloseDataReader();
						return outParamList;
					} finally {
						_tmp.CloseDataReader();
					}
				} else if (multiplicity == IterationMultiplicity.Never) {
					try {
						DatabaseAccess.ForCurrentDatabase.ExecuteQuery(sqlCmd, outParamList, "Query Student_ChangeRAG.GetStudentRAGByStudentReference.List");
						outParamList.MaxRecords = maxRecords;
						return outParamList;
					} finally {
						outParamList.CloseDataReader();
					}
				} else {
					if (maxRecords > 0 && maxRecords <= 150) {
						RLStudentRAGRecordList _tmp = new RLStudentRAGRecordList();
						_tmp.Transaction = trans;
						_tmp.AllOptimizedAttributes = opt;
						try {
							DatabaseAccess.ForCurrentDatabase.ExecuteQuery(sqlCmd, _tmp, "Query Student_ChangeRAG.GetStudentRAGByStudentReference.List");
							outParamList = (RLStudentRAGRecordList) _tmp.Duplicate();
							outParamList.AllOptimizedAttributes = opt;
							_tmp.CloseDataReader();
							return outParamList;
						} finally {
							_tmp.CloseDataReader();
						}
					} else {
						try {
							DatabaseAccess.ForCurrentDatabase.ExecuteQuery(sqlCmd, outParamList, "Query Student_ChangeRAG.GetStudentRAGByStudentReference.List");
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