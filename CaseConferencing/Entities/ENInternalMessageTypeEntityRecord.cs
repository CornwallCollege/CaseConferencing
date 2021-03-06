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

	public sealed partial class ENInternalMessageTypeEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return RsseSpaceCaseConferencingCore.ENInternalMessageTypeEntity.ViewName(tenant, locale);
		}
		public const int eSpaceId = RsseSpaceCaseConferencingCore.ENInternalMessageTypeEntity.eSpaceId;
	} // ENInternalMessageTypeEntity

	/// <summary>
	/// Entity <code>ENInternalMessageTypeEntityRecord</code> that represents the Service Studio entity
	///  <code>InternalMessageType</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("InternalMessageType", "s3iKDCJRBUWzZBcY_oddfQ", "U4Zx4qCUzUe0A+0C93K3BA", 0, "OSUSR_q0e_InternalMessageType", "")]
	[Serializable()]
	public partial struct ENInternalMessageTypeEntityRecord: ISerializable, ITypedRecord<ENInternalMessageTypeEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("U4Zx4qCUzUe0A+0C93K3BA*f43o9wTfl0ianA_QCzbicw");
		private static readonly GlobalObjectKey IdLabel = GlobalObjectKey.Parse("U4Zx4qCUzUe0A+0C93K3BA*SWaaJXsHvE+aACa2S9S6gw");
		private static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("U4Zx4qCUzUe0A+0C93K3BA*tD8TZnG4DE2EWMvQcKrMJA");
		private static readonly GlobalObjectKey IdIs_Active = GlobalObjectKey.Parse("U4Zx4qCUzUe0A+0C93K3BA*cvUKuVPjwEu+B2UbMucsGQ");

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

		public ENInternalMessageTypeEntityRecord(params string[] dummy) {
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
			ssId = r.ReadInteger(index++, "InternalMessageType.Id", 0);
			ssLabel = r.ReadText(index++, "InternalMessageType.Label", "");
			ssOrder = r.ReadInteger(index++, "InternalMessageType.Order", 0);
			ssIs_Active = r.ReadBoolean(index++, "InternalMessageType.Is_Active", false);
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
		public void ReadIM(ENInternalMessageTypeEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENInternalMessageTypeEntityRecord a, ENInternalMessageTypeEntityRecord b) {
			if (a.ssId != b.ssId) return false;
			if (a.ssLabel != b.ssLabel) return false;
			if (a.ssOrder != b.ssOrder) return false;
			if (a.ssIs_Active != b.ssIs_Active) return false;
			return true;
		}

		public static bool operator != (ENInternalMessageTypeEntityRecord a, ENInternalMessageTypeEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENInternalMessageTypeEntityRecord)) return false;
			return (this == (ENInternalMessageTypeEntityRecord) o);
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

		public ENInternalMessageTypeEntityRecord(SerializationInfo info, StreamingContext context) {
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


		public ENInternalMessageTypeEntityRecord Duplicate() {
			ENInternalMessageTypeEntityRecord t;
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
	} // ENInternalMessageTypeEntityRecord
	/// <summary>
	/// Static Entity <code>ENInternalMessageTypeEntity</code> gets the values for this static entity
	///  records in runtime <code>InternalMessageType</code>
	/// </summary>
	partial class ENInternalMessageTypeEntity {


		static ENInternalMessageTypeEntity() {
			ENInternalMessageTypeEntityRecordTypeFactoryImpl.InitializeFactory();
		}

		public static ENInternalMessageTypeEntityRecord GetRecordById(int id) {
			return (ENInternalMessageTypeEntityRecord) RsseSpaceCaseConferencingCore.ENInternalMessageTypeEntity.GetRecordById(id);
		}

		public static ENInternalMessageTypeEntityRecord GetRecordByName(string name) {
			return (ENInternalMessageTypeEntityRecord) RsseSpaceCaseConferencingCore.ENInternalMessageTypeEntity.GetRecordByName(name);
		}

		public static ENInternalMessageTypeEntityRecord GetRecordByKey(ObjectKey key) {
			return (ENInternalMessageTypeEntityRecord) RsseSpaceCaseConferencingCore.ENInternalMessageTypeEntity.GetRecordByKey(key);
		}
	} // ENInternalMessageTypeEntity;
	/// <summary>
	/// Structure <code>RCInternalMessageTypeRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCInternalMessageTypeRecord: ISerializable, ITypedRecord<RCInternalMessageTypeRecord> {
		private static readonly GlobalObjectKey IdInternalMessageType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*DkrdEGbNZAQ0p5ypgWJpGQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("InternalMessageType")]
		public ENInternalMessageTypeEntityRecord ssENInternalMessageType;


		public static implicit operator ENInternalMessageTypeEntityRecord(RCInternalMessageTypeRecord r) {
			return r.ssENInternalMessageType;
		}

		public static implicit operator RCInternalMessageTypeRecord(ENInternalMessageTypeEntityRecord r) {
			RCInternalMessageTypeRecord res = new RCInternalMessageTypeRecord(null);
			res.ssENInternalMessageType = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENInternalMessageType.ChangedAttributes = value;
			}
			get {
				return ssENInternalMessageType.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCInternalMessageTypeRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENInternalMessageType = new ENInternalMessageTypeEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(4, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENInternalMessageType.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENInternalMessageType.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENInternalMessageType.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENInternalMessageType.Read(r, ref index);
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
		public void ReadIM(RCInternalMessageTypeRecord r) {
			this = r;
		}


		public static bool operator == (RCInternalMessageTypeRecord a, RCInternalMessageTypeRecord b) {
			if (a.ssENInternalMessageType != b.ssENInternalMessageType) return false;
			return true;
		}

		public static bool operator != (RCInternalMessageTypeRecord a, RCInternalMessageTypeRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCInternalMessageTypeRecord)) return false;
			return (this == (RCInternalMessageTypeRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENInternalMessageType.GetHashCode()
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

		public RCInternalMessageTypeRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENInternalMessageType = new ENInternalMessageTypeEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fields[0] .FieldType.IsSerializable)
			ssENInternalMessageType = (ENInternalMessageTypeEntityRecord) info.GetValue(fields[0] .Name, fields[0] .FieldType);
		}

		public void RecursiveReset() {
			ssENInternalMessageType.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENInternalMessageType.InternalRecursiveSave();
		}


		public RCInternalMessageTypeRecord Duplicate() {
			RCInternalMessageTypeRecord t;
			t.ssENInternalMessageType = (ENInternalMessageTypeEntityRecord) this.ssENInternalMessageType.Duplicate();
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
				ssENInternalMessageType.ToXml(this, recordElem, "InternalMessageType", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "internalmessagetype") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".InternalMessageType")) variable.Value = ssENInternalMessageType; else variable.Optimized = true;
				variable.SetFieldName("internalmessagetype");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENInternalMessageType.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENInternalMessageType.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdInternalMessageType) {
				return ssENInternalMessageType;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENInternalMessageType.FillFromOther((IRecord) other.AttributeGet(IdInternalMessageType));
		}
	} // RCInternalMessageTypeRecord
	/// <summary>
	/// RecordList type <code>RLInternalMessageTypeRecordList</code> that represents a record list of
	///  <code>InternalMessageType</code>
	/// </summary>
	[Serializable()]
	public partial class RLInternalMessageTypeRecordList: GenericRecordList<RCInternalMessageTypeRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCInternalMessageTypeRecord GetElementDefaultValue() {
			return new RCInternalMessageTypeRecord("");
		}

		public T[] ToArray<T>(Func<RCInternalMessageTypeRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLInternalMessageTypeRecordList recordlist, Func<RCInternalMessageTypeRecord, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLInternalMessageTypeRecordList ToList<T>(T[] array, Func <T, RCInternalMessageTypeRecord> converter) {
			RLInternalMessageTypeRecordList result = new RLInternalMessageTypeRecordList();
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
		public RLInternalMessageTypeRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLInternalMessageTypeRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLInternalMessageTypeRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLInternalMessageTypeRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
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
		protected override OSList<RCInternalMessageTypeRecord> NewList() {
			return new RLInternalMessageTypeRecordList();
		}


	} // RLInternalMessageTypeRecordList

	/// <summary>
	/// RecordList type <code>RLInternalMessageTypeList</code> that represents a record list of <code>Text,
	///  Boolean, Integer, Integer</code>
	/// </summary>
	[Serializable()]
	public partial class RLInternalMessageTypeList: GenericRecordList<ENInternalMessageTypeEntityRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override ENInternalMessageTypeEntityRecord GetElementDefaultValue() {
			return new ENInternalMessageTypeEntityRecord("");
		}

		public T[] ToArray<T>(Func<ENInternalMessageTypeEntityRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLInternalMessageTypeList recordlist, Func<ENInternalMessageTypeEntityRecord, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLInternalMessageTypeList ToList<T>(T[] array, Func <T, ENInternalMessageTypeEntityRecord> converter) {
			RLInternalMessageTypeList result = new RLInternalMessageTypeList();
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
		public RLInternalMessageTypeList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLInternalMessageTypeList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLInternalMessageTypeList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLInternalMessageTypeList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[0];
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<ENInternalMessageTypeEntityRecord> NewList() {
			return new RLInternalMessageTypeList();
		}


	} // RLInternalMessageTypeList
	public partial class ExtendedActions {
		/// <summary>
		/// Action: GetInternalMessageType
		/// </summary>

		public static void GetInternalMessageType(HeContext heContext, int inParamId, out RCInternalMessageTypeRecord outParamRecord) {
			outParamRecord = new RCInternalMessageTypeRecord(null);

			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ENInternalMessageTypeEntity.eSpaceId;
				try {
					outParamRecord = ENInternalMessageTypeEntity.GetRecordById(inParamId);
				} catch {
					using(Transaction trans = DatabaseAccess.ForCurrentDatabase.GetRequestTransaction()) {
						string sql =
						 "SELECT " +
						 " [ID]" +
						 ", [LABEL]" +
						 ", [ORDER]" +
						 ", [IS_ACTIVE]" +
						 " FROM " + ENInternalMessageTypeEntity.LocalViewName(heContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale()) + " " +
						 "WHERE [ID] = @inParamId";
						Command sqlCmd = trans.CreateCommand(sql);
						sqlCmd.CreateParameter("@inParamId", DbType.Int32, inParamId);
						using(IDataReader reader = sqlCmd.ExecuteReader("Entity Action GetInternalMessageType", true, false, false)) {
							if (reader.Read()) {
								outParamRecord.ReadDB(reader);
							} else
							throw new DataBaseException(ENInternalMessageTypeEntity.LocalViewName(heContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale()) + " with key " + inParamId + " was not found");
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
	[XmlType("InternalMessageType")]
	public class WORCInternalMessageTypeRecord {
		[System.Xml.Serialization.XmlElement("Id")]
		public int varWSId;

		[System.Xml.Serialization.XmlElement("Label")]
		public string varWSLabel;

		[System.Xml.Serialization.XmlElement("Order")]
		public int varWSOrder;

		[System.Xml.Serialization.XmlElement("Is_Active")]
		public bool varWSIs_Active;

		public WORCInternalMessageTypeRecord() {
			varWSId = (int) 0;
			varWSLabel = (string) "";
			varWSOrder = (int) 0;
			varWSIs_Active = (bool) false;
		}

		public WORCInternalMessageTypeRecord(ENInternalMessageTypeEntityRecord r) {
			varWSId = (int) r.ssId;
			varWSLabel = BaseAppUtils.RemoveControlChars(r.ssLabel);
			varWSOrder = (int) r.ssOrder;
			varWSIs_Active = (bool) r.ssIs_Active;
		}

		public static RLInternalMessageTypeList ToRecordList(WORCInternalMessageTypeRecord[] array) {
			RLInternalMessageTypeList rl = new RLInternalMessageTypeList();
			if (array != null) {
				foreach(WORCInternalMessageTypeRecord val in array) {
					rl.Append(val);
				}
			}
			return rl;
		}

		public static WORCInternalMessageTypeRecord[] FromRecordList(RLInternalMessageTypeList rl) {
			WORCInternalMessageTypeRecord[] array = new WORCInternalMessageTypeRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial struct RCInternalMessageTypeRecord {
		public static implicit operator WORCInternalMessageTypeRecord(RCInternalMessageTypeRecord r) {
			return new WORCInternalMessageTypeRecord(r.ssENInternalMessageType);
		}

		public static implicit operator RCInternalMessageTypeRecord(WORCInternalMessageTypeRecord w) {
			RCInternalMessageTypeRecord r = new RCInternalMessageTypeRecord("");
			if (w != null) {
				r.ssENInternalMessageType = w;
			}
			return r;
		}

	}

	partial struct ENInternalMessageTypeEntityRecord {
		public static implicit operator WORCInternalMessageTypeRecord(ENInternalMessageTypeEntityRecord r) {
			return new WORCInternalMessageTypeRecord(r);
		}

		public static implicit operator ENInternalMessageTypeEntityRecord(WORCInternalMessageTypeRecord w) {
			ENInternalMessageTypeEntityRecord r = new ENInternalMessageTypeEntityRecord("");
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
	public partial class WORLInternalMessageTypeRecordList {
		public WORCInternalMessageTypeRecord[] Array;


		public WORLInternalMessageTypeRecordList(WORCInternalMessageTypeRecord[] r) {
			if (r == null)
			Array = new WORCInternalMessageTypeRecord[0];
			else
			Array = r;
		}
		public WORLInternalMessageTypeRecordList() {
			Array = new WORCInternalMessageTypeRecord[0];
		}

		public WORLInternalMessageTypeRecordList(RLInternalMessageTypeRecordList rl) {
			rl=(RLInternalMessageTypeRecordList) rl.Duplicate();
			Array = new WORCInternalMessageTypeRecord[rl.Length];
			while (!rl.Eof) {
				Array[rl.CurrentRowNumber] = new WORCInternalMessageTypeRecord(rl.CurrentRec);
				rl.Advance();
			}
		}

	}
}

namespace ssCaseConferencing {
	partial class RLInternalMessageTypeRecordList {
		public static implicit operator RLInternalMessageTypeRecordList(WORCInternalMessageTypeRecord[] array) {
			RLInternalMessageTypeRecordList rl = new RLInternalMessageTypeRecordList();
			if (array != null) {
				foreach(WORCInternalMessageTypeRecord val in array) {
					rl.Append((RCInternalMessageTypeRecord) val);
				}
			}
			return rl;
		}
		public static implicit operator WORCInternalMessageTypeRecord[](RLInternalMessageTypeRecordList rl) {
			WORCInternalMessageTypeRecord[] array = new WORCInternalMessageTypeRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = (RCInternalMessageTypeRecord) rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial class WORLInternalMessageTypeRecordList {
		public static implicit operator RLInternalMessageTypeRecordList(WORLInternalMessageTypeRecordList w) {
			return w.Array;
		}
		public static implicit operator WORLInternalMessageTypeRecordList(RLInternalMessageTypeRecordList rl) {
			return new WORLInternalMessageTypeRecordList(rl);
		}
		public static implicit operator WORCInternalMessageTypeRecord[](WORLInternalMessageTypeRecordList w) {
			if (w != null) {
				return w.Array;
			}
			return null;
		}
		public static implicit operator WORLInternalMessageTypeRecordList(WORCInternalMessageTypeRecord[] array) {
			return new WORLInternalMessageTypeRecordList(array);
		}
	}
}

