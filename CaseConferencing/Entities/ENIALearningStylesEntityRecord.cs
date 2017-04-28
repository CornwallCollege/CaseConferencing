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

	public sealed partial class ENIALearningStylesEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return RsseSpaceCornwallCollegeData.ENIALearningStylesEntity.ViewName(tenant, locale);
		}
		public const int eSpaceId = RsseSpaceCornwallCollegeData.ENIALearningStylesEntity.eSpaceId;
	} // ENIALearningStylesEntity

	/// <summary>
	/// Entity <code>ENIALearningStylesEntityRecord</code> that represents the Service Studio entity
	///  <code>IALearningStyles</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("IALearningStyles", "9ZC9bYMa4EGoMVkCBPppRg", "MHDKEnEy6kO1VcZuY5cJcA", 0, "OSUSR_bd2_IALearningStyles", "")]
	[Serializable()]
	public partial struct ENIALearningStylesEntityRecord: ISerializable, ITypedRecord<ENIALearningStylesEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("MHDKEnEy6kO1VcZuY5cJcA*d4vYKEB8ZkKIkPAUYlTL3Q");
		private static readonly GlobalObjectKey IdLabel = GlobalObjectKey.Parse("MHDKEnEy6kO1VcZuY5cJcA*2BKGGJ7lmUCl_Zas1nVLow");
		private static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("MHDKEnEy6kO1VcZuY5cJcA*1P2cUfgHdkaynfFdrqs4Rw");
		private static readonly GlobalObjectKey IdIs_Active = GlobalObjectKey.Parse("MHDKEnEy6kO1VcZuY5cJcA*V7PbPchqTUGaHfyJD0lHzw");

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

		public ENIALearningStylesEntityRecord(params string[] dummy) {
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
			ssId = r.ReadText(index++, "IALearningStyles.Id", "");
			ssLabel = r.ReadText(index++, "IALearningStyles.Label", "");
			ssOrder = r.ReadInteger(index++, "IALearningStyles.Order", 0);
			ssIs_Active = r.ReadBoolean(index++, "IALearningStyles.Is_Active", false);
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
		public void ReadIM(ENIALearningStylesEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENIALearningStylesEntityRecord a, ENIALearningStylesEntityRecord b) {
			if (a.ssId != b.ssId) return false;
			if (a.ssLabel != b.ssLabel) return false;
			if (a.ssOrder != b.ssOrder) return false;
			if (a.ssIs_Active != b.ssIs_Active) return false;
			return true;
		}

		public static bool operator != (ENIALearningStylesEntityRecord a, ENIALearningStylesEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENIALearningStylesEntityRecord)) return false;
			return (this == (ENIALearningStylesEntityRecord) o);
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

		public ENIALearningStylesEntityRecord(SerializationInfo info, StreamingContext context) {
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


		public ENIALearningStylesEntityRecord Duplicate() {
			ENIALearningStylesEntityRecord t;
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
	} // ENIALearningStylesEntityRecord
	/// <summary>
	/// Static Entity <code>ENIALearningStylesEntity</code> gets the values for this static entity records
	///  in runtime <code>IALearningStyles</code>
	/// </summary>
	partial class ENIALearningStylesEntity {


		static ENIALearningStylesEntity() {
			ENIALearningStylesEntityRecordTypeFactoryImpl.InitializeFactory();
		}

		public static ENIALearningStylesEntityRecord GetRecordById(string id) {
			return (ENIALearningStylesEntityRecord) RsseSpaceCornwallCollegeData.ENIALearningStylesEntity.GetRecordById(id);
		}

		public static ENIALearningStylesEntityRecord GetRecordByName(string name) {
			return (ENIALearningStylesEntityRecord) RsseSpaceCornwallCollegeData.ENIALearningStylesEntity.GetRecordByName(name);
		}

		public static ENIALearningStylesEntityRecord GetRecordByKey(ObjectKey key) {
			return (ENIALearningStylesEntityRecord) RsseSpaceCornwallCollegeData.ENIALearningStylesEntity.GetRecordByKey(key);
		}
	} // ENIALearningStylesEntity;
	/// <summary>
	/// Structure <code>RCIALearningStylesRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCIALearningStylesRecord: ISerializable, ITypedRecord<RCIALearningStylesRecord> {
		private static readonly GlobalObjectKey IdIALearningStyles = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*GIlzKX5uwZ6IbvcsdNNf2w");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("IALearningStyles")]
		public ENIALearningStylesEntityRecord ssENIALearningStyles;


		public static implicit operator ENIALearningStylesEntityRecord(RCIALearningStylesRecord r) {
			return r.ssENIALearningStyles;
		}

		public static implicit operator RCIALearningStylesRecord(ENIALearningStylesEntityRecord r) {
			RCIALearningStylesRecord res = new RCIALearningStylesRecord(null);
			res.ssENIALearningStyles = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENIALearningStyles.ChangedAttributes = value;
			}
			get {
				return ssENIALearningStyles.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCIALearningStylesRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENIALearningStyles = new ENIALearningStylesEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(4, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENIALearningStyles.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENIALearningStyles.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENIALearningStyles.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENIALearningStyles.Read(r, ref index);
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
		public void ReadIM(RCIALearningStylesRecord r) {
			this = r;
		}


		public static bool operator == (RCIALearningStylesRecord a, RCIALearningStylesRecord b) {
			if (a.ssENIALearningStyles != b.ssENIALearningStyles) return false;
			return true;
		}

		public static bool operator != (RCIALearningStylesRecord a, RCIALearningStylesRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCIALearningStylesRecord)) return false;
			return (this == (RCIALearningStylesRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENIALearningStyles.GetHashCode()
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

		public RCIALearningStylesRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENIALearningStyles = new ENIALearningStylesEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fields[0] .FieldType.IsSerializable)
			ssENIALearningStyles = (ENIALearningStylesEntityRecord) info.GetValue(fields[0] .Name, fields[0] .FieldType);
		}

		public void RecursiveReset() {
			ssENIALearningStyles.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENIALearningStyles.InternalRecursiveSave();
		}


		public RCIALearningStylesRecord Duplicate() {
			RCIALearningStylesRecord t;
			t.ssENIALearningStyles = (ENIALearningStylesEntityRecord) this.ssENIALearningStyles.Duplicate();
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
				ssENIALearningStyles.ToXml(this, recordElem, "IALearningStyles", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "ialearningstyles") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".IALearningStyles")) variable.Value = ssENIALearningStyles; else variable.Optimized = true;
				variable.SetFieldName("ialearningstyles");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENIALearningStyles.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENIALearningStyles.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdIALearningStyles) {
				return ssENIALearningStyles;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENIALearningStyles.FillFromOther((IRecord) other.AttributeGet(IdIALearningStyles));
		}
	} // RCIALearningStylesRecord
	/// <summary>
	/// RecordList type <code>RLIALearningStylesRecordList</code> that represents a record list of
	///  <code>IALearningStyles</code>
	/// </summary>
	[Serializable()]
	public partial class RLIALearningStylesRecordList: GenericRecordList<RCIALearningStylesRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCIALearningStylesRecord GetElementDefaultValue() {
			return new RCIALearningStylesRecord("");
		}

		public T[] ToArray<T>(Func<RCIALearningStylesRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLIALearningStylesRecordList recordlist, Func<RCIALearningStylesRecord, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLIALearningStylesRecordList ToList<T>(T[] array, Func <T, RCIALearningStylesRecord> converter) {
			RLIALearningStylesRecordList result = new RLIALearningStylesRecordList();
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
		public RLIALearningStylesRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLIALearningStylesRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLIALearningStylesRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLIALearningStylesRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
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
		protected override OSList<RCIALearningStylesRecord> NewList() {
			return new RLIALearningStylesRecordList();
		}


	} // RLIALearningStylesRecordList

	/// <summary>
	/// RecordList type <code>RLIALearningStylesList</code> that represents a record list of <code>Text,
	///  Text, Boolean, Integer</code>
	/// </summary>
	[Serializable()]
	public partial class RLIALearningStylesList: GenericRecordList<ENIALearningStylesEntityRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override ENIALearningStylesEntityRecord GetElementDefaultValue() {
			return new ENIALearningStylesEntityRecord("");
		}

		public T[] ToArray<T>(Func<ENIALearningStylesEntityRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLIALearningStylesList recordlist, Func<ENIALearningStylesEntityRecord, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLIALearningStylesList ToList<T>(T[] array, Func <T, ENIALearningStylesEntityRecord> converter) {
			RLIALearningStylesList result = new RLIALearningStylesList();
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
		public RLIALearningStylesList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLIALearningStylesList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLIALearningStylesList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLIALearningStylesList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[0];
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<ENIALearningStylesEntityRecord> NewList() {
			return new RLIALearningStylesList();
		}


	} // RLIALearningStylesList
	public partial class ExtendedActions {
		/// <summary>
		/// Action: GetIALearningStyles
		/// </summary>

		public static void GetIALearningStyles(HeContext heContext, string inParamId, out RCIALearningStylesRecord outParamRecord) {
			outParamRecord = new RCIALearningStylesRecord(null);

			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ENIALearningStylesEntity.eSpaceId;
				try {
					outParamRecord = ENIALearningStylesEntity.GetRecordById(inParamId);
				} catch {
					using(Transaction trans = DatabaseAccess.ForCurrentDatabase.GetRequestTransaction()) {
						string sql =
						 "SELECT " +
						 " [ID]" +
						 ", [LABEL]" +
						 ", [ORDER]" +
						 ", [IS_ACTIVE]" +
						 " FROM " + ENIALearningStylesEntity.LocalViewName(heContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale()) + " " +
						 "WHERE [ID] = @inParamId";
						Command sqlCmd = trans.CreateCommand(sql);
						sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
						using(IDataReader reader = sqlCmd.ExecuteReader("Entity Action GetIALearningStyles", true, false, false)) {
							if (reader.Read()) {
								outParamRecord.ReadDB(reader);
							} else
							throw new DataBaseException(ENIALearningStylesEntity.LocalViewName(heContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale()) + " with key " + inParamId + " was not found");
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
	[XmlType("IALearningStyles")]
	public class WORCIALearningStylesRecord {
		[System.Xml.Serialization.XmlElement("Id")]
		public string varWSId;

		[System.Xml.Serialization.XmlElement("Label")]
		public string varWSLabel;

		[System.Xml.Serialization.XmlElement("Order")]
		public int varWSOrder;

		[System.Xml.Serialization.XmlElement("Is_Active")]
		public bool varWSIs_Active;

		public WORCIALearningStylesRecord() {
			varWSId = (string) "";
			varWSLabel = (string) "";
			varWSOrder = (int) 0;
			varWSIs_Active = (bool) false;
		}

		public WORCIALearningStylesRecord(ENIALearningStylesEntityRecord r) {
			varWSId = BaseAppUtils.RemoveControlChars(r.ssId);
			varWSLabel = BaseAppUtils.RemoveControlChars(r.ssLabel);
			varWSOrder = (int) r.ssOrder;
			varWSIs_Active = (bool) r.ssIs_Active;
		}

		public static RLIALearningStylesList ToRecordList(WORCIALearningStylesRecord[] array) {
			RLIALearningStylesList rl = new RLIALearningStylesList();
			if (array != null) {
				foreach(WORCIALearningStylesRecord val in array) {
					rl.Append(val);
				}
			}
			return rl;
		}

		public static WORCIALearningStylesRecord[] FromRecordList(RLIALearningStylesList rl) {
			WORCIALearningStylesRecord[] array = new WORCIALearningStylesRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial struct RCIALearningStylesRecord {
		public static implicit operator WORCIALearningStylesRecord(RCIALearningStylesRecord r) {
			return new WORCIALearningStylesRecord(r.ssENIALearningStyles);
		}

		public static implicit operator RCIALearningStylesRecord(WORCIALearningStylesRecord w) {
			RCIALearningStylesRecord r = new RCIALearningStylesRecord("");
			if (w != null) {
				r.ssENIALearningStyles = w;
			}
			return r;
		}

	}

	partial struct ENIALearningStylesEntityRecord {
		public static implicit operator WORCIALearningStylesRecord(ENIALearningStylesEntityRecord r) {
			return new WORCIALearningStylesRecord(r);
		}

		public static implicit operator ENIALearningStylesEntityRecord(WORCIALearningStylesRecord w) {
			ENIALearningStylesEntityRecord r = new ENIALearningStylesEntityRecord("");
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
	public partial class WORLIALearningStylesRecordList {
		public WORCIALearningStylesRecord[] Array;


		public WORLIALearningStylesRecordList(WORCIALearningStylesRecord[] r) {
			if (r == null)
			Array = new WORCIALearningStylesRecord[0];
			else
			Array = r;
		}
		public WORLIALearningStylesRecordList() {
			Array = new WORCIALearningStylesRecord[0];
		}

		public WORLIALearningStylesRecordList(RLIALearningStylesRecordList rl) {
			rl=(RLIALearningStylesRecordList) rl.Duplicate();
			Array = new WORCIALearningStylesRecord[rl.Length];
			while (!rl.Eof) {
				Array[rl.CurrentRowNumber] = new WORCIALearningStylesRecord(rl.CurrentRec);
				rl.Advance();
			}
		}

	}
}

namespace ssCaseConferencing {
	partial class RLIALearningStylesRecordList {
		public static implicit operator RLIALearningStylesRecordList(WORCIALearningStylesRecord[] array) {
			RLIALearningStylesRecordList rl = new RLIALearningStylesRecordList();
			if (array != null) {
				foreach(WORCIALearningStylesRecord val in array) {
					rl.Append((RCIALearningStylesRecord) val);
				}
			}
			return rl;
		}
		public static implicit operator WORCIALearningStylesRecord[](RLIALearningStylesRecordList rl) {
			WORCIALearningStylesRecord[] array = new WORCIALearningStylesRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = (RCIALearningStylesRecord) rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial class WORLIALearningStylesRecordList {
		public static implicit operator RLIALearningStylesRecordList(WORLIALearningStylesRecordList w) {
			return w.Array;
		}
		public static implicit operator WORLIALearningStylesRecordList(RLIALearningStylesRecordList rl) {
			return new WORLIALearningStylesRecordList(rl);
		}
		public static implicit operator WORCIALearningStylesRecord[](WORLIALearningStylesRecordList w) {
			if (w != null) {
				return w.Array;
			}
			return null;
		}
		public static implicit operator WORLIALearningStylesRecordList(WORCIALearningStylesRecord[] array) {
			return new WORLIALearningStylesRecordList(array);
		}
	}
}

