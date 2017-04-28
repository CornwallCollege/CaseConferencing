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
	/// Structure <code>STMarkbookAssessmentsStructure</code> that represents the Service Studio structure
	///  <code>MarkbookAssessments</code> <p> Description: </p>
	/// </summary>
	[Serializable()]
	public partial struct STMarkbookAssessmentsStructure: ISerializable, ITypedRecord<STMarkbookAssessmentsStructure>, ISimpleRecord {
		private static readonly GlobalObjectKey IdAssessmentID = GlobalObjectKey.Parse("9iBL85w0ZUGz9zoHIHP4NA*+bYmiHAcpkmIGQEm+fKQbw");
		private static readonly GlobalObjectKey IdAssessmentCode = GlobalObjectKey.Parse("9iBL85w0ZUGz9zoHIHP4NA*xzpRikoYmEy+fptqYnS2+A");
		private static readonly GlobalObjectKey IdAssessmentTitle = GlobalObjectKey.Parse("9iBL85w0ZUGz9zoHIHP4NA*RXu4aD0hOUORxp4FRLKRJA");
		private static readonly GlobalObjectKey IdAssessmentCompleted = GlobalObjectKey.Parse("9iBL85w0ZUGz9zoHIHP4NA*pa1SUYto60Kf5AbocfPKmQ");
		private static readonly GlobalObjectKey IdAssessmentGrade = GlobalObjectKey.Parse("9iBL85w0ZUGz9zoHIHP4NA*pCM8DA1hnUq1abz2hNe+ng");
		private static readonly GlobalObjectKey IdAssessmentMarks = GlobalObjectKey.Parse("9iBL85w0ZUGz9zoHIHP4NA*Wx02NmbKmUqigcOdRMnyFQ");
		private static readonly GlobalObjectKey IdAssessmentDateSubmitted = GlobalObjectKey.Parse("9iBL85w0ZUGz9zoHIHP4NA*OnrrzCAKdEyvgRajfI1Wcg");
		private static readonly GlobalObjectKey IdAssessmentDateMarked = GlobalObjectKey.Parse("9iBL85w0ZUGz9zoHIHP4NA*GMlsO84aLUinhCANAbYHUg");
		private static readonly GlobalObjectKey IdMarkbookTasksList = GlobalObjectKey.Parse("9iBL85w0ZUGz9zoHIHP4NA*NPMeiw0OlkCgS2CFNTqEOg");

		public static void EnsureInitialized() {}

		static STMarkbookAssessmentsStructure() {
			ssCaseConferencing.STMarkbookAssessmentsStructureTypeFactoryImpl.InitializeFactory();
		}
		[System.Xml.Serialization.XmlElement("AssessmentID")]
		public int ssAssessmentID;

		[System.Xml.Serialization.XmlElement("AssessmentCode")]
		public string ssAssessmentCode;

		[System.Xml.Serialization.XmlElement("AssessmentTitle")]
		public string ssAssessmentTitle;

		[System.Xml.Serialization.XmlElement("AssessmentCompleted")]
		public bool ssAssessmentCompleted;

		[System.Xml.Serialization.XmlElement("AssessmentGrade")]
		public string ssAssessmentGrade;

		[System.Xml.Serialization.XmlElement("AssessmentMarks")]
		public decimal ssAssessmentMarks;

		[System.Xml.Serialization.XmlElement("AssessmentDateSubmitted")]
		public DateTime ssAssessmentDateSubmitted;

		[System.Xml.Serialization.XmlElement("AssessmentDateMarked")]
		public DateTime ssAssessmentDateMarked;

		[System.Xml.Serialization.XmlElement("MarkbookTasksList")]
		public RLMarkbookTasksList ssMarkbookTasksList;


		public BitArray OptimizedAttributes;

		public STMarkbookAssessmentsStructure(params string[] dummy) {
			OptimizedAttributes = null;
			ssAssessmentID = 0;
			ssAssessmentCode = "";
			ssAssessmentTitle = "";
			ssAssessmentCompleted = false;
			ssAssessmentGrade = "";
			ssAssessmentMarks = 0.0M;
			ssAssessmentDateSubmitted = new DateTime(1900, 1, 1, 0, 0, 0);
			ssAssessmentDateMarked = new DateTime(1900, 1, 1, 0, 0, 0);
			ssMarkbookTasksList = new RLMarkbookTasksList();
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
			ssAssessmentID = r.ReadInteger(index++, "MarkbookAssessments.AssessmentID", 0);
			ssAssessmentCode = r.ReadText(index++, "MarkbookAssessments.AssessmentCode", "");
			ssAssessmentTitle = r.ReadText(index++, "MarkbookAssessments.AssessmentTitle", "");
			ssAssessmentCompleted = r.ReadBoolean(index++, "MarkbookAssessments.AssessmentCompleted", false);
			ssAssessmentGrade = r.ReadText(index++, "MarkbookAssessments.AssessmentGrade", "");
			ssAssessmentMarks = r.ReadDecimal(index++, "MarkbookAssessments.AssessmentMarks", 0.0M);
			ssAssessmentDateSubmitted = r.ReadDateTime(index++, "MarkbookAssessments.AssessmentDateSubmitted", new DateTime(1900, 1, 1, 0, 0, 0));
			ssAssessmentDateMarked = r.ReadDateTime(index++, "MarkbookAssessments.AssessmentDateMarked", new DateTime(1900, 1, 1, 0, 0, 0));
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
		public void ReadIM(STMarkbookAssessmentsStructure r) {
			this = r;
		}


		public static bool operator == (STMarkbookAssessmentsStructure a, STMarkbookAssessmentsStructure b) {
			if (a.ssAssessmentID != b.ssAssessmentID) return false;
			if (a.ssAssessmentCode != b.ssAssessmentCode) return false;
			if (a.ssAssessmentTitle != b.ssAssessmentTitle) return false;
			if (a.ssAssessmentCompleted != b.ssAssessmentCompleted) return false;
			if (a.ssAssessmentGrade != b.ssAssessmentGrade) return false;
			if (a.ssAssessmentMarks != b.ssAssessmentMarks) return false;
			if (a.ssAssessmentDateSubmitted != b.ssAssessmentDateSubmitted) return false;
			if (a.ssAssessmentDateMarked != b.ssAssessmentDateMarked) return false;
			if (a.ssMarkbookTasksList != b.ssMarkbookTasksList) return false;
			return true;
		}

		public static bool operator != (STMarkbookAssessmentsStructure a, STMarkbookAssessmentsStructure b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(STMarkbookAssessmentsStructure)) return false;
			return (this == (STMarkbookAssessmentsStructure) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssAssessmentID.GetHashCode()
				^ ssAssessmentCode.GetHashCode()
				^ ssAssessmentTitle.GetHashCode()
				^ ssAssessmentCompleted.GetHashCode()
				^ ssAssessmentGrade.GetHashCode()
				^ ssAssessmentMarks.GetHashCode()
				^ ssAssessmentDateSubmitted.GetHashCode()
				^ ssAssessmentDateMarked.GetHashCode()
				^ ssMarkbookTasksList.GetHashCode()
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

		public STMarkbookAssessmentsStructure(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssAssessmentID = 0;
			ssAssessmentCode = "";
			ssAssessmentTitle = "";
			ssAssessmentCompleted = false;
			ssAssessmentGrade = "";
			ssAssessmentMarks = 0.0M;
			ssAssessmentDateSubmitted = new DateTime(1900, 1, 1, 0, 0, 0);
			ssAssessmentDateMarked = new DateTime(1900, 1, 1, 0, 0, 0);
			ssMarkbookTasksList = new RLMarkbookTasksList();
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fields[0] .FieldType.IsSerializable)
			ssAssessmentID = (int) info.GetValue(fields[0] .Name, fields[0] .FieldType);
			if (fields[1] .FieldType.IsSerializable)
			ssAssessmentCode = (string) info.GetValue(fields[1] .Name, fields[1] .FieldType);
			if (fields[2] .FieldType.IsSerializable)
			ssAssessmentTitle = (string) info.GetValue(fields[2] .Name, fields[2] .FieldType);
			if (fields[3] .FieldType.IsSerializable)
			ssAssessmentCompleted = (bool) info.GetValue(fields[3] .Name, fields[3] .FieldType);
			if (fields[4] .FieldType.IsSerializable)
			ssAssessmentGrade = (string) info.GetValue(fields[4] .Name, fields[4] .FieldType);
			if (fields[5] .FieldType.IsSerializable)
			ssAssessmentMarks = (decimal) info.GetValue(fields[5] .Name, fields[5] .FieldType);
			if (fields[6] .FieldType.IsSerializable)
			ssAssessmentDateSubmitted = (DateTime) info.GetValue(fields[6] .Name, fields[6] .FieldType);
			if (fields[7] .FieldType.IsSerializable)
			ssAssessmentDateMarked = (DateTime) info.GetValue(fields[7] .Name, fields[7] .FieldType);
			if (fields[8] .FieldType.IsSerializable)
			ssMarkbookTasksList = (RLMarkbookTasksList) info.GetValue(fields[8] .Name, fields[8] .FieldType);
		}

		public void RecursiveReset() {
			ssMarkbookTasksList.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssMarkbookTasksList.InternalRecursiveSave();
		}


		public STMarkbookAssessmentsStructure Duplicate() {
			STMarkbookAssessmentsStructure t;
			t.ssAssessmentID = this.ssAssessmentID;
			t.ssAssessmentCode = this.ssAssessmentCode;
			t.ssAssessmentTitle = this.ssAssessmentTitle;
			t.ssAssessmentCompleted = this.ssAssessmentCompleted;
			t.ssAssessmentGrade = this.ssAssessmentGrade;
			t.ssAssessmentMarks = this.ssAssessmentMarks;
			t.ssAssessmentDateSubmitted = this.ssAssessmentDateSubmitted;
			t.ssAssessmentDateMarked = this.ssAssessmentDateMarked;
			t.ssMarkbookTasksList = (RLMarkbookTasksList) this.ssMarkbookTasksList.Duplicate();
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
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".AssessmentID")) VarValue.AppendAttribute(recordElem, "AssessmentID", ssAssessmentID, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "AssessmentID");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".AssessmentCode")) VarValue.AppendAttribute(recordElem, "AssessmentCode", ssAssessmentCode, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "AssessmentCode");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".AssessmentTitle")) VarValue.AppendAttribute(recordElem, "AssessmentTitle", ssAssessmentTitle, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "AssessmentTitle");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".AssessmentCompleted")) VarValue.AppendAttribute(recordElem, "AssessmentCompleted", ssAssessmentCompleted, detailLevel, TypeKind.Boolean); else VarValue.AppendOptimizedAttribute(recordElem, "AssessmentCompleted");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".AssessmentGrade")) VarValue.AppendAttribute(recordElem, "AssessmentGrade", ssAssessmentGrade, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "AssessmentGrade");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".AssessmentMarks")) VarValue.AppendAttribute(recordElem, "AssessmentMarks", ssAssessmentMarks, detailLevel, TypeKind.Decimal); else VarValue.AppendOptimizedAttribute(recordElem, "AssessmentMarks");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".AssessmentDateSubmitted")) VarValue.AppendAttribute(recordElem, "AssessmentDateSubmitted", ssAssessmentDateSubmitted, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "AssessmentDateSubmitted");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".AssessmentDateMarked")) VarValue.AppendAttribute(recordElem, "AssessmentDateMarked", ssAssessmentDateMarked, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "AssessmentDateMarked");
				ssMarkbookTasksList.ToXml(this, recordElem, "MarkbookTasksList", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "assessmentid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".AssessmentID")) variable.Value = ssAssessmentID; else variable.Optimized = true;
			} else if (head == "assessmentcode") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".AssessmentCode")) variable.Value = ssAssessmentCode; else variable.Optimized = true;
			} else if (head == "assessmenttitle") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".AssessmentTitle")) variable.Value = ssAssessmentTitle; else variable.Optimized = true;
			} else if (head == "assessmentcompleted") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".AssessmentCompleted")) variable.Value = ssAssessmentCompleted; else variable.Optimized = true;
			} else if (head == "assessmentgrade") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".AssessmentGrade")) variable.Value = ssAssessmentGrade; else variable.Optimized = true;
			} else if (head == "assessmentmarks") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".AssessmentMarks")) variable.Value = ssAssessmentMarks; else variable.Optimized = true;
			} else if (head == "assessmentdatesubmitted") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".AssessmentDateSubmitted")) variable.Value = ssAssessmentDateSubmitted; else variable.Optimized = true;
			} else if (head == "assessmentdatemarked") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".AssessmentDateMarked")) variable.Value = ssAssessmentDateMarked; else variable.Optimized = true;
			} else if (head == "markbooktaskslist") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".MarkbookTasksList")) variable.Value = ssMarkbookTasksList; else variable.Optimized = true;
				variable.SetFieldName("markbooktaskslist");
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
			if (key == IdAssessmentID) {
				return ssAssessmentID;
			} else if (key == IdAssessmentCode) {
				return ssAssessmentCode;
			} else if (key == IdAssessmentTitle) {
				return ssAssessmentTitle;
			} else if (key == IdAssessmentCompleted) {
				return ssAssessmentCompleted;
			} else if (key == IdAssessmentGrade) {
				return ssAssessmentGrade;
			} else if (key == IdAssessmentMarks) {
				return ssAssessmentMarks;
			} else if (key == IdAssessmentDateSubmitted) {
				return ssAssessmentDateSubmitted;
			} else if (key == IdAssessmentDateMarked) {
				return ssAssessmentDateMarked;
			} else if (key == IdMarkbookTasksList) {
				return ssMarkbookTasksList;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssAssessmentID = (int) other.AttributeGet(IdAssessmentID);
			ssAssessmentCode = (string) other.AttributeGet(IdAssessmentCode);
			ssAssessmentTitle = (string) other.AttributeGet(IdAssessmentTitle);
			ssAssessmentCompleted = (bool) other.AttributeGet(IdAssessmentCompleted);
			ssAssessmentGrade = (string) other.AttributeGet(IdAssessmentGrade);
			ssAssessmentMarks = (decimal) other.AttributeGet(IdAssessmentMarks);
			ssAssessmentDateSubmitted = (DateTime) other.AttributeGet(IdAssessmentDateSubmitted);
			ssAssessmentDateMarked = (DateTime) other.AttributeGet(IdAssessmentDateMarked);
			ssMarkbookTasksList = new RLMarkbookTasksList();
			ssMarkbookTasksList.FillFromOther((IOSList) other.AttributeGet(IdMarkbookTasksList));
		}
	} // STMarkbookAssessmentsStructure
	/// <summary>
	/// Structure <code>RCMarkbookAssessmentsRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCMarkbookAssessmentsRecord: ISerializable, ITypedRecord<RCMarkbookAssessmentsRecord> {
		private static readonly GlobalObjectKey IdMarkbookAssessments = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*2Y+0ugXwOhAD2W+Ib09V1A");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("MarkbookAssessments")]
		public STMarkbookAssessmentsStructure ssSTMarkbookAssessments;


		public static implicit operator STMarkbookAssessmentsStructure(RCMarkbookAssessmentsRecord r) {
			return r.ssSTMarkbookAssessments;
		}

		public static implicit operator RCMarkbookAssessmentsRecord(STMarkbookAssessmentsStructure r) {
			RCMarkbookAssessmentsRecord res = new RCMarkbookAssessmentsRecord(null);
			res.ssSTMarkbookAssessments = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCMarkbookAssessmentsRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTMarkbookAssessments = new STMarkbookAssessmentsStructure(null);
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
					ssSTMarkbookAssessments.OptimizedAttributes = value[0];
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
			ssSTMarkbookAssessments.Read(r, ref index);
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
		public void ReadIM(RCMarkbookAssessmentsRecord r) {
			this = r;
		}


		public static bool operator == (RCMarkbookAssessmentsRecord a, RCMarkbookAssessmentsRecord b) {
			if (a.ssSTMarkbookAssessments != b.ssSTMarkbookAssessments) return false;
			return true;
		}

		public static bool operator != (RCMarkbookAssessmentsRecord a, RCMarkbookAssessmentsRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCMarkbookAssessmentsRecord)) return false;
			return (this == (RCMarkbookAssessmentsRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTMarkbookAssessments.GetHashCode()
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

		public RCMarkbookAssessmentsRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTMarkbookAssessments = new STMarkbookAssessmentsStructure(null);
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fields[0] .FieldType.IsSerializable)
			ssSTMarkbookAssessments = (STMarkbookAssessmentsStructure) info.GetValue(fields[0] .Name, fields[0] .FieldType);
		}

		public void RecursiveReset() {
			ssSTMarkbookAssessments.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTMarkbookAssessments.InternalRecursiveSave();
		}


		public RCMarkbookAssessmentsRecord Duplicate() {
			RCMarkbookAssessmentsRecord t;
			t.ssSTMarkbookAssessments = (STMarkbookAssessmentsStructure) this.ssSTMarkbookAssessments.Duplicate();
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
				ssSTMarkbookAssessments.ToXml(this, recordElem, "MarkbookAssessments", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "markbookassessments") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".MarkbookAssessments")) variable.Value = ssSTMarkbookAssessments; else variable.Optimized = true;
				variable.SetFieldName("markbookassessments");
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
			if (key == IdMarkbookAssessments) {
				return ssSTMarkbookAssessments;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTMarkbookAssessments.FillFromOther((IRecord) other.AttributeGet(IdMarkbookAssessments));
		}
	} // RCMarkbookAssessmentsRecord
	/// <summary>
	/// RecordList type <code>RLMarkbookAssessmentsRecordList</code> that represents a record list of
	///  <code>MarkbookAssessments</code>
	/// </summary>
	[Serializable()]
	public partial class RLMarkbookAssessmentsRecordList: GenericRecordList<RCMarkbookAssessmentsRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCMarkbookAssessmentsRecord GetElementDefaultValue() {
			return new RCMarkbookAssessmentsRecord("");
		}

		public T[] ToArray<T>(Func<RCMarkbookAssessmentsRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLMarkbookAssessmentsRecordList recordlist, Func<RCMarkbookAssessmentsRecord, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLMarkbookAssessmentsRecordList ToList<T>(T[] array, Func <T, RCMarkbookAssessmentsRecord> converter) {
			RLMarkbookAssessmentsRecordList result = new RLMarkbookAssessmentsRecordList();
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
		public RLMarkbookAssessmentsRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLMarkbookAssessmentsRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLMarkbookAssessmentsRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLMarkbookAssessmentsRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
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
		protected override OSList<RCMarkbookAssessmentsRecord> NewList() {
			return new RLMarkbookAssessmentsRecordList();
		}


	} // RLMarkbookAssessmentsRecordList
	/// <summary>
	/// RecordList type <code>RLMarkbookAssessmentsList</code> that represents a record list of <code>Text,
	///  Text, Text, Decimal, DateTime, DateTime, Boolean, Integer, MarkbookTasksList</code>
	/// </summary>
	[Serializable()]
	public partial class RLMarkbookAssessmentsList: GenericRecordList<STMarkbookAssessmentsStructure>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		static RLMarkbookAssessmentsList() {
			ssCaseConferencing.RLMarkbookAssessmentsListTypeFactoryImpl.InitializeFactory();
		}

		protected override STMarkbookAssessmentsStructure GetElementDefaultValue() {
			return new STMarkbookAssessmentsStructure("");
		}

		public T[] ToArray<T>(Func<STMarkbookAssessmentsStructure, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLMarkbookAssessmentsList recordlist, Func<STMarkbookAssessmentsStructure, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLMarkbookAssessmentsList ToList<T>(T[] array, Func <T, STMarkbookAssessmentsStructure> converter) {
			RLMarkbookAssessmentsList result = new RLMarkbookAssessmentsList();
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
		public RLMarkbookAssessmentsList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLMarkbookAssessmentsList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLMarkbookAssessmentsList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLMarkbookAssessmentsList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[0];
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<STMarkbookAssessmentsStructure> NewList() {
			return new RLMarkbookAssessmentsList();
		}


	} // RLMarkbookAssessmentsList
}

namespace ssCaseConferencing {
	[XmlType("MarkbookAssessments")]
	public class WORCMarkbookAssessmentsRecord {
		[System.Xml.Serialization.XmlElement("AssessmentID")]
		public int varWSAssessmentID;

		[System.Xml.Serialization.XmlElement("AssessmentCode")]
		public string varWSAssessmentCode;

		[System.Xml.Serialization.XmlElement("AssessmentTitle")]
		public string varWSAssessmentTitle;

		[System.Xml.Serialization.XmlElement("AssessmentCompleted")]
		public bool varWSAssessmentCompleted;

		[System.Xml.Serialization.XmlElement("AssessmentGrade")]
		public string varWSAssessmentGrade;

		[System.Xml.Serialization.XmlElement("AssessmentMarks")]
		public decimal varWSAssessmentMarks;

		[System.Xml.Serialization.XmlElement("AssessmentDateSubmitted")]
		public DateTime varWSAssessmentDateSubmitted;

		[System.Xml.Serialization.XmlElement("AssessmentDateMarked")]
		public DateTime varWSAssessmentDateMarked;

		[System.Xml.Serialization.XmlArray("MarkbookTasksList")]
		public WORCMarkbookTasksRecord[] varWSMarkbookTasksList;

		public WORCMarkbookAssessmentsRecord() {
			varWSAssessmentID = (int) 0;
			varWSAssessmentCode = (string) "";
			varWSAssessmentTitle = (string) "";
			varWSAssessmentCompleted = (bool) false;
			varWSAssessmentGrade = (string) "";
			varWSAssessmentMarks = (decimal) 0.0M;
			varWSAssessmentDateSubmitted = (DateTime) new DateTime(1900, 1, 1, 0, 0, 0);
			varWSAssessmentDateMarked = (DateTime) new DateTime(1900, 1, 1, 0, 0, 0);
			varWSMarkbookTasksList = new WORCMarkbookTasksRecord[0];
		}

		public WORCMarkbookAssessmentsRecord(STMarkbookAssessmentsStructure r) {
			varWSAssessmentID = (int) r.ssAssessmentID;
			varWSAssessmentCode = BaseAppUtils.RemoveControlChars(r.ssAssessmentCode);
			varWSAssessmentTitle = BaseAppUtils.RemoveControlChars(r.ssAssessmentTitle);
			varWSAssessmentCompleted = (bool) r.ssAssessmentCompleted;
			varWSAssessmentGrade = BaseAppUtils.RemoveControlChars(r.ssAssessmentGrade);
			varWSAssessmentMarks = (decimal) r.ssAssessmentMarks;
			varWSAssessmentDateSubmitted = (DateTime) r.ssAssessmentDateSubmitted;
			varWSAssessmentDateMarked = (DateTime) r.ssAssessmentDateMarked;
			varWSMarkbookTasksList = WORCMarkbookTasksRecord.FromRecordList(r.ssMarkbookTasksList);
		}

		public static RLMarkbookAssessmentsList ToRecordList(WORCMarkbookAssessmentsRecord[] array) {
			RLMarkbookAssessmentsList rl = new RLMarkbookAssessmentsList();
			if (array != null) {
				foreach(WORCMarkbookAssessmentsRecord val in array) {
					rl.Append(val);
				}
			}
			return rl;
		}

		public static WORCMarkbookAssessmentsRecord[] FromRecordList(RLMarkbookAssessmentsList rl) {
			WORCMarkbookAssessmentsRecord[] array = new WORCMarkbookAssessmentsRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial struct RCMarkbookAssessmentsRecord {
		public static implicit operator WORCMarkbookAssessmentsRecord(RCMarkbookAssessmentsRecord r) {
			return new WORCMarkbookAssessmentsRecord(r.ssSTMarkbookAssessments);
		}

		public static implicit operator RCMarkbookAssessmentsRecord(WORCMarkbookAssessmentsRecord w) {
			RCMarkbookAssessmentsRecord r = new RCMarkbookAssessmentsRecord("");
			if (w != null) {
				r.ssSTMarkbookAssessments = w;
			}
			return r;
		}

	}

	partial struct STMarkbookAssessmentsStructure {
		public static implicit operator WORCMarkbookAssessmentsRecord(STMarkbookAssessmentsStructure r) {
			return new WORCMarkbookAssessmentsRecord(r);
		}

		public static implicit operator STMarkbookAssessmentsStructure(WORCMarkbookAssessmentsRecord w) {
			STMarkbookAssessmentsStructure r = new STMarkbookAssessmentsStructure("");
			if (w != null) {
				r.ssAssessmentID = (int) w.varWSAssessmentID;
				r.ssAssessmentCode = ((string) w.varWSAssessmentCode ?? "");
				r.ssAssessmentTitle = ((string) w.varWSAssessmentTitle ?? "");
				r.ssAssessmentCompleted = (bool) w.varWSAssessmentCompleted;
				r.ssAssessmentGrade = ((string) w.varWSAssessmentGrade ?? "");
				r.ssAssessmentMarks = (decimal) w.varWSAssessmentMarks;
				r.ssAssessmentDateSubmitted = (DateTime) w.varWSAssessmentDateSubmitted;
				r.ssAssessmentDateMarked = (DateTime) w.varWSAssessmentDateMarked;
				r.ssMarkbookTasksList = WORCMarkbookTasksRecord.ToRecordList(w.varWSMarkbookTasksList);
			}
			return r;
		}

	}
}


namespace ssCaseConferencing {
	[Serializable()]
	public partial class WORLMarkbookAssessmentsRecordList {
		public WORCMarkbookAssessmentsRecord[] Array;


		public WORLMarkbookAssessmentsRecordList(WORCMarkbookAssessmentsRecord[] r) {
			if (r == null)
			Array = new WORCMarkbookAssessmentsRecord[0];
			else
			Array = r;
		}
		public WORLMarkbookAssessmentsRecordList() {
			Array = new WORCMarkbookAssessmentsRecord[0];
		}

		public WORLMarkbookAssessmentsRecordList(RLMarkbookAssessmentsRecordList rl) {
			rl=(RLMarkbookAssessmentsRecordList) rl.Duplicate();
			Array = new WORCMarkbookAssessmentsRecord[rl.Length];
			while (!rl.Eof) {
				Array[rl.CurrentRowNumber] = new WORCMarkbookAssessmentsRecord(rl.CurrentRec);
				rl.Advance();
			}
		}

	}
}

namespace ssCaseConferencing {
	partial class RLMarkbookAssessmentsRecordList {
		public static implicit operator RLMarkbookAssessmentsRecordList(WORCMarkbookAssessmentsRecord[] array) {
			RLMarkbookAssessmentsRecordList rl = new RLMarkbookAssessmentsRecordList();
			if (array != null) {
				foreach(WORCMarkbookAssessmentsRecord val in array) {
					rl.Append((RCMarkbookAssessmentsRecord) val);
				}
			}
			return rl;
		}
		public static implicit operator WORCMarkbookAssessmentsRecord[](RLMarkbookAssessmentsRecordList rl) {
			WORCMarkbookAssessmentsRecord[] array = new WORCMarkbookAssessmentsRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = (RCMarkbookAssessmentsRecord) rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial class WORLMarkbookAssessmentsRecordList {
		public static implicit operator RLMarkbookAssessmentsRecordList(WORLMarkbookAssessmentsRecordList w) {
			return w.Array;
		}
		public static implicit operator WORLMarkbookAssessmentsRecordList(RLMarkbookAssessmentsRecordList rl) {
			return new WORLMarkbookAssessmentsRecordList(rl);
		}
		public static implicit operator WORCMarkbookAssessmentsRecord[](WORLMarkbookAssessmentsRecordList w) {
			if (w != null) {
				return w.Array;
			}
			return null;
		}
		public static implicit operator WORLMarkbookAssessmentsRecordList(WORCMarkbookAssessmentsRecord[] array) {
			return new WORLMarkbookAssessmentsRecordList(array);
		}
	}
}

namespace ssCaseConferencing {
	[Serializable()]
	public partial class WORLMarkbookAssessmentsList {
		public WORCMarkbookAssessmentsRecord[] Array;


		public WORLMarkbookAssessmentsList(WORCMarkbookAssessmentsRecord[] r) {
			if (r == null)
			Array = new WORCMarkbookAssessmentsRecord[0];
			else
			Array = r;
		}
		public WORLMarkbookAssessmentsList() {
			Array = new WORCMarkbookAssessmentsRecord[0];
		}

		public WORLMarkbookAssessmentsList(RLMarkbookAssessmentsList rl) {
			rl=(RLMarkbookAssessmentsList) rl.Duplicate();
			Array = new WORCMarkbookAssessmentsRecord[rl.Length];
			while (!rl.Eof) {
				Array[rl.CurrentRowNumber] = rl.CurrentRec.Duplicate();
				rl.Advance();
			}
		}

	}
}

namespace ssCaseConferencing {
	partial class RLMarkbookAssessmentsList {
		public static implicit operator RLMarkbookAssessmentsList(WORCMarkbookAssessmentsRecord[] array) {
			RLMarkbookAssessmentsList rl = new RLMarkbookAssessmentsList();
			if (array != null) {
				foreach(WORCMarkbookAssessmentsRecord val in array) {
					rl.Append((STMarkbookAssessmentsStructure) val);
				}
			}
			return rl;
		}
		public static implicit operator WORCMarkbookAssessmentsRecord[](RLMarkbookAssessmentsList rl) {
			WORCMarkbookAssessmentsRecord[] array = new WORCMarkbookAssessmentsRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = (STMarkbookAssessmentsStructure) rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial class WORLMarkbookAssessmentsList {
		public static implicit operator RLMarkbookAssessmentsList(WORLMarkbookAssessmentsList w) {
			return w.Array;
		}
		public static implicit operator WORLMarkbookAssessmentsList(RLMarkbookAssessmentsList rl) {
			return new WORLMarkbookAssessmentsList(rl);
		}
		public static implicit operator WORCMarkbookAssessmentsRecord[](WORLMarkbookAssessmentsList w) {
			if (w != null) {
				return w.Array;
			}
			return null;
		}
		public static implicit operator WORLMarkbookAssessmentsList(WORCMarkbookAssessmentsRecord[] array) {
			return new WORLMarkbookAssessmentsList(array);
		}
	}
}
