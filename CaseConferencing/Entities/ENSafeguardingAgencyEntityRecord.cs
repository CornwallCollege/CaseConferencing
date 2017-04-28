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

	public sealed partial class ENSafeguardingAgencyEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return RsseSpaceCaseConferencingCore.ENSafeguardingAgencyEntity.ViewName(tenant, locale);
		}
		public const int eSpaceId = RsseSpaceCaseConferencingCore.ENSafeguardingAgencyEntity.eSpaceId;
	} // ENSafeguardingAgencyEntity

	/// <summary>
	/// Entity <code>ENSafeguardingAgencyEntityRecord</code> that represents the Service Studio entity
	///  <code>SafeguardingAgency</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("SafeguardingAgency", "hK3V6Trl20iTKN0_RFpCFA", "U4Zx4qCUzUe0A+0C93K3BA", 0, "OSUSR_q0e_SafeguardingAgency", "")]
	[Serializable()]
	public partial struct ENSafeguardingAgencyEntityRecord: ISerializable, ITypedRecord<ENSafeguardingAgencyEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("U4Zx4qCUzUe0A+0C93K3BA*Y16CFew3okSmsNGts4w19w");
		private static readonly GlobalObjectKey IdLabel = GlobalObjectKey.Parse("U4Zx4qCUzUe0A+0C93K3BA*xa1CLHNAUkGYEFUtudGZIw");
		private static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("U4Zx4qCUzUe0A+0C93K3BA*4hFFcBlB10K2JrHqaTJWKg");
		private static readonly GlobalObjectKey IdIs_Active = GlobalObjectKey.Parse("U4Zx4qCUzUe0A+0C93K3BA*8wtLnH_DnkSmKzurb+3HAg");

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

		public ENSafeguardingAgencyEntityRecord(params string[] dummy) {
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
			ssId = r.ReadText(index++, "SafeguardingAgency.Id", "");
			ssLabel = r.ReadText(index++, "SafeguardingAgency.Label", "");
			ssOrder = r.ReadInteger(index++, "SafeguardingAgency.Order", 0);
			ssIs_Active = r.ReadBoolean(index++, "SafeguardingAgency.Is_Active", false);
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
		public void ReadIM(ENSafeguardingAgencyEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENSafeguardingAgencyEntityRecord a, ENSafeguardingAgencyEntityRecord b) {
			if (a.ssId != b.ssId) return false;
			if (a.ssLabel != b.ssLabel) return false;
			if (a.ssOrder != b.ssOrder) return false;
			if (a.ssIs_Active != b.ssIs_Active) return false;
			return true;
		}

		public static bool operator != (ENSafeguardingAgencyEntityRecord a, ENSafeguardingAgencyEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENSafeguardingAgencyEntityRecord)) return false;
			return (this == (ENSafeguardingAgencyEntityRecord) o);
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

		public ENSafeguardingAgencyEntityRecord(SerializationInfo info, StreamingContext context) {
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


		public ENSafeguardingAgencyEntityRecord Duplicate() {
			ENSafeguardingAgencyEntityRecord t;
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
	} // ENSafeguardingAgencyEntityRecord
	/// <summary>
	/// Static Entity <code>ENSafeguardingAgencyEntity</code> gets the values for this static entity
	///  records in runtime <code>SafeguardingAgency</code>
	/// </summary>
	partial class ENSafeguardingAgencyEntity {


		static ENSafeguardingAgencyEntity() {
			ENSafeguardingAgencyEntityRecordTypeFactoryImpl.InitializeFactory();
		}

		public static ENSafeguardingAgencyEntityRecord GetRecordById(string id) {
			return (ENSafeguardingAgencyEntityRecord) RsseSpaceCaseConferencingCore.ENSafeguardingAgencyEntity.GetRecordById(id);
		}

		public static ENSafeguardingAgencyEntityRecord GetRecordByName(string name) {
			return (ENSafeguardingAgencyEntityRecord) RsseSpaceCaseConferencingCore.ENSafeguardingAgencyEntity.GetRecordByName(name);
		}

		public static ENSafeguardingAgencyEntityRecord GetRecordByKey(ObjectKey key) {
			return (ENSafeguardingAgencyEntityRecord) RsseSpaceCaseConferencingCore.ENSafeguardingAgencyEntity.GetRecordByKey(key);
		}
	} // ENSafeguardingAgencyEntity;
	/// <summary>
	/// Structure <code>RCSafeguardingAgencyRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCSafeguardingAgencyRecord: ISerializable, ITypedRecord<RCSafeguardingAgencyRecord> {
		private static readonly GlobalObjectKey IdSafeguardingAgency = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*oHjOWqHMDfajgxBVKlTNVg");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("SafeguardingAgency")]
		public ENSafeguardingAgencyEntityRecord ssENSafeguardingAgency;


		public static implicit operator ENSafeguardingAgencyEntityRecord(RCSafeguardingAgencyRecord r) {
			return r.ssENSafeguardingAgency;
		}

		public static implicit operator RCSafeguardingAgencyRecord(ENSafeguardingAgencyEntityRecord r) {
			RCSafeguardingAgencyRecord res = new RCSafeguardingAgencyRecord(null);
			res.ssENSafeguardingAgency = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENSafeguardingAgency.ChangedAttributes = value;
			}
			get {
				return ssENSafeguardingAgency.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCSafeguardingAgencyRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENSafeguardingAgency = new ENSafeguardingAgencyEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(4, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENSafeguardingAgency.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENSafeguardingAgency.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENSafeguardingAgency.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENSafeguardingAgency.Read(r, ref index);
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
		public void ReadIM(RCSafeguardingAgencyRecord r) {
			this = r;
		}


		public static bool operator == (RCSafeguardingAgencyRecord a, RCSafeguardingAgencyRecord b) {
			if (a.ssENSafeguardingAgency != b.ssENSafeguardingAgency) return false;
			return true;
		}

		public static bool operator != (RCSafeguardingAgencyRecord a, RCSafeguardingAgencyRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCSafeguardingAgencyRecord)) return false;
			return (this == (RCSafeguardingAgencyRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENSafeguardingAgency.GetHashCode()
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

		public RCSafeguardingAgencyRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENSafeguardingAgency = new ENSafeguardingAgencyEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fields[0] .FieldType.IsSerializable)
			ssENSafeguardingAgency = (ENSafeguardingAgencyEntityRecord) info.GetValue(fields[0] .Name, fields[0] .FieldType);
		}

		public void RecursiveReset() {
			ssENSafeguardingAgency.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENSafeguardingAgency.InternalRecursiveSave();
		}


		public RCSafeguardingAgencyRecord Duplicate() {
			RCSafeguardingAgencyRecord t;
			t.ssENSafeguardingAgency = (ENSafeguardingAgencyEntityRecord) this.ssENSafeguardingAgency.Duplicate();
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
				ssENSafeguardingAgency.ToXml(this, recordElem, "SafeguardingAgency", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "safeguardingagency") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".SafeguardingAgency")) variable.Value = ssENSafeguardingAgency; else variable.Optimized = true;
				variable.SetFieldName("safeguardingagency");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENSafeguardingAgency.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENSafeguardingAgency.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdSafeguardingAgency) {
				return ssENSafeguardingAgency;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENSafeguardingAgency.FillFromOther((IRecord) other.AttributeGet(IdSafeguardingAgency));
		}
	} // RCSafeguardingAgencyRecord
	/// <summary>
	/// RecordList type <code>RLSafeguardingAgencyRecordList</code> that represents a record list of
	///  <code>SafeguardingAgency</code>
	/// </summary>
	[Serializable()]
	public partial class RLSafeguardingAgencyRecordList: GenericRecordList<RCSafeguardingAgencyRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCSafeguardingAgencyRecord GetElementDefaultValue() {
			return new RCSafeguardingAgencyRecord("");
		}

		public T[] ToArray<T>(Func<RCSafeguardingAgencyRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLSafeguardingAgencyRecordList recordlist, Func<RCSafeguardingAgencyRecord, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLSafeguardingAgencyRecordList ToList<T>(T[] array, Func <T, RCSafeguardingAgencyRecord> converter) {
			RLSafeguardingAgencyRecordList result = new RLSafeguardingAgencyRecordList();
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
		public RLSafeguardingAgencyRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLSafeguardingAgencyRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLSafeguardingAgencyRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLSafeguardingAgencyRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
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
		protected override OSList<RCSafeguardingAgencyRecord> NewList() {
			return new RLSafeguardingAgencyRecordList();
		}


	} // RLSafeguardingAgencyRecordList

	/// <summary>
	/// RecordList type <code>RLSafeguardingAgencyList</code> that represents a record list of <code>Text,
	///  Text, Boolean, Integer</code>
	/// </summary>
	[Serializable()]
	public partial class RLSafeguardingAgencyList: GenericRecordList<ENSafeguardingAgencyEntityRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override ENSafeguardingAgencyEntityRecord GetElementDefaultValue() {
			return new ENSafeguardingAgencyEntityRecord("");
		}

		public T[] ToArray<T>(Func<ENSafeguardingAgencyEntityRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLSafeguardingAgencyList recordlist, Func<ENSafeguardingAgencyEntityRecord, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLSafeguardingAgencyList ToList<T>(T[] array, Func <T, ENSafeguardingAgencyEntityRecord> converter) {
			RLSafeguardingAgencyList result = new RLSafeguardingAgencyList();
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
		public RLSafeguardingAgencyList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLSafeguardingAgencyList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLSafeguardingAgencyList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLSafeguardingAgencyList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[0];
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<ENSafeguardingAgencyEntityRecord> NewList() {
			return new RLSafeguardingAgencyList();
		}


	} // RLSafeguardingAgencyList
	public partial class ExtendedActions {
		/// <summary>
		/// Action: GetSafeguardingAgency
		/// </summary>

		public static void GetSafeguardingAgency(HeContext heContext, string inParamId, out RCSafeguardingAgencyRecord outParamRecord) {
			outParamRecord = new RCSafeguardingAgencyRecord(null);

			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ENSafeguardingAgencyEntity.eSpaceId;
				try {
					outParamRecord = ENSafeguardingAgencyEntity.GetRecordById(inParamId);
				} catch {
					using(Transaction trans = DatabaseAccess.ForCurrentDatabase.GetRequestTransaction()) {
						string sql =
						 "SELECT " +
						 " [ID]" +
						 ", [LABEL]" +
						 ", [ORDER]" +
						 ", [IS_ACTIVE]" +
						 " FROM " + ENSafeguardingAgencyEntity.LocalViewName(heContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale()) + " " +
						 "WHERE [ID] = @inParamId";
						Command sqlCmd = trans.CreateCommand(sql);
						sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
						using(IDataReader reader = sqlCmd.ExecuteReader("Entity Action GetSafeguardingAgency", true, false, false)) {
							if (reader.Read()) {
								outParamRecord.ReadDB(reader);
							} else
							throw new DataBaseException(ENSafeguardingAgencyEntity.LocalViewName(heContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale()) + " with key " + inParamId + " was not found");
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
	[XmlType("SafeguardingAgency")]
	public class WORCSafeguardingAgencyRecord {
		[System.Xml.Serialization.XmlElement("Id")]
		public string varWSId;

		[System.Xml.Serialization.XmlElement("Label")]
		public string varWSLabel;

		[System.Xml.Serialization.XmlElement("Order")]
		public int varWSOrder;

		[System.Xml.Serialization.XmlElement("Is_Active")]
		public bool varWSIs_Active;

		public WORCSafeguardingAgencyRecord() {
			varWSId = (string) "";
			varWSLabel = (string) "";
			varWSOrder = (int) 0;
			varWSIs_Active = (bool) false;
		}

		public WORCSafeguardingAgencyRecord(ENSafeguardingAgencyEntityRecord r) {
			varWSId = BaseAppUtils.RemoveControlChars(r.ssId);
			varWSLabel = BaseAppUtils.RemoveControlChars(r.ssLabel);
			varWSOrder = (int) r.ssOrder;
			varWSIs_Active = (bool) r.ssIs_Active;
		}

		public static RLSafeguardingAgencyList ToRecordList(WORCSafeguardingAgencyRecord[] array) {
			RLSafeguardingAgencyList rl = new RLSafeguardingAgencyList();
			if (array != null) {
				foreach(WORCSafeguardingAgencyRecord val in array) {
					rl.Append(val);
				}
			}
			return rl;
		}

		public static WORCSafeguardingAgencyRecord[] FromRecordList(RLSafeguardingAgencyList rl) {
			WORCSafeguardingAgencyRecord[] array = new WORCSafeguardingAgencyRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial struct RCSafeguardingAgencyRecord {
		public static implicit operator WORCSafeguardingAgencyRecord(RCSafeguardingAgencyRecord r) {
			return new WORCSafeguardingAgencyRecord(r.ssENSafeguardingAgency);
		}

		public static implicit operator RCSafeguardingAgencyRecord(WORCSafeguardingAgencyRecord w) {
			RCSafeguardingAgencyRecord r = new RCSafeguardingAgencyRecord("");
			if (w != null) {
				r.ssENSafeguardingAgency = w;
			}
			return r;
		}

	}

	partial struct ENSafeguardingAgencyEntityRecord {
		public static implicit operator WORCSafeguardingAgencyRecord(ENSafeguardingAgencyEntityRecord r) {
			return new WORCSafeguardingAgencyRecord(r);
		}

		public static implicit operator ENSafeguardingAgencyEntityRecord(WORCSafeguardingAgencyRecord w) {
			ENSafeguardingAgencyEntityRecord r = new ENSafeguardingAgencyEntityRecord("");
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
	public partial class WORLSafeguardingAgencyRecordList {
		public WORCSafeguardingAgencyRecord[] Array;


		public WORLSafeguardingAgencyRecordList(WORCSafeguardingAgencyRecord[] r) {
			if (r == null)
			Array = new WORCSafeguardingAgencyRecord[0];
			else
			Array = r;
		}
		public WORLSafeguardingAgencyRecordList() {
			Array = new WORCSafeguardingAgencyRecord[0];
		}

		public WORLSafeguardingAgencyRecordList(RLSafeguardingAgencyRecordList rl) {
			rl=(RLSafeguardingAgencyRecordList) rl.Duplicate();
			Array = new WORCSafeguardingAgencyRecord[rl.Length];
			while (!rl.Eof) {
				Array[rl.CurrentRowNumber] = new WORCSafeguardingAgencyRecord(rl.CurrentRec);
				rl.Advance();
			}
		}

	}
}

namespace ssCaseConferencing {
	partial class RLSafeguardingAgencyRecordList {
		public static implicit operator RLSafeguardingAgencyRecordList(WORCSafeguardingAgencyRecord[] array) {
			RLSafeguardingAgencyRecordList rl = new RLSafeguardingAgencyRecordList();
			if (array != null) {
				foreach(WORCSafeguardingAgencyRecord val in array) {
					rl.Append((RCSafeguardingAgencyRecord) val);
				}
			}
			return rl;
		}
		public static implicit operator WORCSafeguardingAgencyRecord[](RLSafeguardingAgencyRecordList rl) {
			WORCSafeguardingAgencyRecord[] array = new WORCSafeguardingAgencyRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = (RCSafeguardingAgencyRecord) rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial class WORLSafeguardingAgencyRecordList {
		public static implicit operator RLSafeguardingAgencyRecordList(WORLSafeguardingAgencyRecordList w) {
			return w.Array;
		}
		public static implicit operator WORLSafeguardingAgencyRecordList(RLSafeguardingAgencyRecordList rl) {
			return new WORLSafeguardingAgencyRecordList(rl);
		}
		public static implicit operator WORCSafeguardingAgencyRecord[](WORLSafeguardingAgencyRecordList w) {
			if (w != null) {
				return w.Array;
			}
			return null;
		}
		public static implicit operator WORLSafeguardingAgencyRecordList(WORCSafeguardingAgencyRecord[] array) {
			return new WORLSafeguardingAgencyRecordList(array);
		}
	}
}
