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
using OutSystems.RuntimeCommon;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.Internal.Db;
using System.Xml.Serialization;
using System.Collections;

namespace ssCaseConferencing {
	/// <summary>
	/// Structure <code>STDashboardFilterStructure</code> that represents the Service Studio structure
	///  <code>DashboardFilter</code> <p> Description: </p>
	/// </summary>
	[Serializable()]
	public partial struct STDashboardFilterStructure: ISerializable, ITypedRecord<STDashboardFilterStructure>, ISimpleRecord {
		private static readonly GlobalObjectKey IdIsFavourites = GlobalObjectKey.Parse("shmcdFKEAEWXZGfrlZEwCQ*zFblygFVr06Xe3gENi3e7w");
		private static readonly GlobalObjectKey IdRedRAGFilterOn = GlobalObjectKey.Parse("shmcdFKEAEWXZGfrlZEwCQ*LMliId4oA06ATSSb+445Yw");
		private static readonly GlobalObjectKey IdAmberRAGFilterOn = GlobalObjectKey.Parse("shmcdFKEAEWXZGfrlZEwCQ*Lhs8wkWe+kqN3Jq1_R6sPQ");
		private static readonly GlobalObjectKey IdGreenRAGFilterOn = GlobalObjectKey.Parse("shmcdFKEAEWXZGfrlZEwCQ*DNMAOlF6bE+m4_Zv9YCPHQ");
		private static readonly GlobalObjectKey IdLatestUpdatesFilterOn = GlobalObjectKey.Parse("shmcdFKEAEWXZGfrlZEwCQ*xiAyl2AhAUKPb_HSntffOw");
		private static readonly GlobalObjectKey IdCauseForConcernFilterOn = GlobalObjectKey.Parse("shmcdFKEAEWXZGfrlZEwCQ*v9fOKVEe4kCOfSjvhRb8Yw");
		private static readonly GlobalObjectKey IdRedAttendanceFilterOn = GlobalObjectKey.Parse("shmcdFKEAEWXZGfrlZEwCQ*eJdoHAi4vE6+dMydxIweIQ");
		private static readonly GlobalObjectKey IdAmberAttendanceFilterOn = GlobalObjectKey.Parse("shmcdFKEAEWXZGfrlZEwCQ*ZlZVueBziUCvR00pimLE3Q");
		private static readonly GlobalObjectKey IdGreenAttendanceFilterOn = GlobalObjectKey.Parse("shmcdFKEAEWXZGfrlZEwCQ*cHOq301_X0KPZbUKv_sW+w");
		private static readonly GlobalObjectKey IdNotSetRAGFilterOn = GlobalObjectKey.Parse("shmcdFKEAEWXZGfrlZEwCQ*D6yAToG2AUa5mz3qRtfbRw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("IsFavourites")]
		public bool ssIsFavourites;

		[System.Xml.Serialization.XmlElement("RedRAGFilterOn")]
		public bool ssRedRAGFilterOn;

		[System.Xml.Serialization.XmlElement("AmberRAGFilterOn")]
		public bool ssAmberRAGFilterOn;

		[System.Xml.Serialization.XmlElement("GreenRAGFilterOn")]
		public bool ssGreenRAGFilterOn;

		[System.Xml.Serialization.XmlElement("LatestUpdatesFilterOn")]
		public bool ssLatestUpdatesFilterOn;

		[System.Xml.Serialization.XmlElement("CauseForConcernFilterOn")]
		public bool ssCauseForConcernFilterOn;

		[System.Xml.Serialization.XmlElement("RedAttendanceFilterOn")]
		public bool ssRedAttendanceFilterOn;

		[System.Xml.Serialization.XmlElement("AmberAttendanceFilterOn")]
		public bool ssAmberAttendanceFilterOn;

		[System.Xml.Serialization.XmlElement("GreenAttendanceFilterOn")]
		public bool ssGreenAttendanceFilterOn;

		[System.Xml.Serialization.XmlElement("NotSetRAGFilterOn")]
		public bool ssNotSetRAGFilterOn;


		public BitArray OptimizedAttributes;

		public STDashboardFilterStructure(params string[] dummy) {
			OptimizedAttributes = null;
			ssIsFavourites = false;
			ssRedRAGFilterOn = false;
			ssAmberRAGFilterOn = false;
			ssGreenRAGFilterOn = false;
			ssLatestUpdatesFilterOn = false;
			ssCauseForConcernFilterOn = false;
			ssRedAttendanceFilterOn = false;
			ssAmberAttendanceFilterOn = false;
			ssGreenAttendanceFilterOn = false;
			ssNotSetRAGFilterOn = false;
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
			ssIsFavourites = r.ReadBoolean(index++, "DashboardFilter.IsFavourites", false);
			ssRedRAGFilterOn = r.ReadBoolean(index++, "DashboardFilter.RedRAGFilterOn", false);
			ssAmberRAGFilterOn = r.ReadBoolean(index++, "DashboardFilter.AmberRAGFilterOn", false);
			ssGreenRAGFilterOn = r.ReadBoolean(index++, "DashboardFilter.GreenRAGFilterOn", false);
			ssLatestUpdatesFilterOn = r.ReadBoolean(index++, "DashboardFilter.LatestUpdatesFilterOn", false);
			ssCauseForConcernFilterOn = r.ReadBoolean(index++, "DashboardFilter.CauseForConcernFilterOn", false);
			ssRedAttendanceFilterOn = r.ReadBoolean(index++, "DashboardFilter.RedAttendanceFilterOn", false);
			ssAmberAttendanceFilterOn = r.ReadBoolean(index++, "DashboardFilter.AmberAttendanceFilterOn", false);
			ssGreenAttendanceFilterOn = r.ReadBoolean(index++, "DashboardFilter.GreenAttendanceFilterOn", false);
			ssNotSetRAGFilterOn = r.ReadBoolean(index++, "DashboardFilter.NotSetRAGFilterOn", false);
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
		public void ReadIM(STDashboardFilterStructure r) {
			this = r;
		}


		public static bool operator == (STDashboardFilterStructure a, STDashboardFilterStructure b) {
			if (a.ssIsFavourites != b.ssIsFavourites) return false;
			if (a.ssRedRAGFilterOn != b.ssRedRAGFilterOn) return false;
			if (a.ssAmberRAGFilterOn != b.ssAmberRAGFilterOn) return false;
			if (a.ssGreenRAGFilterOn != b.ssGreenRAGFilterOn) return false;
			if (a.ssLatestUpdatesFilterOn != b.ssLatestUpdatesFilterOn) return false;
			if (a.ssCauseForConcernFilterOn != b.ssCauseForConcernFilterOn) return false;
			if (a.ssRedAttendanceFilterOn != b.ssRedAttendanceFilterOn) return false;
			if (a.ssAmberAttendanceFilterOn != b.ssAmberAttendanceFilterOn) return false;
			if (a.ssGreenAttendanceFilterOn != b.ssGreenAttendanceFilterOn) return false;
			if (a.ssNotSetRAGFilterOn != b.ssNotSetRAGFilterOn) return false;
			return true;
		}

		public static bool operator != (STDashboardFilterStructure a, STDashboardFilterStructure b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(STDashboardFilterStructure)) return false;
			return (this == (STDashboardFilterStructure) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssIsFavourites.GetHashCode()
				^ ssRedRAGFilterOn.GetHashCode()
				^ ssAmberRAGFilterOn.GetHashCode()
				^ ssGreenRAGFilterOn.GetHashCode()
				^ ssLatestUpdatesFilterOn.GetHashCode()
				^ ssCauseForConcernFilterOn.GetHashCode()
				^ ssRedAttendanceFilterOn.GetHashCode()
				^ ssAmberAttendanceFilterOn.GetHashCode()
				^ ssGreenAttendanceFilterOn.GetHashCode()
				^ ssNotSetRAGFilterOn.GetHashCode()
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

		public STDashboardFilterStructure(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssIsFavourites = false;
			ssRedRAGFilterOn = false;
			ssAmberRAGFilterOn = false;
			ssGreenRAGFilterOn = false;
			ssLatestUpdatesFilterOn = false;
			ssCauseForConcernFilterOn = false;
			ssRedAttendanceFilterOn = false;
			ssAmberAttendanceFilterOn = false;
			ssGreenAttendanceFilterOn = false;
			ssNotSetRAGFilterOn = false;
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fields[0] .FieldType.IsSerializable)
			ssIsFavourites = (bool) info.GetValue(fields[0] .Name, fields[0] .FieldType);
			if (fields[1] .FieldType.IsSerializable)
			ssRedRAGFilterOn = (bool) info.GetValue(fields[1] .Name, fields[1] .FieldType);
			if (fields[2] .FieldType.IsSerializable)
			ssAmberRAGFilterOn = (bool) info.GetValue(fields[2] .Name, fields[2] .FieldType);
			if (fields[3] .FieldType.IsSerializable)
			ssGreenRAGFilterOn = (bool) info.GetValue(fields[3] .Name, fields[3] .FieldType);
			if (fields[4] .FieldType.IsSerializable)
			ssLatestUpdatesFilterOn = (bool) info.GetValue(fields[4] .Name, fields[4] .FieldType);
			if (fields[5] .FieldType.IsSerializable)
			ssCauseForConcernFilterOn = (bool) info.GetValue(fields[5] .Name, fields[5] .FieldType);
			if (fields[6] .FieldType.IsSerializable)
			ssRedAttendanceFilterOn = (bool) info.GetValue(fields[6] .Name, fields[6] .FieldType);
			if (fields[7] .FieldType.IsSerializable)
			ssAmberAttendanceFilterOn = (bool) info.GetValue(fields[7] .Name, fields[7] .FieldType);
			if (fields[8] .FieldType.IsSerializable)
			ssGreenAttendanceFilterOn = (bool) info.GetValue(fields[8] .Name, fields[8] .FieldType);
			if (fields[9] .FieldType.IsSerializable)
			ssNotSetRAGFilterOn = (bool) info.GetValue(fields[9] .Name, fields[9] .FieldType);
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public STDashboardFilterStructure Duplicate() {
			STDashboardFilterStructure t;
			t.ssIsFavourites = this.ssIsFavourites;
			t.ssRedRAGFilterOn = this.ssRedRAGFilterOn;
			t.ssAmberRAGFilterOn = this.ssAmberRAGFilterOn;
			t.ssGreenRAGFilterOn = this.ssGreenRAGFilterOn;
			t.ssLatestUpdatesFilterOn = this.ssLatestUpdatesFilterOn;
			t.ssCauseForConcernFilterOn = this.ssCauseForConcernFilterOn;
			t.ssRedAttendanceFilterOn = this.ssRedAttendanceFilterOn;
			t.ssAmberAttendanceFilterOn = this.ssAmberAttendanceFilterOn;
			t.ssGreenAttendanceFilterOn = this.ssGreenAttendanceFilterOn;
			t.ssNotSetRAGFilterOn = this.ssNotSetRAGFilterOn;
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Structure");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".IsFavourites")) VarValue.AppendAttribute(recordElem, "IsFavourites", ssIsFavourites, detailLevel, TypeKind.Boolean); else VarValue.AppendOptimizedAttribute(recordElem, "IsFavourites");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".RedRAGFilterOn")) VarValue.AppendAttribute(recordElem, "RedRAGFilterOn", ssRedRAGFilterOn, detailLevel, TypeKind.Boolean); else VarValue.AppendOptimizedAttribute(recordElem, "RedRAGFilterOn");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".AmberRAGFilterOn")) VarValue.AppendAttribute(recordElem, "AmberRAGFilterOn", ssAmberRAGFilterOn, detailLevel, TypeKind.Boolean); else VarValue.AppendOptimizedAttribute(recordElem, "AmberRAGFilterOn");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".GreenRAGFilterOn")) VarValue.AppendAttribute(recordElem, "GreenRAGFilterOn", ssGreenRAGFilterOn, detailLevel, TypeKind.Boolean); else VarValue.AppendOptimizedAttribute(recordElem, "GreenRAGFilterOn");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".LatestUpdatesFilterOn")) VarValue.AppendAttribute(recordElem, "LatestUpdatesFilterOn", ssLatestUpdatesFilterOn, detailLevel, TypeKind.Boolean); else VarValue.AppendOptimizedAttribute(recordElem, "LatestUpdatesFilterOn");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".CauseForConcernFilterOn")) VarValue.AppendAttribute(recordElem, "CauseForConcernFilterOn", ssCauseForConcernFilterOn, detailLevel, TypeKind.Boolean); else VarValue.AppendOptimizedAttribute(recordElem, "CauseForConcernFilterOn");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".RedAttendanceFilterOn")) VarValue.AppendAttribute(recordElem, "RedAttendanceFilterOn", ssRedAttendanceFilterOn, detailLevel, TypeKind.Boolean); else VarValue.AppendOptimizedAttribute(recordElem, "RedAttendanceFilterOn");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".AmberAttendanceFilterOn")) VarValue.AppendAttribute(recordElem, "AmberAttendanceFilterOn", ssAmberAttendanceFilterOn, detailLevel, TypeKind.Boolean); else VarValue.AppendOptimizedAttribute(recordElem, "AmberAttendanceFilterOn");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".GreenAttendanceFilterOn")) VarValue.AppendAttribute(recordElem, "GreenAttendanceFilterOn", ssGreenAttendanceFilterOn, detailLevel, TypeKind.Boolean); else VarValue.AppendOptimizedAttribute(recordElem, "GreenAttendanceFilterOn");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".NotSetRAGFilterOn")) VarValue.AppendAttribute(recordElem, "NotSetRAGFilterOn", ssNotSetRAGFilterOn, detailLevel, TypeKind.Boolean); else VarValue.AppendOptimizedAttribute(recordElem, "NotSetRAGFilterOn");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "isfavourites") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".IsFavourites")) variable.Value = ssIsFavourites; else variable.Optimized = true;
			} else if (head == "redragfilteron") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".RedRAGFilterOn")) variable.Value = ssRedRAGFilterOn; else variable.Optimized = true;
			} else if (head == "amberragfilteron") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".AmberRAGFilterOn")) variable.Value = ssAmberRAGFilterOn; else variable.Optimized = true;
			} else if (head == "greenragfilteron") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".GreenRAGFilterOn")) variable.Value = ssGreenRAGFilterOn; else variable.Optimized = true;
			} else if (head == "latestupdatesfilteron") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".LatestUpdatesFilterOn")) variable.Value = ssLatestUpdatesFilterOn; else variable.Optimized = true;
			} else if (head == "causeforconcernfilteron") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".CauseForConcernFilterOn")) variable.Value = ssCauseForConcernFilterOn; else variable.Optimized = true;
			} else if (head == "redattendancefilteron") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".RedAttendanceFilterOn")) variable.Value = ssRedAttendanceFilterOn; else variable.Optimized = true;
			} else if (head == "amberattendancefilteron") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".AmberAttendanceFilterOn")) variable.Value = ssAmberAttendanceFilterOn; else variable.Optimized = true;
			} else if (head == "greenattendancefilteron") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".GreenAttendanceFilterOn")) variable.Value = ssGreenAttendanceFilterOn; else variable.Optimized = true;
			} else if (head == "notsetragfilteron") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".NotSetRAGFilterOn")) variable.Value = ssNotSetRAGFilterOn; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdIsFavourites) {
				return ssIsFavourites;
			} else if (key == IdRedRAGFilterOn) {
				return ssRedRAGFilterOn;
			} else if (key == IdAmberRAGFilterOn) {
				return ssAmberRAGFilterOn;
			} else if (key == IdGreenRAGFilterOn) {
				return ssGreenRAGFilterOn;
			} else if (key == IdLatestUpdatesFilterOn) {
				return ssLatestUpdatesFilterOn;
			} else if (key == IdCauseForConcernFilterOn) {
				return ssCauseForConcernFilterOn;
			} else if (key == IdRedAttendanceFilterOn) {
				return ssRedAttendanceFilterOn;
			} else if (key == IdAmberAttendanceFilterOn) {
				return ssAmberAttendanceFilterOn;
			} else if (key == IdGreenAttendanceFilterOn) {
				return ssGreenAttendanceFilterOn;
			} else if (key == IdNotSetRAGFilterOn) {
				return ssNotSetRAGFilterOn;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssIsFavourites = (bool) other.AttributeGet(IdIsFavourites);
			ssRedRAGFilterOn = (bool) other.AttributeGet(IdRedRAGFilterOn);
			ssAmberRAGFilterOn = (bool) other.AttributeGet(IdAmberRAGFilterOn);
			ssGreenRAGFilterOn = (bool) other.AttributeGet(IdGreenRAGFilterOn);
			ssLatestUpdatesFilterOn = (bool) other.AttributeGet(IdLatestUpdatesFilterOn);
			ssCauseForConcernFilterOn = (bool) other.AttributeGet(IdCauseForConcernFilterOn);
			ssRedAttendanceFilterOn = (bool) other.AttributeGet(IdRedAttendanceFilterOn);
			ssAmberAttendanceFilterOn = (bool) other.AttributeGet(IdAmberAttendanceFilterOn);
			ssGreenAttendanceFilterOn = (bool) other.AttributeGet(IdGreenAttendanceFilterOn);
			ssNotSetRAGFilterOn = (bool) other.AttributeGet(IdNotSetRAGFilterOn);
		}
	} // STDashboardFilterStructure
	/// <summary>
	/// Structure <code>RCDashboardFilterRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCDashboardFilterRecord: ISerializable, ITypedRecord<RCDashboardFilterRecord> {
		private static readonly GlobalObjectKey IdDashboardFilter = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SfsSzubG6bd3Kv+QC4qgfQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("DashboardFilter")]
		public STDashboardFilterStructure ssSTDashboardFilter;


		public static implicit operator STDashboardFilterStructure(RCDashboardFilterRecord r) {
			return r.ssSTDashboardFilter;
		}

		public static implicit operator RCDashboardFilterRecord(STDashboardFilterStructure r) {
			RCDashboardFilterRecord res = new RCDashboardFilterRecord(null);
			res.ssSTDashboardFilter = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCDashboardFilterRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTDashboardFilter = new STDashboardFilterStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTDashboardFilter.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTDashboardFilter.Read(r, ref index);
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
		public void ReadIM(RCDashboardFilterRecord r) {
			this = r;
		}


		public static bool operator == (RCDashboardFilterRecord a, RCDashboardFilterRecord b) {
			if (a.ssSTDashboardFilter != b.ssSTDashboardFilter) return false;
			return true;
		}

		public static bool operator != (RCDashboardFilterRecord a, RCDashboardFilterRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCDashboardFilterRecord)) return false;
			return (this == (RCDashboardFilterRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTDashboardFilter.GetHashCode()
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

		public RCDashboardFilterRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTDashboardFilter = new STDashboardFilterStructure(null);
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fields[0] .FieldType.IsSerializable)
			ssSTDashboardFilter = (STDashboardFilterStructure) info.GetValue(fields[0] .Name, fields[0] .FieldType);
		}

		public void RecursiveReset() {
			ssSTDashboardFilter.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTDashboardFilter.InternalRecursiveSave();
		}


		public RCDashboardFilterRecord Duplicate() {
			RCDashboardFilterRecord t;
			t.ssSTDashboardFilter = (STDashboardFilterStructure) this.ssSTDashboardFilter.Duplicate();
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
				ssSTDashboardFilter.ToXml(this, recordElem, "DashboardFilter", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "dashboardfilter") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".DashboardFilter")) variable.Value = ssSTDashboardFilter; else variable.Optimized = true;
				variable.SetFieldName("dashboardfilter");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdDashboardFilter) {
				return ssSTDashboardFilter;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTDashboardFilter.FillFromOther((IRecord) other.AttributeGet(IdDashboardFilter));
		}
	} // RCDashboardFilterRecord
	/// <summary>
	/// RecordList type <code>RLDashboardFilterRecordList</code> that represents a record list of
	///  <code>DashboardFilter</code>
	/// </summary>
	[Serializable()]
	public partial class RLDashboardFilterRecordList: GenericRecordList<RCDashboardFilterRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCDashboardFilterRecord GetElementDefaultValue() {
			return new RCDashboardFilterRecord("");
		}

		public T[] ToArray<T>(Func<RCDashboardFilterRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLDashboardFilterRecordList recordlist, Func<RCDashboardFilterRecord, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLDashboardFilterRecordList ToList<T>(T[] array, Func <T, RCDashboardFilterRecord> converter) {
			RLDashboardFilterRecordList result = new RLDashboardFilterRecordList();
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
		public RLDashboardFilterRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLDashboardFilterRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLDashboardFilterRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLDashboardFilterRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCDashboardFilterRecord> NewList() {
			return new RLDashboardFilterRecordList();
		}


	} // RLDashboardFilterRecordList
	/// <summary>
	/// RecordList type <code>RLDashboardFilterList</code> that represents a record list of <code>Boolean,
	///  Boolean, Boolean, Boolean, Boolean, Boolean, Boolean, Boolean, Boolean, Boolean</code>
	/// </summary>
	[Serializable()]
	public partial class RLDashboardFilterList: GenericRecordList<STDashboardFilterStructure>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override STDashboardFilterStructure GetElementDefaultValue() {
			return new STDashboardFilterStructure("");
		}

		public T[] ToArray<T>(Func<STDashboardFilterStructure, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLDashboardFilterList recordlist, Func<STDashboardFilterStructure, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLDashboardFilterList ToList<T>(T[] array, Func <T, STDashboardFilterStructure> converter) {
			RLDashboardFilterList result = new RLDashboardFilterList();
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
		public RLDashboardFilterList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLDashboardFilterList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLDashboardFilterList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLDashboardFilterList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[0];
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<STDashboardFilterStructure> NewList() {
			return new RLDashboardFilterList();
		}


	} // RLDashboardFilterList
}

namespace ssCaseConferencing {
	[XmlType("DashboardFilter")]
	public class WORCDashboardFilterRecord {
		[System.Xml.Serialization.XmlElement("IsFavourites")]
		public bool varWSIsFavourites;

		[System.Xml.Serialization.XmlElement("RedRAGFilterOn")]
		public bool varWSRedRAGFilterOn;

		[System.Xml.Serialization.XmlElement("AmberRAGFilterOn")]
		public bool varWSAmberRAGFilterOn;

		[System.Xml.Serialization.XmlElement("GreenRAGFilterOn")]
		public bool varWSGreenRAGFilterOn;

		[System.Xml.Serialization.XmlElement("LatestUpdatesFilterOn")]
		public bool varWSLatestUpdatesFilterOn;

		[System.Xml.Serialization.XmlElement("CauseForConcernFilterOn")]
		public bool varWSCauseForConcernFilterOn;

		[System.Xml.Serialization.XmlElement("RedAttendanceFilterOn")]
		public bool varWSRedAttendanceFilterOn;

		[System.Xml.Serialization.XmlElement("AmberAttendanceFilterOn")]
		public bool varWSAmberAttendanceFilterOn;

		[System.Xml.Serialization.XmlElement("GreenAttendanceFilterOn")]
		public bool varWSGreenAttendanceFilterOn;

		[System.Xml.Serialization.XmlElement("NotSetRAGFilterOn")]
		public bool varWSNotSetRAGFilterOn;

		public WORCDashboardFilterRecord() {
			varWSIsFavourites = (bool) false;
			varWSRedRAGFilterOn = (bool) false;
			varWSAmberRAGFilterOn = (bool) false;
			varWSGreenRAGFilterOn = (bool) false;
			varWSLatestUpdatesFilterOn = (bool) false;
			varWSCauseForConcernFilterOn = (bool) false;
			varWSRedAttendanceFilterOn = (bool) false;
			varWSAmberAttendanceFilterOn = (bool) false;
			varWSGreenAttendanceFilterOn = (bool) false;
			varWSNotSetRAGFilterOn = (bool) false;
		}

		public WORCDashboardFilterRecord(STDashboardFilterStructure r) {
			varWSIsFavourites = (bool) r.ssIsFavourites;
			varWSRedRAGFilterOn = (bool) r.ssRedRAGFilterOn;
			varWSAmberRAGFilterOn = (bool) r.ssAmberRAGFilterOn;
			varWSGreenRAGFilterOn = (bool) r.ssGreenRAGFilterOn;
			varWSLatestUpdatesFilterOn = (bool) r.ssLatestUpdatesFilterOn;
			varWSCauseForConcernFilterOn = (bool) r.ssCauseForConcernFilterOn;
			varWSRedAttendanceFilterOn = (bool) r.ssRedAttendanceFilterOn;
			varWSAmberAttendanceFilterOn = (bool) r.ssAmberAttendanceFilterOn;
			varWSGreenAttendanceFilterOn = (bool) r.ssGreenAttendanceFilterOn;
			varWSNotSetRAGFilterOn = (bool) r.ssNotSetRAGFilterOn;
		}

		public static RLDashboardFilterList ToRecordList(WORCDashboardFilterRecord[] array) {
			RLDashboardFilterList rl = new RLDashboardFilterList();
			if (array != null) {
				foreach(WORCDashboardFilterRecord val in array) {
					rl.Append(val);
				}
			}
			return rl;
		}

		public static WORCDashboardFilterRecord[] FromRecordList(RLDashboardFilterList rl) {
			WORCDashboardFilterRecord[] array = new WORCDashboardFilterRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial struct RCDashboardFilterRecord {
		public static implicit operator WORCDashboardFilterRecord(RCDashboardFilterRecord r) {
			return new WORCDashboardFilterRecord(r.ssSTDashboardFilter);
		}

		public static implicit operator RCDashboardFilterRecord(WORCDashboardFilterRecord w) {
			RCDashboardFilterRecord r = new RCDashboardFilterRecord("");
			if (w != null) {
				r.ssSTDashboardFilter = w;
			}
			return r;
		}

	}

	partial struct STDashboardFilterStructure {
		public static implicit operator WORCDashboardFilterRecord(STDashboardFilterStructure r) {
			return new WORCDashboardFilterRecord(r);
		}

		public static implicit operator STDashboardFilterStructure(WORCDashboardFilterRecord w) {
			STDashboardFilterStructure r = new STDashboardFilterStructure("");
			if (w != null) {
				r.ssIsFavourites = (bool) w.varWSIsFavourites;
				r.ssRedRAGFilterOn = (bool) w.varWSRedRAGFilterOn;
				r.ssAmberRAGFilterOn = (bool) w.varWSAmberRAGFilterOn;
				r.ssGreenRAGFilterOn = (bool) w.varWSGreenRAGFilterOn;
				r.ssLatestUpdatesFilterOn = (bool) w.varWSLatestUpdatesFilterOn;
				r.ssCauseForConcernFilterOn = (bool) w.varWSCauseForConcernFilterOn;
				r.ssRedAttendanceFilterOn = (bool) w.varWSRedAttendanceFilterOn;
				r.ssAmberAttendanceFilterOn = (bool) w.varWSAmberAttendanceFilterOn;
				r.ssGreenAttendanceFilterOn = (bool) w.varWSGreenAttendanceFilterOn;
				r.ssNotSetRAGFilterOn = (bool) w.varWSNotSetRAGFilterOn;
			}
			return r;
		}

	}
}


namespace ssCaseConferencing {
	[Serializable()]
	public partial class WORLDashboardFilterRecordList {
		public WORCDashboardFilterRecord[] Array;


		public WORLDashboardFilterRecordList(WORCDashboardFilterRecord[] r) {
			if (r == null)
			Array = new WORCDashboardFilterRecord[0];
			else
			Array = r;
		}
		public WORLDashboardFilterRecordList() {
			Array = new WORCDashboardFilterRecord[0];
		}

		public WORLDashboardFilterRecordList(RLDashboardFilterRecordList rl) {
			rl=(RLDashboardFilterRecordList) rl.Duplicate();
			Array = new WORCDashboardFilterRecord[rl.Length];
			while (!rl.Eof) {
				Array[rl.CurrentRowNumber] = new WORCDashboardFilterRecord(rl.CurrentRec);
				rl.Advance();
			}
		}

	}
}

namespace ssCaseConferencing {
	partial class RLDashboardFilterRecordList {
		public static implicit operator RLDashboardFilterRecordList(WORCDashboardFilterRecord[] array) {
			RLDashboardFilterRecordList rl = new RLDashboardFilterRecordList();
			if (array != null) {
				foreach(WORCDashboardFilterRecord val in array) {
					rl.Append((RCDashboardFilterRecord) val);
				}
			}
			return rl;
		}
		public static implicit operator WORCDashboardFilterRecord[](RLDashboardFilterRecordList rl) {
			WORCDashboardFilterRecord[] array = new WORCDashboardFilterRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = (RCDashboardFilterRecord) rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial class WORLDashboardFilterRecordList {
		public static implicit operator RLDashboardFilterRecordList(WORLDashboardFilterRecordList w) {
			return w.Array;
		}
		public static implicit operator WORLDashboardFilterRecordList(RLDashboardFilterRecordList rl) {
			return new WORLDashboardFilterRecordList(rl);
		}
		public static implicit operator WORCDashboardFilterRecord[](WORLDashboardFilterRecordList w) {
			if (w != null) {
				return w.Array;
			}
			return null;
		}
		public static implicit operator WORLDashboardFilterRecordList(WORCDashboardFilterRecord[] array) {
			return new WORLDashboardFilterRecordList(array);
		}
	}
}

namespace ssCaseConferencing {
	[Serializable()]
	public partial class WORLDashboardFilterList {
		public WORCDashboardFilterRecord[] Array;


		public WORLDashboardFilterList(WORCDashboardFilterRecord[] r) {
			if (r == null)
			Array = new WORCDashboardFilterRecord[0];
			else
			Array = r;
		}
		public WORLDashboardFilterList() {
			Array = new WORCDashboardFilterRecord[0];
		}

		public WORLDashboardFilterList(RLDashboardFilterList rl) {
			rl=(RLDashboardFilterList) rl.Duplicate();
			Array = new WORCDashboardFilterRecord[rl.Length];
			while (!rl.Eof) {
				Array[rl.CurrentRowNumber] = rl.CurrentRec.Duplicate();
				rl.Advance();
			}
		}

	}
}

namespace ssCaseConferencing {
	partial class RLDashboardFilterList {
		public static implicit operator RLDashboardFilterList(WORCDashboardFilterRecord[] array) {
			RLDashboardFilterList rl = new RLDashboardFilterList();
			if (array != null) {
				foreach(WORCDashboardFilterRecord val in array) {
					rl.Append((STDashboardFilterStructure) val);
				}
			}
			return rl;
		}
		public static implicit operator WORCDashboardFilterRecord[](RLDashboardFilterList rl) {
			WORCDashboardFilterRecord[] array = new WORCDashboardFilterRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = (STDashboardFilterStructure) rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial class WORLDashboardFilterList {
		public static implicit operator RLDashboardFilterList(WORLDashboardFilterList w) {
			return w.Array;
		}
		public static implicit operator WORLDashboardFilterList(RLDashboardFilterList rl) {
			return new WORLDashboardFilterList(rl);
		}
		public static implicit operator WORCDashboardFilterRecord[](WORLDashboardFilterList w) {
			if (w != null) {
				return w.Array;
			}
			return null;
		}
		public static implicit operator WORLDashboardFilterList(WORCDashboardFilterRecord[] array) {
			return new WORLDashboardFilterList(array);
		}
	}
}

