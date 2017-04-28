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
	/// Structure <code>STAttendanceOVLayoutColumnsStructure</code> that represents the Service Studio
	///  structure <code>AttendanceOVLayoutColumns</code> <p> Description: </p>
	/// </summary>
	[Serializable()]
	public partial struct STAttendanceOVLayoutColumnsStructure: ISerializable, ITypedRecord<STAttendanceOVLayoutColumnsStructure>, ISimpleRecord {
		private static readonly GlobalObjectKey IdColumnNumber = GlobalObjectKey.Parse("shmcdFKEAEWXZGfrlZEwCQ*YsFwAfYt7U2HogTWdBlemg");
		private static readonly GlobalObjectKey IdColumnDate = GlobalObjectKey.Parse("shmcdFKEAEWXZGfrlZEwCQ*8H1NAuKJSUK6cVUYrZlKLg");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("ColumnNumber")]
		public int ssColumnNumber;

		[System.Xml.Serialization.XmlElement("ColumnDate")]
		public DateTime ssColumnDate;


		public BitArray OptimizedAttributes;

		public STAttendanceOVLayoutColumnsStructure(params string[] dummy) {
			OptimizedAttributes = null;
			ssColumnNumber = 0;
			ssColumnDate = new DateTime(1900, 1, 1, 0, 0, 0);
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
			ssColumnNumber = r.ReadInteger(index++, "AttendanceOVLayoutColumns.ColumnNumber", 0);
			ssColumnDate = r.ReadDate(index++, "AttendanceOVLayoutColumns.ColumnDate", new DateTime(1900, 1, 1, 0, 0, 0));
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
		public void ReadIM(STAttendanceOVLayoutColumnsStructure r) {
			this = r;
		}


		public static bool operator == (STAttendanceOVLayoutColumnsStructure a, STAttendanceOVLayoutColumnsStructure b) {
			if (a.ssColumnNumber != b.ssColumnNumber) return false;
			if (a.ssColumnDate != b.ssColumnDate) return false;
			return true;
		}

		public static bool operator != (STAttendanceOVLayoutColumnsStructure a, STAttendanceOVLayoutColumnsStructure b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(STAttendanceOVLayoutColumnsStructure)) return false;
			return (this == (STAttendanceOVLayoutColumnsStructure) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssColumnNumber.GetHashCode()
				^ ssColumnDate.GetHashCode()
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

		public STAttendanceOVLayoutColumnsStructure(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssColumnNumber = 0;
			ssColumnDate = new DateTime(1900, 1, 1, 0, 0, 0);
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fields[0] .FieldType.IsSerializable)
			ssColumnNumber = (int) info.GetValue(fields[0] .Name, fields[0] .FieldType);
			if (fields[1] .FieldType.IsSerializable)
			ssColumnDate = (DateTime) info.GetValue(fields[1] .Name, fields[1] .FieldType);
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public STAttendanceOVLayoutColumnsStructure Duplicate() {
			STAttendanceOVLayoutColumnsStructure t;
			t.ssColumnNumber = this.ssColumnNumber;
			t.ssColumnDate = this.ssColumnDate;
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
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".ColumnNumber")) VarValue.AppendAttribute(recordElem, "ColumnNumber", ssColumnNumber, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "ColumnNumber");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".ColumnDate")) VarValue.AppendAttribute(recordElem, "ColumnDate", ssColumnDate, detailLevel, TypeKind.Date); else VarValue.AppendOptimizedAttribute(recordElem, "ColumnDate");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "columnnumber") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ColumnNumber")) variable.Value = ssColumnNumber; else variable.Optimized = true;
			} else if (head == "columndate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ColumnDate")) variable.Value = ssColumnDate; else variable.Optimized = true;
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
			if (key == IdColumnNumber) {
				return ssColumnNumber;
			} else if (key == IdColumnDate) {
				return ssColumnDate;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssColumnNumber = (int) other.AttributeGet(IdColumnNumber);
			ssColumnDate = (DateTime) other.AttributeGet(IdColumnDate);
		}
	} // STAttendanceOVLayoutColumnsStructure
	/// <summary>
	/// Structure <code>RCAttendanceOVLayoutColumnsRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCAttendanceOVLayoutColumnsRecord: ISerializable, ITypedRecord<RCAttendanceOVLayoutColumnsRecord> {
		private static readonly GlobalObjectKey IdAttendanceOVLayoutColumns = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*rCFY_buYTMIb4td9C0Y0Eg");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("AttendanceOVLayoutColumns")]
		public STAttendanceOVLayoutColumnsStructure ssSTAttendanceOVLayoutColumns;


		public static implicit operator STAttendanceOVLayoutColumnsStructure(RCAttendanceOVLayoutColumnsRecord r) {
			return r.ssSTAttendanceOVLayoutColumns;
		}

		public static implicit operator RCAttendanceOVLayoutColumnsRecord(STAttendanceOVLayoutColumnsStructure r) {
			RCAttendanceOVLayoutColumnsRecord res = new RCAttendanceOVLayoutColumnsRecord(null);
			res.ssSTAttendanceOVLayoutColumns = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCAttendanceOVLayoutColumnsRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTAttendanceOVLayoutColumns = new STAttendanceOVLayoutColumnsStructure(null);
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
					ssSTAttendanceOVLayoutColumns.OptimizedAttributes = value[0];
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
			ssSTAttendanceOVLayoutColumns.Read(r, ref index);
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
		public void ReadIM(RCAttendanceOVLayoutColumnsRecord r) {
			this = r;
		}


		public static bool operator == (RCAttendanceOVLayoutColumnsRecord a, RCAttendanceOVLayoutColumnsRecord b) {
			if (a.ssSTAttendanceOVLayoutColumns != b.ssSTAttendanceOVLayoutColumns) return false;
			return true;
		}

		public static bool operator != (RCAttendanceOVLayoutColumnsRecord a, RCAttendanceOVLayoutColumnsRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCAttendanceOVLayoutColumnsRecord)) return false;
			return (this == (RCAttendanceOVLayoutColumnsRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTAttendanceOVLayoutColumns.GetHashCode()
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

		public RCAttendanceOVLayoutColumnsRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTAttendanceOVLayoutColumns = new STAttendanceOVLayoutColumnsStructure(null);
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fields[0] .FieldType.IsSerializable)
			ssSTAttendanceOVLayoutColumns = (STAttendanceOVLayoutColumnsStructure) info.GetValue(fields[0] .Name, fields[0] .FieldType);
		}

		public void RecursiveReset() {
			ssSTAttendanceOVLayoutColumns.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTAttendanceOVLayoutColumns.InternalRecursiveSave();
		}


		public RCAttendanceOVLayoutColumnsRecord Duplicate() {
			RCAttendanceOVLayoutColumnsRecord t;
			t.ssSTAttendanceOVLayoutColumns = (STAttendanceOVLayoutColumnsStructure) this.ssSTAttendanceOVLayoutColumns.Duplicate();
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
				ssSTAttendanceOVLayoutColumns.ToXml(this, recordElem, "AttendanceOVLayoutColumns", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "attendanceovlayoutcolumns") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".AttendanceOVLayoutColumns")) variable.Value = ssSTAttendanceOVLayoutColumns; else variable.Optimized = true;
				variable.SetFieldName("attendanceovlayoutcolumns");
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
			if (key == IdAttendanceOVLayoutColumns) {
				return ssSTAttendanceOVLayoutColumns;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTAttendanceOVLayoutColumns.FillFromOther((IRecord) other.AttributeGet(IdAttendanceOVLayoutColumns));
		}
	} // RCAttendanceOVLayoutColumnsRecord
	/// <summary>
	/// RecordList type <code>RLAttendanceOVLayoutColumnsRecordList</code> that represents a record list of
	///  <code>AttendanceOVLayoutColumns</code>
	/// </summary>
	[Serializable()]
	public partial class RLAttendanceOVLayoutColumnsRecordList: GenericRecordList<RCAttendanceOVLayoutColumnsRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCAttendanceOVLayoutColumnsRecord GetElementDefaultValue() {
			return new RCAttendanceOVLayoutColumnsRecord("");
		}

		public T[] ToArray<T>(Func<RCAttendanceOVLayoutColumnsRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLAttendanceOVLayoutColumnsRecordList recordlist, Func<RCAttendanceOVLayoutColumnsRecord, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLAttendanceOVLayoutColumnsRecordList ToList<T>(T[] array, Func <T, RCAttendanceOVLayoutColumnsRecord> converter) {
			RLAttendanceOVLayoutColumnsRecordList result = new RLAttendanceOVLayoutColumnsRecordList();
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
		public RLAttendanceOVLayoutColumnsRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLAttendanceOVLayoutColumnsRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLAttendanceOVLayoutColumnsRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLAttendanceOVLayoutColumnsRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
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
		protected override OSList<RCAttendanceOVLayoutColumnsRecord> NewList() {
			return new RLAttendanceOVLayoutColumnsRecordList();
		}


	} // RLAttendanceOVLayoutColumnsRecordList
	/// <summary>
	/// RecordList type <code>RLAttendanceOVLayoutColumnsList</code> that represents a record list of
	///  <code>Date, Integer</code>
	/// </summary>
	[Serializable()]
	public partial class RLAttendanceOVLayoutColumnsList: GenericRecordList<STAttendanceOVLayoutColumnsStructure>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override STAttendanceOVLayoutColumnsStructure GetElementDefaultValue() {
			return new STAttendanceOVLayoutColumnsStructure("");
		}

		public T[] ToArray<T>(Func<STAttendanceOVLayoutColumnsStructure, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLAttendanceOVLayoutColumnsList recordlist, Func<STAttendanceOVLayoutColumnsStructure, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLAttendanceOVLayoutColumnsList ToList<T>(T[] array, Func <T, STAttendanceOVLayoutColumnsStructure> converter) {
			RLAttendanceOVLayoutColumnsList result = new RLAttendanceOVLayoutColumnsList();
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
		public RLAttendanceOVLayoutColumnsList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLAttendanceOVLayoutColumnsList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLAttendanceOVLayoutColumnsList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLAttendanceOVLayoutColumnsList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[0];
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<STAttendanceOVLayoutColumnsStructure> NewList() {
			return new RLAttendanceOVLayoutColumnsList();
		}


	} // RLAttendanceOVLayoutColumnsList
}

namespace ssCaseConferencing {
	[XmlType("AttendanceOVLayoutColumns")]
	public class WORCAttendanceOVLayoutColumnsRecord {
		[System.Xml.Serialization.XmlElement("ColumnNumber")]
		public int varWSColumnNumber;

		[System.Xml.Serialization.XmlElement("ColumnDate", DataType= "date")]
		public DateTime varWSColumnDate;

		public WORCAttendanceOVLayoutColumnsRecord() {
			varWSColumnNumber = (int) 0;
			varWSColumnDate = (DateTime) new DateTime(1900, 1, 1, 0, 0, 0);
		}

		public WORCAttendanceOVLayoutColumnsRecord(STAttendanceOVLayoutColumnsStructure r) {
			varWSColumnNumber = (int) r.ssColumnNumber;
			varWSColumnDate = (DateTime) r.ssColumnDate;
		}

		public static RLAttendanceOVLayoutColumnsList ToRecordList(WORCAttendanceOVLayoutColumnsRecord[] array) {
			RLAttendanceOVLayoutColumnsList rl = new RLAttendanceOVLayoutColumnsList();
			if (array != null) {
				foreach(WORCAttendanceOVLayoutColumnsRecord val in array) {
					rl.Append(val);
				}
			}
			return rl;
		}

		public static WORCAttendanceOVLayoutColumnsRecord[] FromRecordList(RLAttendanceOVLayoutColumnsList rl) {
			WORCAttendanceOVLayoutColumnsRecord[] array = new WORCAttendanceOVLayoutColumnsRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial struct RCAttendanceOVLayoutColumnsRecord {
		public static implicit operator WORCAttendanceOVLayoutColumnsRecord(RCAttendanceOVLayoutColumnsRecord r) {
			return new WORCAttendanceOVLayoutColumnsRecord(r.ssSTAttendanceOVLayoutColumns);
		}

		public static implicit operator RCAttendanceOVLayoutColumnsRecord(WORCAttendanceOVLayoutColumnsRecord w) {
			RCAttendanceOVLayoutColumnsRecord r = new RCAttendanceOVLayoutColumnsRecord("");
			if (w != null) {
				r.ssSTAttendanceOVLayoutColumns = w;
			}
			return r;
		}

	}

	partial struct STAttendanceOVLayoutColumnsStructure {
		public static implicit operator WORCAttendanceOVLayoutColumnsRecord(STAttendanceOVLayoutColumnsStructure r) {
			return new WORCAttendanceOVLayoutColumnsRecord(r);
		}

		public static implicit operator STAttendanceOVLayoutColumnsStructure(WORCAttendanceOVLayoutColumnsRecord w) {
			STAttendanceOVLayoutColumnsStructure r = new STAttendanceOVLayoutColumnsStructure("");
			if (w != null) {
				r.ssColumnNumber = (int) w.varWSColumnNumber;
				r.ssColumnDate = (DateTime) w.varWSColumnDate;
			}
			return r;
		}

	}
}


namespace ssCaseConferencing {
	[Serializable()]
	public partial class WORLAttendanceOVLayoutColumnsRecordList {
		public WORCAttendanceOVLayoutColumnsRecord[] Array;


		public WORLAttendanceOVLayoutColumnsRecordList(WORCAttendanceOVLayoutColumnsRecord[] r) {
			if (r == null)
			Array = new WORCAttendanceOVLayoutColumnsRecord[0];
			else
			Array = r;
		}
		public WORLAttendanceOVLayoutColumnsRecordList() {
			Array = new WORCAttendanceOVLayoutColumnsRecord[0];
		}

		public WORLAttendanceOVLayoutColumnsRecordList(RLAttendanceOVLayoutColumnsRecordList rl) {
			rl=(RLAttendanceOVLayoutColumnsRecordList) rl.Duplicate();
			Array = new WORCAttendanceOVLayoutColumnsRecord[rl.Length];
			while (!rl.Eof) {
				Array[rl.CurrentRowNumber] = new WORCAttendanceOVLayoutColumnsRecord(rl.CurrentRec);
				rl.Advance();
			}
		}

	}
}

namespace ssCaseConferencing {
	partial class RLAttendanceOVLayoutColumnsRecordList {
		public static implicit operator RLAttendanceOVLayoutColumnsRecordList(WORCAttendanceOVLayoutColumnsRecord[] array) {
			RLAttendanceOVLayoutColumnsRecordList rl = new RLAttendanceOVLayoutColumnsRecordList();
			if (array != null) {
				foreach(WORCAttendanceOVLayoutColumnsRecord val in array) {
					rl.Append((RCAttendanceOVLayoutColumnsRecord) val);
				}
			}
			return rl;
		}
		public static implicit operator WORCAttendanceOVLayoutColumnsRecord[](RLAttendanceOVLayoutColumnsRecordList rl) {
			WORCAttendanceOVLayoutColumnsRecord[] array = new WORCAttendanceOVLayoutColumnsRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = (RCAttendanceOVLayoutColumnsRecord) rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial class WORLAttendanceOVLayoutColumnsRecordList {
		public static implicit operator RLAttendanceOVLayoutColumnsRecordList(WORLAttendanceOVLayoutColumnsRecordList w) {
			return w.Array;
		}
		public static implicit operator WORLAttendanceOVLayoutColumnsRecordList(RLAttendanceOVLayoutColumnsRecordList rl) {
			return new WORLAttendanceOVLayoutColumnsRecordList(rl);
		}
		public static implicit operator WORCAttendanceOVLayoutColumnsRecord[](WORLAttendanceOVLayoutColumnsRecordList w) {
			if (w != null) {
				return w.Array;
			}
			return null;
		}
		public static implicit operator WORLAttendanceOVLayoutColumnsRecordList(WORCAttendanceOVLayoutColumnsRecord[] array) {
			return new WORLAttendanceOVLayoutColumnsRecordList(array);
		}
	}
}

namespace ssCaseConferencing {
	[Serializable()]
	public partial class WORLAttendanceOVLayoutColumnsList {
		public WORCAttendanceOVLayoutColumnsRecord[] Array;


		public WORLAttendanceOVLayoutColumnsList(WORCAttendanceOVLayoutColumnsRecord[] r) {
			if (r == null)
			Array = new WORCAttendanceOVLayoutColumnsRecord[0];
			else
			Array = r;
		}
		public WORLAttendanceOVLayoutColumnsList() {
			Array = new WORCAttendanceOVLayoutColumnsRecord[0];
		}

		public WORLAttendanceOVLayoutColumnsList(RLAttendanceOVLayoutColumnsList rl) {
			rl=(RLAttendanceOVLayoutColumnsList) rl.Duplicate();
			Array = new WORCAttendanceOVLayoutColumnsRecord[rl.Length];
			while (!rl.Eof) {
				Array[rl.CurrentRowNumber] = rl.CurrentRec.Duplicate();
				rl.Advance();
			}
		}

	}
}

namespace ssCaseConferencing {
	partial class RLAttendanceOVLayoutColumnsList {
		public static implicit operator RLAttendanceOVLayoutColumnsList(WORCAttendanceOVLayoutColumnsRecord[] array) {
			RLAttendanceOVLayoutColumnsList rl = new RLAttendanceOVLayoutColumnsList();
			if (array != null) {
				foreach(WORCAttendanceOVLayoutColumnsRecord val in array) {
					rl.Append((STAttendanceOVLayoutColumnsStructure) val);
				}
			}
			return rl;
		}
		public static implicit operator WORCAttendanceOVLayoutColumnsRecord[](RLAttendanceOVLayoutColumnsList rl) {
			WORCAttendanceOVLayoutColumnsRecord[] array = new WORCAttendanceOVLayoutColumnsRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = (STAttendanceOVLayoutColumnsStructure) rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial class WORLAttendanceOVLayoutColumnsList {
		public static implicit operator RLAttendanceOVLayoutColumnsList(WORLAttendanceOVLayoutColumnsList w) {
			return w.Array;
		}
		public static implicit operator WORLAttendanceOVLayoutColumnsList(RLAttendanceOVLayoutColumnsList rl) {
			return new WORLAttendanceOVLayoutColumnsList(rl);
		}
		public static implicit operator WORCAttendanceOVLayoutColumnsRecord[](WORLAttendanceOVLayoutColumnsList w) {
			if (w != null) {
				return w.Array;
			}
			return null;
		}
		public static implicit operator WORLAttendanceOVLayoutColumnsList(WORCAttendanceOVLayoutColumnsRecord[] array) {
			return new WORLAttendanceOVLayoutColumnsList(array);
		}
	}
}

