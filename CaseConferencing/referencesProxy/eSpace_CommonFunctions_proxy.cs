﻿/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

// Proxy for reference eSpace with name CommonFunctions and key tLKcO8hZD0G4jbCV8FfZcA
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
	/// Class: RsseSpaceCommonFunctions
	/// </summary>
	public class RsseSpaceCommonFunctions {
		protected static int _maxExtensionLogsPerRequest = OutSystems.HubEdition.RuntimePlatform.Settings.GetInt(OutSystems.HubEdition.RuntimePlatform.Settings.Configs.Log_MaxLogsPerRequest_Extension);
		public static void MssOnSessionStart(HeContext heContext) {
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ssCommonFunctions.Global.eSpaceId;
				if (RuntimePlatformUtils.TestAndSetProducerSession("CommonFunctions")) {
					ssCommonFunctions.Actions.ActionOnSessionStart(heContext);
				}
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}


		public static void MssGetAcademicYearValues2(HeContext heContext, int inParamAcademicYearType, string inParamSpecificYearID, out IRecord outParamAcademicYear) {
			outParamAcademicYear = ssCaseConferencing.RsseSpaceCommonFunctions.Factory.FactoryRCAcademicYear2RecordSingleton.CreateRsseSpaceCommonFunctionsRCAcademicYear2Record();
			ssCommonFunctions.RCAcademicYearRecord _proxyoutParamAcademicYear = new ssCommonFunctions.RCAcademicYearRecord(null);
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ssCommonFunctions.Global.eSpaceId;
				RsseSpaceCommonFunctions.MssOnSessionStart(heContext);
				ssCommonFunctions.Actions.ActionGetAcademicYearValues(heContext, inParamAcademicYearType, inParamSpecificYearID, out _proxyoutParamAcademicYear);
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
			outParamAcademicYear.FillFromOther(_proxyoutParamAcademicYear);
		}


		public sealed partial class ENAcademicYearType2Entity {
			public static string ViewName(int? tenant, string locale) {
				return ssCommonFunctions.ENAcademicYearTypeEntity.ViewName(tenant, locale);
			}
			public const int eSpaceId = ssCommonFunctions.Global.eSpaceId;
		} // ENAcademicYearType2Entity
		partial class ENAcademicYearType2Entity {


			public static IRecord GetRecordById(int id) {
				IRecord rec = Factory.FactoryENAcademicYearType2EntityRecordSingleton.CreateENAcademicYearType2EntityRecord();
				rec.FillFromOther(ssCommonFunctions.ENAcademicYearTypeEntity.GetRecordById(id));
				return rec;
			}

			public static IRecord GetRecordByName(string name) {
				IRecord rec = Factory.FactoryENAcademicYearType2EntityRecordSingleton.CreateENAcademicYearType2EntityRecord();
				rec.FillFromOther(ssCommonFunctions.ENAcademicYearTypeEntity.GetRecordByName(name));
				return rec;
			}

			public static IRecord GetRecordByKey(ObjectKey key) {
				IRecord rec = Factory.FactoryENAcademicYearType2EntityRecordSingleton.CreateENAcademicYearType2EntityRecord();
				rec.FillFromOther(ssCommonFunctions.ENAcademicYearTypeEntity.GetRecordByKey(key));
				return rec;
			}
		} // ENAcademicYearType2Entity;

		public sealed partial class ENAcademicYear2Entity {
			public static string ViewName(int? tenant, string locale) {
				return ssCommonFunctions.ENAcademicYearEntity.ViewName(tenant, locale);
			}
			public const int eSpaceId = ssCommonFunctions.Global.eSpaceId;
		} // ENAcademicYear2Entity
		partial class ENAcademicYear2Entity {


			public static IRecord GetRecordById(string id) {
				IRecord rec = Factory.FactoryENAcademicYear2EntityRecordSingleton.CreateENAcademicYear2EntityRecord();
				rec.FillFromOther(ssCommonFunctions.ENAcademicYearEntity.GetRecordById(id));
				return rec;
			}

			public static IRecord GetRecordByName(string name) {
				IRecord rec = Factory.FactoryENAcademicYear2EntityRecordSingleton.CreateENAcademicYear2EntityRecord();
				rec.FillFromOther(ssCommonFunctions.ENAcademicYearEntity.GetRecordByName(name));
				return rec;
			}

			public static IRecord GetRecordByKey(ObjectKey key) {
				IRecord rec = Factory.FactoryENAcademicYear2EntityRecordSingleton.CreateENAcademicYear2EntityRecord();
				rec.FillFromOther(ssCommonFunctions.ENAcademicYearEntity.GetRecordByKey(key));
				return rec;
			}
		} // ENAcademicYear2Entity;

		public interface IRCAcademicYear2RecordTypeFactory {
			IRecord CreateRsseSpaceCommonFunctionsRCAcademicYear2Record();
		}

		public interface IENAcademicYearType2EntityRecordTypeFactory {
			IRecord CreateENAcademicYearType2EntityRecord();
		}
		public interface IENAcademicYear2EntityRecordTypeFactory {
			IRecord CreateENAcademicYear2EntityRecord();
		}

		public class Factory {
			public static IRCAcademicYear2RecordTypeFactory FactoryRCAcademicYear2RecordSingleton;
			public static IENAcademicYearType2EntityRecordTypeFactory FactoryENAcademicYearType2EntityRecordSingleton;
			public static IENAcademicYear2EntityRecordTypeFactory FactoryENAcademicYear2EntityRecordSingleton;
		}
		public class DefaultValues {
			public static int ReferenceActionFolder_AcademicYearFunctions_ReferenceActionInsideFolder_GetAcademicYearValues2_Variables_ReferenceGenericInputParameter_AcademicYearType {
				get {
					return ssCommonFunctions.DefaultValues.ReferenceActionFolder_AcademicYearFunctions_ReferenceActionInsideFolder_GetAcademicYearValues_Variables_ReferenceGenericInputParameter_AcademicYearType; 
				}
			}
			public static string ReferenceActionFolder_AcademicYearFunctions_ReferenceActionInsideFolder_GetAcademicYearValues2_Variables_ReferenceGenericInputParameter_SpecificYearID {
				get {
					return ssCommonFunctions.DefaultValues.ReferenceActionFolder_AcademicYearFunctions_ReferenceActionInsideFolder_GetAcademicYearValues_Variables_ReferenceGenericInputParameter_SpecificYearID; 
				}
			}
		}
	}
}
