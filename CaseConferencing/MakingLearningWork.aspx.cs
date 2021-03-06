﻿/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.Internal.Db;
using OutSystems.HubEdition.RuntimePlatform.Web;
using OutSystems.ObjectKeys;
using System.Configuration;


namespace ssCaseConferencing.Flows.FlowMainFlow2 {
	public class EntryMakingLearningWork: System.Web.UI.Page {
		HeContext heContext;
		override protected void OnInit(EventArgs e) {
			InitializeComponent();
			base.OnInit(e);
		}
		private void InitializeComponent() {
			this.Load += new System.EventHandler(this.Page_Load);
			this.Unload += new System.EventHandler(this.Page_Unload);
		}
		private void Page_Load(object sender, System.EventArgs e) {
			heContext = Global.App.OsContext;
			heContext.Session["_ScreenParametersKey"] = "WKSQ_Cis+0SQKUbKih54NA";
			ArrayList screenParameters = new ArrayList();
			heContext.Session["CaseConferencing._ScreenParameters_HomePage"] = screenParameters;
			heContext.Session.EntryPoint = Request.Url.ToString();
			if (RuntimePlatformUtils.RequestIsSecure(Request)) {
				Server.Transfer("HomePage.aspx" + Request.Url.Query);
				return;

			} else {
				Response.BufferOutput = true;
				Response.Redirect("https" + "://" + Request.Url.Host + "" + AppUtils.Instance.getImagePath() + "HomePage.aspx" + Request.Url.Query);
				return;

			}
		}
		private void Page_Unload(object sender, System.EventArgs e) {
		}
		public ObjectKey Key {
			get {
				return ObjectKey.Parse("r38iazVVBUGBUITB5A0ezg"); 
			}
		}
		public bool IsSecure {
			get {
				return false; 
			}
		}


		protected static string GetString(string key, string defaultValue) {
			return Global.GetStringResource(key, defaultValue);
		}

	}
}
