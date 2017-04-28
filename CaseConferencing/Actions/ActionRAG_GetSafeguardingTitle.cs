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
		public class lcvRAG_GetSafeguardingTitle: VarsBag {
			public string inParamStudent;
			public RLSafeguardingIssueSafeguardingIssueTypeRecordList queryResGetSafeguardingIssuesByStudentReference_outParamList = new RLSafeguardingIssueSafeguardingIssueTypeRecordList();
			public int queryResGetSafeguardingIssuesByStudentReference_outParamCount = 0;

			public lcvRAG_GetSafeguardingTitle(string inParamStudent) {
				this.inParamStudent = inParamStudent;
			}
		}
		public class lcoRAG_GetSafeguardingTitle: VarsBag {
			public RCTextRecord outParamText = new RCTextRecord(null);

			public lcoRAG_GetSafeguardingTitle() {
			}
		}
		/// <summary>
		/// Action <code>ActionRAG_GetSafeguardingTitle</code> that represents the Service Studio user action
		///  <code>RAG_GetSafeguardingTitle</code> <p> Description: </p>
		/// </summary>
		public static void ActionRAG_GetSafeguardingTitle(HeContext heContext, string inParamStudent, out RCTextRecord outParamText) {
			lcoRAG_GetSafeguardingTitle result = new lcoRAG_GetSafeguardingTitle();
			lcvRAG_GetSafeguardingTitle localVars = new lcvRAG_GetSafeguardingTitle(inParamStudent);
			try {
				// Query datasetGetSafeguardingIssuesByStudentReference
				int datasetGetSafeguardingIssuesByStudentReference_maxRecords = 0;
				localVars.queryResGetSafeguardingIssuesByStudentReference_outParamList = FuncActionRAG_GetSafeguardingTitle.datasetGetSafeguardingIssuesByStudentReference(heContext, datasetGetSafeguardingIssuesByStudentReference_maxRecords, IterationMultiplicity.Single, out localVars.queryResGetSafeguardingIssuesByStudentReference_outParamCount, localVars.inParamStudent
				);
				// Foreach GetSafeguardingIssuesByStudentReference.List
				localVars.queryResGetSafeguardingIssuesByStudentReference_outParamList.StartIteration();
				try {
					while (! localVars.queryResGetSafeguardingIssuesByStudentReference_outParamList.Eof) {
						result.outParamText.ssSTText.ssValue = ((result.outParamText.ssSTText.ssValue+localVars.queryResGetSafeguardingIssuesByStudentReference_outParamList.CurrentRec.ssENSafeguardingIssueType.ssLabel) + "\r\n"); // Text.Text.Value = Text.Text.Value +
						// GetSafeguardingIssuesByStudentReference.List.Current.SafeguardingIssueType.Label + NewLine
						localVars.queryResGetSafeguardingIssuesByStudentReference_outParamList.Advance();
					}
				} finally {
					localVars.queryResGetSafeguardingIssuesByStudentReference_outParamList.EndIteration();
				}
			} // try

			finally {
				outParamText = result.outParamText;
			}
		}

		public static class FuncActionRAG_GetSafeguardingTitle {

			private static void datasetGetSafeguardingIssuesByStudentReferenceReadDB(ref RCSafeguardingIssueSafeguardingIssueTypeRecord rec, IDataReader r) {
				int index = 0;
				rec.ssENSafeguardingIssue.Read(r, ref index);
				rec.ssENSafeguardingIssueType.Read(r, ref index);
			}
			/// <summary>
			/// Query Function "GetSafeguardingIssuesByStudentReference" of Action "RAG_GetSafeguardingTitle"
			/// </summary>
			public static RLSafeguardingIssueSafeguardingIssueTypeRecordList datasetGetSafeguardingIssuesByStudentReference(HeContext heContext, int maxRecords, IterationMultiplicity multiplicity, out int outParamCount, string qpstP) {
				// Query Iterations: Single {-unbound-}
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
				selectBuilder.Append("NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, ENSafeguardingIssueType.[LABEL] o20, NULL o21, NULL o22");
				fromBuilder.Append(" FROM ({SafeguardingIssueType} ENSafeguardingIssueType Inner JOIN {SafeguardingIssue} ENSafeguardingIssue ON (ENSafeguardingIssue.[SAFEGUARDINGISSUETYPE] = ENSafeguardingIssueType.[ID])) ");
				whereBuilder.Append(" WHERE ");
				if (qpstP.Trim() != "") {
					whereBuilder.Append("((ENSafeguardingIssue.[STUDENTREFERENCE] = @qpstP) AND (ENSafeguardingIssue.[STUDENTREFERENCE] IS NOT NULL))");
					sqlCmd.CreateParameterWithoutReplacements("@qpstP", DbType.String, qpstP);
				} else {
					whereBuilder.Append("(ENSafeguardingIssue.[STUDENTREFERENCE] IS NULL)");
				}

				sql = selectBuilder.ToString() + fromBuilder.ToString() + whereBuilder.ToString() + groupByBuilder.ToString() + havingBuilder.ToString() + orderByBuilder.ToString();
				string advSql = sql;
				sql = AppUtils.Instance.ReplaceEntityReferences(heContext, advSql);
				sqlCmd.CommandText = sql;
				RLSafeguardingIssueSafeguardingIssueTypeRecordList outParamList = new RLSafeguardingIssueSafeguardingIssueTypeRecordList();
				if (multiplicity != IterationMultiplicity.Multiple) {
					outParamList.AlternateReadDBMethod = datasetGetSafeguardingIssuesByStudentReferenceReadDB;
				}
				outParamList.Transaction = trans;
				BitArray[] opt = new BitArray[2];
				opt[0] = new BitArray(new bool[] {
					true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true
				}
				);
				opt[1] = new BitArray(new bool[] {
					true, false, true, true
				}
				);
				outParamList.AllOptimizedAttributes = opt;
				if (multiplicity == IterationMultiplicity.Multiple) {
					RLSafeguardingIssueSafeguardingIssueTypeRecordList _tmp = new RLSafeguardingIssueSafeguardingIssueTypeRecordList();
					_tmp.AlternateReadDBMethod = datasetGetSafeguardingIssuesByStudentReferenceReadDB;
					_tmp.Transaction = trans;
					_tmp.AllOptimizedAttributes = opt;
					_tmp.MaxRecords = maxRecords;
					try {
						DatabaseAccess.ForCurrentDatabase.ExecuteQuery(sqlCmd, _tmp, "Query RAG_GetSafeguardingTitle.GetSafeguardingIssuesByStudentReference.List");
						outParamList = (RLSafeguardingIssueSafeguardingIssueTypeRecordList) _tmp.Duplicate();
						_tmp.CloseDataReader();
						return outParamList;
					} finally {
						_tmp.CloseDataReader();
					}
				} else if (multiplicity == IterationMultiplicity.Never) {
					try {
						DatabaseAccess.ForCurrentDatabase.ExecuteQuery(sqlCmd, outParamList, "Query RAG_GetSafeguardingTitle.GetSafeguardingIssuesByStudentReference.List");
						outParamList.MaxRecords = maxRecords;
						return outParamList;
					} finally {
						outParamList.CloseDataReader();
					}
				} else {
					if (maxRecords > 0 && maxRecords <= 150) {
						RLSafeguardingIssueSafeguardingIssueTypeRecordList _tmp = new RLSafeguardingIssueSafeguardingIssueTypeRecordList();
						_tmp.AlternateReadDBMethod = datasetGetSafeguardingIssuesByStudentReferenceReadDB;
						_tmp.Transaction = trans;
						_tmp.AllOptimizedAttributes = opt;
						try {
							DatabaseAccess.ForCurrentDatabase.ExecuteQuery(sqlCmd, _tmp, "Query RAG_GetSafeguardingTitle.GetSafeguardingIssuesByStudentReference.List");
							outParamList = (RLSafeguardingIssueSafeguardingIssueTypeRecordList) _tmp.Duplicate();
							outParamList.AllOptimizedAttributes = opt;
							_tmp.CloseDataReader();
							return outParamList;
						} finally {
							_tmp.CloseDataReader();
						}
					} else {
						try {
							DatabaseAccess.ForCurrentDatabase.ExecuteQuery(sqlCmd, outParamList, "Query RAG_GetSafeguardingTitle.GetSafeguardingIssuesByStudentReference.List");
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