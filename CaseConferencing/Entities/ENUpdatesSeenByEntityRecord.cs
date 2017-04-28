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

	public sealed partial class ENUpdatesSeenByEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return RsseSpaceCaseConferencingCore.ENUpdatesSeenByEntity.ViewName(tenant, locale);
		}
		public const int eSpaceId = RsseSpaceCaseConferencingCore.ENUpdatesSeenByEntity.eSpaceId;
	} // ENUpdatesSeenByEntity

	/// <summary>
	/// Entity <code>ENUpdatesSeenByEntityRecord</code> that represents the Service Studio entity
	///  <code>UpdatesSeenBy</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("UpdatesSeenBy", "AdDKObh7Jk+H25oFadOFLg", "U4Zx4qCUzUe0A+0C93K3BA", 0, "OSUSR_q0e_UpdatesSeenBy", "")]
	[Serializable()]
	public partial struct ENUpdatesSeenByEntityRecord: ISerializable, ITypedRecord<ENUpdatesSeenByEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("U4Zx4qCUzUe0A+0C93K3BA*sJlrvPmhsUG3uY5UPQ6KXg");
		private static readonly GlobalObjectKey IdUpdate = GlobalObjectKey.Parse("U4Zx4qCUzUe0A+0C93K3BA*cSfdj0IVXUCAK3m+KV0NqA");
		private static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("U4Zx4qCUzUe0A+0C93K3BA*5U77XdXduUSLxXchLmkt3w");

		public static void EnsureInitialized() {}
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

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UPDATE", 0, false, false, true)]
		[System.Xml.Serialization.XmlElement("Update")]
		private int _ssUpdate;
		public int ssUpdate {
			get {
				return _ssUpdate;
			}
			set {
				if ((_ssUpdate!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssUpdate = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("USER", 0, false, false, true)]
		[System.Xml.Serialization.XmlElement("User")]
		private int _ssUser;
		public int ssUser {
			get {
				return _ssUser;
			}
			set {
				if ((_ssUser!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssUser = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENUpdatesSeenByEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(3, true);
			OptimizedAttributes = new BitArray(3, false);
			_ssId = 0;
			_ssUpdate = 0;
			_ssUser = 0;
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
			ssId = r.ReadInteger(index++, "UpdatesSeenBy.Id", 0);
			ssUpdate = r.ReadEntityReference(index++, "UpdatesSeenBy.Update", 0);
			ssUser = r.ReadEntityReference(index++, "UpdatesSeenBy.User", 0);
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
		public void ReadIM(ENUpdatesSeenByEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENUpdatesSeenByEntityRecord a, ENUpdatesSeenByEntityRecord b) {
			if (a.ssId != b.ssId) return false;
			if (a.ssUpdate != b.ssUpdate) return false;
			if (a.ssUser != b.ssUser) return false;
			return true;
		}

		public static bool operator != (ENUpdatesSeenByEntityRecord a, ENUpdatesSeenByEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENUpdatesSeenByEntityRecord)) return false;
			return (this == (ENUpdatesSeenByEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssId.GetHashCode()
				^ ssUpdate.GetHashCode()
				^ ssUser.GetHashCode()
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

		public ENUpdatesSeenByEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(3, true);
			OptimizedAttributes = new BitArray(3, false);
			_ssId = 0;
			_ssUpdate = 0;
			_ssUser = 0;
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fields[0] .FieldType.IsSerializable)
			_ssId = (int) info.GetValue(fields[0] .Name, fields[0] .FieldType);
			if (fields[1] .FieldType.IsSerializable)
			_ssUpdate = (int) info.GetValue(fields[1] .Name, fields[1] .FieldType);
			if (fields[2] .FieldType.IsSerializable)
			_ssUser = (int) info.GetValue(fields[2] .Name, fields[2] .FieldType);
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENUpdatesSeenByEntityRecord Duplicate() {
			ENUpdatesSeenByEntityRecord t;
			t._ssId = this._ssId;
			t._ssUpdate = this._ssUpdate;
			t._ssUser = this._ssUser;
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
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Update")) VarValue.AppendAttribute(recordElem, "Update", ssUpdate, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "Update");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".User")) VarValue.AppendAttribute(recordElem, "User", ssUser, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "User");
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
			} else if (head == "update") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Update")) variable.Value = ssUpdate; else variable.Optimized = true;
			} else if (head == "user") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".User")) variable.Value = ssUser; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdId)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdUpdate)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdUser)) {
				return ChangedAttributes[2];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdId)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdUpdate)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdUser)) {
				return OptimizedAttributes[2];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdId) {
				return ssId;
			} else if (key == IdUpdate) {
				return ssUpdate;
			} else if (key == IdUser) {
				return ssUser;
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
			ssUpdate = (int) other.AttributeGet(IdUpdate);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdUpdate);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdUpdate);
			ssUser = (int) other.AttributeGet(IdUser);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdUser);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdUser);
		}
	} // ENUpdatesSeenByEntityRecord
	/// <summary>
	/// Structure <code>RCUpdatesSeenByRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCUpdatesSeenByRecord: ISerializable, ITypedRecord<RCUpdatesSeenByRecord> {
		private static readonly GlobalObjectKey IdUpdatesSeenBy = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*uixt2N1Iym7XTaScz4q1MQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("UpdatesSeenBy")]
		public ENUpdatesSeenByEntityRecord ssENUpdatesSeenBy;


		public static implicit operator ENUpdatesSeenByEntityRecord(RCUpdatesSeenByRecord r) {
			return r.ssENUpdatesSeenBy;
		}

		public static implicit operator RCUpdatesSeenByRecord(ENUpdatesSeenByEntityRecord r) {
			RCUpdatesSeenByRecord res = new RCUpdatesSeenByRecord(null);
			res.ssENUpdatesSeenBy = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENUpdatesSeenBy.ChangedAttributes = value;
			}
			get {
				return ssENUpdatesSeenBy.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCUpdatesSeenByRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENUpdatesSeenBy = new ENUpdatesSeenByEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(3, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENUpdatesSeenBy.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENUpdatesSeenBy.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENUpdatesSeenBy.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENUpdatesSeenBy.Read(r, ref index);
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
		public void ReadIM(RCUpdatesSeenByRecord r) {
			this = r;
		}


		public static bool operator == (RCUpdatesSeenByRecord a, RCUpdatesSeenByRecord b) {
			if (a.ssENUpdatesSeenBy != b.ssENUpdatesSeenBy) return false;
			return true;
		}

		public static bool operator != (RCUpdatesSeenByRecord a, RCUpdatesSeenByRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCUpdatesSeenByRecord)) return false;
			return (this == (RCUpdatesSeenByRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENUpdatesSeenBy.GetHashCode()
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

		public RCUpdatesSeenByRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENUpdatesSeenBy = new ENUpdatesSeenByEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fields[0] .FieldType.IsSerializable)
			ssENUpdatesSeenBy = (ENUpdatesSeenByEntityRecord) info.GetValue(fields[0] .Name, fields[0] .FieldType);
		}

		public void RecursiveReset() {
			ssENUpdatesSeenBy.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENUpdatesSeenBy.InternalRecursiveSave();
		}


		public RCUpdatesSeenByRecord Duplicate() {
			RCUpdatesSeenByRecord t;
			t.ssENUpdatesSeenBy = (ENUpdatesSeenByEntityRecord) this.ssENUpdatesSeenBy.Duplicate();
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
				ssENUpdatesSeenBy.ToXml(this, recordElem, "UpdatesSeenBy", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "updatesseenby") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdatesSeenBy")) variable.Value = ssENUpdatesSeenBy; else variable.Optimized = true;
				variable.SetFieldName("updatesseenby");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENUpdatesSeenBy.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENUpdatesSeenBy.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdUpdatesSeenBy) {
				return ssENUpdatesSeenBy;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENUpdatesSeenBy.FillFromOther((IRecord) other.AttributeGet(IdUpdatesSeenBy));
		}
	} // RCUpdatesSeenByRecord
	/// <summary>
	/// RecordList type <code>RLUpdatesSeenByRecordList</code> that represents a record list of
	///  <code>UpdatesSeenBy</code>
	/// </summary>
	[Serializable()]
	public partial class RLUpdatesSeenByRecordList: GenericRecordList<RCUpdatesSeenByRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCUpdatesSeenByRecord GetElementDefaultValue() {
			return new RCUpdatesSeenByRecord("");
		}

		public T[] ToArray<T>(Func<RCUpdatesSeenByRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLUpdatesSeenByRecordList recordlist, Func<RCUpdatesSeenByRecord, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLUpdatesSeenByRecordList ToList<T>(T[] array, Func <T, RCUpdatesSeenByRecord> converter) {
			RLUpdatesSeenByRecordList result = new RLUpdatesSeenByRecordList();
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
		public RLUpdatesSeenByRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLUpdatesSeenByRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLUpdatesSeenByRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLUpdatesSeenByRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
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
		protected override OSList<RCUpdatesSeenByRecord> NewList() {
			return new RLUpdatesSeenByRecordList();
		}


	} // RLUpdatesSeenByRecordList

	/// <summary>
	/// RecordList type <code>RLUpdatesSeenByList</code> that represents a record list of
	///  <code>UserIdentifier, Integer, UpdatesIdentifier</code>
	/// </summary>
	[Serializable()]
	public partial class RLUpdatesSeenByList: GenericRecordList<ENUpdatesSeenByEntityRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override ENUpdatesSeenByEntityRecord GetElementDefaultValue() {
			return new ENUpdatesSeenByEntityRecord("");
		}

		public T[] ToArray<T>(Func<ENUpdatesSeenByEntityRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLUpdatesSeenByList recordlist, Func<ENUpdatesSeenByEntityRecord, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLUpdatesSeenByList ToList<T>(T[] array, Func <T, ENUpdatesSeenByEntityRecord> converter) {
			RLUpdatesSeenByList result = new RLUpdatesSeenByList();
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
		public RLUpdatesSeenByList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLUpdatesSeenByList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLUpdatesSeenByList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLUpdatesSeenByList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[0];
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<ENUpdatesSeenByEntityRecord> NewList() {
			return new RLUpdatesSeenByList();
		}


	} // RLUpdatesSeenByList
	public partial class ExtendedActions {
		/// <summary>
		/// Action: CreateUpdatesSeenBy
		/// </summary>

		public static void CreateUpdatesSeenBy(HeContext heContext, RCUpdatesSeenByRecord inParamSource, out int outParamId) {
			outParamId = 0;

			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ENUpdatesSeenByEntity.eSpaceId;
				ENUpdatesSeenByEntityRecord ssENUpdatesSeenBy = inParamSource;
				using(Transaction trans = DatabaseAccess.ForCurrentDatabase.GetRequestTransaction()) {
					string insertSql =
					 "SET NOCOUNT ON; INSERT INTO " + ENUpdatesSeenByEntity.LocalViewName(null, null) + " (" +
					 " [UPDATE]" +
					 ", [USER]" +
					 " ) VALUES (" +
					 " @ssUpdate" +
					 ", @ssUser" +
					 " ) ; SELECT SCOPE_IDENTITY();";
					Command insertSqlCmd = trans.CreateCommand(insertSql);
					if ((ssENUpdatesSeenBy.ssUpdate==0)) {
						insertSqlCmd.CreateParameter("@ssUpdate", DBNull.Value);
					} else {
						insertSqlCmd.CreateParameter("@ssUpdate", DbType.Int32, ssENUpdatesSeenBy.ssUpdate);
					}
					if ((ssENUpdatesSeenBy.ssUser==0)) {
						insertSqlCmd.CreateParameter("@ssUser", DBNull.Value);
					} else {
						insertSqlCmd.CreateParameter("@ssUser", DbType.Int32, ssENUpdatesSeenBy.ssUser);
					}
					outParamId = (int) Convert.ChangeType(insertSqlCmd.ExecuteScalar("Entity Action CreateUpdatesSeenBy", true), typeof(int));
				}
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}

		/// <summary>
		/// Action: CreateOrUpdateUpdatesSeenBy
		/// </summary>

		public static void CreateOrUpdateUpdatesSeenBy(HeContext heContext, BitArray usedFields, RCUpdatesSeenByRecord inParamSource, out int outParamId) {
			outParamId = 0;

			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ENUpdatesSeenByEntity.eSpaceId;
				ENUpdatesSeenByEntityRecord ssENUpdatesSeenBy = inParamSource;
				using(Transaction trans = DatabaseAccess.ForCurrentDatabase.GetRequestTransaction()) {
					if (usedFields == null) {
						usedFields = new BitArray(3, true);
					}
					string updateSet = "SET NOCOUNT OFF; UPDATE " + ENUpdatesSeenByEntity.LocalViewName(heContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale()) + " SET ";
					string parameters = "";
					parameters = (usedFields[1] ?(StringUtils.SuffixIfNotEmpty(parameters, ", ") + "[UPDATE] = @ssUpdate"): parameters);
					parameters = (usedFields[2] ?(StringUtils.SuffixIfNotEmpty(parameters, ", ") + "[USER] = @ssUser"): parameters);
					string whereCondition = " WHERE [ID] = @ssENUpdatesSeenByssId";
					string sql = updateSet + parameters + whereCondition;
					Command sqlCmd = trans.CreateCommand(sql);
					int counter = 0;
					if (usedFields[1]) {
						if ((ssENUpdatesSeenBy.ssUpdate==0)) {
							sqlCmd.CreateParameter("@ssUpdate", DBNull.Value);
						} else {
							sqlCmd.CreateParameter("@ssUpdate", DbType.Int32, ssENUpdatesSeenBy.ssUpdate);
						}
						counter++;
					}
					if (usedFields[2]) {
						if ((ssENUpdatesSeenBy.ssUser==0)) {
							sqlCmd.CreateParameter("@ssUser", DBNull.Value);
						} else {
							sqlCmd.CreateParameter("@ssUser", DbType.Int32, ssENUpdatesSeenBy.ssUser);
						}
						counter++;
					}
					if (counter == 0) {
						string dummyUpdate = "[UPDATE] = [UPDATE]";
						string noUpdate = updateSet + dummyUpdate + whereCondition;
						sqlCmd = trans.CreateCommand(noUpdate);
					}
					sqlCmd.CreateParameter("@ssENUpdatesSeenByssId", DbType.Int32, ssENUpdatesSeenBy.ssId);
					counter = sqlCmd.ExecuteNonQueryWithoutTransformParametersSyntax("Entity Action CreateOrUpdateUpdatesSeenBy (update)", true);
					if (counter == 0) {
						string insertSql =
						 "SET NOCOUNT ON; INSERT INTO " + ENUpdatesSeenByEntity.LocalViewName(null, null) + " (" +
						 " [UPDATE]" +
						 ", [USER]" +
						 " ) VALUES (" +
						 " @ssUpdate" +
						 ", @ssUser" +
						 " ) ; SELECT SCOPE_IDENTITY();";
						Command insertSqlCmd = trans.CreateCommand(insertSql);
						if ((ssENUpdatesSeenBy.ssUpdate==0)) {
							insertSqlCmd.CreateParameter("@ssUpdate", DBNull.Value);
						} else {
							insertSqlCmd.CreateParameter("@ssUpdate", DbType.Int32, ssENUpdatesSeenBy.ssUpdate);
						}
						if ((ssENUpdatesSeenBy.ssUser==0)) {
							insertSqlCmd.CreateParameter("@ssUser", DBNull.Value);
						} else {
							insertSqlCmd.CreateParameter("@ssUser", DbType.Int32, ssENUpdatesSeenBy.ssUser);
						}
						outParamId = (int) Convert.ChangeType(insertSqlCmd.ExecuteScalar("Entity Action CreateOrUpdateUpdatesSeenBy", true), typeof(int));
					} else {
						outParamId = ssENUpdatesSeenBy.ssId;
					}
				}
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}

		/// <summary>
		/// Action: DeleteUpdatesSeenBy
		/// </summary>

		public static void DeleteUpdatesSeenBy(HeContext heContext, int inParamId) {
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ENUpdatesSeenByEntity.eSpaceId;
				using(Transaction trans = DatabaseAccess.ForCurrentDatabase.GetRequestTransaction()) {
					string sql =
					 "DELETE " +
					 "FROM " + ENUpdatesSeenByEntity.LocalViewName(heContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale()) + " " +
					 "WHERE [ID] = @inParamId";
					Command sqlCmd = trans.CreateCommand(sql);
					sqlCmd.CreateParameter("@inParamId", DbType.Int32, inParamId);
					sqlCmd.ExecuteNonQueryWithoutTransformParametersSyntax("Entity Action DeleteUpdatesSeenBy", true);
				}
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}

		/// <summary>
		/// Action: GetUpdatesSeenBy
		/// </summary>

		public static void GetUpdatesSeenBy(HeContext heContext, int inParamId, out RCUpdatesSeenByRecord outParamRecord) {
			outParamRecord = new RCUpdatesSeenByRecord(null);

			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ENUpdatesSeenByEntity.eSpaceId;
				using(Transaction trans = DatabaseAccess.ForCurrentDatabase.GetRequestTransaction()) {
					string sql =
					 "SELECT " +
					 " [ID]" +
					 ", [UPDATE]" +
					 ", [USER]" +
					 " FROM " + ENUpdatesSeenByEntity.LocalViewName(heContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale()) + " " +
					 "WHERE [ID] = @inParamId";
					Command sqlCmd = trans.CreateCommand(sql);
					sqlCmd.CreateParameter("@inParamId", DbType.Int32, inParamId);
					using(IDataReader reader = sqlCmd.ExecuteReader("Entity Action GetUpdatesSeenBy", true, false, false)) {
						if (reader.Read()) {
							outParamRecord.ReadDB(reader);
							outParamRecord.AllOptimizedAttributes = new BitArray[] {
								new BitArray(3, false)
							}
							;
						} else
						throw new DataBaseException(ENUpdatesSeenByEntity.LocalViewName(heContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale()) + " with key " + inParamId + " was not found");
					}
				}
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}

		/// <summary>
		/// Action: GetUpdatesSeenByForUpdate
		/// </summary>

		public static void GetUpdatesSeenByForUpdate(HeContext heContext, int inParamId, out RCUpdatesSeenByRecord outParamRecord) {
			outParamRecord = new RCUpdatesSeenByRecord(null);

			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ENUpdatesSeenByEntity.eSpaceId;
				using(Transaction trans = DatabaseAccess.ForCurrentDatabase.GetRequestTransaction()) {
					string sql =
					 "SELECT " +
					 " [ID]" +
					 ", [UPDATE]" +
					 ", [USER]" +
					 "FROM " + ENUpdatesSeenByEntity.LocalViewName(heContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale()) + " WITH ( UPDLOCK ) " +
					 "WHERE [ID] = @inParamId ";
					Command sqlCmd = trans.CreateCommand(sql);
					sqlCmd.CreateParameter("@inParamId", DbType.Int32, inParamId);
					using(IDataReader reader = sqlCmd.ExecuteReader("Entity Action GetUpdatesSeenByForUpdate", true, false, false)) {
						if (reader.Read()) {
							outParamRecord.ReadDB(reader);
							outParamRecord.AllOptimizedAttributes = new BitArray[] {
								new BitArray(3, false)
							}
							;
						} else
						throw new DataBaseException(ENUpdatesSeenByEntity.LocalViewName(heContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale()) + " with key " + inParamId + " was not found");
					}
				}
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}

		/// <summary>
		/// Action: UpdateUpdatesSeenBy
		/// </summary>

		public static void UpdateUpdatesSeenBy(HeContext heContext, BitArray usedFields, RCUpdatesSeenByRecord inParamSource) {
			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ENUpdatesSeenByEntity.eSpaceId;
				ENUpdatesSeenByEntityRecord ssENUpdatesSeenBy = inParamSource;
				using(Transaction trans = DatabaseAccess.ForCurrentDatabase.GetRequestTransaction()) {
					if (usedFields == null) {
						usedFields = new BitArray(3, true);
					}
					string updateSet = "SET NOCOUNT OFF; UPDATE " + ENUpdatesSeenByEntity.LocalViewName(heContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale()) + " SET ";
					string parameters = "";
					parameters = (usedFields[1] ?(StringUtils.SuffixIfNotEmpty(parameters, ", ") + "[UPDATE] = @ssUpdate"): parameters);
					parameters = (usedFields[2] ?(StringUtils.SuffixIfNotEmpty(parameters, ", ") + "[USER] = @ssUser"): parameters);
					string whereCondition = " WHERE [ID] = @ssENUpdatesSeenByssId";
					string sql = updateSet + parameters + whereCondition;
					Command sqlCmd = trans.CreateCommand(sql);
					int counter = 0;
					if (usedFields[1]) {
						if ((ssENUpdatesSeenBy.ssUpdate==0)) {
							sqlCmd.CreateParameter("@ssUpdate", DBNull.Value);
						} else {
							sqlCmd.CreateParameter("@ssUpdate", DbType.Int32, ssENUpdatesSeenBy.ssUpdate);
						}
						counter++;
					}
					if (usedFields[2]) {
						if ((ssENUpdatesSeenBy.ssUser==0)) {
							sqlCmd.CreateParameter("@ssUser", DBNull.Value);
						} else {
							sqlCmd.CreateParameter("@ssUser", DbType.Int32, ssENUpdatesSeenBy.ssUser);
						}
						counter++;
					}
					if (counter == 0) {
						string dummyUpdate = "[UPDATE] = [UPDATE]";
						string noUpdate = updateSet + dummyUpdate + whereCondition;
						sqlCmd = trans.CreateCommand(noUpdate);
					}
					sqlCmd.CreateParameter("@ssENUpdatesSeenByssId", DbType.Int32, ssENUpdatesSeenBy.ssId);
					if (sqlCmd.ExecuteNonQueryWithoutTransformParametersSyntax("Entity Action UpdateUpdatesSeenBy", true) <= 0)
					throw new DataBaseException(ENUpdatesSeenByEntity.LocalViewName(heContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale()) + " with key " + ssENUpdatesSeenBy.ssId + " was not updated");
				}
			} finally {
				heContext.CurrentESpaceId = oldCurrentESpaceId;
			}
		}

	}
}

namespace ssCaseConferencing {
	[XmlType("UpdatesSeenBy")]
	public class WORCUpdatesSeenByRecord {
		[System.Xml.Serialization.XmlElement("Id")]
		public int varWSId;

		[System.Xml.Serialization.XmlElement("Update")]
		public int varWSUpdate;

		[System.Xml.Serialization.XmlElement("User")]
		public int varWSUser;

		public WORCUpdatesSeenByRecord() {
			varWSId = (int) 0;
			varWSUpdate = (int) 0;
			varWSUser = (int) 0;
		}

		public WORCUpdatesSeenByRecord(ENUpdatesSeenByEntityRecord r) {
			varWSId = (int) r.ssId;
			varWSUpdate = (int) r.ssUpdate;
			varWSUser = (int) r.ssUser;
		}

		public static RLUpdatesSeenByList ToRecordList(WORCUpdatesSeenByRecord[] array) {
			RLUpdatesSeenByList rl = new RLUpdatesSeenByList();
			if (array != null) {
				foreach(WORCUpdatesSeenByRecord val in array) {
					rl.Append(val);
				}
			}
			return rl;
		}

		public static WORCUpdatesSeenByRecord[] FromRecordList(RLUpdatesSeenByList rl) {
			WORCUpdatesSeenByRecord[] array = new WORCUpdatesSeenByRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial struct RCUpdatesSeenByRecord {
		public static implicit operator WORCUpdatesSeenByRecord(RCUpdatesSeenByRecord r) {
			return new WORCUpdatesSeenByRecord(r.ssENUpdatesSeenBy);
		}

		public static implicit operator RCUpdatesSeenByRecord(WORCUpdatesSeenByRecord w) {
			RCUpdatesSeenByRecord r = new RCUpdatesSeenByRecord("");
			if (w != null) {
				r.ssENUpdatesSeenBy = w;
			}
			return r;
		}

	}

	partial struct ENUpdatesSeenByEntityRecord {
		public static implicit operator WORCUpdatesSeenByRecord(ENUpdatesSeenByEntityRecord r) {
			return new WORCUpdatesSeenByRecord(r);
		}

		public static implicit operator ENUpdatesSeenByEntityRecord(WORCUpdatesSeenByRecord w) {
			ENUpdatesSeenByEntityRecord r = new ENUpdatesSeenByEntityRecord("");
			if (w != null) {
				r.ssId = (int) w.varWSId;
				r.ssUpdate = (int) w.varWSUpdate;
				r.ssUser = (int) w.varWSUser;
			}
			return r;
		}

	}
}


namespace ssCaseConferencing {
	[Serializable()]
	public partial class WORLUpdatesSeenByRecordList {
		public WORCUpdatesSeenByRecord[] Array;


		public WORLUpdatesSeenByRecordList(WORCUpdatesSeenByRecord[] r) {
			if (r == null)
			Array = new WORCUpdatesSeenByRecord[0];
			else
			Array = r;
		}
		public WORLUpdatesSeenByRecordList() {
			Array = new WORCUpdatesSeenByRecord[0];
		}

		public WORLUpdatesSeenByRecordList(RLUpdatesSeenByRecordList rl) {
			rl=(RLUpdatesSeenByRecordList) rl.Duplicate();
			Array = new WORCUpdatesSeenByRecord[rl.Length];
			while (!rl.Eof) {
				Array[rl.CurrentRowNumber] = new WORCUpdatesSeenByRecord(rl.CurrentRec);
				rl.Advance();
			}
		}

	}
}

namespace ssCaseConferencing {
	partial class RLUpdatesSeenByRecordList {
		public static implicit operator RLUpdatesSeenByRecordList(WORCUpdatesSeenByRecord[] array) {
			RLUpdatesSeenByRecordList rl = new RLUpdatesSeenByRecordList();
			if (array != null) {
				foreach(WORCUpdatesSeenByRecord val in array) {
					rl.Append((RCUpdatesSeenByRecord) val);
				}
			}
			return rl;
		}
		public static implicit operator WORCUpdatesSeenByRecord[](RLUpdatesSeenByRecordList rl) {
			WORCUpdatesSeenByRecord[] array = new WORCUpdatesSeenByRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = (RCUpdatesSeenByRecord) rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial class WORLUpdatesSeenByRecordList {
		public static implicit operator RLUpdatesSeenByRecordList(WORLUpdatesSeenByRecordList w) {
			return w.Array;
		}
		public static implicit operator WORLUpdatesSeenByRecordList(RLUpdatesSeenByRecordList rl) {
			return new WORLUpdatesSeenByRecordList(rl);
		}
		public static implicit operator WORCUpdatesSeenByRecord[](WORLUpdatesSeenByRecordList w) {
			if (w != null) {
				return w.Array;
			}
			return null;
		}
		public static implicit operator WORLUpdatesSeenByRecordList(WORCUpdatesSeenByRecord[] array) {
			return new WORLUpdatesSeenByRecordList(array);
		}
	}
}

