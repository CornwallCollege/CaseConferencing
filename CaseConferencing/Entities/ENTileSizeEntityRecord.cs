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

	public sealed partial class ENTileSizeEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return RsseSpaceThemeProvider.ENTileSizeEntity.ViewName(tenant, locale);
		}
		public const int eSpaceId = RsseSpaceThemeProvider.ENTileSizeEntity.eSpaceId;
	} // ENTileSizeEntity

	/// <summary>
	/// Entity <code>ENTileSizeEntityRecord</code> that represents the Service Studio entity
	///  <code>TileSize</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("TileSize", "Oyf6t+p3Q0KUK0lkd0SWiw", "VofHcHeK2kSPL0JlVdburg", 0, "OSUSR_o9a_TileSize", "")]
	[Serializable()]
	public partial struct ENTileSizeEntityRecord: ISerializable, ITypedRecord<ENTileSizeEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdType = GlobalObjectKey.Parse("VofHcHeK2kSPL0JlVdburg*P+379RjZA0WmbDruejew6g");
		private static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("VofHcHeK2kSPL0JlVdburg*cLgWfMc2ME+R5eqCrIHr3g");
		private static readonly GlobalObjectKey IdIs_Active = GlobalObjectKey.Parse("VofHcHeK2kSPL0JlVdburg*ZlZHm_h7LkS0_Oki2uFBCw");

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("TYPE", 50, false, true, false)]
		[System.Xml.Serialization.XmlElement("Type")]
		private string _ssType;
		public string ssType {
			get {
				return _ssType;
			}
			set {
				if ((_ssType!=value) || OptimizedAttributes[0]) {
					ChangedAttributes = new BitArray(3, true);
					_ssType = value;
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

		public ENTileSizeEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(3, true);
			OptimizedAttributes = new BitArray(3, false);
			_ssType = "";
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
			ssType = r.ReadText(index++, "TileSize.Type", "");
			ssOrder = r.ReadInteger(index++, "TileSize.Order", 0);
			ssIs_Active = r.ReadBoolean(index++, "TileSize.Is_Active", false);
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
		public void ReadIM(ENTileSizeEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENTileSizeEntityRecord a, ENTileSizeEntityRecord b) {
			if (a.ssType != b.ssType) return false;
			if (a.ssOrder != b.ssOrder) return false;
			if (a.ssIs_Active != b.ssIs_Active) return false;
			return true;
		}

		public static bool operator != (ENTileSizeEntityRecord a, ENTileSizeEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENTileSizeEntityRecord)) return false;
			return (this == (ENTileSizeEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssType.GetHashCode()
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

		public ENTileSizeEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(3, true);
			OptimizedAttributes = new BitArray(3, false);
			_ssType = "";
			_ssOrder = 0;
			_ssIs_Active = false;
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fields[0] .FieldType.IsSerializable)
			_ssType = (string) info.GetValue(fields[0] .Name, fields[0] .FieldType);
			if (fields[1] .FieldType.IsSerializable)
			_ssOrder = (int) info.GetValue(fields[1] .Name, fields[1] .FieldType);
			if (fields[2] .FieldType.IsSerializable)
			_ssIs_Active = (bool) info.GetValue(fields[2] .Name, fields[2] .FieldType);
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENTileSizeEntityRecord Duplicate() {
			ENTileSizeEntityRecord t;
			t._ssType = this._ssType;
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
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Type")) VarValue.AppendAttribute(recordElem, "Type", ssType, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Type");
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
			if (head == "type") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Type")) variable.Value = ssType; else variable.Optimized = true;
			} else if (head == "order") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Order")) variable.Value = ssOrder; else variable.Optimized = true;
			} else if (head == "is_active") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Is_Active")) variable.Value = ssIs_Active; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdType)) {
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
			if (key.Equals(IdType)) {
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
			if (key == IdType) {
				return ssType;
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
			ssType = (string) other.AttributeGet(IdType);
			ChangedAttributes[0] = other.ChangedAttributeGet(IdType);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(IdType);
			ssOrder = (int) other.AttributeGet(IdOrder);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdOrder);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdOrder);
			ssIs_Active = (bool) other.AttributeGet(IdIs_Active);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdIs_Active);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdIs_Active);
		}
	} // ENTileSizeEntityRecord
	/// <summary>
	/// Static Entity <code>ENTileSizeEntity</code> gets the values for this static entity records in
	///  runtime <code>TileSize</code>
	/// </summary>
	partial class ENTileSizeEntity {


		static ENTileSizeEntity() {
			ENTileSizeEntityRecordTypeFactoryImpl.InitializeFactory();
		}

		public static ENTileSizeEntityRecord GetRecordById(string id) {
			return (ENTileSizeEntityRecord) RsseSpaceThemeProvider.ENTileSizeEntity.GetRecordById(id);
		}

		public static ENTileSizeEntityRecord GetRecordByName(string name) {
			return (ENTileSizeEntityRecord) RsseSpaceThemeProvider.ENTileSizeEntity.GetRecordByName(name);
		}

		public static ENTileSizeEntityRecord GetRecordByKey(ObjectKey key) {
			return (ENTileSizeEntityRecord) RsseSpaceThemeProvider.ENTileSizeEntity.GetRecordByKey(key);
		}
	} // ENTileSizeEntity;
	/// <summary>
	/// Structure <code>RCTileSizeRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCTileSizeRecord: ISerializable, ITypedRecord<RCTileSizeRecord> {
		private static readonly GlobalObjectKey IdTileSize = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*2cCOUsAW_ZmWAjfSwSc9Bg");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("TileSize")]
		public ENTileSizeEntityRecord ssENTileSize;


		public static implicit operator ENTileSizeEntityRecord(RCTileSizeRecord r) {
			return r.ssENTileSize;
		}

		public static implicit operator RCTileSizeRecord(ENTileSizeEntityRecord r) {
			RCTileSizeRecord res = new RCTileSizeRecord(null);
			res.ssENTileSize = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENTileSize.ChangedAttributes = value;
			}
			get {
				return ssENTileSize.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCTileSizeRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENTileSize = new ENTileSizeEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(3, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENTileSize.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENTileSize.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENTileSize.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENTileSize.Read(r, ref index);
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
		public void ReadIM(RCTileSizeRecord r) {
			this = r;
		}


		public static bool operator == (RCTileSizeRecord a, RCTileSizeRecord b) {
			if (a.ssENTileSize != b.ssENTileSize) return false;
			return true;
		}

		public static bool operator != (RCTileSizeRecord a, RCTileSizeRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCTileSizeRecord)) return false;
			return (this == (RCTileSizeRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENTileSize.GetHashCode()
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

		public RCTileSizeRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENTileSize = new ENTileSizeEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fields[0] .FieldType.IsSerializable)
			ssENTileSize = (ENTileSizeEntityRecord) info.GetValue(fields[0] .Name, fields[0] .FieldType);
		}

		public void RecursiveReset() {
			ssENTileSize.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENTileSize.InternalRecursiveSave();
		}


		public RCTileSizeRecord Duplicate() {
			RCTileSizeRecord t;
			t.ssENTileSize = (ENTileSizeEntityRecord) this.ssENTileSize.Duplicate();
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
				ssENTileSize.ToXml(this, recordElem, "TileSize", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "tilesize") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".TileSize")) variable.Value = ssENTileSize; else variable.Optimized = true;
				variable.SetFieldName("tilesize");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENTileSize.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENTileSize.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdTileSize) {
				return ssENTileSize;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENTileSize.FillFromOther((IRecord) other.AttributeGet(IdTileSize));
		}
	} // RCTileSizeRecord
	/// <summary>
	/// RecordList type <code>RLTileSizeRecordList</code> that represents a record list of
	///  <code>TileSize</code>
	/// </summary>
	[Serializable()]
	public partial class RLTileSizeRecordList: GenericRecordList<RCTileSizeRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCTileSizeRecord GetElementDefaultValue() {
			return new RCTileSizeRecord("");
		}

		public T[] ToArray<T>(Func<RCTileSizeRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLTileSizeRecordList recordlist, Func<RCTileSizeRecord, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLTileSizeRecordList ToList<T>(T[] array, Func <T, RCTileSizeRecord> converter) {
			RLTileSizeRecordList result = new RLTileSizeRecordList();
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
		public RLTileSizeRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLTileSizeRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLTileSizeRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLTileSizeRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
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
		protected override OSList<RCTileSizeRecord> NewList() {
			return new RLTileSizeRecordList();
		}


	} // RLTileSizeRecordList

	/// <summary>
	/// RecordList type <code>RLTileSizeList</code> that represents a record list of <code>Text, Boolean,
	///  Integer</code>
	/// </summary>
	[Serializable()]
	public partial class RLTileSizeList: GenericRecordList<ENTileSizeEntityRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override ENTileSizeEntityRecord GetElementDefaultValue() {
			return new ENTileSizeEntityRecord("");
		}

		public T[] ToArray<T>(Func<ENTileSizeEntityRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLTileSizeList recordlist, Func<ENTileSizeEntityRecord, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLTileSizeList ToList<T>(T[] array, Func <T, ENTileSizeEntityRecord> converter) {
			RLTileSizeList result = new RLTileSizeList();
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
		public RLTileSizeList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLTileSizeList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLTileSizeList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLTileSizeList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[0];
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<ENTileSizeEntityRecord> NewList() {
			return new RLTileSizeList();
		}


	} // RLTileSizeList
	public partial class ExtendedActions {
		/// <summary>
		/// Action: GetTileSize
		/// </summary>

		public static void GetTileSize(HeContext heContext, string inParamId, out RCTileSizeRecord outParamRecord) {
			outParamRecord = new RCTileSizeRecord(null);

			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ENTileSizeEntity.eSpaceId;
				try {
					outParamRecord = ENTileSizeEntity.GetRecordById(inParamId);
				} catch {
					using(Transaction trans = DatabaseAccess.ForCurrentDatabase.GetRequestTransaction()) {
						string sql =
						 "SELECT " +
						 " [TYPE]" +
						 ", [ORDER]" +
						 ", [IS_ACTIVE]" +
						 " FROM " + ENTileSizeEntity.LocalViewName(heContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale()) + " " +
						 "WHERE [TYPE] = @inParamId";
						Command sqlCmd = trans.CreateCommand(sql);
						sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
						using(IDataReader reader = sqlCmd.ExecuteReader("Entity Action GetTileSize", true, false, false)) {
							if (reader.Read()) {
								outParamRecord.ReadDB(reader);
							} else
							throw new DataBaseException(ENTileSizeEntity.LocalViewName(heContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale()) + " with key " + inParamId + " was not found");
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
	[XmlType("TileSize")]
	public class WORCTileSizeRecord {
		[System.Xml.Serialization.XmlElement("Type")]
		public string varWSType;

		[System.Xml.Serialization.XmlElement("Order")]
		public int varWSOrder;

		[System.Xml.Serialization.XmlElement("Is_Active")]
		public bool varWSIs_Active;

		public WORCTileSizeRecord() {
			varWSType = (string) "";
			varWSOrder = (int) 0;
			varWSIs_Active = (bool) false;
		}

		public WORCTileSizeRecord(ENTileSizeEntityRecord r) {
			varWSType = BaseAppUtils.RemoveControlChars(r.ssType);
			varWSOrder = (int) r.ssOrder;
			varWSIs_Active = (bool) r.ssIs_Active;
		}

		public static RLTileSizeList ToRecordList(WORCTileSizeRecord[] array) {
			RLTileSizeList rl = new RLTileSizeList();
			if (array != null) {
				foreach(WORCTileSizeRecord val in array) {
					rl.Append(val);
				}
			}
			return rl;
		}

		public static WORCTileSizeRecord[] FromRecordList(RLTileSizeList rl) {
			WORCTileSizeRecord[] array = new WORCTileSizeRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial struct RCTileSizeRecord {
		public static implicit operator WORCTileSizeRecord(RCTileSizeRecord r) {
			return new WORCTileSizeRecord(r.ssENTileSize);
		}

		public static implicit operator RCTileSizeRecord(WORCTileSizeRecord w) {
			RCTileSizeRecord r = new RCTileSizeRecord("");
			if (w != null) {
				r.ssENTileSize = w;
			}
			return r;
		}

	}

	partial struct ENTileSizeEntityRecord {
		public static implicit operator WORCTileSizeRecord(ENTileSizeEntityRecord r) {
			return new WORCTileSizeRecord(r);
		}

		public static implicit operator ENTileSizeEntityRecord(WORCTileSizeRecord w) {
			ENTileSizeEntityRecord r = new ENTileSizeEntityRecord("");
			if (w != null) {
				r.ssType = ((string) w.varWSType ?? "");
				r.ssOrder = (int) w.varWSOrder;
				r.ssIs_Active = (bool) w.varWSIs_Active;
			}
			return r;
		}

	}
}


namespace ssCaseConferencing {
	[Serializable()]
	public partial class WORLTileSizeRecordList {
		public WORCTileSizeRecord[] Array;


		public WORLTileSizeRecordList(WORCTileSizeRecord[] r) {
			if (r == null)
			Array = new WORCTileSizeRecord[0];
			else
			Array = r;
		}
		public WORLTileSizeRecordList() {
			Array = new WORCTileSizeRecord[0];
		}

		public WORLTileSizeRecordList(RLTileSizeRecordList rl) {
			rl=(RLTileSizeRecordList) rl.Duplicate();
			Array = new WORCTileSizeRecord[rl.Length];
			while (!rl.Eof) {
				Array[rl.CurrentRowNumber] = new WORCTileSizeRecord(rl.CurrentRec);
				rl.Advance();
			}
		}

	}
}

namespace ssCaseConferencing {
	partial class RLTileSizeRecordList {
		public static implicit operator RLTileSizeRecordList(WORCTileSizeRecord[] array) {
			RLTileSizeRecordList rl = new RLTileSizeRecordList();
			if (array != null) {
				foreach(WORCTileSizeRecord val in array) {
					rl.Append((RCTileSizeRecord) val);
				}
			}
			return rl;
		}
		public static implicit operator WORCTileSizeRecord[](RLTileSizeRecordList rl) {
			WORCTileSizeRecord[] array = new WORCTileSizeRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = (RCTileSizeRecord) rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial class WORLTileSizeRecordList {
		public static implicit operator RLTileSizeRecordList(WORLTileSizeRecordList w) {
			return w.Array;
		}
		public static implicit operator WORLTileSizeRecordList(RLTileSizeRecordList rl) {
			return new WORLTileSizeRecordList(rl);
		}
		public static implicit operator WORCTileSizeRecord[](WORLTileSizeRecordList w) {
			if (w != null) {
				return w.Array;
			}
			return null;
		}
		public static implicit operator WORLTileSizeRecordList(WORCTileSizeRecord[] array) {
			return new WORLTileSizeRecordList(array);
		}
	}
}

