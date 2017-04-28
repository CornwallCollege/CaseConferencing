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
		public class lcvGetStudentEnrolmentStatus: VarsBag {
			public string inParamStudentReference;
			public RLStudent_GroupRecordList inParamStudentEnrolments;
			public lcvGetStudentEnrolmentStatus(string inParamStudentReference, RLStudent_GroupRecordList inParamStudentEnrolments) {
				this.inParamStudentReference = inParamStudentReference;
				this.inParamStudentEnrolments = inParamStudentEnrolments;
			}
		}
		public class lcoGetStudentEnrolmentStatus: VarsBag {
			public string outParamEnrolmentStatus = "";

			public lcoGetStudentEnrolmentStatus() {
			}
		}
		/// <summary>
		/// Action <code>ActionGetStudentEnrolmentStatus</code> that represents the Service Studio user action
		///  <code>GetStudentEnrolmentStatus</code> <p> Description: </p>
		/// </summary>
		public static void ActionGetStudentEnrolmentStatus(HeContext heContext, string inParamStudentReference, RLStudent_GroupRecordList inParamStudentEnrolments, out string outParamEnrolmentStatus) {
			lcoGetStudentEnrolmentStatus result = new lcoGetStudentEnrolmentStatus();
			lcvGetStudentEnrolmentStatus localVars = new lcvGetStudentEnrolmentStatus(inParamStudentReference, inParamStudentEnrolments);
			try {
				// Foreach StudentEnrolments
				localVars.inParamStudentEnrolments.StartIteration();
				try {
					while (! localVars.inParamStudentEnrolments.Eof) {
						if ((localVars.inParamStudentReference==localVars.inParamStudentEnrolments.CurrentRec.ssENStudent_Group.ssStudentReference)) {
							result.outParamEnrolmentStatus = localVars.inParamStudentEnrolments.CurrentRec.ssENStudent_Group.ssEnrolmentStatus; // EnrolmentStatus = StudentEnrolments.Current.Student_Group.EnrolmentStatus
							return;

						}
						localVars.inParamStudentEnrolments.Advance();
					}
				} finally {
					localVars.inParamStudentEnrolments.EndIteration();
				}
			} // try

			finally {
				outParamEnrolmentStatus = result.outParamEnrolmentStatus;
			}
		}

		public static class FuncActionGetStudentEnrolmentStatus {


		}


	}


}