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
		public class lcvCalculcateAttendanceFigures: VarsBag {
			public RLStudentAttendanceTotalsList inParamStudentAttendanceTotals;
			public lcvCalculcateAttendanceFigures(RLStudentAttendanceTotalsList inParamStudentAttendanceTotals) {
				this.inParamStudentAttendanceTotals = inParamStudentAttendanceTotals;
			}
		}
		public class lcoCalculcateAttendanceFigures: VarsBag {
			public int outParamMyLearnersGreenAttendanceCount = 0;

			public int outParamMyLearnersAmberAttendanceCount = 0;

			public int outParamMyLearnersRedAttendanceCount = 0;

			public int outParamMyFavouritesGreenAttendanceCount = 0;

			public int outParamMyFavouritesAmberAttendanceCount = 0;

			public int outParamMyFavouritesRedAttendanceCount = 0;

			public lcoCalculcateAttendanceFigures() {
			}
		}
		/// <summary>
		/// Action <code>ActionCalculcateAttendanceFigures</code> that represents the Service Studio user
		///  action <code>CalculcateAttendanceFigures</code> <p> Description: </p>
		/// </summary>
		public static void ActionCalculcateAttendanceFigures(HeContext heContext, RLStudentAttendanceTotalsList inParamStudentAttendanceTotals, out int outParamMyLearnersGreenAttendanceCount, out int outParamMyLearnersAmberAttendanceCount, out int outParamMyLearnersRedAttendanceCount, out int outParamMyFavouritesGreenAttendanceCount, out int outParamMyFavouritesAmberAttendanceCount, out int outParamMyFavouritesRedAttendanceCount) {
			lcoCalculcateAttendanceFigures result = new lcoCalculcateAttendanceFigures();
			lcvCalculcateAttendanceFigures localVars = new lcvCalculcateAttendanceFigures(inParamStudentAttendanceTotals);
			try {
				// Foreach StudentAttendanceTotals
				localVars.inParamStudentAttendanceTotals.StartIteration();
				try {
					while (! localVars.inParamStudentAttendanceTotals.Eof) {
						if ((localVars.inParamStudentAttendanceTotals.CurrentRec.ssAttendancePercentage>=90)) {
							if ((localVars.inParamStudentAttendanceTotals.CurrentRec.ssListType== "MyLearners")) {
								result.outParamMyLearnersGreenAttendanceCount = (result.outParamMyLearnersGreenAttendanceCount+1); // MyLearnersGreenAttendanceCount = MyLearnersGreenAttendanceCount + 1

							} else {
								result.outParamMyFavouritesGreenAttendanceCount = (result.outParamMyFavouritesGreenAttendanceCount+1); // MyFavouritesGreenAttendanceCount = MyFavouritesGreenAttendanceCount + 1

							}

						} else {
							if (((localVars.inParamStudentAttendanceTotals.CurrentRec.ssAttendancePercentage<90) && (localVars.inParamStudentAttendanceTotals.CurrentRec.ssAttendancePercentage>=80))) {
								if ((localVars.inParamStudentAttendanceTotals.CurrentRec.ssListType== "MyLearners")) {
									result.outParamMyLearnersAmberAttendanceCount = (result.outParamMyLearnersAmberAttendanceCount+1); // MyLearnersAmberAttendanceCount = MyLearnersAmberAttendanceCount + 1

								} else {
									result.outParamMyFavouritesAmberAttendanceCount = (result.outParamMyFavouritesAmberAttendanceCount+1); // MyFavouritesAmberAttendanceCount = MyFavouritesAmberAttendanceCount + 1

								}

							} else {
								if ((localVars.inParamStudentAttendanceTotals.CurrentRec.ssAttendancePercentage<80)) {
									if ((localVars.inParamStudentAttendanceTotals.CurrentRec.ssListType== "MyLearners")) {
										result.outParamMyLearnersRedAttendanceCount = (result.outParamMyLearnersRedAttendanceCount+1); // MyLearnersRedAttendanceCount = MyLearnersRedAttendanceCount + 1

									} else {
										result.outParamMyFavouritesRedAttendanceCount = (result.outParamMyFavouritesRedAttendanceCount+1); // MyFavouritesRedAttendanceCount = MyFavouritesRedAttendanceCount + 1

									}

								}

							}

						}
						localVars.inParamStudentAttendanceTotals.Advance();
					}
				} finally {
					localVars.inParamStudentAttendanceTotals.EndIteration();
				}
			} // try

			finally {
				outParamMyLearnersGreenAttendanceCount = result.outParamMyLearnersGreenAttendanceCount;
				outParamMyLearnersAmberAttendanceCount = result.outParamMyLearnersAmberAttendanceCount;
				outParamMyLearnersRedAttendanceCount = result.outParamMyLearnersRedAttendanceCount;
				outParamMyFavouritesGreenAttendanceCount = result.outParamMyFavouritesGreenAttendanceCount;
				outParamMyFavouritesAmberAttendanceCount = result.outParamMyFavouritesAmberAttendanceCount;
				outParamMyFavouritesRedAttendanceCount = result.outParamMyFavouritesRedAttendanceCount;
			}
		}

		public static class FuncActionCalculcateAttendanceFigures {


		}


	}


}