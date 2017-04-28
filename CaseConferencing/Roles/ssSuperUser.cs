﻿/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

using System;
using System.Threading;
using System.Collections;
using System.Data;
using System.Web;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.Internal.Db;
using OutSystems.HubEdition.RuntimePlatform.Log;

namespace ssCaseConferencing {
	public partial class Roles {

		private static int? __ssSuperUser = null;
		public static int ssSuperUser {
			get {
				if (__ssSuperUser == null) {
					using(Transaction trans = DatabaseAccess.ForSystemDatabase.GetRequestTransaction()) {
						__ssSuperUser = DBRuntimePlatform.Instance.GetRoleId(trans, "18b6662d-6c9c-4e0d-a491-d11e6647f704", "19da6e54-4d22-4e6c-8d53-377953028e58");
					}
				}
				if (__ssSuperUser == null) {
					throw new Exception("Unable to find 'SuperUser' Role in meta-model");
				}
				return (int) __ssSuperUser;
			}
		}
	}
}