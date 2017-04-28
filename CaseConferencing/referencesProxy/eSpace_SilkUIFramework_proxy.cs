﻿/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

// Proxy for reference eSpace with name SilkUIFramework and key TTIHTU58MEW9P46Q9i6whQ
using System;
using System.Data;
using System.Reflection;
using System.Collections;
using System.Runtime.Serialization;
using OutSystems.ObjectKeys;
using OutSystems.RuntimeCommon;
using OutSystems.HubEdition.RuntimePlatform;
using System.Collections.Generic;
using System.Xml;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.Internal.Db;
using OutSystems.HubEdition.RuntimePlatform.Log;
using System.Web.UI;
using OutSystems.HubEdition.WebWidgets;
using OutSystems.HubEdition.RuntimePlatform.Web;
using ssCaseConferencing;
namespace ssCaseConferencing {
	/// <summary>
	/// Class: RsseSpaceSilkUIFramework
	/// </summary>
	public class RsseSpaceSilkUIFramework {
		protected static int _maxExtensionLogsPerRequest = OutSystems.HubEdition.RuntimePlatform.Settings.GetInt(OutSystems.HubEdition.RuntimePlatform.Settings.Configs.Log_MaxLogsPerRequest_Extension);
		public static void MssOnSessionStart(HeContext heContext) {
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ssSilkUIFramework.Global.eSpaceId;
				if (RuntimePlatformUtils.TestAndSetProducerSession("SilkUIFramework")) {
					ssSilkUIFramework.Actions.ActionOnSessionStart(heContext);
				}
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}


		public sealed partial class ENSizesEntity {
			public static string ViewName(int? tenant, string locale) {
				return ssSilkUIFramework.ENSizesEntity.ViewName(tenant, locale);
			}
			public const int eSpaceId = ssSilkUIFramework.Global.eSpaceId;
		} // ENSizesEntity
		partial class ENSizesEntity {


			public static IRecord GetRecordById(string id) {
				IRecord rec = Factory.FactoryENSizesEntityRecordSingleton.CreateENSizesEntityRecord();
				rec.FillFromOther(ssSilkUIFramework.ENSizesEntity.GetRecordById(id));
				return rec;
			}

			public static IRecord GetRecordByName(string name) {
				IRecord rec = Factory.FactoryENSizesEntityRecordSingleton.CreateENSizesEntityRecord();
				rec.FillFromOther(ssSilkUIFramework.ENSizesEntity.GetRecordByName(name));
				return rec;
			}

			public static IRecord GetRecordByKey(ObjectKey key) {
				IRecord rec = Factory.FactoryENSizesEntityRecordSingleton.CreateENSizesEntityRecord();
				rec.FillFromOther(ssSilkUIFramework.ENSizesEntity.GetRecordByKey(key));
				return rec;
			}
		} // ENSizesEntity;


		public interface IENSizesEntityRecordTypeFactory {
			IRecord CreateENSizesEntityRecord();
		}

		public class Factory {
			public static IENSizesEntityRecordTypeFactory FactoryENSizesEntityRecordSingleton;
		}
		public class DefaultValues {
		}
	}
}
namespace proxy_CaseConferencing_SilkUIFramework.Flows.FlowDevelopment {
	public class WBlkJS: OSUserControl, INegotiateTabIndexes, IWebScreen
	{
		protected ssSilkUIFramework.Flows.FlowDevelopment.WBlkJS block;
		public Container wtDescription {
			get {
				return block.wtDescription; 
			}
		}
		public System.Web.UI.ITemplate phDescription {
			get; set; 
		}
		protected override void OnInit(EventArgs e) {
			base.OnInit(e);
			block.phDescription = phDescription;
			block.phDescription.InstantiateIn(block.wtDescription);
		}
		static WBlkJS() {
			HeContext heContext = AppInfo.GetAppInfo().OsContext;
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ssSilkUIFramework.Global.eSpaceId;
				ssCaseConferencing.RsseSpaceSilkUIFramework.MssOnSessionStart(AppInfo.GetAppInfo().OsContext);
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}


		// override OSUserControl IsProxy()
		public override bool IsProxy() {
			return true;
		}

		// proxy implementation for WebScreen interface methods

		public override event EventHandler EvaluateParameters;

		public override string ClientID {
			get {
				return block.ClientID;
			}
		}

		public LocalState PushStack() {
			return block.PushStack();
		}

		public void doRefreshScreen(HeContext context) {
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = 39;
				block.doRefreshScreen(context);
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}

		public void doAJAXRefreshScreen(HeContext context) {
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = 39;
				block.doAJAXRefreshScreen(context);
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}

		public void OnSubmit(String parentEditRecord, bool validate) {
			block.OnSubmit(parentEditRecord, validate);
		}

		public void CheckPermissions(HeContext context) {
			block.CheckPermissions(context);
		}

		public ObjectKey Key {
			get {
				return block.Key;
			}
		}
		public bool isSecure {
			get {
				return block.isSecure;
			}
		}

		public string InstanceID {
			get {
				return block.InstanceID;
			}
			set {
				block.InstanceID = value;
			}
		}

		public HeContext heContext {
			get {
				return block.heContext;
			}
			set {
				block.heContext = value;
			}
		}

		// proxy implementation INegociateTabs interface method

		public short NegotiateTabIndexes(short tabindex, bool setTabIndex) {
			return block.NegotiateTabIndexes(tabindex, setTabIndex);
		}

		public short NegotiateTabIndexesRecursively(short tabindex, System.Web.UI.Control rootControl, bool setTabIndex) {
			return block.NegotiateTabIndexesRecursively(tabindex, rootControl, setTabIndex);
		}

		public override void DataBind() {
			HandleBreakpoint();
			if (EvaluateParameters != null) {
				EvaluateParameters(this, null);
			}
			block.DataBind();
		}

		public override bool IncludeSpan {
			get {
				return block.IncludeSpan; 
			}
			set {
				block.IncludeSpan = value; 
			}
		}

		public void BindProxyDelegates(object sender, BindDelegatesEventArgs e) {
			BindDelegatesIfNeeded();
			ssSilkUIFramework.Flows.FlowDevelopment.WBlkJS webBlock = (ssSilkUIFramework.Flows.FlowDevelopment.WBlkJS) e.UserControl;

		}

		public override string ParentEditRecord {
			get {
				return block.ParentEditRecord;
			}
			set {
				block.ParentEditRecord = value;
			}
		}

		public static void GetCss(System.IO.TextWriter writer, bool inline, HashSet<string> visited) {
			ssSilkUIFramework.Flows.FlowDevelopment.WBlkJS.GetCss(writer, inline, visited);
		}

		public override string GridCssClasses {
			get {
				return block.GridCssClasses;
			}
			set {
				block.GridCssClasses = value;
			}
		}

		public override string Style {
			get {
				return block.Style;
			}
			set {
				block.Style = value;
			}
		}

		public override string WebBlockIdentifier {
			get {
				return "Proxy." + block.WebBlockIdentifier;
			}
		}

		/// <summary>
		/// Delegate Definitions
		/// </summary>

		// web block public declarations

		// block input variable Javascript
		public string inParamJavascript {
			get {
				return block.inParamJavascript;
			}
			set {
				block.inParamJavascript = value;
			}
		}

	}

}
namespace proxy_CaseConferencing_SilkUIFramework.Flows.FlowDevelopment {
	public class WBlkjQuery: OSUserControl, INegotiateTabIndexes, IWebScreen
	{
		protected ssSilkUIFramework.Flows.FlowDevelopment.WBlkjQuery block;
		public Container wtDescription {
			get {
				return block.wtDescription; 
			}
		}
		public System.Web.UI.ITemplate phDescription {
			get; set; 
		}
		protected override void OnInit(EventArgs e) {
			base.OnInit(e);
			block.phDescription = phDescription;
			block.phDescription.InstantiateIn(block.wtDescription);
		}
		static WBlkjQuery() {
			HeContext heContext = AppInfo.GetAppInfo().OsContext;
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ssSilkUIFramework.Global.eSpaceId;
				ssCaseConferencing.RsseSpaceSilkUIFramework.MssOnSessionStart(AppInfo.GetAppInfo().OsContext);
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}


		// override OSUserControl IsProxy()
		public override bool IsProxy() {
			return true;
		}

		// proxy implementation for WebScreen interface methods

		public override event EventHandler EvaluateParameters;

		public override string ClientID {
			get {
				return block.ClientID;
			}
		}

		public LocalState PushStack() {
			return block.PushStack();
		}

		public void doRefreshScreen(HeContext context) {
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = 39;
				block.doRefreshScreen(context);
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}

		public void doAJAXRefreshScreen(HeContext context) {
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = 39;
				block.doAJAXRefreshScreen(context);
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}

		public void OnSubmit(String parentEditRecord, bool validate) {
			block.OnSubmit(parentEditRecord, validate);
		}

		public void CheckPermissions(HeContext context) {
			block.CheckPermissions(context);
		}

		public ObjectKey Key {
			get {
				return block.Key;
			}
		}
		public bool isSecure {
			get {
				return block.isSecure;
			}
		}

		public string InstanceID {
			get {
				return block.InstanceID;
			}
			set {
				block.InstanceID = value;
			}
		}

		public HeContext heContext {
			get {
				return block.heContext;
			}
			set {
				block.heContext = value;
			}
		}

		// proxy implementation INegociateTabs interface method

		public short NegotiateTabIndexes(short tabindex, bool setTabIndex) {
			return block.NegotiateTabIndexes(tabindex, setTabIndex);
		}

		public short NegotiateTabIndexesRecursively(short tabindex, System.Web.UI.Control rootControl, bool setTabIndex) {
			return block.NegotiateTabIndexesRecursively(tabindex, rootControl, setTabIndex);
		}

		public override void DataBind() {
			HandleBreakpoint();
			if (EvaluateParameters != null) {
				EvaluateParameters(this, null);
			}
			block.DataBind();
		}

		public override bool IncludeSpan {
			get {
				return block.IncludeSpan; 
			}
			set {
				block.IncludeSpan = value; 
			}
		}

		public void BindProxyDelegates(object sender, BindDelegatesEventArgs e) {
			BindDelegatesIfNeeded();
			ssSilkUIFramework.Flows.FlowDevelopment.WBlkjQuery webBlock = (ssSilkUIFramework.Flows.FlowDevelopment.WBlkjQuery) e.UserControl;

		}

		public override string ParentEditRecord {
			get {
				return block.ParentEditRecord;
			}
			set {
				block.ParentEditRecord = value;
			}
		}

		public static void GetCss(System.IO.TextWriter writer, bool inline, HashSet<string> visited) {
			ssSilkUIFramework.Flows.FlowDevelopment.WBlkjQuery.GetCss(writer, inline, visited);
		}

		public override string GridCssClasses {
			get {
				return block.GridCssClasses;
			}
			set {
				block.GridCssClasses = value;
			}
		}

		public override string Style {
			get {
				return block.Style;
			}
			set {
				block.Style = value;
			}
		}

		public override string WebBlockIdentifier {
			get {
				return "Proxy." + block.WebBlockIdentifier;
			}
		}

		/// <summary>
		/// Delegate Definitions
		/// </summary>

		// web block public declarations

		// block input variable Javascript
		public string inParamJavascript {
			get {
				return block.inParamJavascript;
			}
			set {
				block.inParamJavascript = value;
			}
		}

	}

}
