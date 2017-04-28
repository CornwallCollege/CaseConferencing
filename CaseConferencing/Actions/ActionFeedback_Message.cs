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
		/// <summary>
		/// Action <code>ActionFeedback_Message</code> that represents the Service Studio reference action
		///  <code>Feedback_Message</code> <p> Description: Sets the message to be displayed on th
		/// e Feedback_Message widget.</p>
		/// </summary>
		public static void ActionFeedback_Message(HeContext heContext, string inParamMessageText, int inParamMessageType) {
			RsseSpaceRichWidgets.MssFeedback_Message(heContext, inParamMessageText, inParamMessageType);
		}

	}


}