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

	public sealed partial class ENCategoryEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return RsseSpaceCornwallCollegeData.ENCategoryEntity.ViewName(tenant, locale);
		}
		public const int eSpaceId = RsseSpaceCornwallCollegeData.ENCategoryEntity.eSpaceId;
	} // ENCategoryEntity

	/// <summary>
	/// Entity <code>ENCategoryEntityRecord</code> that represents the Service Studio entity
	///  <code>Category</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("Category", "FZ6j_fV40EaRQLF55vZmAg", "MHDKEnEy6kO1VcZuY5cJcA", 0, "OSUSR_bd2_Category", "")]
	[Serializable()]
	public partial struct ENCategoryEntityRecord: ISerializable, ITypedRecord<ENCategoryEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("MHDKEnEy6kO1VcZuY5cJcA*QCrqXRNzvU6Ly_uJCnSAVQ");
		private static readonly GlobalObjectKey IdLabel = GlobalObjectKey.Parse("MHDKEnEy6kO1VcZuY5cJcA*iNoKwI27akCY2Mzvg+dAWw");
		private static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("MHDKEnEy6kO1VcZuY5cJcA*O88G4QIY+UG3c7dIUdjwSQ");
		private static readonly GlobalObjectKey IdIs_Active = GlobalObjectKey.Parse("MHDKEnEy6kO1VcZuY5cJcA*duTvZMILvkW5ENiqoyOfNg");
		private static readonly GlobalObjectKey IdUSPType = GlobalObjectKey.Parse("MHDKEnEy6kO1VcZuY5cJcA*XAt4Y439GEyE8iBSEKIGpQ");

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ID", 0, true, true, false)]
		[System.Xml.Serialization.XmlElement("Id")]
		private int _ssId;
		public int ssId {
			get {
				return _ssId;
			}
			set {
				if ((_ssId!=value) || OptimizedAttributes[0]) {
					ChangedAttributes = new BitArray(5, true);
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

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("USPTYPE", 50, false, false, false)]
		[System.Xml.Serialization.XmlElement("USPType")]
		private string _ssUSPType;
		public string ssUSPType {
			get {
				return _ssUSPType;
			}
			set {
				if ((_ssUSPType!=value) || OptimizedAttributes[4]) {
					ChangedAttributes[4] = true;
					_ssUSPType = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENCategoryEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(5, true);
			OptimizedAttributes = new BitArray(5, false);
			_ssId = 0;
			_ssLabel = "";
			_ssOrder = 0;
			_ssIs_Active = false;
			_ssUSPType = "";
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
			ssId = r.ReadInteger(index++, "Category.Id", 0);
			ssLabel = r.ReadText(index++, "Category.Label", "");
			ssOrder = r.ReadInteger(index++, "Category.Order", 0);
			ssIs_Active = r.ReadBoolean(index++, "Category.Is_Active", false);
			ssUSPType = r.ReadText(index++, "Category.USPType", "");
			ChangedAttributes = new BitArray(5, false);
			OptimizedAttributes = new BitArray(5, false);
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
		public void ReadIM(ENCategoryEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENCategoryEntityRecord a, ENCategoryEntityRecord b) {
			if (a.ssId != b.ssId) return false;
			if (a.ssLabel != b.ssLabel) return false;
			if (a.ssOrder != b.ssOrder) return false;
			if (a.ssIs_Active != b.ssIs_Active) return false;
			if (a.ssUSPType != b.ssUSPType) return false;
			return true;
		}

		public static bool operator != (ENCategoryEntityRecord a, ENCategoryEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENCategoryEntityRecord)) return false;
			return (this == (ENCategoryEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssId.GetHashCode()
				^ ssLabel.GetHashCode()
				^ ssOrder.GetHashCode()
				^ ssIs_Active.GetHashCode()
				^ ssUSPType.GetHashCode()
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

		public ENCategoryEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(5, true);
			OptimizedAttributes = new BitArray(5, false);
			_ssId = 0;
			_ssLabel = "";
			_ssOrder = 0;
			_ssIs_Active = false;
			_ssUSPType = "";
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
			if (fields[4] .FieldType.IsSerializable)
			_ssUSPType = (string) info.GetValue(fields[4] .Name, fields[4] .FieldType);
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENCategoryEntityRecord Duplicate() {
			ENCategoryEntityRecord t;
			t._ssId = this._ssId;
			t._ssLabel = this._ssLabel;
			t._ssOrder = this._ssOrder;
			t._ssIs_Active = this._ssIs_Active;
			t._ssUSPType = this._ssUSPType;
			t.ChangedAttributes = new BitArray(5);
			t.OptimizedAttributes = new BitArray(5);
			for (int i = 0; i < 5; i++) {
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
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".USPType")) VarValue.AppendAttribute(recordElem, "USPType", ssUSPType, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "USPType");
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
			} else if (head == "usptype") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".USPType")) variable.Value = ssUSPType; else variable.Optimized = true;
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
			} else if (key.Equals(IdUSPType)) {
				return ChangedAttributes[4];
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
			} else if (key.Equals(IdUSPType)) {
				return OptimizedAttributes[4];
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
			} else if (key == IdUSPType) {
				return ssUSPType;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(5);
			OptimizedAttributes = new BitArray(5);
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
			ssUSPType = (string) other.AttributeGet(IdUSPType);
			ChangedAttributes[4] = other.ChangedAttributeGet(IdUSPType);
			OptimizedAttributes[4] = other.OptimizedAttributeGet(IdUSPType);
		}
	} // ENCategoryEntityRecord
	/// <summary>
	/// Static Entity <code>ENCategoryEntity</code> gets the values for this static entity records in
	///  runtime <code>Category</code>
	/// </summary>
	partial class ENCategoryEntity {


		static ENCategoryEntity() {
			ENCategoryEntityRecordTypeFactoryImpl.InitializeFactory();
		}

		public static ENCategoryEntityRecord GetRecordById(int id) {
			return (ENCategoryEntityRecord) RsseSpaceCornwallCollegeData.ENCategoryEntity.GetRecordById(id);
		}

		public static ENCategoryEntityRecord GetRecordByName(string name) {
			return (ENCategoryEntityRecord) RsseSpaceCornwallCollegeData.ENCategoryEntity.GetRecordByName(name);
		}

		public static ENCategoryEntityRecord GetRecordByKey(ObjectKey key) {
			return (ENCategoryEntityRecord) RsseSpaceCornwallCollegeData.ENCategoryEntity.GetRecordByKey(key);
		}
	} // ENCategoryEntity;
	/// <summary>
	/// Structure <code>RCCategoryRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCCategoryRecord: ISerializable, ITypedRecord<RCCategoryRecord> {
		private static readonly GlobalObjectKey IdCategory = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*QOorPFvJI1gzBEfDKCy9mw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Category")]
		public ENCategoryEntityRecord ssENCategory;


		public static implicit operator ENCategoryEntityRecord(RCCategoryRecord r) {
			return r.ssENCategory;
		}

		public static implicit operator RCCategoryRecord(ENCategoryEntityRecord r) {
			RCCategoryRecord res = new RCCategoryRecord(null);
			res.ssENCategory = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENCategory.ChangedAttributes = value;
			}
			get {
				return ssENCategory.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCCategoryRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENCategory = new ENCategoryEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(5, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENCategory.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENCategory.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENCategory.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENCategory.Read(r, ref index);
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
		public void ReadIM(RCCategoryRecord r) {
			this = r;
		}


		public static bool operator == (RCCategoryRecord a, RCCategoryRecord b) {
			if (a.ssENCategory != b.ssENCategory) return false;
			return true;
		}

		public static bool operator != (RCCategoryRecord a, RCCategoryRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCCategoryRecord)) return false;
			return (this == (RCCategoryRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENCategory.GetHashCode()
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

		public RCCategoryRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENCategory = new ENCategoryEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fields[0] .FieldType.IsSerializable)
			ssENCategory = (ENCategoryEntityRecord) info.GetValue(fields[0] .Name, fields[0] .FieldType);
		}

		public void RecursiveReset() {
			ssENCategory.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENCategory.InternalRecursiveSave();
		}


		public RCCategoryRecord Duplicate() {
			RCCategoryRecord t;
			t.ssENCategory = (ENCategoryEntityRecord) this.ssENCategory.Duplicate();
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
				ssENCategory.ToXml(this, recordElem, "Category", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "category") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Category")) variable.Value = ssENCategory; else variable.Optimized = true;
				variable.SetFieldName("category");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENCategory.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENCategory.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdCategory) {
				return ssENCategory;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENCategory.FillFromOther((IRecord) other.AttributeGet(IdCategory));
		}
	} // RCCategoryRecord
	/// <summary>
	/// RecordList type <code>RLCategoryRecordList</code> that represents a record list of
	///  <code>Category</code>
	/// </summary>
	[Serializable()]
	public partial class RLCategoryRecordList: GenericRecordList<RCCategoryRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCCategoryRecord GetElementDefaultValue() {
			return new RCCategoryRecord("");
		}

		public T[] ToArray<T>(Func<RCCategoryRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLCategoryRecordList recordlist, Func<RCCategoryRecord, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLCategoryRecordList ToList<T>(T[] array, Func <T, RCCategoryRecord> converter) {
			RLCategoryRecordList result = new RLCategoryRecordList();
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
		public RLCategoryRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLCategoryRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLCategoryRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLCategoryRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(5, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCCategoryRecord> NewList() {
			return new RLCategoryRecordList();
		}


	} // RLCategoryRecordList

	/// <summary>
	/// RecordList type <code>RLCategoryList</code> that represents a record list of <code>Text, Text,
	///  Boolean, Integer, Integer</code>
	/// </summary>
	[Serializable()]
	public partial class RLCategoryList: GenericRecordList<ENCategoryEntityRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override ENCategoryEntityRecord GetElementDefaultValue() {
			return new ENCategoryEntityRecord("");
		}

		public T[] ToArray<T>(Func<ENCategoryEntityRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLCategoryList recordlist, Func<ENCategoryEntityRecord, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLCategoryList ToList<T>(T[] array, Func <T, ENCategoryEntityRecord> converter) {
			RLCategoryList result = new RLCategoryList();
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
		public RLCategoryList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLCategoryList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLCategoryList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLCategoryList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[0];
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<ENCategoryEntityRecord> NewList() {
			return new RLCategoryList();
		}


	} // RLCategoryList
	public partial class ExtendedActions {
		/// <summary>
		/// Action: GetCategory
		/// </summary>

		public static void GetCategory(HeContext heContext, int inParamId, out RCCategoryRecord outParamRecord) {
			outParamRecord = new RCCategoryRecord(null);

			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ENCategoryEntity.eSpaceId;
				try {
					outParamRecord = ENCategoryEntity.GetRecordById(inParamId);
				} catch {
					using(Transaction trans = DatabaseAccess.ForCurrentDatabase.GetRequestTransaction()) {
						string sql =
						 "SELECT " +
						 " [ID]" +
						 ", [LABEL]" +
						 ", [ORDER]" +
						 ", [IS_ACTIVE]" +
						 ", [USPTYPE]" +
						 " FROM " + ENCategoryEntity.LocalViewName(heContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale()) + " " +
						 "WHERE [ID] = @inParamId";
						Command sqlCmd = trans.CreateCommand(sql);
						sqlCmd.CreateParameter("@inParamId", DbType.Int32, inParamId);
						using(IDataReader reader = sqlCmd.ExecuteReader("Entity Action GetCategory", true, false, false)) {
							if (reader.Read()) {
								outParamRecord.ReadDB(reader);
							} else
							throw new DataBaseException(ENCategoryEntity.LocalViewName(heContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale()) + " with key " + inParamId + " was not found");
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
	[XmlType("Category")]
	public class WORCCategoryRecord {
		[System.Xml.Serialization.XmlElement("Id")]
		public int varWSId;

		[System.Xml.Serialization.XmlElement("Label")]
		public string varWSLabel;

		[System.Xml.Serialization.XmlElement("Order")]
		public int varWSOrder;

		[System.Xml.Serialization.XmlElement("Is_Active")]
		public bool varWSIs_Active;

		[System.Xml.Serialization.XmlElement("USPType")]
		public string varWSUSPType;

		public WORCCategoryRecord() {
			varWSId = (int) 0;
			varWSLabel = (string) "";
			varWSOrder = (int) 0;
			varWSIs_Active = (bool) false;
			varWSUSPType = (string) "";
		}

		public WORCCategoryRecord(ENCategoryEntityRecord r) {
			varWSId = (int) r.ssId;
			varWSLabel = BaseAppUtils.RemoveControlChars(r.ssLabel);
			varWSOrder = (int) r.ssOrder;
			varWSIs_Active = (bool) r.ssIs_Active;
			varWSUSPType = BaseAppUtils.RemoveControlChars(r.ssUSPType);
		}

		public static RLCategoryList ToRecordList(WORCCategoryRecord[] array) {
			RLCategoryList rl = new RLCategoryList();
			if (array != null) {
				foreach(WORCCategoryRecord val in array) {
					rl.Append(val);
				}
			}
			return rl;
		}

		public static WORCCategoryRecord[] FromRecordList(RLCategoryList rl) {
			WORCCategoryRecord[] array = new WORCCategoryRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial struct RCCategoryRecord {
		public static implicit operator WORCCategoryRecord(RCCategoryRecord r) {
			return new WORCCategoryRecord(r.ssENCategory);
		}

		public static implicit operator RCCategoryRecord(WORCCategoryRecord w) {
			RCCategoryRecord r = new RCCategoryRecord("");
			if (w != null) {
				r.ssENCategory = w;
			}
			return r;
		}

	}

	partial struct ENCategoryEntityRecord {
		public static implicit operator WORCCategoryRecord(ENCategoryEntityRecord r) {
			return new WORCCategoryRecord(r);
		}

		public static implicit operator ENCategoryEntityRecord(WORCCategoryRecord w) {
			ENCategoryEntityRecord r = new ENCategoryEntityRecord("");
			if (w != null) {
				r.ssId = (int) w.varWSId;
				r.ssLabel = ((string) w.varWSLabel ?? "");
				r.ssOrder = (int) w.varWSOrder;
				r.ssIs_Active = (bool) w.varWSIs_Active;
				r.ssUSPType = ((string) w.varWSUSPType ?? "");
			}
			return r;
		}

	}
}


namespace ssCaseConferencing {
	[Serializable()]
	public partial class WORLCategoryRecordList {
		public WORCCategoryRecord[] Array;


		public WORLCategoryRecordList(WORCCategoryRecord[] r) {
			if (r == null)
			Array = new WORCCategoryRecord[0];
			else
			Array = r;
		}
		public WORLCategoryRecordList() {
			Array = new WORCCategoryRecord[0];
		}

		public WORLCategoryRecordList(RLCategoryRecordList rl) {
			rl=(RLCategoryRecordList) rl.Duplicate();
			Array = new WORCCategoryRecord[rl.Length];
			while (!rl.Eof) {
				Array[rl.CurrentRowNumber] = new WORCCategoryRecord(rl.CurrentRec);
				rl.Advance();
			}
		}

	}
}

namespace ssCaseConferencing {
	partial class RLCategoryRecordList {
		public static implicit operator RLCategoryRecordList(WORCCategoryRecord[] array) {
			RLCategoryRecordList rl = new RLCategoryRecordList();
			if (array != null) {
				foreach(WORCCategoryRecord val in array) {
					rl.Append((RCCategoryRecord) val);
				}
			}
			return rl;
		}
		public static implicit operator WORCCategoryRecord[](RLCategoryRecordList rl) {
			WORCCategoryRecord[] array = new WORCCategoryRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = (RCCategoryRecord) rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial class WORLCategoryRecordList {
		public static implicit operator RLCategoryRecordList(WORLCategoryRecordList w) {
			return w.Array;
		}
		public static implicit operator WORLCategoryRecordList(RLCategoryRecordList rl) {
			return new WORLCategoryRecordList(rl);
		}
		public static implicit operator WORCCategoryRecord[](WORLCategoryRecordList w) {
			if (w != null) {
				return w.Array;
			}
			return null;
		}
		public static implicit operator WORLCategoryRecordList(WORCCategoryRecord[] array) {
			return new WORLCategoryRecordList(array);
		}
	}
}

