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
		public class lcvGetMonthName: VarsBag {
			public int inParamMonth;
			public lcvGetMonthName(int inParamMonth) {
				this.inParamMonth = inParamMonth;
			}
		}
		public class lcoGetMonthName: VarsBag {
			public string outParamMonthName = "";

			public lcoGetMonthName() {
			}
		}
		/// <summary>
		/// Action <code>ActionGetMonthName</code> that represents the Service Studio user action
		///  <code>GetMonthName</code> <p> Description: </p>
		/// </summary>
		public static void ActionGetMonthName(HeContext heContext, int inParamMonth, out string outParamMonthName) {
			lcoGetMonthName result = new lcoGetMonthName();
			lcvGetMonthName localVars = new lcvGetMonthName(inParamMonth);
			try {
				if ((localVars.inParamMonth==1)) {
					result.outParamMonthName = "January"; // MonthName = "January"

				} else {
					if ((localVars.inParamMonth==2)) {
						result.outParamMonthName = "Febuary"; // MonthName = "Febuary"

					} else {
						if ((localVars.inParamMonth==3)) {
							result.outParamMonthName = "March"; // MonthName = "March"

						} else {
							if ((localVars.inParamMonth==4)) {
								result.outParamMonthName = "April"; // MonthName = "April"

							} else {
								if ((localVars.inParamMonth==5)) {
									result.outParamMonthName = "May"; // MonthName = "May"

								} else {
									if ((localVars.inParamMonth==6)) {
										result.outParamMonthName = "June"; // MonthName = "June"

									} else {
										if ((localVars.inParamMonth==7)) {
											result.outParamMonthName = "July"; // MonthName = "July"

										} else {
											if ((localVars.inParamMonth==8)) {
												result.outParamMonthName = "August"; // MonthName = "August"

											} else {
												if ((localVars.inParamMonth==9)) {
													result.outParamMonthName = "September"; // MonthName = "September"

												} else {
													if ((localVars.inParamMonth==10)) {
														result.outParamMonthName = "October"; // MonthName = "October"

													} else {
														if ((localVars.inParamMonth==11)) {
															result.outParamMonthName = "November"; // MonthName = "November"

														} else {
															if ((localVars.inParamMonth==12)) {
																result.outParamMonthName = "December"; // MonthName = "December"

															}

														}

													}

												}

											}

										}

									}

								}

							}

						}

					}

				}
			} // try

			finally {
				outParamMonthName = result.outParamMonthName;
			}
		}

		public static class FuncActionGetMonthName {


		}


	}


}