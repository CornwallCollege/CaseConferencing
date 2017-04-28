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

	public sealed partial class ENMLWStagesEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return RsseSpaceCaseConferencingCore.ENMLWStagesEntity.ViewName(tenant, locale);
		}
		public const int eSpaceId = RsseSpaceCaseConferencingCore.ENMLWStagesEntity.eSpaceId;
	} // ENMLWStagesEntity

	/// <summary>
	/// Entity <code>ENMLWStagesEntityRecord</code> that represents the Service Studio entity
	///  <code>MLWStages</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("MLWStages", "Ap8k_UWpM0SPGXglEiWQpg", "U4Zx4qCUzUe0A+0C93K3BA", 0, "OSUSR_q0e_MLWStages", "")]
	[Serializable()]
	public partial struct ENMLWStagesEntityRecord: ISerializable, ITypedRecord<ENMLWStagesEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("U4Zx4qCUzUe0A+0C93K3BA*2dg1NvJJwk28hGHDykUEZg");
		private static readonly GlobalObjectKey IdLabel = GlobalObjectKey.Parse("U4Zx4qCUzUe0A+0C93K3BA*rOP4vZs5NkSnlWAW2YP3HQ");
		private static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("U4Zx4qCUzUe0A+0C93K3BA*Jj5Fb9_LC0KPaohjzd2sJA");
		private static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("U4Zx4qCUzUe0A+0C93K3BA*NjAfS7f0_0+M7u8nr8qUmg");
		private static readonly GlobalObjectKey IdIs_Active = GlobalObjectKey.Parse("U4Zx4qCUzUe0A+0C93K3BA*xD1un6+JTUqxFS9ob59hEg");

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ID", 50, false, true, false)]
		[System.Xml.Serialization.XmlElement("Id")]
		private string _ssId;
		public string ssId {
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

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("DESCRIPTION", 100, false, false, false)]
		[System.Xml.Serialization.XmlElement("Description")]
		private string _ssDescription;
		public string ssDescription {
			get {
				return _ssDescription;
			}
			set {
				if ((_ssDescription!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssDescription = value;
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
				if ((_ssOrder!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
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
				if ((_ssIs_Active!=value) || OptimizedAttributes[4]) {
					ChangedAttributes[4] = true;
					_ssIs_Active = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENMLWStagesEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(5, true);
			OptimizedAttributes = new BitArray(5, false);
			_ssId = "";
			_ssLabel = "";
			_ssDescription = "";
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
			ssId = r.ReadText(index++, "MLWStages.Id", "");
			ssLabel = r.ReadText(index++, "MLWStages.Label", "");
			ssDescription = r.ReadText(index++, "MLWStages.Description", "");
			ssOrder = r.ReadInteger(index++, "MLWStages.Order", 0);
			ssIs_Active = r.ReadBoolean(index++, "MLWStages.Is_Active", false);
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
		public void ReadIM(ENMLWStagesEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENMLWStagesEntityRecord a, ENMLWStagesEntityRecord b) {
			if (a.ssId != b.ssId) return false;
			if (a.ssLabel != b.ssLabel) return false;
			if (a.ssDescription != b.ssDescription) return false;
			if (a.ssOrder != b.ssOrder) return false;
			if (a.ssIs_Active != b.ssIs_Active) return false;
			return true;
		}

		public static bool operator != (ENMLWStagesEntityRecord a, ENMLWStagesEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENMLWStagesEntityRecord)) return false;
			return (this == (ENMLWStagesEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssId.GetHashCode()
				^ ssLabel.GetHashCode()
				^ ssDescription.GetHashCode()
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

		public ENMLWStagesEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(5, true);
			OptimizedAttributes = new BitArray(5, false);
			_ssId = "";
			_ssLabel = "";
			_ssDescription = "";
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
			_ssDescription = (string) info.GetValue(fields[2] .Name, fields[2] .FieldType);
			if (fields[3] .FieldType.IsSerializable)
			_ssOrder = (int) info.GetValue(fields[3] .Name, fields[3] .FieldType);
			if (fields[4] .FieldType.IsSerializable)
			_ssIs_Active = (bool) info.GetValue(fields[4] .Name, fields[4] .FieldType);
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENMLWStagesEntityRecord Duplicate() {
			ENMLWStagesEntityRecord t;
			t._ssId = this._ssId;
			t._ssLabel = this._ssLabel;
			t._ssDescription = this._ssDescription;
			t._ssOrder = this._ssOrder;
			t._ssIs_Active = this._ssIs_Active;
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
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Id")) VarValue.AppendAttribute(recordElem, "Id", ssId, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Id");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Label")) VarValue.AppendAttribute(recordElem, "Label", ssLabel, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Label");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Description")) VarValue.AppendAttribute(recordElem, "Description", ssDescription, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Description");
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
			} else if (head == "description") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Description")) variable.Value = ssDescription; else variable.Optimized = true;
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
			} else if (key.Equals(IdDescription)) {
				return ChangedAttributes[2];
			} else if (key.Equals(IdOrder)) {
				return ChangedAttributes[3];
			} else if (key.Equals(IdIs_Active)) {
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
			} else if (key.Equals(IdDescription)) {
				return OptimizedAttributes[2];
			} else if (key.Equals(IdOrder)) {
				return OptimizedAttributes[3];
			} else if (key.Equals(IdIs_Active)) {
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
			} else if (key == IdDescription) {
				return ssDescription;
			} else if (key == IdOrder) {
				return ssOrder;
			} else if (key == IdIs_Active) {
				return ssIs_Active;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(5);
			OptimizedAttributes = new BitArray(5);
			if (other == null) return;
			ssId = (string) other.AttributeGet(IdId);
			ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
			ssLabel = (string) other.AttributeGet(IdLabel);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdLabel);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdLabel);
			ssDescription = (string) other.AttributeGet(IdDescription);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdDescription);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdDescription);
			ssOrder = (int) other.AttributeGet(IdOrder);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdOrder);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdOrder);
			ssIs_Active = (bool) other.AttributeGet(IdIs_Active);
			ChangedAttributes[4] = other.ChangedAttributeGet(IdIs_Active);
			OptimizedAttributes[4] = other.OptimizedAttributeGet(IdIs_Active);
		}
	} // ENMLWStagesEntityRecord
	/// <summary>
	/// Static Entity <code>ENMLWStagesEntity</code> gets the values for this static entity records in
	///  runtime <code>MLWStages</code>
	/// </summary>
	partial class ENMLWStagesEntity {


		static ENMLWStagesEntity() {
			ENMLWStagesEntityRecordTypeFactoryImpl.InitializeFactory();
		}

		public static ENMLWStagesEntityRecord GetRecordById(string id) {
			return (ENMLWStagesEntityRecord) RsseSpaceCaseConferencingCore.ENMLWStagesEntity.GetRecordById(id);
		}

		public static ENMLWStagesEntityRecord GetRecordByName(string name) {
			return (ENMLWStagesEntityRecord) RsseSpaceCaseConferencingCore.ENMLWStagesEntity.GetRecordByName(name);
		}

		public static ENMLWStagesEntityRecord GetRecordByKey(ObjectKey key) {
			return (ENMLWStagesEntityRecord) RsseSpaceCaseConferencingCore.ENMLWStagesEntity.GetRecordByKey(key);
		}
	} // ENMLWStagesEntity;
	/// <summary>
	/// Structure <code>RCMLWStagesRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCMLWStagesRecord: ISerializable, ITypedRecord<RCMLWStagesRecord> {
		private static readonly GlobalObjectKey IdMLWStages = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*C8s83aVO1M6A5QcMoEeldg");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("MLWStages")]
		public ENMLWStagesEntityRecord ssENMLWStages;


		public static implicit operator ENMLWStagesEntityRecord(RCMLWStagesRecord r) {
			return r.ssENMLWStages;
		}

		public static implicit operator RCMLWStagesRecord(ENMLWStagesEntityRecord r) {
			RCMLWStagesRecord res = new RCMLWStagesRecord(null);
			res.ssENMLWStages = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENMLWStages.ChangedAttributes = value;
			}
			get {
				return ssENMLWStages.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCMLWStagesRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENMLWStages = new ENMLWStagesEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(5, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENMLWStages.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENMLWStages.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENMLWStages.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENMLWStages.Read(r, ref index);
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
		public void ReadIM(RCMLWStagesRecord r) {
			this = r;
		}


		public static bool operator == (RCMLWStagesRecord a, RCMLWStagesRecord b) {
			if (a.ssENMLWStages != b.ssENMLWStages) return false;
			return true;
		}

		public static bool operator != (RCMLWStagesRecord a, RCMLWStagesRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCMLWStagesRecord)) return false;
			return (this == (RCMLWStagesRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENMLWStages.GetHashCode()
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

		public RCMLWStagesRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENMLWStages = new ENMLWStagesEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fields[0] .FieldType.IsSerializable)
			ssENMLWStages = (ENMLWStagesEntityRecord) info.GetValue(fields[0] .Name, fields[0] .FieldType);
		}

		public void RecursiveReset() {
			ssENMLWStages.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENMLWStages.InternalRecursiveSave();
		}


		public RCMLWStagesRecord Duplicate() {
			RCMLWStagesRecord t;
			t.ssENMLWStages = (ENMLWStagesEntityRecord) this.ssENMLWStages.Duplicate();
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
				ssENMLWStages.ToXml(this, recordElem, "MLWStages", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "mlwstages") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".MLWStages")) variable.Value = ssENMLWStages; else variable.Optimized = true;
				variable.SetFieldName("mlwstages");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENMLWStages.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENMLWStages.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdMLWStages) {
				return ssENMLWStages;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENMLWStages.FillFromOther((IRecord) other.AttributeGet(IdMLWStages));
		}
	} // RCMLWStagesRecord
	/// <summary>
	/// RecordList type <code>RLMLWStagesRecordList</code> that represents a record list of
	///  <code>MLWStages</code>
	/// </summary>
	[Serializable()]
	public partial class RLMLWStagesRecordList: GenericRecordList<RCMLWStagesRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCMLWStagesRecord GetElementDefaultValue() {
			return new RCMLWStagesRecord("");
		}

		public T[] ToArray<T>(Func<RCMLWStagesRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLMLWStagesRecordList recordlist, Func<RCMLWStagesRecord, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLMLWStagesRecordList ToList<T>(T[] array, Func <T, RCMLWStagesRecord> converter) {
			RLMLWStagesRecordList result = new RLMLWStagesRecordList();
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
		public RLMLWStagesRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLMLWStagesRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLMLWStagesRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLMLWStagesRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
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
		protected override OSList<RCMLWStagesRecord> NewList() {
			return new RLMLWStagesRecordList();
		}


	} // RLMLWStagesRecordList

	/// <summary>
	/// RecordList type <code>RLMLWStagesList</code> that represents a record list of <code>Text, Text,
	///  Text, Boolean, Integer</code>
	/// </summary>
	[Serializable()]
	public partial class RLMLWStagesList: GenericRecordList<ENMLWStagesEntityRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override ENMLWStagesEntityRecord GetElementDefaultValue() {
			return new ENMLWStagesEntityRecord("");
		}

		public T[] ToArray<T>(Func<ENMLWStagesEntityRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLMLWStagesList recordlist, Func<ENMLWStagesEntityRecord, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLMLWStagesList ToList<T>(T[] array, Func <T, ENMLWStagesEntityRecord> converter) {
			RLMLWStagesList result = new RLMLWStagesList();
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
		public RLMLWStagesList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLMLWStagesList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLMLWStagesList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLMLWStagesList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[0];
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<ENMLWStagesEntityRecord> NewList() {
			return new RLMLWStagesList();
		}


	} // RLMLWStagesList
	public partial class ExtendedActions {
		/// <summary>
		/// Action: GetMLWStages
		/// </summary>

		public static void GetMLWStages(HeContext heContext, string inParamId, out RCMLWStagesRecord outParamRecord) {
			outParamRecord = new RCMLWStagesRecord(null);

			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ENMLWStagesEntity.eSpaceId;
				try {
					outParamRecord = ENMLWStagesEntity.GetRecordById(inParamId);
				} catch {
					using(Transaction trans = DatabaseAccess.ForCurrentDatabase.GetRequestTransaction()) {
						string sql =
						 "SELECT " +
						 " [ID]" +
						 ", [LABEL]" +
						 ", [DESCRIPTION]" +
						 ", [ORDER]" +
						 ", [IS_ACTIVE]" +
						 " FROM " + ENMLWStagesEntity.LocalViewName(heContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale()) + " " +
						 "WHERE [ID] = @inParamId";
						Command sqlCmd = trans.CreateCommand(sql);
						sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
						using(IDataReader reader = sqlCmd.ExecuteReader("Entity Action GetMLWStages", true, false, false)) {
							if (reader.Read()) {
								outParamRecord.ReadDB(reader);
							} else
							throw new DataBaseException(ENMLWStagesEntity.LocalViewName(heContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale()) + " with key " + inParamId + " was not found");
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
	[XmlType("MLWStages")]
	public class WORCMLWStagesRecord {
		[System.Xml.Serialization.XmlElement("Id")]
		public string varWSId;

		[System.Xml.Serialization.XmlElement("Label")]
		public string varWSLabel;

		[System.Xml.Serialization.XmlElement("Description")]
		public string varWSDescription;

		[System.Xml.Serialization.XmlElement("Order")]
		public int varWSOrder;

		[System.Xml.Serialization.XmlElement("Is_Active")]
		public bool varWSIs_Active;

		public WORCMLWStagesRecord() {
			varWSId = (string) "";
			varWSLabel = (string) "";
			varWSDescription = (string) "";
			varWSOrder = (int) 0;
			varWSIs_Active = (bool) false;
		}

		public WORCMLWStagesRecord(ENMLWStagesEntityRecord r) {
			varWSId = BaseAppUtils.RemoveControlChars(r.ssId);
			varWSLabel = BaseAppUtils.RemoveControlChars(r.ssLabel);
			varWSDescription = BaseAppUtils.RemoveControlChars(r.ssDescription);
			varWSOrder = (int) r.ssOrder;
			varWSIs_Active = (bool) r.ssIs_Active;
		}

		public static RLMLWStagesList ToRecordList(WORCMLWStagesRecord[] array) {
			RLMLWStagesList rl = new RLMLWStagesList();
			if (array != null) {
				foreach(WORCMLWStagesRecord val in array) {
					rl.Append(val);
				}
			}
			return rl;
		}

		public static WORCMLWStagesRecord[] FromRecordList(RLMLWStagesList rl) {
			WORCMLWStagesRecord[] array = new WORCMLWStagesRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial struct RCMLWStagesRecord {
		public static implicit operator WORCMLWStagesRecord(RCMLWStagesRecord r) {
			return new WORCMLWStagesRecord(r.ssENMLWStages);
		}

		public static implicit operator RCMLWStagesRecord(WORCMLWStagesRecord w) {
			RCMLWStagesRecord r = new RCMLWStagesRecord("");
			if (w != null) {
				r.ssENMLWStages = w;
			}
			return r;
		}

	}

	partial struct ENMLWStagesEntityRecord {
		public static implicit operator WORCMLWStagesRecord(ENMLWStagesEntityRecord r) {
			return new WORCMLWStagesRecord(r);
		}

		public static implicit operator ENMLWStagesEntityRecord(WORCMLWStagesRecord w) {
			ENMLWStagesEntityRecord r = new ENMLWStagesEntityRecord("");
			if (w != null) {
				r.ssId = ((string) w.varWSId ?? "");
				r.ssLabel = ((string) w.varWSLabel ?? "");
				r.ssDescription = ((string) w.varWSDescription ?? "");
				r.ssOrder = (int) w.varWSOrder;
				r.ssIs_Active = (bool) w.varWSIs_Active;
			}
			return r;
		}

	}
}


namespace ssCaseConferencing {
	[Serializable()]
	public partial class WORLMLWStagesRecordList {
		public WORCMLWStagesRecord[] Array;


		public WORLMLWStagesRecordList(WORCMLWStagesRecord[] r) {
			if (r == null)
			Array = new WORCMLWStagesRecord[0];
			else
			Array = r;
		}
		public WORLMLWStagesRecordList() {
			Array = new WORCMLWStagesRecord[0];
		}

		public WORLMLWStagesRecordList(RLMLWStagesRecordList rl) {
			rl=(RLMLWStagesRecordList) rl.Duplicate();
			Array = new WORCMLWStagesRecord[rl.Length];
			while (!rl.Eof) {
				Array[rl.CurrentRowNumber] = new WORCMLWStagesRecord(rl.CurrentRec);
				rl.Advance();
			}
		}

	}
}

namespace ssCaseConferencing {
	partial class RLMLWStagesRecordList {
		public static implicit operator RLMLWStagesRecordList(WORCMLWStagesRecord[] array) {
			RLMLWStagesRecordList rl = new RLMLWStagesRecordList();
			if (array != null) {
				foreach(WORCMLWStagesRecord val in array) {
					rl.Append((RCMLWStagesRecord) val);
				}
			}
			return rl;
		}
		public static implicit operator WORCMLWStagesRecord[](RLMLWStagesRecordList rl) {
			WORCMLWStagesRecord[] array = new WORCMLWStagesRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = (RCMLWStagesRecord) rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial class WORLMLWStagesRecordList {
		public static implicit operator RLMLWStagesRecordList(WORLMLWStagesRecordList w) {
			return w.Array;
		}
		public static implicit operator WORLMLWStagesRecordList(RLMLWStagesRecordList rl) {
			return new WORLMLWStagesRecordList(rl);
		}
		public static implicit operator WORCMLWStagesRecord[](WORLMLWStagesRecordList w) {
			if (w != null) {
				return w.Array;
			}
			return null;
		}
		public static implicit operator WORLMLWStagesRecordList(WORCMLWStagesRecord[] array) {
			return new WORLMLWStagesRecordList(array);
		}
	}
}
