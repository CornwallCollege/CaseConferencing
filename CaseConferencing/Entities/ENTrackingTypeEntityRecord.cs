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

	public sealed partial class ENTrackingTypeEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return RsseSpaceCornwallCollegeData.ENTrackingTypeEntity.ViewName(tenant, locale);
		}
		public const int eSpaceId = RsseSpaceCornwallCollegeData.ENTrackingTypeEntity.eSpaceId;
	} // ENTrackingTypeEntity

	/// <summary>
	/// Entity <code>ENTrackingTypeEntityRecord</code> that represents the Service Studio entity
	///  <code>TrackingType</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("TrackingType", "ImGjNEvk4UGdc42LHZUWsw", "MHDKEnEy6kO1VcZuY5cJcA", 0, "OSUSR_bd2_TrackingType", "")]
	[Serializable()]
	public partial struct ENTrackingTypeEntityRecord: ISerializable, ITypedRecord<ENTrackingTypeEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("MHDKEnEy6kO1VcZuY5cJcA*yUXyakUDyEyaZpPYshjzKA");
		private static readonly GlobalObjectKey IdLabel = GlobalObjectKey.Parse("MHDKEnEy6kO1VcZuY5cJcA*oJQ_vAynVkuMyyh_q4O9dg");
		private static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("MHDKEnEy6kO1VcZuY5cJcA*hXnX8G4QHEiljJQumXCpfA");
		private static readonly GlobalObjectKey IdIs_Active = GlobalObjectKey.Parse("MHDKEnEy6kO1VcZuY5cJcA*ytM+iKpNV0CU_XWet0OjFg");

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

		public ENTrackingTypeEntityRecord(params string[] dummy) {
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
			ssId = r.ReadText(index++, "TrackingType.Id", "");
			ssLabel = r.ReadText(index++, "TrackingType.Label", "");
			ssOrder = r.ReadInteger(index++, "TrackingType.Order", 0);
			ssIs_Active = r.ReadBoolean(index++, "TrackingType.Is_Active", false);
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
		public void ReadIM(ENTrackingTypeEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENTrackingTypeEntityRecord a, ENTrackingTypeEntityRecord b) {
			if (a.ssId != b.ssId) return false;
			if (a.ssLabel != b.ssLabel) return false;
			if (a.ssOrder != b.ssOrder) return false;
			if (a.ssIs_Active != b.ssIs_Active) return false;
			return true;
		}

		public static bool operator != (ENTrackingTypeEntityRecord a, ENTrackingTypeEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENTrackingTypeEntityRecord)) return false;
			return (this == (ENTrackingTypeEntityRecord) o);
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

		public ENTrackingTypeEntityRecord(SerializationInfo info, StreamingContext context) {
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


		public ENTrackingTypeEntityRecord Duplicate() {
			ENTrackingTypeEntityRecord t;
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
	} // ENTrackingTypeEntityRecord
	/// <summary>
	/// Static Entity <code>ENTrackingTypeEntity</code> gets the values for this static entity records in
	///  runtime <code>TrackingType</code>
	/// </summary>
	partial class ENTrackingTypeEntity {


		static ENTrackingTypeEntity() {
			ENTrackingTypeEntityRecordTypeFactoryImpl.InitializeFactory();
		}

		public static ENTrackingTypeEntityRecord GetRecordById(string id) {
			return (ENTrackingTypeEntityRecord) RsseSpaceCornwallCollegeData.ENTrackingTypeEntity.GetRecordById(id);
		}

		public static ENTrackingTypeEntityRecord GetRecordByName(string name) {
			return (ENTrackingTypeEntityRecord) RsseSpaceCornwallCollegeData.ENTrackingTypeEntity.GetRecordByName(name);
		}

		public static ENTrackingTypeEntityRecord GetRecordByKey(ObjectKey key) {
			return (ENTrackingTypeEntityRecord) RsseSpaceCornwallCollegeData.ENTrackingTypeEntity.GetRecordByKey(key);
		}
	} // ENTrackingTypeEntity;
	/// <summary>
	/// Structure <code>RCTrackingTypeRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCTrackingTypeRecord: ISerializable, ITypedRecord<RCTrackingTypeRecord> {
		private static readonly GlobalObjectKey IdTrackingType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Sfe1fxqn7A2pjcOM2yWqNg");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("TrackingType")]
		public ENTrackingTypeEntityRecord ssENTrackingType;


		public static implicit operator ENTrackingTypeEntityRecord(RCTrackingTypeRecord r) {
			return r.ssENTrackingType;
		}

		public static implicit operator RCTrackingTypeRecord(ENTrackingTypeEntityRecord r) {
			RCTrackingTypeRecord res = new RCTrackingTypeRecord(null);
			res.ssENTrackingType = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENTrackingType.ChangedAttributes = value;
			}
			get {
				return ssENTrackingType.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCTrackingTypeRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENTrackingType = new ENTrackingTypeEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(4, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENTrackingType.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENTrackingType.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENTrackingType.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENTrackingType.Read(r, ref index);
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
		public void ReadIM(RCTrackingTypeRecord r) {
			this = r;
		}


		public static bool operator == (RCTrackingTypeRecord a, RCTrackingTypeRecord b) {
			if (a.ssENTrackingType != b.ssENTrackingType) return false;
			return true;
		}

		public static bool operator != (RCTrackingTypeRecord a, RCTrackingTypeRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCTrackingTypeRecord)) return false;
			return (this == (RCTrackingTypeRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENTrackingType.GetHashCode()
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

		public RCTrackingTypeRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENTrackingType = new ENTrackingTypeEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fields[0] .FieldType.IsSerializable)
			ssENTrackingType = (ENTrackingTypeEntityRecord) info.GetValue(fields[0] .Name, fields[0] .FieldType);
		}

		public void RecursiveReset() {
			ssENTrackingType.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENTrackingType.InternalRecursiveSave();
		}


		public RCTrackingTypeRecord Duplicate() {
			RCTrackingTypeRecord t;
			t.ssENTrackingType = (ENTrackingTypeEntityRecord) this.ssENTrackingType.Duplicate();
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
				ssENTrackingType.ToXml(this, recordElem, "TrackingType", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "trackingtype") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".TrackingType")) variable.Value = ssENTrackingType; else variable.Optimized = true;
				variable.SetFieldName("trackingtype");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENTrackingType.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENTrackingType.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdTrackingType) {
				return ssENTrackingType;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENTrackingType.FillFromOther((IRecord) other.AttributeGet(IdTrackingType));
		}
	} // RCTrackingTypeRecord
	/// <summary>
	/// RecordList type <code>RLTrackingTypeRecordList</code> that represents a record list of
	///  <code>TrackingType</code>
	/// </summary>
	[Serializable()]
	public partial class RLTrackingTypeRecordList: GenericRecordList<RCTrackingTypeRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCTrackingTypeRecord GetElementDefaultValue() {
			return new RCTrackingTypeRecord("");
		}

		public T[] ToArray<T>(Func<RCTrackingTypeRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLTrackingTypeRecordList recordlist, Func<RCTrackingTypeRecord, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLTrackingTypeRecordList ToList<T>(T[] array, Func <T, RCTrackingTypeRecord> converter) {
			RLTrackingTypeRecordList result = new RLTrackingTypeRecordList();
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
		public RLTrackingTypeRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLTrackingTypeRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLTrackingTypeRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLTrackingTypeRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
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
		protected override OSList<RCTrackingTypeRecord> NewList() {
			return new RLTrackingTypeRecordList();
		}


	} // RLTrackingTypeRecordList

	/// <summary>
	/// RecordList type <code>RLTrackingTypeList</code> that represents a record list of <code>Text, Text,
	///  Boolean, Integer</code>
	/// </summary>
	[Serializable()]
	public partial class RLTrackingTypeList: GenericRecordList<ENTrackingTypeEntityRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override ENTrackingTypeEntityRecord GetElementDefaultValue() {
			return new ENTrackingTypeEntityRecord("");
		}

		public T[] ToArray<T>(Func<ENTrackingTypeEntityRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLTrackingTypeList recordlist, Func<ENTrackingTypeEntityRecord, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLTrackingTypeList ToList<T>(T[] array, Func <T, ENTrackingTypeEntityRecord> converter) {
			RLTrackingTypeList result = new RLTrackingTypeList();
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
		public RLTrackingTypeList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLTrackingTypeList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLTrackingTypeList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLTrackingTypeList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[0];
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<ENTrackingTypeEntityRecord> NewList() {
			return new RLTrackingTypeList();
		}


	} // RLTrackingTypeList
	public partial class ExtendedActions {
		/// <summary>
		/// Action: GetTrackingType
		/// </summary>

		public static void GetTrackingType(HeContext heContext, string inParamId, out RCTrackingTypeRecord outParamRecord) {
			outParamRecord = new RCTrackingTypeRecord(null);

			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ENTrackingTypeEntity.eSpaceId;
				try {
					outParamRecord = ENTrackingTypeEntity.GetRecordById(inParamId);
				} catch {
					using(Transaction trans = DatabaseAccess.ForCurrentDatabase.GetRequestTransaction()) {
						string sql =
						 "SELECT " +
						 " [ID]" +
						 ", [LABEL]" +
						 ", [ORDER]" +
						 ", [IS_ACTIVE]" +
						 " FROM " + ENTrackingTypeEntity.LocalViewName(heContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale()) + " " +
						 "WHERE [ID] = @inParamId";
						Command sqlCmd = trans.CreateCommand(sql);
						sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
						using(IDataReader reader = sqlCmd.ExecuteReader("Entity Action GetTrackingType", true, false, false)) {
							if (reader.Read()) {
								outParamRecord.ReadDB(reader);
							} else
							throw new DataBaseException(ENTrackingTypeEntity.LocalViewName(heContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale()) + " with key " + inParamId + " was not found");
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
	[XmlType("TrackingType")]
	public class WORCTrackingTypeRecord {
		[System.Xml.Serialization.XmlElement("Id")]
		public string varWSId;

		[System.Xml.Serialization.XmlElement("Label")]
		public string varWSLabel;

		[System.Xml.Serialization.XmlElement("Order")]
		public int varWSOrder;

		[System.Xml.Serialization.XmlElement("Is_Active")]
		public bool varWSIs_Active;

		public WORCTrackingTypeRecord() {
			varWSId = (string) "";
			varWSLabel = (string) "";
			varWSOrder = (int) 0;
			varWSIs_Active = (bool) false;
		}

		public WORCTrackingTypeRecord(ENTrackingTypeEntityRecord r) {
			varWSId = BaseAppUtils.RemoveControlChars(r.ssId);
			varWSLabel = BaseAppUtils.RemoveControlChars(r.ssLabel);
			varWSOrder = (int) r.ssOrder;
			varWSIs_Active = (bool) r.ssIs_Active;
		}

		public static RLTrackingTypeList ToRecordList(WORCTrackingTypeRecord[] array) {
			RLTrackingTypeList rl = new RLTrackingTypeList();
			if (array != null) {
				foreach(WORCTrackingTypeRecord val in array) {
					rl.Append(val);
				}
			}
			return rl;
		}

		public static WORCTrackingTypeRecord[] FromRecordList(RLTrackingTypeList rl) {
			WORCTrackingTypeRecord[] array = new WORCTrackingTypeRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial struct RCTrackingTypeRecord {
		public static implicit operator WORCTrackingTypeRecord(RCTrackingTypeRecord r) {
			return new WORCTrackingTypeRecord(r.ssENTrackingType);
		}

		public static implicit operator RCTrackingTypeRecord(WORCTrackingTypeRecord w) {
			RCTrackingTypeRecord r = new RCTrackingTypeRecord("");
			if (w != null) {
				r.ssENTrackingType = w;
			}
			return r;
		}

	}

	partial struct ENTrackingTypeEntityRecord {
		public static implicit operator WORCTrackingTypeRecord(ENTrackingTypeEntityRecord r) {
			return new WORCTrackingTypeRecord(r);
		}

		public static implicit operator ENTrackingTypeEntityRecord(WORCTrackingTypeRecord w) {
			ENTrackingTypeEntityRecord r = new ENTrackingTypeEntityRecord("");
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
	public partial class WORLTrackingTypeRecordList {
		public WORCTrackingTypeRecord[] Array;


		public WORLTrackingTypeRecordList(WORCTrackingTypeRecord[] r) {
			if (r == null)
			Array = new WORCTrackingTypeRecord[0];
			else
			Array = r;
		}
		public WORLTrackingTypeRecordList() {
			Array = new WORCTrackingTypeRecord[0];
		}

		public WORLTrackingTypeRecordList(RLTrackingTypeRecordList rl) {
			rl=(RLTrackingTypeRecordList) rl.Duplicate();
			Array = new WORCTrackingTypeRecord[rl.Length];
			while (!rl.Eof) {
				Array[rl.CurrentRowNumber] = new WORCTrackingTypeRecord(rl.CurrentRec);
				rl.Advance();
			}
		}

	}
}

namespace ssCaseConferencing {
	partial class RLTrackingTypeRecordList {
		public static implicit operator RLTrackingTypeRecordList(WORCTrackingTypeRecord[] array) {
			RLTrackingTypeRecordList rl = new RLTrackingTypeRecordList();
			if (array != null) {
				foreach(WORCTrackingTypeRecord val in array) {
					rl.Append((RCTrackingTypeRecord) val);
				}
			}
			return rl;
		}
		public static implicit operator WORCTrackingTypeRecord[](RLTrackingTypeRecordList rl) {
			WORCTrackingTypeRecord[] array = new WORCTrackingTypeRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = (RCTrackingTypeRecord) rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial class WORLTrackingTypeRecordList {
		public static implicit operator RLTrackingTypeRecordList(WORLTrackingTypeRecordList w) {
			return w.Array;
		}
		public static implicit operator WORLTrackingTypeRecordList(RLTrackingTypeRecordList rl) {
			return new WORLTrackingTypeRecordList(rl);
		}
		public static implicit operator WORCTrackingTypeRecord[](WORLTrackingTypeRecordList w) {
			if (w != null) {
				return w.Array;
			}
			return null;
		}
		public static implicit operator WORLTrackingTypeRecordList(WORCTrackingTypeRecord[] array) {
			return new WORLTrackingTypeRecordList(array);
		}
	}
}

