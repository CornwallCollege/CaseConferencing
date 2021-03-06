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
	/// Structure <code>STLearnerCategoryCoursesStructure</code> that represents the Service Studio
	///  structure <code>LearnerCategoryCourses</code> <p> Description: </p>
	/// </summary>
	[Serializable()]
	public partial struct STLearnerCategoryCoursesStructure: ISerializable, ITypedRecord<STLearnerCategoryCoursesStructure>, ISimpleRecord {
		private static readonly GlobalObjectKey IdOfferingName = GlobalObjectKey.Parse("shmcdFKEAEWXZGfrlZEwCQ*7iwZHS8J+USFM6bE8bKg4w");
		private static readonly GlobalObjectKey IdOfferingCode = GlobalObjectKey.Parse("shmcdFKEAEWXZGfrlZEwCQ*nwlcvlr3TUKMBp+A_eAHtA");
		private static readonly GlobalObjectKey IdCompletedUnits = GlobalObjectKey.Parse("shmcdFKEAEWXZGfrlZEwCQ*bi0pbUJ_Z0eo876KHAYMng");
		private static readonly GlobalObjectKey IdTotalUnits = GlobalObjectKey.Parse("shmcdFKEAEWXZGfrlZEwCQ*DqRp1QETxkaXg5N0Yih19w");
		private static readonly GlobalObjectKey IdCompletedTargets = GlobalObjectKey.Parse("shmcdFKEAEWXZGfrlZEwCQ*2oJpw2Ina0W4r4MZHRrpug");
		private static readonly GlobalObjectKey IdTotalTargets = GlobalObjectKey.Parse("shmcdFKEAEWXZGfrlZEwCQ*W5vb1x4zh02PBhFUnj0npQ");
		private static readonly GlobalObjectKey IdVisible = GlobalObjectKey.Parse("shmcdFKEAEWXZGfrlZEwCQ*cYo1qWHBcEuEYgPHHFQqyA");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("OfferingName")]
		public string ssOfferingName;

		[System.Xml.Serialization.XmlElement("OfferingCode")]
		public string ssOfferingCode;

		[System.Xml.Serialization.XmlElement("CompletedUnits")]
		public int ssCompletedUnits;

		[System.Xml.Serialization.XmlElement("TotalUnits")]
		public int ssTotalUnits;

		[System.Xml.Serialization.XmlElement("CompletedTargets")]
		public int ssCompletedTargets;

		[System.Xml.Serialization.XmlElement("TotalTargets")]
		public int ssTotalTargets;

		[System.Xml.Serialization.XmlElement("Visible")]
		public bool ssVisible;


		public BitArray OptimizedAttributes;

		public STLearnerCategoryCoursesStructure(params string[] dummy) {
			OptimizedAttributes = null;
			ssOfferingName = "";
			ssOfferingCode = "";
			ssCompletedUnits = 0;
			ssTotalUnits = 0;
			ssCompletedTargets = 0;
			ssTotalTargets = 0;
			ssVisible = false;
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
			ssOfferingName = r.ReadText(index++, "LearnerCategoryCourses.OfferingName", "");
			ssOfferingCode = r.ReadText(index++, "LearnerCategoryCourses.OfferingCode", "");
			ssCompletedUnits = r.ReadInteger(index++, "LearnerCategoryCourses.CompletedUnits", 0);
			ssTotalUnits = r.ReadInteger(index++, "LearnerCategoryCourses.TotalUnits", 0);
			ssCompletedTargets = r.ReadInteger(index++, "LearnerCategoryCourses.CompletedTargets", 0);
			ssTotalTargets = r.ReadInteger(index++, "LearnerCategoryCourses.TotalTargets", 0);
			ssVisible = r.ReadBoolean(index++, "LearnerCategoryCourses.Visible", false);
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
		public void ReadIM(STLearnerCategoryCoursesStructure r) {
			this = r;
		}


		public static bool operator == (STLearnerCategoryCoursesStructure a, STLearnerCategoryCoursesStructure b) {
			if (a.ssOfferingName != b.ssOfferingName) return false;
			if (a.ssOfferingCode != b.ssOfferingCode) return false;
			if (a.ssCompletedUnits != b.ssCompletedUnits) return false;
			if (a.ssTotalUnits != b.ssTotalUnits) return false;
			if (a.ssCompletedTargets != b.ssCompletedTargets) return false;
			if (a.ssTotalTargets != b.ssTotalTargets) return false;
			if (a.ssVisible != b.ssVisible) return false;
			return true;
		}

		public static bool operator != (STLearnerCategoryCoursesStructure a, STLearnerCategoryCoursesStructure b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(STLearnerCategoryCoursesStructure)) return false;
			return (this == (STLearnerCategoryCoursesStructure) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssOfferingName.GetHashCode()
				^ ssOfferingCode.GetHashCode()
				^ ssCompletedUnits.GetHashCode()
				^ ssTotalUnits.GetHashCode()
				^ ssCompletedTargets.GetHashCode()
				^ ssTotalTargets.GetHashCode()
				^ ssVisible.GetHashCode()
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

		public STLearnerCategoryCoursesStructure(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssOfferingName = "";
			ssOfferingCode = "";
			ssCompletedUnits = 0;
			ssTotalUnits = 0;
			ssCompletedTargets = 0;
			ssTotalTargets = 0;
			ssVisible = false;
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fields[0] .FieldType.IsSerializable)
			ssOfferingName = (string) info.GetValue(fields[0] .Name, fields[0] .FieldType);
			if (fields[1] .FieldType.IsSerializable)
			ssOfferingCode = (string) info.GetValue(fields[1] .Name, fields[1] .FieldType);
			if (fields[2] .FieldType.IsSerializable)
			ssCompletedUnits = (int) info.GetValue(fields[2] .Name, fields[2] .FieldType);
			if (fields[3] .FieldType.IsSerializable)
			ssTotalUnits = (int) info.GetValue(fields[3] .Name, fields[3] .FieldType);
			if (fields[4] .FieldType.IsSerializable)
			ssCompletedTargets = (int) info.GetValue(fields[4] .Name, fields[4] .FieldType);
			if (fields[5] .FieldType.IsSerializable)
			ssTotalTargets = (int) info.GetValue(fields[5] .Name, fields[5] .FieldType);
			if (fields[6] .FieldType.IsSerializable)
			ssVisible = (bool) info.GetValue(fields[6] .Name, fields[6] .FieldType);
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public STLearnerCategoryCoursesStructure Duplicate() {
			STLearnerCategoryCoursesStructure t;
			t.ssOfferingName = this.ssOfferingName;
			t.ssOfferingCode = this.ssOfferingCode;
			t.ssCompletedUnits = this.ssCompletedUnits;
			t.ssTotalUnits = this.ssTotalUnits;
			t.ssCompletedTargets = this.ssCompletedTargets;
			t.ssTotalTargets = this.ssTotalTargets;
			t.ssVisible = this.ssVisible;
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
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".OfferingName")) VarValue.AppendAttribute(recordElem, "OfferingName", ssOfferingName, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "OfferingName");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".OfferingCode")) VarValue.AppendAttribute(recordElem, "OfferingCode", ssOfferingCode, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "OfferingCode");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".CompletedUnits")) VarValue.AppendAttribute(recordElem, "CompletedUnits", ssCompletedUnits, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "CompletedUnits");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".TotalUnits")) VarValue.AppendAttribute(recordElem, "TotalUnits", ssTotalUnits, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "TotalUnits");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".CompletedTargets")) VarValue.AppendAttribute(recordElem, "CompletedTargets", ssCompletedTargets, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "CompletedTargets");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".TotalTargets")) VarValue.AppendAttribute(recordElem, "TotalTargets", ssTotalTargets, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "TotalTargets");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Visible")) VarValue.AppendAttribute(recordElem, "Visible", ssVisible, detailLevel, TypeKind.Boolean); else VarValue.AppendOptimizedAttribute(recordElem, "Visible");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "offeringname") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".OfferingName")) variable.Value = ssOfferingName; else variable.Optimized = true;
			} else if (head == "offeringcode") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".OfferingCode")) variable.Value = ssOfferingCode; else variable.Optimized = true;
			} else if (head == "completedunits") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".CompletedUnits")) variable.Value = ssCompletedUnits; else variable.Optimized = true;
			} else if (head == "totalunits") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".TotalUnits")) variable.Value = ssTotalUnits; else variable.Optimized = true;
			} else if (head == "completedtargets") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".CompletedTargets")) variable.Value = ssCompletedTargets; else variable.Optimized = true;
			} else if (head == "totaltargets") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".TotalTargets")) variable.Value = ssTotalTargets; else variable.Optimized = true;
			} else if (head == "visible") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Visible")) variable.Value = ssVisible; else variable.Optimized = true;
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
			if (key == IdOfferingName) {
				return ssOfferingName;
			} else if (key == IdOfferingCode) {
				return ssOfferingCode;
			} else if (key == IdCompletedUnits) {
				return ssCompletedUnits;
			} else if (key == IdTotalUnits) {
				return ssTotalUnits;
			} else if (key == IdCompletedTargets) {
				return ssCompletedTargets;
			} else if (key == IdTotalTargets) {
				return ssTotalTargets;
			} else if (key == IdVisible) {
				return ssVisible;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssOfferingName = (string) other.AttributeGet(IdOfferingName);
			ssOfferingCode = (string) other.AttributeGet(IdOfferingCode);
			ssCompletedUnits = (int) other.AttributeGet(IdCompletedUnits);
			ssTotalUnits = (int) other.AttributeGet(IdTotalUnits);
			ssCompletedTargets = (int) other.AttributeGet(IdCompletedTargets);
			ssTotalTargets = (int) other.AttributeGet(IdTotalTargets);
			ssVisible = (bool) other.AttributeGet(IdVisible);
		}
	} // STLearnerCategoryCoursesStructure
	/// <summary>
	/// Structure <code>RCLearnerCategoryCoursesRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCLearnerCategoryCoursesRecord: ISerializable, ITypedRecord<RCLearnerCategoryCoursesRecord> {
		private static readonly GlobalObjectKey IdLearnerCategoryCourses = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*R6UVjBKHr0jA7nEZCPLLlw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("LearnerCategoryCourses")]
		public STLearnerCategoryCoursesStructure ssSTLearnerCategoryCourses;


		public static implicit operator STLearnerCategoryCoursesStructure(RCLearnerCategoryCoursesRecord r) {
			return r.ssSTLearnerCategoryCourses;
		}

		public static implicit operator RCLearnerCategoryCoursesRecord(STLearnerCategoryCoursesStructure r) {
			RCLearnerCategoryCoursesRecord res = new RCLearnerCategoryCoursesRecord(null);
			res.ssSTLearnerCategoryCourses = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCLearnerCategoryCoursesRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTLearnerCategoryCourses = new STLearnerCategoryCoursesStructure(null);
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
					ssSTLearnerCategoryCourses.OptimizedAttributes = value[0];
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
			ssSTLearnerCategoryCourses.Read(r, ref index);
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
		public void ReadIM(RCLearnerCategoryCoursesRecord r) {
			this = r;
		}


		public static bool operator == (RCLearnerCategoryCoursesRecord a, RCLearnerCategoryCoursesRecord b) {
			if (a.ssSTLearnerCategoryCourses != b.ssSTLearnerCategoryCourses) return false;
			return true;
		}

		public static bool operator != (RCLearnerCategoryCoursesRecord a, RCLearnerCategoryCoursesRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCLearnerCategoryCoursesRecord)) return false;
			return (this == (RCLearnerCategoryCoursesRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTLearnerCategoryCourses.GetHashCode()
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

		public RCLearnerCategoryCoursesRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTLearnerCategoryCourses = new STLearnerCategoryCoursesStructure(null);
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fields[0] .FieldType.IsSerializable)
			ssSTLearnerCategoryCourses = (STLearnerCategoryCoursesStructure) info.GetValue(fields[0] .Name, fields[0] .FieldType);
		}

		public void RecursiveReset() {
			ssSTLearnerCategoryCourses.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTLearnerCategoryCourses.InternalRecursiveSave();
		}


		public RCLearnerCategoryCoursesRecord Duplicate() {
			RCLearnerCategoryCoursesRecord t;
			t.ssSTLearnerCategoryCourses = (STLearnerCategoryCoursesStructure) this.ssSTLearnerCategoryCourses.Duplicate();
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
				ssSTLearnerCategoryCourses.ToXml(this, recordElem, "LearnerCategoryCourses", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "learnercategorycourses") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".LearnerCategoryCourses")) variable.Value = ssSTLearnerCategoryCourses; else variable.Optimized = true;
				variable.SetFieldName("learnercategorycourses");
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
			if (key == IdLearnerCategoryCourses) {
				return ssSTLearnerCategoryCourses;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTLearnerCategoryCourses.FillFromOther((IRecord) other.AttributeGet(IdLearnerCategoryCourses));
		}
	} // RCLearnerCategoryCoursesRecord
	/// <summary>
	/// RecordList type <code>RLLearnerCategoryCoursesRecordList</code> that represents a record list of
	///  <code>LearnerCategoryCourses</code>
	/// </summary>
	[Serializable()]
	public partial class RLLearnerCategoryCoursesRecordList: GenericRecordList<RCLearnerCategoryCoursesRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCLearnerCategoryCoursesRecord GetElementDefaultValue() {
			return new RCLearnerCategoryCoursesRecord("");
		}

		public T[] ToArray<T>(Func<RCLearnerCategoryCoursesRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLLearnerCategoryCoursesRecordList recordlist, Func<RCLearnerCategoryCoursesRecord, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLLearnerCategoryCoursesRecordList ToList<T>(T[] array, Func <T, RCLearnerCategoryCoursesRecord> converter) {
			RLLearnerCategoryCoursesRecordList result = new RLLearnerCategoryCoursesRecordList();
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
		public RLLearnerCategoryCoursesRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLLearnerCategoryCoursesRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLLearnerCategoryCoursesRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLLearnerCategoryCoursesRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
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
		protected override OSList<RCLearnerCategoryCoursesRecord> NewList() {
			return new RLLearnerCategoryCoursesRecordList();
		}


	} // RLLearnerCategoryCoursesRecordList
	/// <summary>
	/// RecordList type <code>RLLearnerCategoryCoursesList</code> that represents a record list of
	///  <code>Text, Text, Boolean, Integer, Integer, Integer, Integer</code>
	/// </summary>
	[Serializable()]
	public partial class RLLearnerCategoryCoursesList: GenericRecordList<STLearnerCategoryCoursesStructure>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override STLearnerCategoryCoursesStructure GetElementDefaultValue() {
			return new STLearnerCategoryCoursesStructure("");
		}

		public T[] ToArray<T>(Func<STLearnerCategoryCoursesStructure, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLLearnerCategoryCoursesList recordlist, Func<STLearnerCategoryCoursesStructure, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLLearnerCategoryCoursesList ToList<T>(T[] array, Func <T, STLearnerCategoryCoursesStructure> converter) {
			RLLearnerCategoryCoursesList result = new RLLearnerCategoryCoursesList();
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
		public RLLearnerCategoryCoursesList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLLearnerCategoryCoursesList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLLearnerCategoryCoursesList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLLearnerCategoryCoursesList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[0];
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<STLearnerCategoryCoursesStructure> NewList() {
			return new RLLearnerCategoryCoursesList();
		}


	} // RLLearnerCategoryCoursesList
}

namespace ssCaseConferencing {
	[XmlType("LearnerCategoryCourses")]
	public class WORCLearnerCategoryCoursesRecord {
		[System.Xml.Serialization.XmlElement("OfferingName")]
		public string varWSOfferingName;

		[System.Xml.Serialization.XmlElement("OfferingCode")]
		public string varWSOfferingCode;

		[System.Xml.Serialization.XmlElement("CompletedUnits")]
		public int varWSCompletedUnits;

		[System.Xml.Serialization.XmlElement("TotalUnits")]
		public int varWSTotalUnits;

		[System.Xml.Serialization.XmlElement("CompletedTargets")]
		public int varWSCompletedTargets;

		[System.Xml.Serialization.XmlElement("TotalTargets")]
		public int varWSTotalTargets;

		[System.Xml.Serialization.XmlElement("Visible")]
		public bool varWSVisible;

		public WORCLearnerCategoryCoursesRecord() {
			varWSOfferingName = (string) "";
			varWSOfferingCode = (string) "";
			varWSCompletedUnits = (int) 0;
			varWSTotalUnits = (int) 0;
			varWSCompletedTargets = (int) 0;
			varWSTotalTargets = (int) 0;
			varWSVisible = (bool) false;
		}

		public WORCLearnerCategoryCoursesRecord(STLearnerCategoryCoursesStructure r) {
			varWSOfferingName = BaseAppUtils.RemoveControlChars(r.ssOfferingName);
			varWSOfferingCode = BaseAppUtils.RemoveControlChars(r.ssOfferingCode);
			varWSCompletedUnits = (int) r.ssCompletedUnits;
			varWSTotalUnits = (int) r.ssTotalUnits;
			varWSCompletedTargets = (int) r.ssCompletedTargets;
			varWSTotalTargets = (int) r.ssTotalTargets;
			varWSVisible = (bool) r.ssVisible;
		}

		public static RLLearnerCategoryCoursesList ToRecordList(WORCLearnerCategoryCoursesRecord[] array) {
			RLLearnerCategoryCoursesList rl = new RLLearnerCategoryCoursesList();
			if (array != null) {
				foreach(WORCLearnerCategoryCoursesRecord val in array) {
					rl.Append(val);
				}
			}
			return rl;
		}

		public static WORCLearnerCategoryCoursesRecord[] FromRecordList(RLLearnerCategoryCoursesList rl) {
			WORCLearnerCategoryCoursesRecord[] array = new WORCLearnerCategoryCoursesRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial struct RCLearnerCategoryCoursesRecord {
		public static implicit operator WORCLearnerCategoryCoursesRecord(RCLearnerCategoryCoursesRecord r) {
			return new WORCLearnerCategoryCoursesRecord(r.ssSTLearnerCategoryCourses);
		}

		public static implicit operator RCLearnerCategoryCoursesRecord(WORCLearnerCategoryCoursesRecord w) {
			RCLearnerCategoryCoursesRecord r = new RCLearnerCategoryCoursesRecord("");
			if (w != null) {
				r.ssSTLearnerCategoryCourses = w;
			}
			return r;
		}

	}

	partial struct STLearnerCategoryCoursesStructure {
		public static implicit operator WORCLearnerCategoryCoursesRecord(STLearnerCategoryCoursesStructure r) {
			return new WORCLearnerCategoryCoursesRecord(r);
		}

		public static implicit operator STLearnerCategoryCoursesStructure(WORCLearnerCategoryCoursesRecord w) {
			STLearnerCategoryCoursesStructure r = new STLearnerCategoryCoursesStructure("");
			if (w != null) {
				r.ssOfferingName = ((string) w.varWSOfferingName ?? "");
				r.ssOfferingCode = ((string) w.varWSOfferingCode ?? "");
				r.ssCompletedUnits = (int) w.varWSCompletedUnits;
				r.ssTotalUnits = (int) w.varWSTotalUnits;
				r.ssCompletedTargets = (int) w.varWSCompletedTargets;
				r.ssTotalTargets = (int) w.varWSTotalTargets;
				r.ssVisible = (bool) w.varWSVisible;
			}
			return r;
		}

	}
}


namespace ssCaseConferencing {
	[Serializable()]
	public partial class WORLLearnerCategoryCoursesRecordList {
		public WORCLearnerCategoryCoursesRecord[] Array;


		public WORLLearnerCategoryCoursesRecordList(WORCLearnerCategoryCoursesRecord[] r) {
			if (r == null)
			Array = new WORCLearnerCategoryCoursesRecord[0];
			else
			Array = r;
		}
		public WORLLearnerCategoryCoursesRecordList() {
			Array = new WORCLearnerCategoryCoursesRecord[0];
		}

		public WORLLearnerCategoryCoursesRecordList(RLLearnerCategoryCoursesRecordList rl) {
			rl=(RLLearnerCategoryCoursesRecordList) rl.Duplicate();
			Array = new WORCLearnerCategoryCoursesRecord[rl.Length];
			while (!rl.Eof) {
				Array[rl.CurrentRowNumber] = new WORCLearnerCategoryCoursesRecord(rl.CurrentRec);
				rl.Advance();
			}
		}

	}
}

namespace ssCaseConferencing {
	partial class RLLearnerCategoryCoursesRecordList {
		public static implicit operator RLLearnerCategoryCoursesRecordList(WORCLearnerCategoryCoursesRecord[] array) {
			RLLearnerCategoryCoursesRecordList rl = new RLLearnerCategoryCoursesRecordList();
			if (array != null) {
				foreach(WORCLearnerCategoryCoursesRecord val in array) {
					rl.Append((RCLearnerCategoryCoursesRecord) val);
				}
			}
			return rl;
		}
		public static implicit operator WORCLearnerCategoryCoursesRecord[](RLLearnerCategoryCoursesRecordList rl) {
			WORCLearnerCategoryCoursesRecord[] array = new WORCLearnerCategoryCoursesRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = (RCLearnerCategoryCoursesRecord) rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial class WORLLearnerCategoryCoursesRecordList {
		public static implicit operator RLLearnerCategoryCoursesRecordList(WORLLearnerCategoryCoursesRecordList w) {
			return w.Array;
		}
		public static implicit operator WORLLearnerCategoryCoursesRecordList(RLLearnerCategoryCoursesRecordList rl) {
			return new WORLLearnerCategoryCoursesRecordList(rl);
		}
		public static implicit operator WORCLearnerCategoryCoursesRecord[](WORLLearnerCategoryCoursesRecordList w) {
			if (w != null) {
				return w.Array;
			}
			return null;
		}
		public static implicit operator WORLLearnerCategoryCoursesRecordList(WORCLearnerCategoryCoursesRecord[] array) {
			return new WORLLearnerCategoryCoursesRecordList(array);
		}
	}
}

namespace ssCaseConferencing {
	[Serializable()]
	public partial class WORLLearnerCategoryCoursesList {
		public WORCLearnerCategoryCoursesRecord[] Array;


		public WORLLearnerCategoryCoursesList(WORCLearnerCategoryCoursesRecord[] r) {
			if (r == null)
			Array = new WORCLearnerCategoryCoursesRecord[0];
			else
			Array = r;
		}
		public WORLLearnerCategoryCoursesList() {
			Array = new WORCLearnerCategoryCoursesRecord[0];
		}

		public WORLLearnerCategoryCoursesList(RLLearnerCategoryCoursesList rl) {
			rl=(RLLearnerCategoryCoursesList) rl.Duplicate();
			Array = new WORCLearnerCategoryCoursesRecord[rl.Length];
			while (!rl.Eof) {
				Array[rl.CurrentRowNumber] = rl.CurrentRec.Duplicate();
				rl.Advance();
			}
		}

	}
}

namespace ssCaseConferencing {
	partial class RLLearnerCategoryCoursesList {
		public static implicit operator RLLearnerCategoryCoursesList(WORCLearnerCategoryCoursesRecord[] array) {
			RLLearnerCategoryCoursesList rl = new RLLearnerCategoryCoursesList();
			if (array != null) {
				foreach(WORCLearnerCategoryCoursesRecord val in array) {
					rl.Append((STLearnerCategoryCoursesStructure) val);
				}
			}
			return rl;
		}
		public static implicit operator WORCLearnerCategoryCoursesRecord[](RLLearnerCategoryCoursesList rl) {
			WORCLearnerCategoryCoursesRecord[] array = new WORCLearnerCategoryCoursesRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = (STLearnerCategoryCoursesStructure) rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial class WORLLearnerCategoryCoursesList {
		public static implicit operator RLLearnerCategoryCoursesList(WORLLearnerCategoryCoursesList w) {
			return w.Array;
		}
		public static implicit operator WORLLearnerCategoryCoursesList(RLLearnerCategoryCoursesList rl) {
			return new WORLLearnerCategoryCoursesList(rl);
		}
		public static implicit operator WORCLearnerCategoryCoursesRecord[](WORLLearnerCategoryCoursesList w) {
			if (w != null) {
				return w.Array;
			}
			return null;
		}
		public static implicit operator WORLLearnerCategoryCoursesList(WORCLearnerCategoryCoursesRecord[] array) {
			return new WORLLearnerCategoryCoursesList(array);
		}
	}
}

