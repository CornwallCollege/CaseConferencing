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

	public sealed partial class ENApplicationPermissionEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return RsseSpaceUserPermissions.ENApplicationPermissionEntity.ViewName(tenant, locale);
		}
		public const int eSpaceId = RsseSpaceUserPermissions.ENApplicationPermissionEntity.eSpaceId;
	} // ENApplicationPermissionEntity

	/// <summary>
	/// Entity <code>ENApplicationPermissionEntityRecord</code> that represents the Service Studio entity
	///  <code>ApplicationPermission</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("ApplicationPermission", "ff1iVQT2TEyAwozxlLmtRQ", "VG7aGSJNbE6NUzd5UwKOWA", 0, "OSUSR_31l_ApplicationPermission", "")]
	[Serializable()]
	public partial struct ENApplicationPermissionEntityRecord: ISerializable, ITypedRecord<ENApplicationPermissionEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("VG7aGSJNbE6NUzd5UwKOWA*zMS+A33iDECWa3tx+lZgmQ");
		private static readonly GlobalObjectKey IdLabel = GlobalObjectKey.Parse("VG7aGSJNbE6NUzd5UwKOWA*18ENRixsaUi10p0ikNAMFA");
		private static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("VG7aGSJNbE6NUzd5UwKOWA*g4DvvDwRy0etR4SlQw6s_A");
		private static readonly GlobalObjectKey IdParentId = GlobalObjectKey.Parse("VG7aGSJNbE6NUzd5UwKOWA*FWMtW_dhXUO33dgg3C11cg");
		private static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("VG7aGSJNbE6NUzd5UwKOWA*rObfs3zVJEC5TUAq1B0Cvg");
		private static readonly GlobalObjectKey IdIs_Active = GlobalObjectKey.Parse("VG7aGSJNbE6NUzd5UwKOWA*XOD9Os81nEqdr+iz9_Z8fg");

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ID", 0, false, true, false)]
		[System.Xml.Serialization.XmlElement("Id")]
		private int _ssId;
		public int ssId {
			get {
				return _ssId;
			}
			set {
				if ((_ssId!=value) || OptimizedAttributes[0]) {
					ChangedAttributes = new BitArray(6, true);
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

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("DESCRIPTION", 500, false, false, false)]
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

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("PARENTID", 0, false, false, true)]
		[System.Xml.Serialization.XmlElement("ParentId")]
		private int _ssParentId;
		public int ssParentId {
			get {
				return _ssParentId;
			}
			set {
				if ((_ssParentId!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
					_ssParentId = value;
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
				if ((_ssOrder!=value) || OptimizedAttributes[4]) {
					ChangedAttributes[4] = true;
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
				if ((_ssIs_Active!=value) || OptimizedAttributes[5]) {
					ChangedAttributes[5] = true;
					_ssIs_Active = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENApplicationPermissionEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(6, true);
			OptimizedAttributes = new BitArray(6, false);
			_ssId = 0;
			_ssLabel = "";
			_ssDescription = "";
			_ssParentId = 0;
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
			ssId = r.ReadInteger(index++, "ApplicationPermission.Id", 0);
			ssLabel = r.ReadText(index++, "ApplicationPermission.Label", "");
			ssDescription = r.ReadText(index++, "ApplicationPermission.Description", "");
			ssParentId = r.ReadEntityReference(index++, "ApplicationPermission.ParentId", 0);
			ssOrder = r.ReadInteger(index++, "ApplicationPermission.Order", 0);
			ssIs_Active = r.ReadBoolean(index++, "ApplicationPermission.Is_Active", false);
			ChangedAttributes = new BitArray(6, false);
			OptimizedAttributes = new BitArray(6, false);
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
		public void ReadIM(ENApplicationPermissionEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENApplicationPermissionEntityRecord a, ENApplicationPermissionEntityRecord b) {
			if (a.ssId != b.ssId) return false;
			if (a.ssLabel != b.ssLabel) return false;
			if (a.ssDescription != b.ssDescription) return false;
			if (a.ssParentId != b.ssParentId) return false;
			if (a.ssOrder != b.ssOrder) return false;
			if (a.ssIs_Active != b.ssIs_Active) return false;
			return true;
		}

		public static bool operator != (ENApplicationPermissionEntityRecord a, ENApplicationPermissionEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENApplicationPermissionEntityRecord)) return false;
			return (this == (ENApplicationPermissionEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssId.GetHashCode()
				^ ssLabel.GetHashCode()
				^ ssDescription.GetHashCode()
				^ ssParentId.GetHashCode()
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

		public ENApplicationPermissionEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(6, true);
			OptimizedAttributes = new BitArray(6, false);
			_ssId = 0;
			_ssLabel = "";
			_ssDescription = "";
			_ssParentId = 0;
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
			_ssDescription = (string) info.GetValue(fields[2] .Name, fields[2] .FieldType);
			if (fields[3] .FieldType.IsSerializable)
			_ssParentId = (int) info.GetValue(fields[3] .Name, fields[3] .FieldType);
			if (fields[4] .FieldType.IsSerializable)
			_ssOrder = (int) info.GetValue(fields[4] .Name, fields[4] .FieldType);
			if (fields[5] .FieldType.IsSerializable)
			_ssIs_Active = (bool) info.GetValue(fields[5] .Name, fields[5] .FieldType);
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENApplicationPermissionEntityRecord Duplicate() {
			ENApplicationPermissionEntityRecord t;
			t._ssId = this._ssId;
			t._ssLabel = this._ssLabel;
			t._ssDescription = this._ssDescription;
			t._ssParentId = this._ssParentId;
			t._ssOrder = this._ssOrder;
			t._ssIs_Active = this._ssIs_Active;
			t.ChangedAttributes = new BitArray(6);
			t.OptimizedAttributes = new BitArray(6);
			for (int i = 0; i < 6; i++) {
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
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Description")) VarValue.AppendAttribute(recordElem, "Description", ssDescription, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Description");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".ParentId")) VarValue.AppendAttribute(recordElem, "ParentId", ssParentId, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "ParentId");
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
			} else if (head == "parentid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ParentId")) variable.Value = ssParentId; else variable.Optimized = true;
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
			} else if (key.Equals(IdParentId)) {
				return ChangedAttributes[3];
			} else if (key.Equals(IdOrder)) {
				return ChangedAttributes[4];
			} else if (key.Equals(IdIs_Active)) {
				return ChangedAttributes[5];
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
			} else if (key.Equals(IdParentId)) {
				return OptimizedAttributes[3];
			} else if (key.Equals(IdOrder)) {
				return OptimizedAttributes[4];
			} else if (key.Equals(IdIs_Active)) {
				return OptimizedAttributes[5];
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
			} else if (key == IdParentId) {
				return ssParentId;
			} else if (key == IdOrder) {
				return ssOrder;
			} else if (key == IdIs_Active) {
				return ssIs_Active;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(6);
			OptimizedAttributes = new BitArray(6);
			if (other == null) return;
			ssId = (int) other.AttributeGet(IdId);
			ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
			ssLabel = (string) other.AttributeGet(IdLabel);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdLabel);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdLabel);
			ssDescription = (string) other.AttributeGet(IdDescription);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdDescription);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdDescription);
			ssParentId = (int) other.AttributeGet(IdParentId);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdParentId);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdParentId);
			ssOrder = (int) other.AttributeGet(IdOrder);
			ChangedAttributes[4] = other.ChangedAttributeGet(IdOrder);
			OptimizedAttributes[4] = other.OptimizedAttributeGet(IdOrder);
			ssIs_Active = (bool) other.AttributeGet(IdIs_Active);
			ChangedAttributes[5] = other.ChangedAttributeGet(IdIs_Active);
			OptimizedAttributes[5] = other.OptimizedAttributeGet(IdIs_Active);
		}
	} // ENApplicationPermissionEntityRecord
	/// <summary>
	/// Static Entity <code>ENApplicationPermissionEntity</code> gets the values for this static entity
	///  records in runtime <code>ApplicationPermission</code>
	/// </summary>
	partial class ENApplicationPermissionEntity {


		static ENApplicationPermissionEntity() {
			ENApplicationPermissionEntityRecordTypeFactoryImpl.InitializeFactory();
		}

		public static ENApplicationPermissionEntityRecord GetRecordById(int id) {
			return (ENApplicationPermissionEntityRecord) RsseSpaceUserPermissions.ENApplicationPermissionEntity.GetRecordById(id);
		}

		public static ENApplicationPermissionEntityRecord GetRecordByName(string name) {
			return (ENApplicationPermissionEntityRecord) RsseSpaceUserPermissions.ENApplicationPermissionEntity.GetRecordByName(name);
		}

		public static ENApplicationPermissionEntityRecord GetRecordByKey(ObjectKey key) {
			return (ENApplicationPermissionEntityRecord) RsseSpaceUserPermissions.ENApplicationPermissionEntity.GetRecordByKey(key);
		}
	} // ENApplicationPermissionEntity;
	/// <summary>
	/// Structure <code>RCApplicationPermissionRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCApplicationPermissionRecord: ISerializable, ITypedRecord<RCApplicationPermissionRecord> {
		private static readonly GlobalObjectKey IdApplicationPermission = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*V8cZqgP+kFa109rn8NYV_A");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("ApplicationPermission")]
		public ENApplicationPermissionEntityRecord ssENApplicationPermission;


		public static implicit operator ENApplicationPermissionEntityRecord(RCApplicationPermissionRecord r) {
			return r.ssENApplicationPermission;
		}

		public static implicit operator RCApplicationPermissionRecord(ENApplicationPermissionEntityRecord r) {
			RCApplicationPermissionRecord res = new RCApplicationPermissionRecord(null);
			res.ssENApplicationPermission = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENApplicationPermission.ChangedAttributes = value;
			}
			get {
				return ssENApplicationPermission.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCApplicationPermissionRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENApplicationPermission = new ENApplicationPermissionEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(6, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENApplicationPermission.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENApplicationPermission.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENApplicationPermission.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENApplicationPermission.Read(r, ref index);
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
		public void ReadIM(RCApplicationPermissionRecord r) {
			this = r;
		}


		public static bool operator == (RCApplicationPermissionRecord a, RCApplicationPermissionRecord b) {
			if (a.ssENApplicationPermission != b.ssENApplicationPermission) return false;
			return true;
		}

		public static bool operator != (RCApplicationPermissionRecord a, RCApplicationPermissionRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCApplicationPermissionRecord)) return false;
			return (this == (RCApplicationPermissionRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENApplicationPermission.GetHashCode()
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

		public RCApplicationPermissionRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENApplicationPermission = new ENApplicationPermissionEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fields[0] .FieldType.IsSerializable)
			ssENApplicationPermission = (ENApplicationPermissionEntityRecord) info.GetValue(fields[0] .Name, fields[0] .FieldType);
		}

		public void RecursiveReset() {
			ssENApplicationPermission.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENApplicationPermission.InternalRecursiveSave();
		}


		public RCApplicationPermissionRecord Duplicate() {
			RCApplicationPermissionRecord t;
			t.ssENApplicationPermission = (ENApplicationPermissionEntityRecord) this.ssENApplicationPermission.Duplicate();
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
				ssENApplicationPermission.ToXml(this, recordElem, "ApplicationPermission", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "applicationpermission") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ApplicationPermission")) variable.Value = ssENApplicationPermission; else variable.Optimized = true;
				variable.SetFieldName("applicationpermission");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENApplicationPermission.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENApplicationPermission.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdApplicationPermission) {
				return ssENApplicationPermission;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENApplicationPermission.FillFromOther((IRecord) other.AttributeGet(IdApplicationPermission));
		}
	} // RCApplicationPermissionRecord
	/// <summary>
	/// RecordList type <code>RLApplicationPermissionRecordList</code> that represents a record list of
	///  <code>ApplicationPermission</code>
	/// </summary>
	[Serializable()]
	public partial class RLApplicationPermissionRecordList: GenericRecordList<RCApplicationPermissionRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCApplicationPermissionRecord GetElementDefaultValue() {
			return new RCApplicationPermissionRecord("");
		}

		public T[] ToArray<T>(Func<RCApplicationPermissionRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLApplicationPermissionRecordList recordlist, Func<RCApplicationPermissionRecord, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLApplicationPermissionRecordList ToList<T>(T[] array, Func <T, RCApplicationPermissionRecord> converter) {
			RLApplicationPermissionRecordList result = new RLApplicationPermissionRecordList();
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
		public RLApplicationPermissionRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLApplicationPermissionRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLApplicationPermissionRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLApplicationPermissionRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(6, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCApplicationPermissionRecord> NewList() {
			return new RLApplicationPermissionRecordList();
		}


	} // RLApplicationPermissionRecordList

	/// <summary>
	/// RecordList type <code>RLApplicationPermissionList</code> that represents a record list of
	///  <code>ApplicationPermissionIdentifier, Text, Text, Boolean, Integer, Integer</code>
	/// </summary>
	[Serializable()]
	public partial class RLApplicationPermissionList: GenericRecordList<ENApplicationPermissionEntityRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override ENApplicationPermissionEntityRecord GetElementDefaultValue() {
			return new ENApplicationPermissionEntityRecord("");
		}

		public T[] ToArray<T>(Func<ENApplicationPermissionEntityRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLApplicationPermissionList recordlist, Func<ENApplicationPermissionEntityRecord, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLApplicationPermissionList ToList<T>(T[] array, Func <T, ENApplicationPermissionEntityRecord> converter) {
			RLApplicationPermissionList result = new RLApplicationPermissionList();
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
		public RLApplicationPermissionList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLApplicationPermissionList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLApplicationPermissionList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLApplicationPermissionList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[0];
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<ENApplicationPermissionEntityRecord> NewList() {
			return new RLApplicationPermissionList();
		}


	} // RLApplicationPermissionList
	public partial class ExtendedActions {
		/// <summary>
		/// Action: GetApplicationPermission
		/// </summary>

		public static void GetApplicationPermission(HeContext heContext, int inParamId, out RCApplicationPermissionRecord outParamRecord) {
			outParamRecord = new RCApplicationPermissionRecord(null);

			int oldCurrentESpaceId = heContext.CurrentESpaceId;
			try {
				heContext.CurrentESpaceId = ENApplicationPermissionEntity.eSpaceId;
				try {
					outParamRecord = ENApplicationPermissionEntity.GetRecordById(inParamId);
				} catch {
					using(Transaction trans = DatabaseAccess.ForCurrentDatabase.GetRequestTransaction()) {
						string sql =
						 "SELECT " +
						 " [ID]" +
						 ", [LABEL]" +
						 ", [DESCRIPTION]" +
						 ", [PARENTID]" +
						 ", [ORDER]" +
						 ", [IS_ACTIVE]" +
						 " FROM " + ENApplicationPermissionEntity.LocalViewName(heContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale()) + " " +
						 "WHERE [ID] = @inParamId";
						Command sqlCmd = trans.CreateCommand(sql);
						sqlCmd.CreateParameter("@inParamId", DbType.Int32, inParamId);
						using(IDataReader reader = sqlCmd.ExecuteReader("Entity Action GetApplicationPermission", true, false, false)) {
							if (reader.Read()) {
								outParamRecord.ReadDB(reader);
							} else
							throw new DataBaseException(ENApplicationPermissionEntity.LocalViewName(heContext.AppInfo.Tenant.Id, BuiltInFunction.GetCurrentLocale()) + " with key " + inParamId + " was not found");
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
	[XmlType("ApplicationPermission")]
	public class WORCApplicationPermissionRecord {
		[System.Xml.Serialization.XmlElement("Id")]
		public int varWSId;

		[System.Xml.Serialization.XmlElement("Label")]
		public string varWSLabel;

		[System.Xml.Serialization.XmlElement("Description")]
		public string varWSDescription;

		[System.Xml.Serialization.XmlElement("ParentId")]
		public int varWSParentId;

		[System.Xml.Serialization.XmlElement("Order")]
		public int varWSOrder;

		[System.Xml.Serialization.XmlElement("Is_Active")]
		public bool varWSIs_Active;

		public WORCApplicationPermissionRecord() {
			varWSId = (int) 0;
			varWSLabel = (string) "";
			varWSDescription = (string) "";
			varWSParentId = (int) 0;
			varWSOrder = (int) 0;
			varWSIs_Active = (bool) false;
		}

		public WORCApplicationPermissionRecord(ENApplicationPermissionEntityRecord r) {
			varWSId = (int) r.ssId;
			varWSLabel = BaseAppUtils.RemoveControlChars(r.ssLabel);
			varWSDescription = BaseAppUtils.RemoveControlChars(r.ssDescription);
			varWSParentId = (int) r.ssParentId;
			varWSOrder = (int) r.ssOrder;
			varWSIs_Active = (bool) r.ssIs_Active;
		}

		public static RLApplicationPermissionList ToRecordList(WORCApplicationPermissionRecord[] array) {
			RLApplicationPermissionList rl = new RLApplicationPermissionList();
			if (array != null) {
				foreach(WORCApplicationPermissionRecord val in array) {
					rl.Append(val);
				}
			}
			return rl;
		}

		public static WORCApplicationPermissionRecord[] FromRecordList(RLApplicationPermissionList rl) {
			WORCApplicationPermissionRecord[] array = new WORCApplicationPermissionRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial struct RCApplicationPermissionRecord {
		public static implicit operator WORCApplicationPermissionRecord(RCApplicationPermissionRecord r) {
			return new WORCApplicationPermissionRecord(r.ssENApplicationPermission);
		}

		public static implicit operator RCApplicationPermissionRecord(WORCApplicationPermissionRecord w) {
			RCApplicationPermissionRecord r = new RCApplicationPermissionRecord("");
			if (w != null) {
				r.ssENApplicationPermission = w;
			}
			return r;
		}

	}

	partial struct ENApplicationPermissionEntityRecord {
		public static implicit operator WORCApplicationPermissionRecord(ENApplicationPermissionEntityRecord r) {
			return new WORCApplicationPermissionRecord(r);
		}

		public static implicit operator ENApplicationPermissionEntityRecord(WORCApplicationPermissionRecord w) {
			ENApplicationPermissionEntityRecord r = new ENApplicationPermissionEntityRecord("");
			if (w != null) {
				r.ssId = (int) w.varWSId;
				r.ssLabel = ((string) w.varWSLabel ?? "");
				r.ssDescription = ((string) w.varWSDescription ?? "");
				r.ssParentId = (int) w.varWSParentId;
				r.ssOrder = (int) w.varWSOrder;
				r.ssIs_Active = (bool) w.varWSIs_Active;
			}
			return r;
		}

	}
}


namespace ssCaseConferencing {
	[Serializable()]
	public partial class WORLApplicationPermissionRecordList {
		public WORCApplicationPermissionRecord[] Array;


		public WORLApplicationPermissionRecordList(WORCApplicationPermissionRecord[] r) {
			if (r == null)
			Array = new WORCApplicationPermissionRecord[0];
			else
			Array = r;
		}
		public WORLApplicationPermissionRecordList() {
			Array = new WORCApplicationPermissionRecord[0];
		}

		public WORLApplicationPermissionRecordList(RLApplicationPermissionRecordList rl) {
			rl=(RLApplicationPermissionRecordList) rl.Duplicate();
			Array = new WORCApplicationPermissionRecord[rl.Length];
			while (!rl.Eof) {
				Array[rl.CurrentRowNumber] = new WORCApplicationPermissionRecord(rl.CurrentRec);
				rl.Advance();
			}
		}

	}
}

namespace ssCaseConferencing {
	partial class RLApplicationPermissionRecordList {
		public static implicit operator RLApplicationPermissionRecordList(WORCApplicationPermissionRecord[] array) {
			RLApplicationPermissionRecordList rl = new RLApplicationPermissionRecordList();
			if (array != null) {
				foreach(WORCApplicationPermissionRecord val in array) {
					rl.Append((RCApplicationPermissionRecord) val);
				}
			}
			return rl;
		}
		public static implicit operator WORCApplicationPermissionRecord[](RLApplicationPermissionRecordList rl) {
			WORCApplicationPermissionRecord[] array = new WORCApplicationPermissionRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = (RCApplicationPermissionRecord) rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial class WORLApplicationPermissionRecordList {
		public static implicit operator RLApplicationPermissionRecordList(WORLApplicationPermissionRecordList w) {
			return w.Array;
		}
		public static implicit operator WORLApplicationPermissionRecordList(RLApplicationPermissionRecordList rl) {
			return new WORLApplicationPermissionRecordList(rl);
		}
		public static implicit operator WORCApplicationPermissionRecord[](WORLApplicationPermissionRecordList w) {
			if (w != null) {
				return w.Array;
			}
			return null;
		}
		public static implicit operator WORLApplicationPermissionRecordList(WORCApplicationPermissionRecord[] array) {
			return new WORLApplicationPermissionRecordList(array);
		}
	}
}

