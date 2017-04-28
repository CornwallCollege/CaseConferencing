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

	public sealed partial class ENRAGStatusEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return RsseSpaceCaseConferencingCore.ENRAGStatusEntity.ViewName(tenant, locale);
		}
		public const int eSpaceId = RsseSpaceCaseConferencingCore.ENRAGStatusEntity.eSpaceId;
	} // ENRAGStatusEntity

	/// <summary>
	/// Entity <code>ENRAGStatusEntityRecord</code> that represents the Service Studio entity
	///  <code>RAGStatus</code> <p> Description: RAG Status</p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("RAGStatus", "z51u2rI57kuw_mY7ky0rFw", "U4Zx4qCUzUe0A+0C93K3BA", 0, "OSUSR_q0e_RAGStatus", "")]
	[Serializable()]
	public partial struct ENRAGStatusEntityRecord: ISerializable, ITypedRecord<ENRAGStatusEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("U4Zx4qCUzUe0A+0C93K3BA*vlyiE7VIoEm8y4cw4NvOGg");
		private static readonly GlobalObjectKey IdLabel = GlobalObjectKey.Parse("U4Zx4qCUzUe0A+0C93K3BA*_9eFxPm0hE6GrXZaGq4aLw");
		private static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("U4Zx4qCUzUe0A+0C93K3BA*YtRLfmjfEk+g_YvATZB7vA");
		private static readonly GlobalObjectKey IdIs_Active = GlobalObjectKey.Parse("U4Zx4qCUzUe0A+0C93K3BA*i3aWZ41B6kyHig0FipACLA");
		private static readonly GlobalObjectKey IdHexColor = GlobalObjectKey.Parse("U4Zx4qCUzUe0A+0C93K3BA*KsL5jWtL5kikwaaecwKBTw");

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

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("HEXCOLOR", 8, false, false, false)]
		[System.Xml.Serialization.XmlElement("HexColor")]
		private string _ssHexColor;
		public string ssHexColor {
			get {
				return _ssHexColor;
			}
			set {
				if ((_ssHexColor!=value) || OptimizedAttributes[4]) {
					ChangedAttributes[4] = true;
					_ssHexColor = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENRAGStatusEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(5, true);
			OptimizedAttributes = new BitArray(5, false);
			_ssId = "";
			_ssLabel = "";
			_ssOrder = 0;
			_ssIs_Active = false;
			_ssHexColor = "";
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
			ssId = r.ReadText(index++, "RAGStatus.Id", "");
			ssLabel = r.ReadText(index++, "RAGStatus.Label", "");
			ssOrder = r.ReadInteger(index++, "RAGStatus.Order", 0);
			ssIs_Active = r.ReadBoolean(index++, "RAGStatus.Is_Active", false);
			ssHexColor = r.ReadText(index++, "RAGStatus.HexColor", "");
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
		public void ReadIM(ENRAGStatusEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENRAGStatusEntityRecord a, ENRAGStatusEntityRecord b) {
			if (a.ssId != b.ssId) return false;
			if (a.ssLabel != b.ssLabel) return false;
			if (a.ssOrder != b.ssOrder) return false;
			if (a.ssIs_Active != b.ssIs_Active) return false;
			if (a.ssHexColor != b.ssHexColor) return false;
			return true;
		}

		public static bool operator != (ENRAGStatusEntityRecord a, ENRAGStatusEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENRAGStatusEntityRecord)) return false;
			return (this == (ENRAGStatusEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssId.GetHashCode()
				^ ssLabel.GetHashCode()
				^ ssOrder.GetHashCode()
				^ ssIs_Active.GetHashCode()
				^ ssHexColor.GetHashCode()
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

		public ENRAGStatusEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(5, true);
			OptimizedAttributes = new BitArray(5, false);
			_ssId = "";
			_ssLabel = "";
			_ssOrder = 0;
			_ssIs_Active = false;
			_ssHexColor = "";
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
			if (fields[4] .FieldType.IsSerializable)
			_ssHexColor = (string) info.GetValue(fields[4] .Name, fields[4] .FieldType);
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENRAGStatusEntityRecord Duplicate() {
			ENRAGStatusEntityRecord t;
			t._ssId = this._ssId;
			t._ssLabel = this._ssLabel;
			t._ssOrder = this._ssOrder;
			t._ssIs_Active = this._ssIs_Active;
			t._ssHexColor = this._ssHexColor;
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
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Order")) VarValue.AppendAttribute(recordElem, "Order", ssOrder, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "Order");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Is_Active")) VarValue.AppendAttribute(recordElem, "Is_Active", ssIs_Active, detailLevel, TypeKind.Boolean); else VarValue.AppendOptimizedAttribute(recordElem, "Is_Active");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".HexColor")) VarValue.AppendAttribute(recordElem, "HexColor", ssHexColor, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "HexColor");
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
			} else if (head == "hexcolor") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".HexColor")) variable.Value = ssHexColor; else variable.Optimized = true;
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
			} else if (key.Equals(IdHexColor)) {
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
			} else if (key.Equals(IdHexColor)) {
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
			} else if (key == IdHexColor) {
				return ssHexColor;
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
			ssOrder = (int) other.AttributeGet(IdOrder);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdOrder);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdOrder);
			ssIs_Active = (bool) other.AttributeGet(IdIs_Active);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdIs_Active);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdIs_Active);
			ssHexColor = (string) other.AttributeGet(IdHexColor);
			ChangedAttributes[4] = other.ChangedAttributeGet(IdHexColor);
			OptimizedAttributes[4] = other.OptimizedAttributeGet(IdHexColor);
		}
	} // ENRAGStatusEntityRecord
	/// <summary>
	/// Static Entity <code>ENRAGStatusEntity</code> gets the values for this static entity records in
	///  runtime <code>RAGStatus</code>
	/// </summary>
	partial class ENRAGStatusEntity {


		static ENRAGStatusEntity() {
			ENRAGStatusEntityRecordTypeFactoryImpl.InitializeFactory();
		}

		public static ENRAGStatusEntityRecord GetRecordById(string id) {
			return (ENRAGStatusEntityRecord) RsseSpaceCaseConferencingCore.ENRAGStatusEntity.GetRecordById(id);
		}

		public static ENRAGStatusEntityRecord GetRecordByName(string name) {
			return (ENRAGStatusEntityRecord) RsseSpaceCaseConferencingCore.ENRAGStatusEntity.GetRecordByName(name);
		}

		public static ENRAGStatusEntityRecord GetRecordByKey(ObjectKey key) {
			return (ENRAGStatusEntityRecord) RsseSpaceCaseConferencingCore.ENRAGStatusEntity.GetRecordByKey(key);
		}
	} // ENRAGStatusEntity;
	/// <summary>
	/// Structure <code>RCRAGStatusRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCRAGStatusRecord: ISerializable, ITypedRecord<RCRAGStatusRecord> {
		private static readonly GlobalObjectKey IdRAGStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*24GX8LQ_aRQhomR6Kb4nDw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("RAGStatus")]
		public ENRAGStatusEntityRecord ssENRAGStatus;


		public static implicit operator ENRAGStatusEntityRecord(RCRAGStatusRecord r) {
			return r.ssENRAGStatus;
		}

		public static implicit operator RCRAGStatusRecord(ENRAGStatusEntityRecord r) {
			RCRAGStatusRecord res = new RCRAGStatusRecord(null);
			res.ssENRAGStatus = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENRAGStatus.ChangedAttributes = value;
			}
			get {
				return ssENRAGStatus.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCRAGStatusRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENRAGStatus = new ENRAGStatusEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(5, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENRAGStatus.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENRAGStatus.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENRAGStatus.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENRAGStatus.Read(r, ref index);
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
		public void ReadIM(RCRAGStatusRecord r) {
			this = r;
		}


		public static bool operator == (RCRAGStatusRecord a, RCRAGStatusRecord b) {
			if (a.ssENRAGStatus != b.ssENRAGStatus) return false;
			return true;
		}

		public static bool operator != (RCRAGStatusRecord a, RCRAGStatusRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCRAGStatusRecord)) return false;
			return (this == (RCRAGStatusRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENRAGStatus.GetHashCode()
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

		public RCRAGStatusRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENRAGStatus = new ENRAGStatusEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fields[0] .FieldType.IsSerializable)
			ssENRAGStatus = (ENRAGStatusEntityRecord) info.GetValue(fields[0] .Name, fields[0] .FieldType);
		}

		public void RecursiveReset() {
			ssENRAGStatus.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENRAGStatus.InternalRecursiveSave();
		}


		public RCRAGStatusRecord Duplicate() {
			RCRAGStatusRecord t;
			t.ssENRAGStatus = (ENRAGStatusEntityRecord) this.ssENRAGStatus.Duplicate();
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
				ssENRAGStatus.ToXml(this, recordElem, "RAGStatus", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "ragstatus") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".RAGStatus")) variable.Value = ssENRAGStatus; else variable.Optimized = true;
				variable.SetFieldName("ragstatus");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENRAGStatus.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENRAGStatus.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdRAGStatus) {
				return ssENRAGStatus;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENRAGStatus.FillFromOther((IRecord) other.AttributeGet(IdRAGStatus));
		}
	} // RCRAGStatusRecord
	/// <summary>
	/// RecordList type <code>RLRAGStatusRecordList</code> that represents a record list of
	///  <code>RAGStatus</code>
	/// </summary>
	[Serializable()]
	public partial class RLRAGStatusRecordList: GenericRecordList<RCRAGStatusRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCRAGStatusRecord GetElementDefaultValue() {
			return new RCRAGStatusRecord("");
		}

		public T[] ToArray<T>(Func<RCRAGStatusRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLRAGStatusRecordList recordlist, Func<RCRAGStatusRecord, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLRAGStatusRecordList ToList<T>(T[] array, Func <T, RCRAGStatusRecord> converter) {
			RLRAGStatusRecordList result = new RLRAGStatusRecordList();
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
		public RLRAGStatusRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLRAGStatusRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLRAGStatusRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLRAGStatusRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
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
		protected override OSList<RCRAGStatusRecord> NewList() {
			return new RLRAGStatusRecordList();
		}


	} // RLRAGStatusRecordList

	/// <summary>
	/// RecordList type <code>RLRAGStatusList</code> that represents a record list of <code>Text, Text,
	///  Text, Boolean, Integer</code>
	/// </summary>
	[Serializable()]
	public partial class RLRAGStatusList: GenericRecordList<ENRAGStatusEntityRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override ENRAGStatusEntityRecord GetElementDefaultValue() {
			return new ENRAGStatusEntityRecord("");
		}

		public T[] ToArray<T>(Func<ENRAGStatusEntityRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLRAGStatusList recordlist, Func<ENRAGStatusEntityRecord, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLRAGStatusList ToList<T>(T[] array, Func <T, ENRAGStatusEntityRecord> converter) {
			RLRAGStatusList result = new RLRAGStatusList();
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
		public RLRAGStatusList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLRAGStatusList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLRAGStatusList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLRAGStatusList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[0];
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<ENRAGStatusEntityRecord> NewList() {
			return new RLRAGStatusList();
		}


	} // RLRAGStatusList
	public partial class ExtendedActions {
		/// <summary>
		/// Action: GetRAGStatus
		/// </summary>

		public static void GetRAGStatus(HeContext heContext, string inParamId, out RCRAGStatusRecord outParamRecord) {
			outParamRecord = new RCRAGStatusRecord(null);

			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ENRAGStatusEntity.eSpaceId;
				try {
					outParamRecord = ENRAGStatusEntity.GetRecordById(inParamId);
				} catch {
					using(Transaction trans = DatabaseAccess.ForCurrentDatabase.GetRequestTransaction()) {
						string sql =
						 "SELECT " +
						 " [ID]" +
						 ", [LABEL]" +
						 ", [ORDER]" +
						 ", [IS_ACTIVE]" +
						 ", [HEXCOLOR]" +
						 " FROM " + ENRAGStatusEntity.LocalViewName(heContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale()) + " " +
						 "WHERE [ID] = @inParamId";
						Command sqlCmd = trans.CreateCommand(sql);
						sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
						using(IDataReader reader = sqlCmd.ExecuteReader("Entity Action GetRAGStatus", true, false, false)) {
							if (reader.Read()) {
								outParamRecord.ReadDB(reader);
							} else
							throw new DataBaseException(ENRAGStatusEntity.LocalViewName(heContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale()) + " with key " + inParamId + " was not found");
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
	[XmlType("RAGStatus")]
	public class WORCRAGStatusRecord {
		[System.Xml.Serialization.XmlElement("Id")]
		public string varWSId;

		[System.Xml.Serialization.XmlElement("Label")]
		public string varWSLabel;

		[System.Xml.Serialization.XmlElement("Order")]
		public int varWSOrder;

		[System.Xml.Serialization.XmlElement("Is_Active")]
		public bool varWSIs_Active;

		[System.Xml.Serialization.XmlElement("HexColor")]
		public string varWSHexColor;

		public WORCRAGStatusRecord() {
			varWSId = (string) "";
			varWSLabel = (string) "";
			varWSOrder = (int) 0;
			varWSIs_Active = (bool) false;
			varWSHexColor = (string) "";
		}

		public WORCRAGStatusRecord(ENRAGStatusEntityRecord r) {
			varWSId = BaseAppUtils.RemoveControlChars(r.ssId);
			varWSLabel = BaseAppUtils.RemoveControlChars(r.ssLabel);
			varWSOrder = (int) r.ssOrder;
			varWSIs_Active = (bool) r.ssIs_Active;
			varWSHexColor = BaseAppUtils.RemoveControlChars(r.ssHexColor);
		}

		public static RLRAGStatusList ToRecordList(WORCRAGStatusRecord[] array) {
			RLRAGStatusList rl = new RLRAGStatusList();
			if (array != null) {
				foreach(WORCRAGStatusRecord val in array) {
					rl.Append(val);
				}
			}
			return rl;
		}

		public static WORCRAGStatusRecord[] FromRecordList(RLRAGStatusList rl) {
			WORCRAGStatusRecord[] array = new WORCRAGStatusRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial struct RCRAGStatusRecord {
		public static implicit operator WORCRAGStatusRecord(RCRAGStatusRecord r) {
			return new WORCRAGStatusRecord(r.ssENRAGStatus);
		}

		public static implicit operator RCRAGStatusRecord(WORCRAGStatusRecord w) {
			RCRAGStatusRecord r = new RCRAGStatusRecord("");
			if (w != null) {
				r.ssENRAGStatus = w;
			}
			return r;
		}

	}

	partial struct ENRAGStatusEntityRecord {
		public static implicit operator WORCRAGStatusRecord(ENRAGStatusEntityRecord r) {
			return new WORCRAGStatusRecord(r);
		}

		public static implicit operator ENRAGStatusEntityRecord(WORCRAGStatusRecord w) {
			ENRAGStatusEntityRecord r = new ENRAGStatusEntityRecord("");
			if (w != null) {
				r.ssId = ((string) w.varWSId ?? "");
				r.ssLabel = ((string) w.varWSLabel ?? "");
				r.ssOrder = (int) w.varWSOrder;
				r.ssIs_Active = (bool) w.varWSIs_Active;
				r.ssHexColor = ((string) w.varWSHexColor ?? "");
			}
			return r;
		}

	}
}


namespace ssCaseConferencing {
	[Serializable()]
	public partial class WORLRAGStatusRecordList {
		public WORCRAGStatusRecord[] Array;


		public WORLRAGStatusRecordList(WORCRAGStatusRecord[] r) {
			if (r == null)
			Array = new WORCRAGStatusRecord[0];
			else
			Array = r;
		}
		public WORLRAGStatusRecordList() {
			Array = new WORCRAGStatusRecord[0];
		}

		public WORLRAGStatusRecordList(RLRAGStatusRecordList rl) {
			rl=(RLRAGStatusRecordList) rl.Duplicate();
			Array = new WORCRAGStatusRecord[rl.Length];
			while (!rl.Eof) {
				Array[rl.CurrentRowNumber] = new WORCRAGStatusRecord(rl.CurrentRec);
				rl.Advance();
			}
		}

	}
}

namespace ssCaseConferencing {
	partial class RLRAGStatusRecordList {
		public static implicit operator RLRAGStatusRecordList(WORCRAGStatusRecord[] array) {
			RLRAGStatusRecordList rl = new RLRAGStatusRecordList();
			if (array != null) {
				foreach(WORCRAGStatusRecord val in array) {
					rl.Append((RCRAGStatusRecord) val);
				}
			}
			return rl;
		}
		public static implicit operator WORCRAGStatusRecord[](RLRAGStatusRecordList rl) {
			WORCRAGStatusRecord[] array = new WORCRAGStatusRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = (RCRAGStatusRecord) rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial class WORLRAGStatusRecordList {
		public static implicit operator RLRAGStatusRecordList(WORLRAGStatusRecordList w) {
			return w.Array;
		}
		public static implicit operator WORLRAGStatusRecordList(RLRAGStatusRecordList rl) {
			return new WORLRAGStatusRecordList(rl);
		}
		public static implicit operator WORCRAGStatusRecord[](WORLRAGStatusRecordList w) {
			if (w != null) {
				return w.Array;
			}
			return null;
		}
		public static implicit operator WORLRAGStatusRecordList(WORCRAGStatusRecord[] array) {
			return new WORLRAGStatusRecordList(array);
		}
	}
}

