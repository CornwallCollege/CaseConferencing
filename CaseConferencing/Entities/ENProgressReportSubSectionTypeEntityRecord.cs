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

	public sealed partial class ENProgressReportSubSectionTypeEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return RsseSpaceCaseConferencingCore.ENProgressReportSubSectionTypeEntity.ViewName(tenant, locale);
		}
		public const int eSpaceId = RsseSpaceCaseConferencingCore.ENProgressReportSubSectionTypeEntity.eSpaceId;
	} // ENProgressReportSubSectionTypeEntity

	/// <summary>
	/// Entity <code>ENProgressReportSubSectionTypeEntityRecord</code> that represents the Service Studio
	///  entity <code>ProgressReportSubSectionType</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("ProgressReportSubSectionType", "Fh5Ah+fiP02M8XUHGdjj2g", "U4Zx4qCUzUe0A+0C93K3BA", 0, "OSUSR_q0e_ProgressReportSubSectionType", "")]
	[Serializable()]
	public partial struct ENProgressReportSubSectionTypeEntityRecord: ISerializable, ITypedRecord<ENProgressReportSubSectionTypeEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("U4Zx4qCUzUe0A+0C93K3BA*CDzoNyb+30uR1zGkr1+ghQ");
		private static readonly GlobalObjectKey IdLabel = GlobalObjectKey.Parse("U4Zx4qCUzUe0A+0C93K3BA*+ynZf2MroUSliY5MtZpnlg");
		private static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("U4Zx4qCUzUe0A+0C93K3BA*2Kcju6x9yEy6SmeclDAdhg");
		private static readonly GlobalObjectKey IdIs_Active = GlobalObjectKey.Parse("U4Zx4qCUzUe0A+0C93K3BA*gXeREp0qdkaQcrkqC2ZQ2g");

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ID", 50, false, true, false)]
		[System.Xml.Serialization.XmlElement("Id")]
		private string _ssId;
		public string ssId {
			get {
				return _ssId;
			}
			set {
				if ((_ssId!=value) || OptimizedAttributes[0]) {
					ChangedAttributes = new BitArray(4, true);
					_ssId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("LABEL", 50, false, false, false)]
		[System.Xml.Serialization.XmlElement("Label")]
		private string _ssLabel;
		public string ssLabel {
			get {
				return _ssLabel;
			}
			set {
				if ((_ssLabel!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssLabel = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ORDER", 0, false, false, false)]
		[System.Xml.Serialization.XmlElement("Order")]
		private int _ssOrder;
		public int ssOrder {
			get {
				return _ssOrder;
			}
			set {
				if ((_ssOrder!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssOrder = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("IS_ACTIVE", 0, false, false, false)]
		[System.Xml.Serialization.XmlElement("Is_Active")]
		private bool _ssIs_Active;
		public bool ssIs_Active {
			get {
				return _ssIs_Active;
			}
			set {
				if ((_ssIs_Active!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
					_ssIs_Active = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENProgressReportSubSectionTypeEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(4, true);
			OptimizedAttributes = new BitArray(4, false);
			_ssId = "";
			_ssLabel = "";
			_ssOrder = 0;
			_ssIs_Active = false;
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
			ssId = r.ReadText(index++, "ProgressReportSubSectionType.Id", "");
			ssLabel = r.ReadText(index++, "ProgressReportSubSectionType.Label", "");
			ssOrder = r.ReadInteger(index++, "ProgressReportSubSectionType.Order", 0);
			ssIs_Active = r.ReadBoolean(index++, "ProgressReportSubSectionType.Is_Active", false);
			ChangedAttributes = new BitArray(4, false);
			OptimizedAttributes = new BitArray(4, false);
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
		public void ReadIM(ENProgressReportSubSectionTypeEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENProgressReportSubSectionTypeEntityRecord a, ENProgressReportSubSectionTypeEntityRecord b) {
			if (a.ssId != b.ssId) return false;
			if (a.ssLabel != b.ssLabel) return false;
			if (a.ssOrder != b.ssOrder) return false;
			if (a.ssIs_Active != b.ssIs_Active) return false;
			return true;
		}

		public static bool operator != (ENProgressReportSubSectionTypeEntityRecord a, ENProgressReportSubSectionTypeEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENProgressReportSubSectionTypeEntityRecord)) return false;
			return (this == (ENProgressReportSubSectionTypeEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssId.GetHashCode()
				^ ssLabel.GetHashCode()
				^ ssOrder.GetHashCode()
				^ ssIs_Active.GetHashCode()
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

		public ENProgressReportSubSectionTypeEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(4, true);
			OptimizedAttributes = new BitArray(4, false);
			_ssId = "";
			_ssLabel = "";
			_ssOrder = 0;
			_ssIs_Active = false;
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fields[0] .FieldType.IsSerializable)
			_ssId = (string) info.GetValue(fields[0] .Name, fields[0] .FieldType);
			if (fields[1] .FieldType.IsSerializable)
			_ssLabel = (string) info.GetValue(fields[1] .Name, fields[1] .FieldType);
			if (fields[2] .FieldType.IsSerializable)
			_ssOrder = (int) info.GetValue(fields[2] .Name, fields[2] .FieldType);
			if (fields[3] .FieldType.IsSerializable)
			_ssIs_Active = (bool) info.GetValue(fields[3] .Name, fields[3] .FieldType);
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENProgressReportSubSectionTypeEntityRecord Duplicate() {
			ENProgressReportSubSectionTypeEntityRecord t;
			t._ssId = this._ssId;
			t._ssLabel = this._ssLabel;
			t._ssOrder = this._ssOrder;
			t._ssIs_Active = this._ssIs_Active;
			t.ChangedAttributes = new BitArray(4);
			t.OptimizedAttributes = new BitArray(4);
			for (int i = 0; i < 4; i++) {
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
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Id")) VarValue.AppendAttribute(recordElem, "Id", ssId, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Id");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Label")) VarValue.AppendAttribute(recordElem, "Label", ssLabel, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Label");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Order")) VarValue.AppendAttribute(recordElem, "Order", ssOrder, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "Order");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Is_Active")) VarValue.AppendAttribute(recordElem, "Is_Active", ssIs_Active, detailLevel, TypeKind.Boolean); else VarValue.AppendOptimizedAttribute(recordElem, "Is_Active");
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
			} else if (head == "label") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Label")) variable.Value = ssLabel; else variable.Optimized = true;
			} else if (head == "order") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Order")) variable.Value = ssOrder; else variable.Optimized = true;
			} else if (head == "is_active") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Is_Active")) variable.Value = ssIs_Active; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdId)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdLabel)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdOrder)) {
				return ChangedAttributes[2];
			} else if (key.Equals(IdIs_Active)) {
				return ChangedAttributes[3];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdId)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdLabel)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdOrder)) {
				return OptimizedAttributes[2];
			} else if (key.Equals(IdIs_Active)) {
				return OptimizedAttributes[3];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdId) {
				return ssId;
			} else if (key == IdLabel) {
				return ssLabel;
			} else if (key == IdOrder) {
				return ssOrder;
			} else if (key == IdIs_Active) {
				return ssIs_Active;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(4);
			OptimizedAttributes = new BitArray(4);
			if (other == null) return;
			ssId = (string) other.AttributeGet(IdId);
			ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
			ssLabel = (string) other.AttributeGet(IdLabel);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdLabel);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdLabel);
			ssOrder = (int) other.AttributeGet(IdOrder);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdOrder);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdOrder);
			ssIs_Active = (bool) other.AttributeGet(IdIs_Active);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdIs_Active);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdIs_Active);
		}
	} // ENProgressReportSubSectionTypeEntityRecord
	/// <summary>
	/// Static Entity <code>ENProgressReportSubSectionTypeEntity</code> gets the values for this static
	///  entity records in runtime <code>ProgressReportSubSectionType</code>
	/// </summary>
	partial class ENProgressReportSubSectionTypeEntity {


		static ENProgressReportSubSectionTypeEntity() {
			ENProgressReportSubSectionTypeEntityRecordTypeFactoryImpl.InitializeFactory();
		}

		public static ENProgressReportSubSectionTypeEntityRecord GetRecordById(string id) {
			return (ENProgressReportSubSectionTypeEntityRecord) RsseSpaceCaseConferencingCore.ENProgressReportSubSectionTypeEntity.GetRecordById(id);
		}

		public static ENProgressReportSubSectionTypeEntityRecord GetRecordByName(string name) {
			return (ENProgressReportSubSectionTypeEntityRecord) RsseSpaceCaseConferencingCore.ENProgressReportSubSectionTypeEntity.GetRecordByName(name);
		}

		public static ENProgressReportSubSectionTypeEntityRecord GetRecordByKey(ObjectKey key) {
			return (ENProgressReportSubSectionTypeEntityRecord) RsseSpaceCaseConferencingCore.ENProgressReportSubSectionTypeEntity.GetRecordByKey(key);
		}
	} // ENProgressReportSubSectionTypeEntity;
	/// <summary>
	/// Structure <code>RCProgressReportSubSectionTypeRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCProgressReportSubSectionTypeRecord: ISerializable, ITypedRecord<RCProgressReportSubSectionTypeRecord> {
		private static readonly GlobalObjectKey IdProgressReportSubSectionType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*0ra5d4gvnZTwJmIMeBxGwg");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("ProgressReportSubSectionType")]
		public ENProgressReportSubSectionTypeEntityRecord ssENProgressReportSubSectionType;


		public static implicit operator ENProgressReportSubSectionTypeEntityRecord(RCProgressReportSubSectionTypeRecord r) {
			return r.ssENProgressReportSubSectionType;
		}

		public static implicit operator RCProgressReportSubSectionTypeRecord(ENProgressReportSubSectionTypeEntityRecord r) {
			RCProgressReportSubSectionTypeRecord res = new RCProgressReportSubSectionTypeRecord(null);
			res.ssENProgressReportSubSectionType = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENProgressReportSubSectionType.ChangedAttributes = value;
			}
			get {
				return ssENProgressReportSubSectionType.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCProgressReportSubSectionTypeRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENProgressReportSubSectionType = new ENProgressReportSubSectionTypeEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(4, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENProgressReportSubSectionType.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENProgressReportSubSectionType.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENProgressReportSubSectionType.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENProgressReportSubSectionType.Read(r, ref index);
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
		public void ReadIM(RCProgressReportSubSectionTypeRecord r) {
			this = r;
		}


		public static bool operator == (RCProgressReportSubSectionTypeRecord a, RCProgressReportSubSectionTypeRecord b) {
			if (a.ssENProgressReportSubSectionType != b.ssENProgressReportSubSectionType) return false;
			return true;
		}

		public static bool operator != (RCProgressReportSubSectionTypeRecord a, RCProgressReportSubSectionTypeRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCProgressReportSubSectionTypeRecord)) return false;
			return (this == (RCProgressReportSubSectionTypeRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENProgressReportSubSectionType.GetHashCode()
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

		public RCProgressReportSubSectionTypeRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENProgressReportSubSectionType = new ENProgressReportSubSectionTypeEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fields[0] .FieldType.IsSerializable)
			ssENProgressReportSubSectionType = (ENProgressReportSubSectionTypeEntityRecord) info.GetValue(fields[0] .Name, fields[0] .FieldType);
		}

		public void RecursiveReset() {
			ssENProgressReportSubSectionType.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENProgressReportSubSectionType.InternalRecursiveSave();
		}


		public RCProgressReportSubSectionTypeRecord Duplicate() {
			RCProgressReportSubSectionTypeRecord t;
			t.ssENProgressReportSubSectionType = (ENProgressReportSubSectionTypeEntityRecord) this.ssENProgressReportSubSectionType.Duplicate();
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
				ssENProgressReportSubSectionType.ToXml(this, recordElem, "ProgressReportSubSectionType", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "progressreportsubsectiontype") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ProgressReportSubSectionType")) variable.Value = ssENProgressReportSubSectionType; else variable.Optimized = true;
				variable.SetFieldName("progressreportsubsectiontype");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENProgressReportSubSectionType.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENProgressReportSubSectionType.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdProgressReportSubSectionType) {
				return ssENProgressReportSubSectionType;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENProgressReportSubSectionType.FillFromOther((IRecord) other.AttributeGet(IdProgressReportSubSectionType));
		}
	} // RCProgressReportSubSectionTypeRecord
	/// <summary>
	/// RecordList type <code>RLProgressReportSubSectionTypeRecordList</code> that represents a record list
	///  of <code>ProgressReportSubSectionType</code>
	/// </summary>
	[Serializable()]
	public partial class RLProgressReportSubSectionTypeRecordList: GenericRecordList<RCProgressReportSubSectionTypeRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCProgressReportSubSectionTypeRecord GetElementDefaultValue() {
			return new RCProgressReportSubSectionTypeRecord("");
		}

		public T[] ToArray<T>(Func<RCProgressReportSubSectionTypeRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLProgressReportSubSectionTypeRecordList recordlist, Func<RCProgressReportSubSectionTypeRecord, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLProgressReportSubSectionTypeRecordList ToList<T>(T[] array, Func <T, RCProgressReportSubSectionTypeRecord> converter) {
			RLProgressReportSubSectionTypeRecordList result = new RLProgressReportSubSectionTypeRecordList();
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
		public RLProgressReportSubSectionTypeRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLProgressReportSubSectionTypeRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLProgressReportSubSectionTypeRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLProgressReportSubSectionTypeRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(4, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCProgressReportSubSectionTypeRecord> NewList() {
			return new RLProgressReportSubSectionTypeRecordList();
		}


	} // RLProgressReportSubSectionTypeRecordList

	/// <summary>
	/// RecordList type <code>RLProgressReportSubSectionTypeList</code> that represents a record list of
	///  <code>Text, Text, Boolean, Integer</code>
	/// </summary>
	[Serializable()]
	public partial class RLProgressReportSubSectionTypeList: GenericRecordList<ENProgressReportSubSectionTypeEntityRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override ENProgressReportSubSectionTypeEntityRecord GetElementDefaultValue() {
			return new ENProgressReportSubSectionTypeEntityRecord("");
		}

		public T[] ToArray<T>(Func<ENProgressReportSubSectionTypeEntityRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLProgressReportSubSectionTypeList recordlist, Func<ENProgressReportSubSectionTypeEntityRecord, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLProgressReportSubSectionTypeList ToList<T>(T[] array, Func <T, ENProgressReportSubSectionTypeEntityRecord> converter) {
			RLProgressReportSubSectionTypeList result = new RLProgressReportSubSectionTypeList();
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
		public RLProgressReportSubSectionTypeList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLProgressReportSubSectionTypeList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLProgressReportSubSectionTypeList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLProgressReportSubSectionTypeList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[0];
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<ENProgressReportSubSectionTypeEntityRecord> NewList() {
			return new RLProgressReportSubSectionTypeList();
		}


	} // RLProgressReportSubSectionTypeList
	public partial class ExtendedActions {
		/// <summary>
		/// Action: GetProgressReportSubSectionType
		/// </summary>

		public static void GetProgressReportSubSectionType(HeContext heContext, string inParamId, out RCProgressReportSubSectionTypeRecord outParamRecord) {
			outParamRecord = new RCProgressReportSubSectionTypeRecord(null);

			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ENProgressReportSubSectionTypeEntity.eSpaceId;
				try {
					outParamRecord = ENProgressReportSubSectionTypeEntity.GetRecordById(inParamId);
				} catch {
					using(Transaction trans = DatabaseAccess.ForCurrentDatabase.GetRequestTransaction()) {
						string sql =
						 "SELECT " +
						 " [ID]" +
						 ", [LABEL]" +
						 ", [ORDER]" +
						 ", [IS_ACTIVE]" +
						 " FROM " + ENProgressReportSubSectionTypeEntity.LocalViewName(heContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale()) + " " +
						 "WHERE [ID] = @inParamId";
						Command sqlCmd = trans.CreateCommand(sql);
						sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
						using(IDataReader reader = sqlCmd.ExecuteReader("Entity Action GetProgressReportSubSectionType", true, false, false)) {
							if (reader.Read()) {
								outParamRecord.ReadDB(reader);
							} else
							throw new DataBaseException(ENProgressReportSubSectionTypeEntity.LocalViewName(heContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale()) + " with key " + inParamId + " was not found");
						}
					}
				}
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}

	}
}

namespace ssCaseConferencing {
	[XmlType("ProgressReportSubSectionType")]
	public class WORCProgressReportSubSectionTypeRecord {
		[System.Xml.Serialization.XmlElement("Id")]
		public string varWSId;

		[System.Xml.Serialization.XmlElement("Label")]
		public string varWSLabel;

		[System.Xml.Serialization.XmlElement("Order")]
		public int varWSOrder;

		[System.Xml.Serialization.XmlElement("Is_Active")]
		public bool varWSIs_Active;

		public WORCProgressReportSubSectionTypeRecord() {
			varWSId = (string) "";
			varWSLabel = (string) "";
			varWSOrder = (int) 0;
			varWSIs_Active = (bool) false;
		}

		public WORCProgressReportSubSectionTypeRecord(ENProgressReportSubSectionTypeEntityRecord r) {
			varWSId = BaseAppUtils.RemoveControlChars(r.ssId);
			varWSLabel = BaseAppUtils.RemoveControlChars(r.ssLabel);
			varWSOrder = (int) r.ssOrder;
			varWSIs_Active = (bool) r.ssIs_Active;
		}

		public static RLProgressReportSubSectionTypeList ToRecordList(WORCProgressReportSubSectionTypeRecord[] array) {
			RLProgressReportSubSectionTypeList rl = new RLProgressReportSubSectionTypeList();
			if (array != null) {
				foreach(WORCProgressReportSubSectionTypeRecord val in array) {
					rl.Append(val);
				}
			}
			return rl;
		}

		public static WORCProgressReportSubSectionTypeRecord[] FromRecordList(RLProgressReportSubSectionTypeList rl) {
			WORCProgressReportSubSectionTypeRecord[] array = new WORCProgressReportSubSectionTypeRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial struct RCProgressReportSubSectionTypeRecord {
		public static implicit operator WORCProgressReportSubSectionTypeRecord(RCProgressReportSubSectionTypeRecord r) {
			return new WORCProgressReportSubSectionTypeRecord(r.ssENProgressReportSubSectionType);
		}

		public static implicit operator RCProgressReportSubSectionTypeRecord(WORCProgressReportSubSectionTypeRecord w) {
			RCProgressReportSubSectionTypeRecord r = new RCProgressReportSubSectionTypeRecord("");
			if (w != null) {
				r.ssENProgressReportSubSectionType = w;
			}
			return r;
		}

	}

	partial struct ENProgressReportSubSectionTypeEntityRecord {
		public static implicit operator WORCProgressReportSubSectionTypeRecord(ENProgressReportSubSectionTypeEntityRecord r) {
			return new WORCProgressReportSubSectionTypeRecord(r);
		}

		public static implicit operator ENProgressReportSubSectionTypeEntityRecord(WORCProgressReportSubSectionTypeRecord w) {
			ENProgressReportSubSectionTypeEntityRecord r = new ENProgressReportSubSectionTypeEntityRecord("");
			if (w != null) {
				r.ssId = ((string) w.varWSId ?? "");
				r.ssLabel = ((string) w.varWSLabel ?? "");
				r.ssOrder = (int) w.varWSOrder;
				r.ssIs_Active = (bool) w.varWSIs_Active;
			}
			return r;
		}

	}
}


namespace ssCaseConferencing {
	[Serializable()]
	public partial class WORLProgressReportSubSectionTypeRecordList {
		public WORCProgressReportSubSectionTypeRecord[] Array;


		public WORLProgressReportSubSectionTypeRecordList(WORCProgressReportSubSectionTypeRecord[] r) {
			if (r == null)
			Array = new WORCProgressReportSubSectionTypeRecord[0];
			else
			Array = r;
		}
		public WORLProgressReportSubSectionTypeRecordList() {
			Array = new WORCProgressReportSubSectionTypeRecord[0];
		}

		public WORLProgressReportSubSectionTypeRecordList(RLProgressReportSubSectionTypeRecordList rl) {
			rl=(RLProgressReportSubSectionTypeRecordList) rl.Duplicate();
			Array = new WORCProgressReportSubSectionTypeRecord[rl.Length];
			while (!rl.Eof) {
				Array[rl.CurrentRowNumber] = new WORCProgressReportSubSectionTypeRecord(rl.CurrentRec);
				rl.Advance();
			}
		}

	}
}

namespace ssCaseConferencing {
	partial class RLProgressReportSubSectionTypeRecordList {
		public static implicit operator RLProgressReportSubSectionTypeRecordList(WORCProgressReportSubSectionTypeRecord[] array) {
			RLProgressReportSubSectionTypeRecordList rl = new RLProgressReportSubSectionTypeRecordList();
			if (array != null) {
				foreach(WORCProgressReportSubSectionTypeRecord val in array) {
					rl.Append((RCProgressReportSubSectionTypeRecord) val);
				}
			}
			return rl;
		}
		public static implicit operator WORCProgressReportSubSectionTypeRecord[](RLProgressReportSubSectionTypeRecordList rl) {
			WORCProgressReportSubSectionTypeRecord[] array = new WORCProgressReportSubSectionTypeRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = (RCProgressReportSubSectionTypeRecord) rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial class WORLProgressReportSubSectionTypeRecordList {
		public static implicit operator RLProgressReportSubSectionTypeRecordList(WORLProgressReportSubSectionTypeRecordList w) {
			return w.Array;
		}
		public static implicit operator WORLProgressReportSubSectionTypeRecordList(RLProgressReportSubSectionTypeRecordList rl) {
			return new WORLProgressReportSubSectionTypeRecordList(rl);
		}
		public static implicit operator WORCProgressReportSubSectionTypeRecord[](WORLProgressReportSubSectionTypeRecordList w) {
			if (w != null) {
				return w.Array;
			}
			return null;
		}
		public static implicit operator WORLProgressReportSubSectionTypeRecordList(WORCProgressReportSubSectionTypeRecord[] array) {
			return new WORLProgressReportSubSectionTypeRecordList(array);
		}
	}
}

