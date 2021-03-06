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

	public sealed partial class ENTargetStatusEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return RsseSpaceCornwallCollegeData.ENTargetStatusEntity.ViewName(tenant, locale);
		}
		public const int eSpaceId = RsseSpaceCornwallCollegeData.ENTargetStatusEntity.eSpaceId;
	} // ENTargetStatusEntity

	/// <summary>
	/// Entity <code>ENTargetStatusEntityRecord</code> that represents the Service Studio entity
	///  <code>TargetStatus</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("TargetStatus", "DlGjP5jRDUi+X6aCRzhWmQ", "MHDKEnEy6kO1VcZuY5cJcA", 0, "OSUSR_bd2_TargetStatus", "")]
	[Serializable()]
	public partial struct ENTargetStatusEntityRecord: ISerializable, ITypedRecord<ENTargetStatusEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("MHDKEnEy6kO1VcZuY5cJcA*eJfki3slFUmoYAMTT37JcQ");
		private static readonly GlobalObjectKey IdLabel = GlobalObjectKey.Parse("MHDKEnEy6kO1VcZuY5cJcA*GKpS2sRDz0Wkd7iR4zFnZg");
		private static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("MHDKEnEy6kO1VcZuY5cJcA*Ixn8HtVSr0KIbU9w5j9FKg");
		private static readonly GlobalObjectKey IdIs_Active = GlobalObjectKey.Parse("MHDKEnEy6kO1VcZuY5cJcA*zPEI9bQqLUG1Kn2EJ8lH3A");

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ID", 0, true, true, false)]
		[System.Xml.Serialization.XmlElement("Id")]
		private int _ssId;
		public int ssId {
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

		public ENTargetStatusEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(4, true);
			OptimizedAttributes = new BitArray(4, false);
			_ssId = 0;
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
			ssId = r.ReadInteger(index++, "TargetStatus.Id", 0);
			ssLabel = r.ReadText(index++, "TargetStatus.Label", "");
			ssOrder = r.ReadInteger(index++, "TargetStatus.Order", 0);
			ssIs_Active = r.ReadBoolean(index++, "TargetStatus.Is_Active", false);
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
		public void ReadIM(ENTargetStatusEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENTargetStatusEntityRecord a, ENTargetStatusEntityRecord b) {
			if (a.ssId != b.ssId) return false;
			if (a.ssLabel != b.ssLabel) return false;
			if (a.ssOrder != b.ssOrder) return false;
			if (a.ssIs_Active != b.ssIs_Active) return false;
			return true;
		}

		public static bool operator != (ENTargetStatusEntityRecord a, ENTargetStatusEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENTargetStatusEntityRecord)) return false;
			return (this == (ENTargetStatusEntityRecord) o);
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

		public ENTargetStatusEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(4, true);
			OptimizedAttributes = new BitArray(4, false);
			_ssId = 0;
			_ssLabel = "";
			_ssOrder = 0;
			_ssIs_Active = false;
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fields[0] .FieldType.IsSerializable)
			_ssId = (int) info.GetValue(fields[0] .Name, fields[0] .FieldType);
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


		public ENTargetStatusEntityRecord Duplicate() {
			ENTargetStatusEntityRecord t;
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
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Id")) VarValue.AppendAttribute(recordElem, "Id", ssId, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "Id");
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
			ssId = (int) other.AttributeGet(IdId);
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
	} // ENTargetStatusEntityRecord
	/// <summary>
	/// Static Entity <code>ENTargetStatusEntity</code> gets the values for this static entity records in
	///  runtime <code>TargetStatus</code>
	/// </summary>
	partial class ENTargetStatusEntity {


		static ENTargetStatusEntity() {
			ENTargetStatusEntityRecordTypeFactoryImpl.InitializeFactory();
		}

		public static ENTargetStatusEntityRecord GetRecordById(int id) {
			return (ENTargetStatusEntityRecord) RsseSpaceCornwallCollegeData.ENTargetStatusEntity.GetRecordById(id);
		}

		public static ENTargetStatusEntityRecord GetRecordByName(string name) {
			return (ENTargetStatusEntityRecord) RsseSpaceCornwallCollegeData.ENTargetStatusEntity.GetRecordByName(name);
		}

		public static ENTargetStatusEntityRecord GetRecordByKey(ObjectKey key) {
			return (ENTargetStatusEntityRecord) RsseSpaceCornwallCollegeData.ENTargetStatusEntity.GetRecordByKey(key);
		}
	} // ENTargetStatusEntity;
	/// <summary>
	/// Structure <code>RCTargetStatusRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCTargetStatusRecord: ISerializable, ITypedRecord<RCTargetStatusRecord> {
		private static readonly GlobalObjectKey IdTargetStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NM7jinYNANDuvBkwxohD0Q");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("TargetStatus")]
		public ENTargetStatusEntityRecord ssENTargetStatus;


		public static implicit operator ENTargetStatusEntityRecord(RCTargetStatusRecord r) {
			return r.ssENTargetStatus;
		}

		public static implicit operator RCTargetStatusRecord(ENTargetStatusEntityRecord r) {
			RCTargetStatusRecord res = new RCTargetStatusRecord(null);
			res.ssENTargetStatus = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENTargetStatus.ChangedAttributes = value;
			}
			get {
				return ssENTargetStatus.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCTargetStatusRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENTargetStatus = new ENTargetStatusEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(4, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENTargetStatus.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENTargetStatus.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENTargetStatus.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENTargetStatus.Read(r, ref index);
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
		public void ReadIM(RCTargetStatusRecord r) {
			this = r;
		}


		public static bool operator == (RCTargetStatusRecord a, RCTargetStatusRecord b) {
			if (a.ssENTargetStatus != b.ssENTargetStatus) return false;
			return true;
		}

		public static bool operator != (RCTargetStatusRecord a, RCTargetStatusRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCTargetStatusRecord)) return false;
			return (this == (RCTargetStatusRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENTargetStatus.GetHashCode()
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

		public RCTargetStatusRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENTargetStatus = new ENTargetStatusEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fields[0] .FieldType.IsSerializable)
			ssENTargetStatus = (ENTargetStatusEntityRecord) info.GetValue(fields[0] .Name, fields[0] .FieldType);
		}

		public void RecursiveReset() {
			ssENTargetStatus.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENTargetStatus.InternalRecursiveSave();
		}


		public RCTargetStatusRecord Duplicate() {
			RCTargetStatusRecord t;
			t.ssENTargetStatus = (ENTargetStatusEntityRecord) this.ssENTargetStatus.Duplicate();
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
				ssENTargetStatus.ToXml(this, recordElem, "TargetStatus", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "targetstatus") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".TargetStatus")) variable.Value = ssENTargetStatus; else variable.Optimized = true;
				variable.SetFieldName("targetstatus");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENTargetStatus.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENTargetStatus.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdTargetStatus) {
				return ssENTargetStatus;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENTargetStatus.FillFromOther((IRecord) other.AttributeGet(IdTargetStatus));
		}
	} // RCTargetStatusRecord
	/// <summary>
	/// RecordList type <code>RLTargetStatusRecordList</code> that represents a record list of
	///  <code>TargetStatus</code>
	/// </summary>
	[Serializable()]
	public partial class RLTargetStatusRecordList: GenericRecordList<RCTargetStatusRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCTargetStatusRecord GetElementDefaultValue() {
			return new RCTargetStatusRecord("");
		}

		public T[] ToArray<T>(Func<RCTargetStatusRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLTargetStatusRecordList recordlist, Func<RCTargetStatusRecord, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLTargetStatusRecordList ToList<T>(T[] array, Func <T, RCTargetStatusRecord> converter) {
			RLTargetStatusRecordList result = new RLTargetStatusRecordList();
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
		public RLTargetStatusRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLTargetStatusRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLTargetStatusRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLTargetStatusRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
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
		protected override OSList<RCTargetStatusRecord> NewList() {
			return new RLTargetStatusRecordList();
		}


	} // RLTargetStatusRecordList

	/// <summary>
	/// RecordList type <code>RLTargetStatusList</code> that represents a record list of <code>Text,
	///  Boolean, Integer, Integer</code>
	/// </summary>
	[Serializable()]
	public partial class RLTargetStatusList: GenericRecordList<ENTargetStatusEntityRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override ENTargetStatusEntityRecord GetElementDefaultValue() {
			return new ENTargetStatusEntityRecord("");
		}

		public T[] ToArray<T>(Func<ENTargetStatusEntityRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLTargetStatusList recordlist, Func<ENTargetStatusEntityRecord, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLTargetStatusList ToList<T>(T[] array, Func <T, ENTargetStatusEntityRecord> converter) {
			RLTargetStatusList result = new RLTargetStatusList();
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
		public RLTargetStatusList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLTargetStatusList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLTargetStatusList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLTargetStatusList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[0];
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<ENTargetStatusEntityRecord> NewList() {
			return new RLTargetStatusList();
		}


	} // RLTargetStatusList
	public partial class ExtendedActions {
		/// <summary>
		/// Action: GetTargetStatus
		/// </summary>

		public static void GetTargetStatus(HeContext heContext, int inParamId, out RCTargetStatusRecord outParamRecord) {
			outParamRecord = new RCTargetStatusRecord(null);

			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ENTargetStatusEntity.eSpaceId;
				try {
					outParamRecord = ENTargetStatusEntity.GetRecordById(inParamId);
				} catch {
					using(Transaction trans = DatabaseAccess.ForCurrentDatabase.GetRequestTransaction()) {
						string sql =
						 "SELECT " +
						 " [ID]" +
						 ", [LABEL]" +
						 ", [ORDER]" +
						 ", [IS_ACTIVE]" +
						 " FROM " + ENTargetStatusEntity.LocalViewName(heContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale()) + " " +
						 "WHERE [ID] = @inParamId";
						Command sqlCmd = trans.CreateCommand(sql);
						sqlCmd.CreateParameter("@inParamId", DbType.Int32, inParamId);
						using(IDataReader reader = sqlCmd.ExecuteReader("Entity Action GetTargetStatus", true, false, false)) {
							if (reader.Read()) {
								outParamRecord.ReadDB(reader);
							} else
							throw new DataBaseException(ENTargetStatusEntity.LocalViewName(heContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale()) + " with key " + inParamId + " was not found");
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
	[XmlType("TargetStatus")]
	public class WORCTargetStatusRecord {
		[System.Xml.Serialization.XmlElement("Id")]
		public int varWSId;

		[System.Xml.Serialization.XmlElement("Label")]
		public string varWSLabel;

		[System.Xml.Serialization.XmlElement("Order")]
		public int varWSOrder;

		[System.Xml.Serialization.XmlElement("Is_Active")]
		public bool varWSIs_Active;

		public WORCTargetStatusRecord() {
			varWSId = (int) 0;
			varWSLabel = (string) "";
			varWSOrder = (int) 0;
			varWSIs_Active = (bool) false;
		}

		public WORCTargetStatusRecord(ENTargetStatusEntityRecord r) {
			varWSId = (int) r.ssId;
			varWSLabel = BaseAppUtils.RemoveControlChars(r.ssLabel);
			varWSOrder = (int) r.ssOrder;
			varWSIs_Active = (bool) r.ssIs_Active;
		}

		public static RLTargetStatusList ToRecordList(WORCTargetStatusRecord[] array) {
			RLTargetStatusList rl = new RLTargetStatusList();
			if (array != null) {
				foreach(WORCTargetStatusRecord val in array) {
					rl.Append(val);
				}
			}
			return rl;
		}

		public static WORCTargetStatusRecord[] FromRecordList(RLTargetStatusList rl) {
			WORCTargetStatusRecord[] array = new WORCTargetStatusRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial struct RCTargetStatusRecord {
		public static implicit operator WORCTargetStatusRecord(RCTargetStatusRecord r) {
			return new WORCTargetStatusRecord(r.ssENTargetStatus);
		}

		public static implicit operator RCTargetStatusRecord(WORCTargetStatusRecord w) {
			RCTargetStatusRecord r = new RCTargetStatusRecord("");
			if (w != null) {
				r.ssENTargetStatus = w;
			}
			return r;
		}

	}

	partial struct ENTargetStatusEntityRecord {
		public static implicit operator WORCTargetStatusRecord(ENTargetStatusEntityRecord r) {
			return new WORCTargetStatusRecord(r);
		}

		public static implicit operator ENTargetStatusEntityRecord(WORCTargetStatusRecord w) {
			ENTargetStatusEntityRecord r = new ENTargetStatusEntityRecord("");
			if (w != null) {
				r.ssId = (int) w.varWSId;
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
	public partial class WORLTargetStatusRecordList {
		public WORCTargetStatusRecord[] Array;


		public WORLTargetStatusRecordList(WORCTargetStatusRecord[] r) {
			if (r == null)
			Array = new WORCTargetStatusRecord[0];
			else
			Array = r;
		}
		public WORLTargetStatusRecordList() {
			Array = new WORCTargetStatusRecord[0];
		}

		public WORLTargetStatusRecordList(RLTargetStatusRecordList rl) {
			rl=(RLTargetStatusRecordList) rl.Duplicate();
			Array = new WORCTargetStatusRecord[rl.Length];
			while (!rl.Eof) {
				Array[rl.CurrentRowNumber] = new WORCTargetStatusRecord(rl.CurrentRec);
				rl.Advance();
			}
		}

	}
}

namespace ssCaseConferencing {
	partial class RLTargetStatusRecordList {
		public static implicit operator RLTargetStatusRecordList(WORCTargetStatusRecord[] array) {
			RLTargetStatusRecordList rl = new RLTargetStatusRecordList();
			if (array != null) {
				foreach(WORCTargetStatusRecord val in array) {
					rl.Append((RCTargetStatusRecord) val);
				}
			}
			return rl;
		}
		public static implicit operator WORCTargetStatusRecord[](RLTargetStatusRecordList rl) {
			WORCTargetStatusRecord[] array = new WORCTargetStatusRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = (RCTargetStatusRecord) rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial class WORLTargetStatusRecordList {
		public static implicit operator RLTargetStatusRecordList(WORLTargetStatusRecordList w) {
			return w.Array;
		}
		public static implicit operator WORLTargetStatusRecordList(RLTargetStatusRecordList rl) {
			return new WORLTargetStatusRecordList(rl);
		}
		public static implicit operator WORCTargetStatusRecord[](WORLTargetStatusRecordList w) {
			if (w != null) {
				return w.Array;
			}
			return null;
		}
		public static implicit operator WORLTargetStatusRecordList(WORCTargetStatusRecord[] array) {
			return new WORLTargetStatusRecordList(array);
		}
	}
}

