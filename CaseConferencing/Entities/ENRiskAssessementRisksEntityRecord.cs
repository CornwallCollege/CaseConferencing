﻿/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

using System;
using System.Data;
using System.Runtime.Serialization;
using System.Reflection;
using System.Xml;
using OutSystems.ObjectKeys;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.Internal.Db;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using OutSystems.RuntimeCommon;

namespace ssCaseConferencing {

	public sealed partial class ENRiskAssessementRisksEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return RsseSpaceCaseConferencingCore.ENRiskAssessementRisksEntity.ViewName(tenant, locale);
		}
		public const int eSpaceId = RsseSpaceCaseConferencingCore.ENRiskAssessementRisksEntity.eSpaceId;
	} // ENRiskAssessementRisksEntity

	/// <summary>
	/// Entity <code>ENRiskAssessementRisksEntityRecord</code> that represents the Service Studio entity
	///  <code>RiskAssessementRisks</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("RiskAssessementRisks", "pU2z41UaNESme2NWaUg6AA", "U4Zx4qCUzUe0A+0C93K3BA", 0, "OSUSR_q0e_RiskAssessementRisks", "")]
	[Serializable()]
	public partial struct ENRiskAssessementRisksEntityRecord: ISerializable, ITypedRecord<ENRiskAssessementRisksEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("U4Zx4qCUzUe0A+0C93K3BA*kgQ74b6mLE2hmQkmwnR+ZA");
		private static readonly GlobalObjectKey IdRiskAssessment = GlobalObjectKey.Parse("U4Zx4qCUzUe0A+0C93K3BA*a4vOmuA_IUePXyY8RD+ZQQ");
		private static readonly GlobalObjectKey IdRisk = GlobalObjectKey.Parse("U4Zx4qCUzUe0A+0C93K3BA*+lC7C8C3MU6gJkLx5mYvaA");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ID", 0, true, true, false)]
		[System.Xml.Serialization.XmlElement("Id")]
		private int _ssId;
		public int ssId {
			get {
				return _ssId;
			}
			set {
				if ((_ssId!=value) || OptimizedAttributes[0]) {
					ChangedAttributes = new BitArray(3, true);
					_ssId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("RISKASSESSMENT", 0, false, false, true)]
		[System.Xml.Serialization.XmlElement("RiskAssessment")]
		private int _ssRiskAssessment;
		public int ssRiskAssessment {
			get {
				return _ssRiskAssessment;
			}
			set {
				if ((_ssRiskAssessment!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssRiskAssessment = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("RISK", 250, false, false, false)]
		[System.Xml.Serialization.XmlElement("Risk")]
		private string _ssRisk;
		public string ssRisk {
			get {
				return _ssRisk;
			}
			set {
				if ((_ssRisk!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssRisk = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENRiskAssessementRisksEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(3, true);
			OptimizedAttributes = new BitArray(3, false);
			_ssId = 0;
			_ssRiskAssessment = 0;
			_ssRisk = "";
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssId = r.ReadInteger(index++, "RiskAssessementRisks.Id", 0);
			ssRiskAssessment = r.ReadEntityReference(index++, "RiskAssessementRisks.RiskAssessment", 0);
			ssRisk = r.ReadText(index++, "RiskAssessementRisks.Risk", "");
			ChangedAttributes = new BitArray(3, false);
			OptimizedAttributes = new BitArray(3, false);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(ENRiskAssessementRisksEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENRiskAssessementRisksEntityRecord a, ENRiskAssessementRisksEntityRecord b) {
			if (a.ssId != b.ssId) return false;
			if (a.ssRiskAssessment != b.ssRiskAssessment) return false;
			if (a.ssRisk != b.ssRisk) return false;
			return true;
		}

		public static bool operator != (ENRiskAssessementRisksEntityRecord a, ENRiskAssessementRisksEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENRiskAssessementRisksEntityRecord)) return false;
			return (this == (ENRiskAssessementRisksEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssId.GetHashCode()
				^ ssRiskAssessment.GetHashCode()
				^ ssRisk.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public ENRiskAssessementRisksEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(3, true);
			OptimizedAttributes = new BitArray(3, false);
			_ssId = 0;
			_ssRiskAssessment = 0;
			_ssRisk = "";
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fields[0] .FieldType.IsSerializable)
			_ssId = (int) info.GetValue(fields[0] .Name, fields[0] .FieldType);
			if (fields[1] .FieldType.IsSerializable)
			_ssRiskAssessment = (int) info.GetValue(fields[1] .Name, fields[1] .FieldType);
			if (fields[2] .FieldType.IsSerializable)
			_ssRisk = (string) info.GetValue(fields[2] .Name, fields[2] .FieldType);
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENRiskAssessementRisksEntityRecord Duplicate() {
			ENRiskAssessementRisksEntityRecord t;
			t._ssId = this._ssId;
			t._ssRiskAssessment = this._ssRiskAssessment;
			t._ssRisk = this._ssRisk;
			t.ChangedAttributes = new BitArray(3);
			t.OptimizedAttributes = new BitArray(3);
			for (int i = 0; i < 3; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Id")) VarValue.AppendAttribute(recordElem, "Id", ssId, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "Id");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".RiskAssessment")) VarValue.AppendAttribute(recordElem, "RiskAssessment", ssRiskAssessment, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "RiskAssessment");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Risk")) VarValue.AppendAttribute(recordElem, "Risk", ssRisk, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Risk");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "id") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Id")) variable.Value = ssId; else variable.Optimized = true;
			} else if (head == "riskassessment") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".RiskAssessment")) variable.Value = ssRiskAssessment; else variable.Optimized = true;
			} else if (head == "risk") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Risk")) variable.Value = ssRisk; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdId)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdRiskAssessment)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdRisk)) {
				return ChangedAttributes[2];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdId)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdRiskAssessment)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdRisk)) {
				return OptimizedAttributes[2];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdId) {
				return ssId;
			} else if (key == IdRiskAssessment) {
				return ssRiskAssessment;
			} else if (key == IdRisk) {
				return ssRisk;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(3);
			OptimizedAttributes = new BitArray(3);
			if (other == null) return;
			ssId = (int) other.AttributeGet(IdId);
			ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
			ssRiskAssessment = (int) other.AttributeGet(IdRiskAssessment);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdRiskAssessment);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdRiskAssessment);
			ssRisk = (string) other.AttributeGet(IdRisk);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdRisk);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdRisk);
		}
	} // ENRiskAssessementRisksEntityRecord
	/// <summary>
	/// Structure <code>RCRiskAssessementRisksRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCRiskAssessementRisksRecord: ISerializable, ITypedRecord<RCRiskAssessementRisksRecord> {
		private static readonly GlobalObjectKey IdRiskAssessementRisks = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*jEq4gqFChA1qOUl8hTa1zA");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("RiskAssessementRisks")]
		public ENRiskAssessementRisksEntityRecord ssENRiskAssessementRisks;


		public static implicit operator ENRiskAssessementRisksEntityRecord(RCRiskAssessementRisksRecord r) {
			return r.ssENRiskAssessementRisks;
		}

		public static implicit operator RCRiskAssessementRisksRecord(ENRiskAssessementRisksEntityRecord r) {
			RCRiskAssessementRisksRecord res = new RCRiskAssessementRisksRecord(null);
			res.ssENRiskAssessementRisks = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENRiskAssessementRisks.ChangedAttributes = value;
			}
			get {
				return ssENRiskAssessementRisks.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCRiskAssessementRisksRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENRiskAssessementRisks = new ENRiskAssessementRisksEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(3, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENRiskAssessementRisks.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENRiskAssessementRisks.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENRiskAssessementRisks.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENRiskAssessementRisks.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCRiskAssessementRisksRecord r) {
			this = r;
		}


		public static bool operator == (RCRiskAssessementRisksRecord a, RCRiskAssessementRisksRecord b) {
			if (a.ssENRiskAssessementRisks != b.ssENRiskAssessementRisks) return false;
			return true;
		}

		public static bool operator != (RCRiskAssessementRisksRecord a, RCRiskAssessementRisksRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCRiskAssessementRisksRecord)) return false;
			return (this == (RCRiskAssessementRisksRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENRiskAssessementRisks.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCRiskAssessementRisksRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENRiskAssessementRisks = new ENRiskAssessementRisksEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fields[0] .FieldType.IsSerializable)
			ssENRiskAssessementRisks = (ENRiskAssessementRisksEntityRecord) info.GetValue(fields[0] .Name, fields[0] .FieldType);
		}

		public void RecursiveReset() {
			ssENRiskAssessementRisks.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENRiskAssessementRisks.InternalRecursiveSave();
		}


		public RCRiskAssessementRisksRecord Duplicate() {
			RCRiskAssessementRisksRecord t;
			t.ssENRiskAssessementRisks = (ENRiskAssessementRisksEntityRecord) this.ssENRiskAssessementRisks.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENRiskAssessementRisks.ToXml(this, recordElem, "RiskAssessementRisks", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "riskassessementrisks") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".RiskAssessementRisks")) variable.Value = ssENRiskAssessementRisks; else variable.Optimized = true;
				variable.SetFieldName("riskassessementrisks");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENRiskAssessementRisks.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENRiskAssessementRisks.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdRiskAssessementRisks) {
				return ssENRiskAssessementRisks;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENRiskAssessementRisks.FillFromOther((IRecord) other.AttributeGet(IdRiskAssessementRisks));
		}
	} // RCRiskAssessementRisksRecord
	/// <summary>
	/// RecordList type <code>RLRiskAssessementRisksRecordList</code> that represents a record list of
	///  <code>RiskAssessementRisks</code>
	/// </summary>
	[Serializable()]
	public partial class RLRiskAssessementRisksRecordList: GenericRecordList<RCRiskAssessementRisksRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCRiskAssessementRisksRecord GetElementDefaultValue() {
			return new RCRiskAssessementRisksRecord("");
		}

		public T[] ToArray<T>(Func<RCRiskAssessementRisksRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLRiskAssessementRisksRecordList recordlist, Func<RCRiskAssessementRisksRecord, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLRiskAssessementRisksRecordList ToList<T>(T[] array, Func <T, RCRiskAssessementRisksRecord> converter) {
			RLRiskAssessementRisksRecordList result = new RLRiskAssessementRisksRecordList();
			if (array != null) {
				foreach(T item in array) {
					result.Append(converter(item));
				}
			}
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLRiskAssessementRisksRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLRiskAssessementRisksRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLRiskAssessementRisksRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLRiskAssessementRisksRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(3, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCRiskAssessementRisksRecord> NewList() {
			return new RLRiskAssessementRisksRecordList();
		}


	} // RLRiskAssessementRisksRecordList

	/// <summary>
	/// RecordList type <code>RLRiskAssessementRisksList</code> that represents a record list of
	///  <code>Text, Integer, RiskAssessmentIdentifier</code>
	/// </summary>
	[Serializable()]
	public partial class RLRiskAssessementRisksList: GenericRecordList<ENRiskAssessementRisksEntityRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override ENRiskAssessementRisksEntityRecord GetElementDefaultValue() {
			return new ENRiskAssessementRisksEntityRecord("");
		}

		public T[] ToArray<T>(Func<ENRiskAssessementRisksEntityRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLRiskAssessementRisksList recordlist, Func<ENRiskAssessementRisksEntityRecord, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLRiskAssessementRisksList ToList<T>(T[] array, Func <T, ENRiskAssessementRisksEntityRecord> converter) {
			RLRiskAssessementRisksList result = new RLRiskAssessementRisksList();
			if (array != null) {
				foreach(T item in array) {
					result.Append(converter(item));
				}
			}
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLRiskAssessementRisksList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLRiskAssessementRisksList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLRiskAssessementRisksList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLRiskAssessementRisksList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[0];
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<ENRiskAssessementRisksEntityRecord> NewList() {
			return new RLRiskAssessementRisksList();
		}


	} // RLRiskAssessementRisksList
	public partial class ExtendedActions {
		/// <summary>
		/// Action: CreateRiskAssessementRisks
		/// </summary>

		public static void CreateRiskAssessementRisks(HeContext heContext, RCRiskAssessementRisksRecord inParamSource, out int outParamId) {
			outParamId = 0;

			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ENRiskAssessementRisksEntity.eSpaceId;
				ENRiskAssessementRisksEntityRecord ssENRiskAssessementRisks = inParamSource;
				using(Transaction trans = DatabaseAccess.ForCurrentDatabase.GetRequestTransaction()) {
					string insertSql =
					 "SET NOCOUNT ON; INSERT INTO " + ENRiskAssessementRisksEntity.LocalViewName(null, null) + " (" +
					 " [RISKASSESSMENT]" +
					 ", [RISK]" +
					 " ) VALUES (" +
					 " @ssRiskAssessment" +
					 ", @ssRisk" +
					 " ) ; SELECT SCOPE_IDENTITY();";
					Command insertSqlCmd = trans.CreateCommand(insertSql);
					if ((ssENRiskAssessementRisks.ssRiskAssessment==0)) {
						insertSqlCmd.CreateParameter("@ssRiskAssessment", DBNull.Value);
					} else {
						insertSqlCmd.CreateParameter("@ssRiskAssessment", DbType.Int32, ssENRiskAssessementRisks.ssRiskAssessment);
					}
					insertSqlCmd.CreateParameter("@ssRisk", DbType.String, ssENRiskAssessementRisks.ssRisk);
					outParamId = (int) Convert.ChangeType(insertSqlCmd.ExecuteScalar("Entity Action CreateRiskAssessementRisks", true), typeof(int));
				}
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}

		/// <summary>
		/// Action: CreateOrUpdateRiskAssessementRisks
		/// </summary>

		public static void CreateOrUpdateRiskAssessementRisks(HeContext heContext, BitArray usedFields, RCRiskAssessementRisksRecord inParamSource, out int outParamId) {
			outParamId = 0;

			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ENRiskAssessementRisksEntity.eSpaceId;
				ENRiskAssessementRisksEntityRecord ssENRiskAssessementRisks = inParamSource;
				using(Transaction trans = DatabaseAccess.ForCurrentDatabase.GetRequestTransaction()) {
					if (usedFields == null) {
						usedFields = new BitArray(3, true);
					}
					string updateSet = "SET NOCOUNT OFF; UPDATE " + ENRiskAssessementRisksEntity.LocalViewName(heContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale()) + " SET ";
					string parameters = "";
					parameters = (usedFields[1] ?(StringUtils.SuffixIfNotEmpty(parameters, ", ") + "[RISKASSESSMENT] = @ssRiskAssessment"): parameters);
					parameters = (usedFields[2] ?(StringUtils.SuffixIfNotEmpty(parameters, ", ") + "[RISK] = @ssRisk"): parameters);
					string whereCondition = " WHERE [ID] = @ssENRiskAssessementRisksssId";
					string sql = updateSet + parameters + whereCondition;
					Command sqlCmd = trans.CreateCommand(sql);
					int counter = 0;
					if (usedFields[1]) {
						if ((ssENRiskAssessementRisks.ssRiskAssessment==0)) {
							sqlCmd.CreateParameter("@ssRiskAssessment", DBNull.Value);
						} else {
							sqlCmd.CreateParameter("@ssRiskAssessment", DbType.Int32, ssENRiskAssessementRisks.ssRiskAssessment);
						}
						counter++;
					}
					if (usedFields[2]) {
						sqlCmd.CreateParameter("@ssRisk", DbType.String, ssENRiskAssessementRisks.ssRisk);
						counter++;
					}
					if (counter == 0) {
						string dummyUpdate = "[RISK] = [RISK]";
						string noUpdate = updateSet + dummyUpdate + whereCondition;
						sqlCmd = trans.CreateCommand(noUpdate);
					}
					sqlCmd.CreateParameter("@ssENRiskAssessementRisksssId", DbType.Int32, ssENRiskAssessementRisks.ssId);
					counter = sqlCmd.ExecuteNonQueryWithoutTransformParametersSyntax("Entity Action CreateOrUpdateRiskAssessementRisks (update)", true);
					if (counter == 0) {
						string insertSql =
						 "SET NOCOUNT ON; INSERT INTO " + ENRiskAssessementRisksEntity.LocalViewName(null, null) + " (" +
						 " [RISKASSESSMENT]" +
						 ", [RISK]" +
						 " ) VALUES (" +
						 " @ssRiskAssessment" +
						 ", @ssRisk" +
						 " ) ; SELECT SCOPE_IDENTITY();";
						Command insertSqlCmd = trans.CreateCommand(insertSql);
						if ((ssENRiskAssessementRisks.ssRiskAssessment==0)) {
							insertSqlCmd.CreateParameter("@ssRiskAssessment", DBNull.Value);
						} else {
							insertSqlCmd.CreateParameter("@ssRiskAssessment", DbType.Int32, ssENRiskAssessementRisks.ssRiskAssessment);
						}
						insertSqlCmd.CreateParameter("@ssRisk", DbType.String, ssENRiskAssessementRisks.ssRisk);
						outParamId = (int) Convert.ChangeType(insertSqlCmd.ExecuteScalar("Entity Action CreateOrUpdateRiskAssessementRisks", true), typeof(int));
					} else {
						outParamId = ssENRiskAssessementRisks.ssId;
					}
				}
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}

		/// <summary>
		/// Action: DeleteRiskAssessementRisks
		/// </summary>

		public static void DeleteRiskAssessementRisks(HeContext heContext, int inParamId) {
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ENRiskAssessementRisksEntity.eSpaceId;
				using(Transaction trans = DatabaseAccess.ForCurrentDatabase.GetRequestTransaction()) {
					string sql =
					 "DELETE " +
					 "FROM " + ENRiskAssessementRisksEntity.LocalViewName(heContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale()) + " " +
					 "WHERE [ID] = @inParamId";
					Command sqlCmd = trans.CreateCommand(sql);
					sqlCmd.CreateParameter("@inParamId", DbType.Int32, inParamId);
					sqlCmd.ExecuteNonQueryWithoutTransformParametersSyntax("Entity Action DeleteRiskAssessementRisks", true);
				}
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}

		/// <summary>
		/// Action: GetRiskAssessementRisks
		/// </summary>

		public static void GetRiskAssessementRisks(HeContext heContext, int inParamId, out RCRiskAssessementRisksRecord outParamRecord) {
			outParamRecord = new RCRiskAssessementRisksRecord(null);

			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ENRiskAssessementRisksEntity.eSpaceId;
				using(Transaction trans = DatabaseAccess.ForCurrentDatabase.GetRequestTransaction()) {
					string sql =
					 "SELECT " +
					 " [ID]" +
					 ", [RISKASSESSMENT]" +
					 ", [RISK]" +
					 " FROM " + ENRiskAssessementRisksEntity.LocalViewName(heContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale()) + " " +
					 "WHERE [ID] = @inParamId";
					Command sqlCmd = trans.CreateCommand(sql);
					sqlCmd.CreateParameter("@inParamId", DbType.Int32, inParamId);
					using(IDataReader reader = sqlCmd.ExecuteReader("Entity Action GetRiskAssessementRisks", true, false, false)) {
						if (reader.Read()) {
							outParamRecord.ReadDB(reader);
							outParamRecord.AllOptimizedAttributes = new BitArray[] {
								new BitArray(3, false)
							}
							;
						} else
						throw new DataBaseException(ENRiskAssessementRisksEntity.LocalViewName(heContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale()) + " with key " + inParamId + " was not found");
					}
				}
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}

		/// <summary>
		/// Action: GetRiskAssessementRisksForUpdate
		/// </summary>

		public static void GetRiskAssessementRisksForUpdate(HeContext heContext, int inParamId, out RCRiskAssessementRisksRecord outParamRecord) {
			outParamRecord = new RCRiskAssessementRisksRecord(null);

			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ENRiskAssessementRisksEntity.eSpaceId;
				using(Transaction trans = DatabaseAccess.ForCurrentDatabase.GetRequestTransaction()) {
					string sql =
					 "SELECT " +
					 " [ID]" +
					 ", [RISKASSESSMENT]" +
					 ", [RISK]" +
					 "FROM " + ENRiskAssessementRisksEntity.LocalViewName(heContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale()) + " WITH ( UPDLOCK ) " +
					 "WHERE [ID] = @inParamId ";
					Command sqlCmd = trans.CreateCommand(sql);
					sqlCmd.CreateParameter("@inParamId", DbType.Int32, inParamId);
					using(IDataReader reader = sqlCmd.ExecuteReader("Entity Action GetRiskAssessementRisksForUpdate", true, false, false)) {
						if (reader.Read()) {
							outParamRecord.ReadDB(reader);
							outParamRecord.AllOptimizedAttributes = new BitArray[] {
								new BitArray(3, false)
							}
							;
						} else
						throw new DataBaseException(ENRiskAssessementRisksEntity.LocalViewName(heContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale()) + " with key " + inParamId + " was not found");
					}
				}
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}

		/// <summary>
		/// Action: UpdateRiskAssessementRisks
		/// </summary>

		public static void UpdateRiskAssessementRisks(HeContext heContext, BitArray usedFields, RCRiskAssessementRisksRecord inParamSource) {
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ENRiskAssessementRisksEntity.eSpaceId;
				ENRiskAssessementRisksEntityRecord ssENRiskAssessementRisks = inParamSource;
				using(Transaction trans = DatabaseAccess.ForCurrentDatabase.GetRequestTransaction()) {
					if (usedFields == null) {
						usedFields = new BitArray(3, true);
					}
					string updateSet = "SET NOCOUNT OFF; UPDATE " + ENRiskAssessementRisksEntity.LocalViewName(heContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale()) + " SET ";
					string parameters = "";
					parameters = (usedFields[1] ?(StringUtils.SuffixIfNotEmpty(parameters, ", ") + "[RISKASSESSMENT] = @ssRiskAssessment"): parameters);
					parameters = (usedFields[2] ?(StringUtils.SuffixIfNotEmpty(parameters, ", ") + "[RISK] = @ssRisk"): parameters);
					string whereCondition = " WHERE [ID] = @ssENRiskAssessementRisksssId";
					string sql = updateSet + parameters + whereCondition;
					Command sqlCmd = trans.CreateCommand(sql);
					int counter = 0;
					if (usedFields[1]) {
						if ((ssENRiskAssessementRisks.ssRiskAssessment==0)) {
							sqlCmd.CreateParameter("@ssRiskAssessment", DBNull.Value);
						} else {
							sqlCmd.CreateParameter("@ssRiskAssessment", DbType.Int32, ssENRiskAssessementRisks.ssRiskAssessment);
						}
						counter++;
					}
					if (usedFields[2]) {
						sqlCmd.CreateParameter("@ssRisk", DbType.String, ssENRiskAssessementRisks.ssRisk);
						counter++;
					}
					if (counter == 0) {
						string dummyUpdate = "[RISK] = [RISK]";
						string noUpdate = updateSet + dummyUpdate + whereCondition;
						sqlCmd = trans.CreateCommand(noUpdate);
					}
					sqlCmd.CreateParameter("@ssENRiskAssessementRisksssId", DbType.Int32, ssENRiskAssessementRisks.ssId);
					if (sqlCmd.ExecuteNonQueryWithoutTransformParametersSyntax("Entity Action UpdateRiskAssessementRisks", true) <= 0)
					throw new DataBaseException(ENRiskAssessementRisksEntity.LocalViewName(heContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale()) + " with key " + ssENRiskAssessementRisks.ssId + " was not updated");
				}
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}

	}
}

namespace ssCaseConferencing {
	[XmlType("RiskAssessementRisks")]
	public class WORCRiskAssessementRisksRecord {
		[System.Xml.Serialization.XmlElement("Id")]
		public int varWSId;

		[System.Xml.Serialization.XmlElement("RiskAssessment")]
		public int varWSRiskAssessment;

		[System.Xml.Serialization.XmlElement("Risk")]
		public string varWSRisk;

		public WORCRiskAssessementRisksRecord() {
			varWSId = (int) 0;
			varWSRiskAssessment = (int) 0;
			varWSRisk = (string) "";
		}

		public WORCRiskAssessementRisksRecord(ENRiskAssessementRisksEntityRecord r) {
			varWSId = (int) r.ssId;
			varWSRiskAssessment = (int) r.ssRiskAssessment;
			varWSRisk = BaseAppUtils.RemoveControlChars(r.ssRisk);
		}

		public static RLRiskAssessementRisksList ToRecordList(WORCRiskAssessementRisksRecord[] array) {
			RLRiskAssessementRisksList rl = new RLRiskAssessementRisksList();
			if (array != null) {
				foreach(WORCRiskAssessementRisksRecord val in array) {
					rl.Append(val);
				}
			}
			return rl;
		}

		public static WORCRiskAssessementRisksRecord[] FromRecordList(RLRiskAssessementRisksList rl) {
			WORCRiskAssessementRisksRecord[] array = new WORCRiskAssessementRisksRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial struct RCRiskAssessementRisksRecord {
		public static implicit operator WORCRiskAssessementRisksRecord(RCRiskAssessementRisksRecord r) {
			return new WORCRiskAssessementRisksRecord(r.ssENRiskAssessementRisks);
		}

		public static implicit operator RCRiskAssessementRisksRecord(WORCRiskAssessementRisksRecord w) {
			RCRiskAssessementRisksRecord r = new RCRiskAssessementRisksRecord("");
			if (w != null) {
				r.ssENRiskAssessementRisks = w;
			}
			return r;
		}

	}

	partial struct ENRiskAssessementRisksEntityRecord {
		public static implicit operator WORCRiskAssessementRisksRecord(ENRiskAssessementRisksEntityRecord r) {
			return new WORCRiskAssessementRisksRecord(r);
		}

		public static implicit operator ENRiskAssessementRisksEntityRecord(WORCRiskAssessementRisksRecord w) {
			ENRiskAssessementRisksEntityRecord r = new ENRiskAssessementRisksEntityRecord("");
			if (w != null) {
				r.ssId = (int) w.varWSId;
				r.ssRiskAssessment = (int) w.varWSRiskAssessment;
				r.ssRisk = ((string) w.varWSRisk ?? "");
			}
			return r;
		}

	}
}


namespace ssCaseConferencing {
	[Serializable()]
	public partial class WORLRiskAssessementRisksRecordList {
		public WORCRiskAssessementRisksRecord[] Array;


		public WORLRiskAssessementRisksRecordList(WORCRiskAssessementRisksRecord[] r) {
			if (r == null)
			Array = new WORCRiskAssessementRisksRecord[0];
			else
			Array = r;
		}
		public WORLRiskAssessementRisksRecordList() {
			Array = new WORCRiskAssessementRisksRecord[0];
		}

		public WORLRiskAssessementRisksRecordList(RLRiskAssessementRisksRecordList rl) {
			rl=(RLRiskAssessementRisksRecordList) rl.Duplicate();
			Array = new WORCRiskAssessementRisksRecord[rl.Length];
			while (!rl.Eof) {
				Array[rl.CurrentRowNumber] = new WORCRiskAssessementRisksRecord(rl.CurrentRec);
				rl.Advance();
			}
		}

	}
}

namespace ssCaseConferencing {
	partial class RLRiskAssessementRisksRecordList {
		public static implicit operator RLRiskAssessementRisksRecordList(WORCRiskAssessementRisksRecord[] array) {
			RLRiskAssessementRisksRecordList rl = new RLRiskAssessementRisksRecordList();
			if (array != null) {
				foreach(WORCRiskAssessementRisksRecord val in array) {
					rl.Append((RCRiskAssessementRisksRecord) val);
				}
			}
			return rl;
		}
		public static implicit operator WORCRiskAssessementRisksRecord[](RLRiskAssessementRisksRecordList rl) {
			WORCRiskAssessementRisksRecord[] array = new WORCRiskAssessementRisksRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = (RCRiskAssessementRisksRecord) rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial class WORLRiskAssessementRisksRecordList {
		public static implicit operator RLRiskAssessementRisksRecordList(WORLRiskAssessementRisksRecordList w) {
			return w.Array;
		}
		public static implicit operator WORLRiskAssessementRisksRecordList(RLRiskAssessementRisksRecordList rl) {
			return new WORLRiskAssessementRisksRecordList(rl);
		}
		public static implicit operator WORCRiskAssessementRisksRecord[](WORLRiskAssessementRisksRecordList w) {
			if (w != null) {
				return w.Array;
			}
			return null;
		}
		public static implicit operator WORLRiskAssessementRisksRecordList(WORCRiskAssessementRisksRecord[] array) {
			return new WORLRiskAssessementRisksRecordList(array);
		}
	}
}

