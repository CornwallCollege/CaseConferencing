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
		public class lcvGetLastWeekStartDate: VarsBag {
			/// <summary>
			/// Variable <code>varLcDaysToGoBack</code> that represents the Service Studio local variable
			///  <code>DaysToGoBack</code> <p>Description: </p>
			/// </summary>
			public int varLcDaysToGoBack = 0;

			public lcvGetLastWeekStartDate() {
			}
		}
		public class lcoGetLastWeekStartDate: VarsBag {
			public DateTime outParamLastWeekStartDate = new DateTime(1900, 1, 1, 0, 0, 0);

			public lcoGetLastWeekStartDate() {
			}
		}
		/// <summary>
		/// Action <code>ActionGetLastWeekStartDate</code> that represents the Service Studio user action
		///  <code>GetLastWeekStartDate</code> <p> Description: </p>
		/// </summary>
		public static void ActionGetLastWeekStartDate(HeContext heContext, out DateTime outParamLastWeekStartDate) {
			lcoGetLastWeekStartDate result = new lcoGetLastWeekStartDate();
			lcvGetLastWeekStartDate localVars = new lcvGetLastWeekStartDate();
			try {
				localVars.varLcDaysToGoBack = (BuiltInFunction.DayOfWeek(BuiltInFunction.CurrDate()) +6); // DaysToGoBack = DayOfWeek + 6
			} // try

			finally {
				outParamLastWeekStartDate = result.outParamLastWeekStartDate;
			}
		}

		public static class FuncActionGetLastWeekStartDate {


		}


	}


}