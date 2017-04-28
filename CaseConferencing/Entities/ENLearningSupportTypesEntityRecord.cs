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

	public sealed partial class ENLearningSupportTypesEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return RsseSpaceCaseConferencingCore.ENLearningSupportTypesEntity.ViewName(tenant, locale);
		}
		public const int eSpaceId = RsseSpaceCaseConferencingCore.ENLearningSupportTypesEntity.eSpaceId;
	} // ENLearningSupportTypesEntity

	/// <summary>
	/// Entity <code>ENLearningSupportTypesEntityRecord</code> that represents the Service Studio entity
	///  <code>LearningSupportTypes</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("LearningSupportTypes", "DlteY1BUMU2pFKIRtg+hxQ", "U4Zx4qCUzUe0A+0C93K3BA", 0, "OSUSR_q0e_LearningSupportTypes", "")]
	[Serializable()]
	public partial struct ENLearningSupportTypesEntityRecord: ISerializable, ITypedRecord<ENLearningSupportTypesEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("U4Zx4qCUzUe0A+0C93K3BA*+vwx77GssUKmjatCFi+qDQ");
		private static readonly GlobalObjectKey IdLabel = GlobalObjectKey.Parse("U4Zx4qCUzUe0A+0C93K3BA*uXlPuA0hEk+NVetHm5TM5Q");
		private static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("U4Zx4qCUzUe0A+0C93K3BA*+089ACsiYE6vcUdZlmW9pw");
		private static readonly GlobalObjectKey IdIs_Active = GlobalObjectKey.Parse("U4Zx4qCUzUe0A+0C93K3BA*d4Y4lepv0UOQS7I_slv2yA");

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

		public ENLearningSupportTypesEntityRecord(params string[] dummy) {
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
			ssId = r.ReadInteger(index++, "LearningSupportTypes.Id", 0);
			ssLabel = r.ReadText(index++, "LearningSupportTypes.Label", "");
			ssOrder = r.ReadInteger(index++, "LearningSupportTypes.Order", 0);
			ssIs_Active = r.ReadBoolean(index++, "LearningSupportTypes.Is_Active", false);
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
		public void ReadIM(ENLearningSupportTypesEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENLearningSupportTypesEntityRecord a, ENLearningSupportTypesEntityRecord b) {
			if (a.ssId != b.ssId) return false;
			if (a.ssLabel != b.ssLabel) return false;
			if (a.ssOrder != b.ssOrder) return false;
			if (a.ssIs_Active != b.ssIs_Active) return false;
			return true;
		}

		public static bool operator != (ENLearningSupportTypesEntityRecord a, ENLearningSupportTypesEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENLearningSupportTypesEntityRecord)) return false;
			return (this == (ENLearningSupportTypesEntityRecord) o);
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

		public ENLearningSupportTypesEntityRecord(SerializationInfo info, StreamingContext context) {
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


		public ENLearningSupportTypesEntityRecord Duplicate() {
			ENLearningSupportTypesEntityRecord t;
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
	} // ENLearningSupportTypesEntityRecord
	/// <summary>
	/// Static Entity <code>ENLearningSupportTypesEntity</code> gets the values for this static entity
	///  records in runtime <code>LearningSupportTypes</code>
	/// </summary>
	partial class ENLearningSupportTypesEntity {


		static ENLearningSupportTypesEntity() {
			ENLearningSupportTypesEntityRecordTypeFactoryImpl.InitializeFactory();
		}

		public static ENLearningSupportTypesEntityRecord GetRecordById(int id) {
			return (ENLearningSupportTypesEntityRecord) RsseSpaceCaseConferencingCore.ENLearningSupportTypesEntity.GetRecordById(id);
		}

		public static ENLearningSupportTypesEntityRecord GetRecordByName(string name) {
			return (ENLearningSupportTypesEntityRecord) RsseSpaceCaseConferencingCore.ENLearningSupportTypesEntity.GetRecordByName(name);
		}

		public static ENLearningSupportTypesEntityRecord GetRecordByKey(ObjectKey key) {
			return (ENLearningSupportTypesEntityRecord) RsseSpaceCaseConferencingCore.ENLearningSupportTypesEntity.GetRecordByKey(key);
		}
	} // ENLearningSupportTypesEntity;
	/// <summary>
	/// Structure <code>RCLearningSupportTypesRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCLearningSupportTypesRecord: ISerializable, ITypedRecord<RCLearningSupportTypesRecord> {
		private static readonly GlobalObjectKey IdLearningSupportTypes = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*3388G36NES8a3qmkQLJj4Q");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("LearningSupportTypes")]
		public ENLearningSupportTypesEntityRecord ssENLearningSupportTypes;


		public static implicit operator ENLearningSupportTypesEntityRecord(RCLearningSupportTypesRecord r) {
			return r.ssENLearningSupportTypes;
		}

		public static implicit operator RCLearningSupportTypesRecord(ENLearningSupportTypesEntityRecord r) {
			RCLearningSupportTypesRecord res = new RCLearningSupportTypesRecord(null);
			res.ssENLearningSupportTypes = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENLearningSupportTypes.ChangedAttributes = value;
			}
			get {
				return ssENLearningSupportTypes.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCLearningSupportTypesRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENLearningSupportTypes = new ENLearningSupportTypesEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(4, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENLearningSupportTypes.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENLearningSupportTypes.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENLearningSupportTypes.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENLearningSupportTypes.Read(r, ref index);
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
		public void ReadIM(RCLearningSupportTypesRecord r) {
			this = r;
		}


		public static bool operator == (RCLearningSupportTypesRecord a, RCLearningSupportTypesRecord b) {
			if (a.ssENLearningSupportTypes != b.ssENLearningSupportTypes) return false;
			return true;
		}

		public static bool operator != (RCLearningSupportTypesRecord a, RCLearningSupportTypesRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCLearningSupportTypesRecord)) return false;
			return (this == (RCLearningSupportTypesRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENLearningSupportTypes.GetHashCode()
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

		public RCLearningSupportTypesRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENLearningSupportTypes = new ENLearningSupportTypesEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fields[0] .FieldType.IsSerializable)
			ssENLearningSupportTypes = (ENLearningSupportTypesEntityRecord) info.GetValue(fields[0] .Name, fields[0] .FieldType);
		}

		public void RecursiveReset() {
			ssENLearningSupportTypes.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENLearningSupportTypes.InternalRecursiveSave();
		}


		public RCLearningSupportTypesRecord Duplicate() {
			RCLearningSupportTypesRecord t;
			t.ssENLearningSupportTypes = (ENLearningSupportTypesEntityRecord) this.ssENLearningSupportTypes.Duplicate();
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
				ssENLearningSupportTypes.ToXml(this, recordElem, "LearningSupportTypes", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "learningsupporttypes") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".LearningSupportTypes")) variable.Value = ssENLearningSupportTypes; else variable.Optimized = true;
				variable.SetFieldName("learningsupporttypes");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENLearningSupportTypes.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENLearningSupportTypes.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdLearningSupportTypes) {
				return ssENLearningSupportTypes;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENLearningSupportTypes.FillFromOther((IRecord) other.AttributeGet(IdLearningSupportTypes));
		}
	} // RCLearningSupportTypesRecord
	/// <summary>
	/// RecordList type <code>RLLearningSupportTypesRecordList</code> that represents a record list of
	///  <code>LearningSupportTypes</code>
	/// </summary>
	[Serializable()]
	public partial class RLLearningSupportTypesRecordList: GenericRecordList<RCLearningSupportTypesRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCLearningSupportTypesRecord GetElementDefaultValue() {
			return new RCLearningSupportTypesRecord("");
		}

		public T[] ToArray<T>(Func<RCLearningSupportTypesRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLLearningSupportTypesRecordList recordlist, Func<RCLearningSupportTypesRecord, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLLearningSupportTypesRecordList ToList<T>(T[] array, Func <T, RCLearningSupportTypesRecord> converter) {
			RLLearningSupportTypesRecordList result = new RLLearningSupportTypesRecordList();
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
		public RLLearningSupportTypesRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLLearningSupportTypesRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLLearningSupportTypesRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLLearningSupportTypesRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
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
		protected override OSList<RCLearningSupportTypesRecord> NewList() {
			return new RLLearningSupportTypesRecordList();
		}


	} // RLLearningSupportTypesRecordList

	/// <summary>
	/// RecordList type <code>RLLearningSupportTypesList</code> that represents a record list of
	///  <code>Text, Boolean, Integer, Integer</code>
	/// </summary>
	[Serializable()]
	public partial class RLLearningSupportTypesList: GenericRecordList<ENLearningSupportTypesEntityRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override ENLearningSupportTypesEntityRecord GetElementDefaultValue() {
			return new ENLearningSupportTypesEntityRecord("");
		}

		public T[] ToArray<T>(Func<ENLearningSupportTypesEntityRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLLearningSupportTypesList recordlist, Func<ENLearningSupportTypesEntityRecord, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLLearningSupportTypesList ToList<T>(T[] array, Func <T, ENLearningSupportTypesEntityRecord> converter) {
			RLLearningSupportTypesList result = new RLLearningSupportTypesList();
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
		public RLLearningSupportTypesList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLLearningSupportTypesList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLLearningSupportTypesList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLLearningSupportTypesList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[0];
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<ENLearningSupportTypesEntityRecord> NewList() {
			return new RLLearningSupportTypesList();
		}


	} // RLLearningSupportTypesList
	public partial class ExtendedActions {
		/// <summary>
		/// Action: GetLearningSupportTypes
		/// </summary>

		public static void GetLearningSupportTypes(HeContext heContext, int inParamId, out RCLearningSupportTypesRecord outParamRecord) {
			outParamRecord = new RCLearningSupportTypesRecord(null);

			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ENLearningSupportTypesEntity.eSpaceId;
				try {
					outParamRecord = ENLearningSupportTypesEntity.GetRecordById(inParamId);
				} catch {
					using(Transaction trans = DatabaseAccess.ForCurrentDatabase.GetRequestTransaction()) {
						string sql =
						 "SELECT " +
						 " [ID]" +
						 ", [LABEL]" +
						 ", [ORDER]" +
						 ", [IS_ACTIVE]" +
						 " FROM " + ENLearningSupportTypesEntity.LocalViewName(heContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale()) + " " +
						 "WHERE [ID] = @inParamId";
						Command sqlCmd = trans.CreateCommand(sql);
						sqlCmd.CreateParameter("@inParamId", DbType.Int32, inParamId);
						using(IDataReader reader = sqlCmd.ExecuteReader("Entity Action GetLearningSupportTypes", true, false, false)) {
							if (reader.Read()) {
								outParamRecord.ReadDB(reader);
							} else
							throw new DataBaseException(ENLearningSupportTypesEntity.LocalViewName(heContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale()) + " with key " + inParamId + " was not found");
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
	[XmlType("LearningSupportTypes")]
	public class WORCLearningSupportTypesRecord {
		[System.Xml.Serialization.XmlElement("Id")]
		public int varWSId;

		[System.Xml.Serialization.XmlElement("Label")]
		public string varWSLabel;

		[System.Xml.Serialization.XmlElement("Order")]
		public int varWSOrder;

		[System.Xml.Serialization.XmlElement("Is_Active")]
		public bool varWSIs_Active;

		public WORCLearningSupportTypesRecord() {
			varWSId = (int) 0;
			varWSLabel = (string) "";
			varWSOrder = (int) 0;
			varWSIs_Active = (bool) false;
		}

		public WORCLearningSupportTypesRecord(ENLearningSupportTypesEntityRecord r) {
			varWSId = (int) r.ssId;
			varWSLabel = BaseAppUtils.RemoveControlChars(r.ssLabel);
			varWSOrder = (int) r.ssOrder;
			varWSIs_Active = (bool) r.ssIs_Active;
		}

		public static RLLearningSupportTypesList ToRecordList(WORCLearningSupportTypesRecord[] array) {
			RLLearningSupportTypesList rl = new RLLearningSupportTypesList();
			if (array != null) {
				foreach(WORCLearningSupportTypesRecord val in array) {
					rl.Append(val);
				}
			}
			return rl;
		}

		public static WORCLearningSupportTypesRecord[] FromRecordList(RLLearningSupportTypesList rl) {
			WORCLearningSupportTypesRecord[] array = new WORCLearningSupportTypesRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial struct RCLearningSupportTypesRecord {
		public static implicit operator WORCLearningSupportTypesRecord(RCLearningSupportTypesRecord r) {
			return new WORCLearningSupportTypesRecord(r.ssENLearningSupportTypes);
		}

		public static implicit operator RCLearningSupportTypesRecord(WORCLearningSupportTypesRecord w) {
			RCLearningSupportTypesRecord r = new RCLearningSupportTypesRecord("");
			if (w != null) {
				r.ssENLearningSupportTypes = w;
			}
			return r;
		}

	}

	partial struct ENLearningSupportTypesEntityRecord {
		public static implicit operator WORCLearningSupportTypesRecord(ENLearningSupportTypesEntityRecord r) {
			return new WORCLearningSupportTypesRecord(r);
		}

		public static implicit operator ENLearningSupportTypesEntityRecord(WORCLearningSupportTypesRecord w) {
			ENLearningSupportTypesEntityRecord r = new ENLearningSupportTypesEntityRecord("");
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
	public partial class WORLLearningSupportTypesRecordList {
		public WORCLearningSupportTypesRecord[] Array;


		public WORLLearningSupportTypesRecordList(WORCLearningSupportTypesRecord[] r) {
			if (r == null)
			Array = new WORCLearningSupportTypesRecord[0];
			else
			Array = r;
		}
		public WORLLearningSupportTypesRecordList() {
			Array = new WORCLearningSupportTypesRecord[0];
		}

		public WORLLearningSupportTypesRecordList(RLLearningSupportTypesRecordList rl) {
			rl=(RLLearningSupportTypesRecordList) rl.Duplicate();
			Array = new WORCLearningSupportTypesRecord[rl.Length];
			while (!rl.Eof) {
				Array[rl.CurrentRowNumber] = new WORCLearningSupportTypesRecord(rl.CurrentRec);
				rl.Advance();
			}
		}

	}
}

namespace ssCaseConferencing {
	partial class RLLearningSupportTypesRecordList {
		public static implicit operator RLLearningSupportTypesRecordList(WORCLearningSupportTypesRecord[] array) {
			RLLearningSupportTypesRecordList rl = new RLLearningSupportTypesRecordList();
			if (array != null) {
				foreach(WORCLearningSupportTypesRecord val in array) {
					rl.Append((RCLearningSupportTypesRecord) val);
				}
			}
			return rl;
		}
		public static implicit operator WORCLearningSupportTypesRecord[](RLLearningSupportTypesRecordList rl) {
			WORCLearningSupportTypesRecord[] array = new WORCLearningSupportTypesRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = (RCLearningSupportTypesRecord) rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial class WORLLearningSupportTypesRecordList {
		public static implicit operator RLLearningSupportTypesRecordList(WORLLearningSupportTypesRecordList w) {
			return w.Array;
		}
		public static implicit operator WORLLearningSupportTypesRecordList(RLLearningSupportTypesRecordList rl) {
			return new WORLLearningSupportTypesRecordList(rl);
		}
		public static implicit operator WORCLearningSupportTypesRecord[](WORLLearningSupportTypesRecordList w) {
			if (w != null) {
				return w.Array;
			}
			return null;
		}
		public static implicit operator WORLLearningSupportTypesRecordList(WORCLearningSupportTypesRecord[] array) {
			return new WORLLearningSupportTypesRecordList(array);
		}
	}
}

