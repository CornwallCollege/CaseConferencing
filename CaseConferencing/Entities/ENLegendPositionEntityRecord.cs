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

	public sealed partial class ENLegendPositionEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return RsseSpaceCharts.ENLegendPositionEntity.ViewName(tenant, locale);
		}
		public const int eSpaceId = RsseSpaceCharts.ENLegendPositionEntity.eSpaceId;
	} // ENLegendPositionEntity

	/// <summary>
	/// Entity <code>ENLegendPositionEntityRecord</code> that represents the Service Studio entity
	///  <code>LegendPosition</code> <p> Description: The position where the legend is displayed o
	/// n charts.</p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("LegendPosition", "3ALwV3_D4EWgt+ZANlB_pg", "uQHsYT2wwkKZ1wrN3PIifQ", 0, "OSUSR_bjy_LegendPosition", "")]
	[Serializable()]
	public partial struct ENLegendPositionEntityRecord: ISerializable, ITypedRecord<ENLegendPositionEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("uQHsYT2wwkKZ1wrN3PIifQ*BFolAx3kZ0Ouk_5QDj2X2A");
		private static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("uQHsYT2wwkKZ1wrN3PIifQ*HNo8NtYKB0er9_PlSGRbZQ");
		private static readonly GlobalObjectKey IdIs_Active = GlobalObjectKey.Parse("uQHsYT2wwkKZ1wrN3PIifQ*jl_1PSd0g0qEuswTCWupFA");

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ID", 0, true, true, false)]
		[System.Xml.Serialization.XmlElement("Id")]
		private int _ssId;
		public int ssId {
			get {
				return _ssId;
			}
			set {
				if ((_ssId!=value) || OptimizedAttributes[0]) {
					ChangedAttributes = new BitArray(3, true);
					_ssId = value;
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
				if ((_ssOrder!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
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
				if ((_ssIs_Active!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssIs_Active = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENLegendPositionEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(3, true);
			OptimizedAttributes = new BitArray(3, false);
			_ssId = 0;
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
			ssId = r.ReadInteger(index++, "LegendPosition.Id", 0);
			ssOrder = r.ReadInteger(index++, "LegendPosition.Order", 0);
			ssIs_Active = r.ReadBoolean(index++, "LegendPosition.Is_Active", false);
			ChangedAttributes = new BitArray(3, false);
			OptimizedAttributes = new BitArray(3, false);
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
		public void ReadIM(ENLegendPositionEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENLegendPositionEntityRecord a, ENLegendPositionEntityRecord b) {
			if (a.ssId != b.ssId) return false;
			if (a.ssOrder != b.ssOrder) return false;
			if (a.ssIs_Active != b.ssIs_Active) return false;
			return true;
		}

		public static bool operator != (ENLegendPositionEntityRecord a, ENLegendPositionEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENLegendPositionEntityRecord)) return false;
			return (this == (ENLegendPositionEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssId.GetHashCode()
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

		public ENLegendPositionEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(3, true);
			OptimizedAttributes = new BitArray(3, false);
			_ssId = 0;
			_ssOrder = 0;
			_ssIs_Active = false;
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fields[0] .FieldType.IsSerializable)
			_ssId = (int) info.GetValue(fields[0] .Name, fields[0] .FieldType);
			if (fields[1] .FieldType.IsSerializable)
			_ssOrder = (int) info.GetValue(fields[1] .Name, fields[1] .FieldType);
			if (fields[2] .FieldType.IsSerializable)
			_ssIs_Active = (bool) info.GetValue(fields[2] .Name, fields[2] .FieldType);
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENLegendPositionEntityRecord Duplicate() {
			ENLegendPositionEntityRecord t;
			t._ssId = this._ssId;
			t._ssOrder = this._ssOrder;
			t._ssIs_Active = this._ssIs_Active;
			t.ChangedAttributes = new BitArray(3);
			t.OptimizedAttributes = new BitArray(3);
			for (int i = 0; i < 3; i++) {
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
			} else if (key.Equals(IdOrder)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdIs_Active)) {
				return ChangedAttributes[2];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdId)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdOrder)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdIs_Active)) {
				return OptimizedAttributes[2];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdId) {
				return ssId;
			} else if (key == IdOrder) {
				return ssOrder;
			} else if (key == IdIs_Active) {
				return ssIs_Active;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(3);
			OptimizedAttributes = new BitArray(3);
			if (other == null) return;
			ssId = (int) other.AttributeGet(IdId);
			ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
			ssOrder = (int) other.AttributeGet(IdOrder);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdOrder);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdOrder);
			ssIs_Active = (bool) other.AttributeGet(IdIs_Active);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdIs_Active);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdIs_Active);
		}
	} // ENLegendPositionEntityRecord
	/// <summary>
	/// Static Entity <code>ENLegendPositionEntity</code> gets the values for this static entity records in
	///  runtime <code>LegendPosition</code>
	/// </summary>
	partial class ENLegendPositionEntity {


		static ENLegendPositionEntity() {
			ENLegendPositionEntityRecordTypeFactoryImpl.InitializeFactory();
		}

		public static ENLegendPositionEntityRecord GetRecordById(int id) {
			return (ENLegendPositionEntityRecord) RsseSpaceCharts.ENLegendPositionEntity.GetRecordById(id);
		}

		public static ENLegendPositionEntityRecord GetRecordByName(string name) {
			return (ENLegendPositionEntityRecord) RsseSpaceCharts.ENLegendPositionEntity.GetRecordByName(name);
		}

		public static ENLegendPositionEntityRecord GetRecordByKey(ObjectKey key) {
			return (ENLegendPositionEntityRecord) RsseSpaceCharts.ENLegendPositionEntity.GetRecordByKey(key);
		}
	} // ENLegendPositionEntity;
	/// <summary>
	/// Structure <code>RCLegendPositionRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCLegendPositionRecord: ISerializable, ITypedRecord<RCLegendPositionRecord> {
		private static readonly GlobalObjectKey IdLegendPosition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ZhuiWomOy7Q56PeqfiCI8w");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("LegendPosition")]
		public ENLegendPositionEntityRecord ssENLegendPosition;


		public static implicit operator ENLegendPositionEntityRecord(RCLegendPositionRecord r) {
			return r.ssENLegendPosition;
		}

		public static implicit operator RCLegendPositionRecord(ENLegendPositionEntityRecord r) {
			RCLegendPositionRecord res = new RCLegendPositionRecord(null);
			res.ssENLegendPosition = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENLegendPosition.ChangedAttributes = value;
			}
			get {
				return ssENLegendPosition.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCLegendPositionRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENLegendPosition = new ENLegendPositionEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(3, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENLegendPosition.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENLegendPosition.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENLegendPosition.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENLegendPosition.Read(r, ref index);
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
		public void ReadIM(RCLegendPositionRecord r) {
			this = r;
		}


		public static bool operator == (RCLegendPositionRecord a, RCLegendPositionRecord b) {
			if (a.ssENLegendPosition != b.ssENLegendPosition) return false;
			return true;
		}

		public static bool operator != (RCLegendPositionRecord a, RCLegendPositionRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCLegendPositionRecord)) return false;
			return (this == (RCLegendPositionRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENLegendPosition.GetHashCode()
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

		public RCLegendPositionRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENLegendPosition = new ENLegendPositionEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fields[0] .FieldType.IsSerializable)
			ssENLegendPosition = (ENLegendPositionEntityRecord) info.GetValue(fields[0] .Name, fields[0] .FieldType);
		}

		public void RecursiveReset() {
			ssENLegendPosition.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENLegendPosition.InternalRecursiveSave();
		}


		public RCLegendPositionRecord Duplicate() {
			RCLegendPositionRecord t;
			t.ssENLegendPosition = (ENLegendPositionEntityRecord) this.ssENLegendPosition.Duplicate();
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
				ssENLegendPosition.ToXml(this, recordElem, "LegendPosition", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "legendposition") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".LegendPosition")) variable.Value = ssENLegendPosition; else variable.Optimized = true;
				variable.SetFieldName("legendposition");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENLegendPosition.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENLegendPosition.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdLegendPosition) {
				return ssENLegendPosition;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENLegendPosition.FillFromOther((IRecord) other.AttributeGet(IdLegendPosition));
		}
	} // RCLegendPositionRecord
	/// <summary>
	/// RecordList type <code>RLLegendPositionRecordList</code> that represents a record list of
	///  <code>LegendPosition</code>
	/// </summary>
	[Serializable()]
	public partial class RLLegendPositionRecordList: GenericRecordList<RCLegendPositionRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCLegendPositionRecord GetElementDefaultValue() {
			return new RCLegendPositionRecord("");
		}

		public T[] ToArray<T>(Func<RCLegendPositionRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLLegendPositionRecordList recordlist, Func<RCLegendPositionRecord, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLLegendPositionRecordList ToList<T>(T[] array, Func <T, RCLegendPositionRecord> converter) {
			RLLegendPositionRecordList result = new RLLegendPositionRecordList();
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
		public RLLegendPositionRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLLegendPositionRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLLegendPositionRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLLegendPositionRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(3, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCLegendPositionRecord> NewList() {
			return new RLLegendPositionRecordList();
		}


	} // RLLegendPositionRecordList

	/// <summary>
	/// RecordList type <code>RLLegendPositionList</code> that represents a record list of <code>Boolean,
	///  Integer, Integer</code>
	/// </summary>
	[Serializable()]
	public partial class RLLegendPositionList: GenericRecordList<ENLegendPositionEntityRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override ENLegendPositionEntityRecord GetElementDefaultValue() {
			return new ENLegendPositionEntityRecord("");
		}

		public T[] ToArray<T>(Func<ENLegendPositionEntityRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLLegendPositionList recordlist, Func<ENLegendPositionEntityRecord, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLLegendPositionList ToList<T>(T[] array, Func <T, ENLegendPositionEntityRecord> converter) {
			RLLegendPositionList result = new RLLegendPositionList();
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
		public RLLegendPositionList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLLegendPositionList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLLegendPositionList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLLegendPositionList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[0];
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<ENLegendPositionEntityRecord> NewList() {
			return new RLLegendPositionList();
		}


	} // RLLegendPositionList
	public partial class ExtendedActions {
		/// <summary>
		/// Action: GetLegendPosition
		/// </summary>

		public static void GetLegendPosition(HeContext heContext, int inParamId, out RCLegendPositionRecord outParamRecord) {
			outParamRecord = new RCLegendPositionRecord(null);

			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ENLegendPositionEntity.eSpaceId;
				try {
					outParamRecord = ENLegendPositionEntity.GetRecordById(inParamId);
				} catch {
					using(Transaction trans = DatabaseAccess.ForCurrentDatabase.GetRequestTransaction()) {
						string sql =
						 "SELECT " +
						 " [ID]" +
						 ", [ORDER]" +
						 ", [IS_ACTIVE]" +
						 " FROM " + ENLegendPositionEntity.LocalViewName(heContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale()) + " " +
						 "WHERE [ID] = @inParamId";
						Command sqlCmd = trans.CreateCommand(sql);
						sqlCmd.CreateParameter("@inParamId", DbType.Int32, inParamId);
						using(IDataReader reader = sqlCmd.ExecuteReader("Entity Action GetLegendPosition", true, false, false)) {
							if (reader.Read()) {
								outParamRecord.ReadDB(reader);
							} else
							throw new DataBaseException(ENLegendPositionEntity.LocalViewName(heContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale()) + " with key " + inParamId + " was not found");
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
	[XmlType("LegendPosition")]
	public class WORCLegendPositionRecord {
		[System.Xml.Serialization.XmlElement("Id")]
		public int varWSId;

		[System.Xml.Serialization.XmlElement("Order")]
		public int varWSOrder;

		[System.Xml.Serialization.XmlElement("Is_Active")]
		public bool varWSIs_Active;

		public WORCLegendPositionRecord() {
			varWSId = (int) 0;
			varWSOrder = (int) 0;
			varWSIs_Active = (bool) false;
		}

		public WORCLegendPositionRecord(ENLegendPositionEntityRecord r) {
			varWSId = (int) r.ssId;
			varWSOrder = (int) r.ssOrder;
			varWSIs_Active = (bool) r.ssIs_Active;
		}

		public static RLLegendPositionList ToRecordList(WORCLegendPositionRecord[] array) {
			RLLegendPositionList rl = new RLLegendPositionList();
			if (array != null) {
				foreach(WORCLegendPositionRecord val in array) {
					rl.Append(val);
				}
			}
			return rl;
		}

		public static WORCLegendPositionRecord[] FromRecordList(RLLegendPositionList rl) {
			WORCLegendPositionRecord[] array = new WORCLegendPositionRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial struct RCLegendPositionRecord {
		public static implicit operator WORCLegendPositionRecord(RCLegendPositionRecord r) {
			return new WORCLegendPositionRecord(r.ssENLegendPosition);
		}

		public static implicit operator RCLegendPositionRecord(WORCLegendPositionRecord w) {
			RCLegendPositionRecord r = new RCLegendPositionRecord("");
			if (w != null) {
				r.ssENLegendPosition = w;
			}
			return r;
		}

	}

	partial struct ENLegendPositionEntityRecord {
		public static implicit operator WORCLegendPositionRecord(ENLegendPositionEntityRecord r) {
			return new WORCLegendPositionRecord(r);
		}

		public static implicit operator ENLegendPositionEntityRecord(WORCLegendPositionRecord w) {
			ENLegendPositionEntityRecord r = new ENLegendPositionEntityRecord("");
			if (w != null) {
				r.ssId = (int) w.varWSId;
				r.ssOrder = (int) w.varWSOrder;
				r.ssIs_Active = (bool) w.varWSIs_Active;
			}
			return r;
		}

	}
}


namespace ssCaseConferencing {
	[Serializable()]
	public partial class WORLLegendPositionRecordList {
		public WORCLegendPositionRecord[] Array;


		public WORLLegendPositionRecordList(WORCLegendPositionRecord[] r) {
			if (r == null)
			Array = new WORCLegendPositionRecord[0];
			else
			Array = r;
		}
		public WORLLegendPositionRecordList() {
			Array = new WORCLegendPositionRecord[0];
		}

		public WORLLegendPositionRecordList(RLLegendPositionRecordList rl) {
			rl=(RLLegendPositionRecordList) rl.Duplicate();
			Array = new WORCLegendPositionRecord[rl.Length];
			while (!rl.Eof) {
				Array[rl.CurrentRowNumber] = new WORCLegendPositionRecord(rl.CurrentRec);
				rl.Advance();
			}
		}

	}
}

namespace ssCaseConferencing {
	partial class RLLegendPositionRecordList {
		public static implicit operator RLLegendPositionRecordList(WORCLegendPositionRecord[] array) {
			RLLegendPositionRecordList rl = new RLLegendPositionRecordList();
			if (array != null) {
				foreach(WORCLegendPositionRecord val in array) {
					rl.Append((RCLegendPositionRecord) val);
				}
			}
			return rl;
		}
		public static implicit operator WORCLegendPositionRecord[](RLLegendPositionRecordList rl) {
			WORCLegendPositionRecord[] array = new WORCLegendPositionRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = (RCLegendPositionRecord) rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial class WORLLegendPositionRecordList {
		public static implicit operator RLLegendPositionRecordList(WORLLegendPositionRecordList w) {
			return w.Array;
		}
		public static implicit operator WORLLegendPositionRecordList(RLLegendPositionRecordList rl) {
			return new WORLLegendPositionRecordList(rl);
		}
		public static implicit operator WORCLegendPositionRecord[](WORLLegendPositionRecordList w) {
			if (w != null) {
				return w.Array;
			}
			return null;
		}
		public static implicit operator WORLLegendPositionRecordList(WORCLegendPositionRecord[] array) {
			return new WORLLegendPositionRecordList(array);
		}
	}
}

