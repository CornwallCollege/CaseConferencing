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

	public sealed partial class ENTargetTypeEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return RsseSpaceCornwallCollegeData.ENTargetTypeEntity.ViewName(tenant, locale);
		}
		public const int eSpaceId = RsseSpaceCornwallCollegeData.ENTargetTypeEntity.eSpaceId;
	} // ENTargetTypeEntity

	/// <summary>
	/// Entity <code>ENTargetTypeEntityRecord</code> that represents the Service Studio entity
	///  <code>TargetType</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("TargetType", "XwRHvmp1KEe_Oz_r6xuO7A", "MHDKEnEy6kO1VcZuY5cJcA", 0, "OSUSR_bd2_TargetType", "")]
	[Serializable()]
	public partial struct ENTargetTypeEntityRecord: ISerializable, ITypedRecord<ENTargetTypeEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("MHDKEnEy6kO1VcZuY5cJcA*stB+eI5ek0ugyI8ji4xVEg");
		private static readonly GlobalObjectKey IdLabel = GlobalObjectKey.Parse("MHDKEnEy6kO1VcZuY5cJcA*2WxUxEYj60SUqIzIG9FdxA");
		private static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("MHDKEnEy6kO1VcZuY5cJcA*k23ftevZn02Y5jQ7dsFcXw");
		private static readonly GlobalObjectKey IdIs_Active = GlobalObjectKey.Parse("MHDKEnEy6kO1VcZuY5cJcA*DN2lm3tszEajOZo01fSnRQ");

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

		public ENTargetTypeEntityRecord(params string[] dummy) {
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
			ssId = r.ReadInteger(index++, "TargetType.Id", 0);
			ssLabel = r.ReadText(index++, "TargetType.Label", "");
			ssOrder = r.ReadInteger(index++, "TargetType.Order", 0);
			ssIs_Active = r.ReadBoolean(index++, "TargetType.Is_Active", false);
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
		public void ReadIM(ENTargetTypeEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENTargetTypeEntityRecord a, ENTargetTypeEntityRecord b) {
			if (a.ssId != b.ssId) return false;
			if (a.ssLabel != b.ssLabel) return false;
			if (a.ssOrder != b.ssOrder) return false;
			if (a.ssIs_Active != b.ssIs_Active) return false;
			return true;
		}

		public static bool operator != (ENTargetTypeEntityRecord a, ENTargetTypeEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENTargetTypeEntityRecord)) return false;
			return (this == (ENTargetTypeEntityRecord) o);
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

		public ENTargetTypeEntityRecord(SerializationInfo info, StreamingContext context) {
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


		public ENTargetTypeEntityRecord Duplicate() {
			ENTargetTypeEntityRecord t;
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
	} // ENTargetTypeEntityRecord
	/// <summary>
	/// Static Entity <code>ENTargetTypeEntity</code> gets the values for this static entity records in
	///  runtime <code>TargetType</code>
	/// </summary>
	partial class ENTargetTypeEntity {


		static ENTargetTypeEntity() {
			ENTargetTypeEntityRecordTypeFactoryImpl.InitializeFactory();
		}

		public static ENTargetTypeEntityRecord GetRecordById(int id) {
			return (ENTargetTypeEntityRecord) RsseSpaceCornwallCollegeData.ENTargetTypeEntity.GetRecordById(id);
		}

		public static ENTargetTypeEntityRecord GetRecordByName(string name) {
			return (ENTargetTypeEntityRecord) RsseSpaceCornwallCollegeData.ENTargetTypeEntity.GetRecordByName(name);
		}

		public static ENTargetTypeEntityRecord GetRecordByKey(ObjectKey key) {
			return (ENTargetTypeEntityRecord) RsseSpaceCornwallCollegeData.ENTargetTypeEntity.GetRecordByKey(key);
		}
	} // ENTargetTypeEntity;
	/// <summary>
	/// Structure <code>RCTargetTypeRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCTargetTypeRecord: ISerializable, ITypedRecord<RCTargetTypeRecord> {
		private static readonly GlobalObjectKey IdTargetType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T6JNzkEfecx998+9fAD+0g");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("TargetType")]
		public ENTargetTypeEntityRecord ssENTargetType;


		public static implicit operator ENTargetTypeEntityRecord(RCTargetTypeRecord r) {
			return r.ssENTargetType;
		}

		public static implicit operator RCTargetTypeRecord(ENTargetTypeEntityRecord r) {
			RCTargetTypeRecord res = new RCTargetTypeRecord(null);
			res.ssENTargetType = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENTargetType.ChangedAttributes = value;
			}
			get {
				return ssENTargetType.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCTargetTypeRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENTargetType = new ENTargetTypeEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(4, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENTargetType.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENTargetType.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENTargetType.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENTargetType.Read(r, ref index);
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
		public void ReadIM(RCTargetTypeRecord r) {
			this = r;
		}


		public static bool operator == (RCTargetTypeRecord a, RCTargetTypeRecord b) {
			if (a.ssENTargetType != b.ssENTargetType) return false;
			return true;
		}

		public static bool operator != (RCTargetTypeRecord a, RCTargetTypeRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCTargetTypeRecord)) return false;
			return (this == (RCTargetTypeRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENTargetType.GetHashCode()
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

		public RCTargetTypeRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENTargetType = new ENTargetTypeEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fields[0] .FieldType.IsSerializable)
			ssENTargetType = (ENTargetTypeEntityRecord) info.GetValue(fields[0] .Name, fields[0] .FieldType);
		}

		public void RecursiveReset() {
			ssENTargetType.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENTargetType.InternalRecursiveSave();
		}


		public RCTargetTypeRecord Duplicate() {
			RCTargetTypeRecord t;
			t.ssENTargetType = (ENTargetTypeEntityRecord) this.ssENTargetType.Duplicate();
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
				ssENTargetType.ToXml(this, recordElem, "TargetType", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "targettype") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".TargetType")) variable.Value = ssENTargetType; else variable.Optimized = true;
				variable.SetFieldName("targettype");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENTargetType.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENTargetType.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdTargetType) {
				return ssENTargetType;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENTargetType.FillFromOther((IRecord) other.AttributeGet(IdTargetType));
		}
	} // RCTargetTypeRecord
	/// <summary>
	/// RecordList type <code>RLTargetTypeRecordList</code> that represents a record list of
	///  <code>TargetType</code>
	/// </summary>
	[Serializable()]
	public partial class RLTargetTypeRecordList: GenericRecordList<RCTargetTypeRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCTargetTypeRecord GetElementDefaultValue() {
			return new RCTargetTypeRecord("");
		}

		public T[] ToArray<T>(Func<RCTargetTypeRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLTargetTypeRecordList recordlist, Func<RCTargetTypeRecord, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLTargetTypeRecordList ToList<T>(T[] array, Func <T, RCTargetTypeRecord> converter) {
			RLTargetTypeRecordList result = new RLTargetTypeRecordList();
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
		public RLTargetTypeRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLTargetTypeRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLTargetTypeRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLTargetTypeRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
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
		protected override OSList<RCTargetTypeRecord> NewList() {
			return new RLTargetTypeRecordList();
		}


	} // RLTargetTypeRecordList

	/// <summary>
	/// RecordList type <code>RLTargetTypeList</code> that represents a record list of <code>Text, Boolean,
	///  Integer, Integer</code>
	/// </summary>
	[Serializable()]
	public partial class RLTargetTypeList: GenericRecordList<ENTargetTypeEntityRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override ENTargetTypeEntityRecord GetElementDefaultValue() {
			return new ENTargetTypeEntityRecord("");
		}

		public T[] ToArray<T>(Func<ENTargetTypeEntityRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLTargetTypeList recordlist, Func<ENTargetTypeEntityRecord, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLTargetTypeList ToList<T>(T[] array, Func <T, ENTargetTypeEntityRecord> converter) {
			RLTargetTypeList result = new RLTargetTypeList();
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
		public RLTargetTypeList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLTargetTypeList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLTargetTypeList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLTargetTypeList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[0];
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<ENTargetTypeEntityRecord> NewList() {
			return new RLTargetTypeList();
		}


	} // RLTargetTypeList
	public partial class ExtendedActions {
		/// <summary>
		/// Action: GetTargetType
		/// </summary>

		public static void GetTargetType(HeContext heContext, int inParamId, out RCTargetTypeRecord outParamRecord) {
			outParamRecord = new RCTargetTypeRecord(null);

			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ENTargetTypeEntity.eSpaceId;
				try {
					outParamRecord = ENTargetTypeEntity.GetRecordById(inParamId);
				} catch {
					using(Transaction trans = DatabaseAccess.ForCurrentDatabase.GetRequestTransaction()) {
						string sql =
						 "SELECT " +
						 " [ID]" +
						 ", [LABEL]" +
						 ", [ORDER]" +
						 ", [IS_ACTIVE]" +
						 " FROM " + ENTargetTypeEntity.LocalViewName(heContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale()) + " " +
						 "WHERE [ID] = @inParamId";
						Command sqlCmd = trans.CreateCommand(sql);
						sqlCmd.CreateParameter("@inParamId", DbType.Int32, inParamId);
						using(IDataReader reader = sqlCmd.ExecuteReader("Entity Action GetTargetType", true, false, false)) {
							if (reader.Read()) {
								outParamRecord.ReadDB(reader);
							} else
							throw new DataBaseException(ENTargetTypeEntity.LocalViewName(heContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale()) + " with key " + inParamId + " was not found");
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
	[XmlType("TargetType")]
	public class WORCTargetTypeRecord {
		[System.Xml.Serialization.XmlElement("Id")]
		public int varWSId;

		[System.Xml.Serialization.XmlElement("Label")]
		public string varWSLabel;

		[System.Xml.Serialization.XmlElement("Order")]
		public int varWSOrder;

		[System.Xml.Serialization.XmlElement("Is_Active")]
		public bool varWSIs_Active;

		public WORCTargetTypeRecord() {
			varWSId = (int) 0;
			varWSLabel = (string) "";
			varWSOrder = (int) 0;
			varWSIs_Active = (bool) false;
		}

		public WORCTargetTypeRecord(ENTargetTypeEntityRecord r) {
			varWSId = (int) r.ssId;
			varWSLabel = BaseAppUtils.RemoveControlChars(r.ssLabel);
			varWSOrder = (int) r.ssOrder;
			varWSIs_Active = (bool) r.ssIs_Active;
		}

		public static RLTargetTypeList ToRecordList(WORCTargetTypeRecord[] array) {
			RLTargetTypeList rl = new RLTargetTypeList();
			if (array != null) {
				foreach(WORCTargetTypeRecord val in array) {
					rl.Append(val);
				}
			}
			return rl;
		}

		public static WORCTargetTypeRecord[] FromRecordList(RLTargetTypeList rl) {
			WORCTargetTypeRecord[] array = new WORCTargetTypeRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial struct RCTargetTypeRecord {
		public static implicit operator WORCTargetTypeRecord(RCTargetTypeRecord r) {
			return new WORCTargetTypeRecord(r.ssENTargetType);
		}

		public static implicit operator RCTargetTypeRecord(WORCTargetTypeRecord w) {
			RCTargetTypeRecord r = new RCTargetTypeRecord("");
			if (w != null) {
				r.ssENTargetType = w;
			}
			return r;
		}

	}

	partial struct ENTargetTypeEntityRecord {
		public static implicit operator WORCTargetTypeRecord(ENTargetTypeEntityRecord r) {
			return new WORCTargetTypeRecord(r);
		}

		public static implicit operator ENTargetTypeEntityRecord(WORCTargetTypeRecord w) {
			ENTargetTypeEntityRecord r = new ENTargetTypeEntityRecord("");
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
	public partial class WORLTargetTypeRecordList {
		public WORCTargetTypeRecord[] Array;


		public WORLTargetTypeRecordList(WORCTargetTypeRecord[] r) {
			if (r == null)
			Array = new WORCTargetTypeRecord[0];
			else
			Array = r;
		}
		public WORLTargetTypeRecordList() {
			Array = new WORCTargetTypeRecord[0];
		}

		public WORLTargetTypeRecordList(RLTargetTypeRecordList rl) {
			rl=(RLTargetTypeRecordList) rl.Duplicate();
			Array = new WORCTargetTypeRecord[rl.Length];
			while (!rl.Eof) {
				Array[rl.CurrentRowNumber] = new WORCTargetTypeRecord(rl.CurrentRec);
				rl.Advance();
			}
		}

	}
}

namespace ssCaseConferencing {
	partial class RLTargetTypeRecordList {
		public static implicit operator RLTargetTypeRecordList(WORCTargetTypeRecord[] array) {
			RLTargetTypeRecordList rl = new RLTargetTypeRecordList();
			if (array != null) {
				foreach(WORCTargetTypeRecord val in array) {
					rl.Append((RCTargetTypeRecord) val);
				}
			}
			return rl;
		}
		public static implicit operator WORCTargetTypeRecord[](RLTargetTypeRecordList rl) {
			WORCTargetTypeRecord[] array = new WORCTargetTypeRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = (RCTargetTypeRecord) rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial class WORLTargetTypeRecordList {
		public static implicit operator RLTargetTypeRecordList(WORLTargetTypeRecordList w) {
			return w.Array;
		}
		public static implicit operator WORLTargetTypeRecordList(RLTargetTypeRecordList rl) {
			return new WORLTargetTypeRecordList(rl);
		}
		public static implicit operator WORCTargetTypeRecord[](WORLTargetTypeRecordList w) {
			if (w != null) {
				return w.Array;
			}
			return null;
		}
		public static implicit operator WORLTargetTypeRecordList(WORCTargetTypeRecord[] array) {
			return new WORLTargetTypeRecordList(array);
		}
	}
}
