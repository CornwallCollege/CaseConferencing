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
	/// Structure <code>STStaffListStructure</code> that represents the Service Studio structure
	///  <code>StaffList</code> <p> Description: </p>
	/// </summary>
	[Serializable()]
	public partial struct STStaffListStructure: ISerializable, ITypedRecord<STStaffListStructure>, ISimpleRecord {
		private static readonly GlobalObjectKey IdStaffID = GlobalObjectKey.Parse("shmcdFKEAEWXZGfrlZEwCQ*8BAN6pK5XUCxhID9rqujnA");
		private static readonly GlobalObjectKey IdStaffName = GlobalObjectKey.Parse("shmcdFKEAEWXZGfrlZEwCQ*lW7JQjAZKkymLFRIFqeR6g");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("StaffID")]
		public int ssStaffID;

		[System.Xml.Serialization.XmlElement("StaffName")]
		public string ssStaffName;


		public BitArray OptimizedAttributes;

		public STStaffListStructure(params string[] dummy) {
			OptimizedAttributes = null;
			ssStaffID = 0;
			ssStaffName = "";
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
			ssStaffID = r.ReadEntityReference(index++, "StaffList.StaffID", 0);
			ssStaffName = r.ReadText(index++, "StaffList.StaffName", "");
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
		public void ReadIM(STStaffListStructure r) {
			this = r;
		}


		public static bool operator == (STStaffListStructure a, STStaffListStructure b) {
			if (a.ssStaffID != b.ssStaffID) return false;
			if (a.ssStaffName != b.ssStaffName) return false;
			return true;
		}

		public static bool operator != (STStaffListStructure a, STStaffListStructure b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(STStaffListStructure)) return false;
			return (this == (STStaffListStructure) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssStaffID.GetHashCode()
				^ ssStaffName.GetHashCode()
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

		public STStaffListStructure(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssStaffID = 0;
			ssStaffName = "";
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fields[0] .FieldType.IsSerializable)
			ssStaffID = (int) info.GetValue(fields[0] .Name, fields[0] .FieldType);
			if (fields[1] .FieldType.IsSerializable)
			ssStaffName = (string) info.GetValue(fields[1] .Name, fields[1] .FieldType);
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public STStaffListStructure Duplicate() {
			STStaffListStructure t;
			t.ssStaffID = this.ssStaffID;
			t.ssStaffName = this.ssStaffName;
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
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".StaffID")) VarValue.AppendAttribute(recordElem, "StaffID", ssStaffID, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "StaffID");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".StaffName")) VarValue.AppendAttribute(recordElem, "StaffName", ssStaffName, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "StaffName");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "staffid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".StaffID")) variable.Value = ssStaffID; else variable.Optimized = true;
			} else if (head == "staffname") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".StaffName")) variable.Value = ssStaffName; else variable.Optimized = true;
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
			if (key == IdStaffID) {
				return ssStaffID;
			} else if (key == IdStaffName) {
				return ssStaffName;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssStaffID = (int) other.AttributeGet(IdStaffID);
			ssStaffName = (string) other.AttributeGet(IdStaffName);
		}
	} // STStaffListStructure
	/// <summary>
	/// Structure <code>RCStaffListRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCStaffListRecord: ISerializable, ITypedRecord<RCStaffListRecord> {
		private static readonly GlobalObjectKey IdStaffList = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*7nlwRR4ERtooIjtQb_6V0g");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("StaffList")]
		public STStaffListStructure ssSTStaffList;


		public static implicit operator STStaffListStructure(RCStaffListRecord r) {
			return r.ssSTStaffList;
		}

		public static implicit operator RCStaffListRecord(STStaffListStructure r) {
			RCStaffListRecord res = new RCStaffListRecord(null);
			res.ssSTStaffList = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCStaffListRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTStaffList = new STStaffListStructure(null);
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
					ssSTStaffList.OptimizedAttributes = value[0];
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
			ssSTStaffList.Read(r, ref index);
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
		public void ReadIM(RCStaffListRecord r) {
			this = r;
		}


		public static bool operator == (RCStaffListRecord a, RCStaffListRecord b) {
			if (a.ssSTStaffList != b.ssSTStaffList) return false;
			return true;
		}

		public static bool operator != (RCStaffListRecord a, RCStaffListRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCStaffListRecord)) return false;
			return (this == (RCStaffListRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTStaffList.GetHashCode()
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

		public RCStaffListRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTStaffList = new STStaffListStructure(null);
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fields[0] .FieldType.IsSerializable)
			ssSTStaffList = (STStaffListStructure) info.GetValue(fields[0] .Name, fields[0] .FieldType);
		}

		public void RecursiveReset() {
			ssSTStaffList.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTStaffList.InternalRecursiveSave();
		}


		public RCStaffListRecord Duplicate() {
			RCStaffListRecord t;
			t.ssSTStaffList = (STStaffListStructure) this.ssSTStaffList.Duplicate();
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
				ssSTStaffList.ToXml(this, recordElem, "StaffList", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "stafflist") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".StaffList")) variable.Value = ssSTStaffList; else variable.Optimized = true;
				variable.SetFieldName("stafflist");
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
			if (key == IdStaffList) {
				return ssSTStaffList;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTStaffList.FillFromOther((IRecord) other.AttributeGet(IdStaffList));
		}
	} // RCStaffListRecord
	/// <summary>
	/// RecordList type <code>RLStaffListRecordList</code> that represents a record list of
	///  <code>StaffList</code>
	/// </summary>
	[Serializable()]
	public partial class RLStaffListRecordList: GenericRecordList<RCStaffListRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCStaffListRecord GetElementDefaultValue() {
			return new RCStaffListRecord("");
		}

		public T[] ToArray<T>(Func<RCStaffListRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLStaffListRecordList recordlist, Func<RCStaffListRecord, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLStaffListRecordList ToList<T>(T[] array, Func <T, RCStaffListRecord> converter) {
			RLStaffListRecordList result = new RLStaffListRecordList();
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
		public RLStaffListRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLStaffListRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLStaffListRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLStaffListRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
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
		protected override OSList<RCStaffListRecord> NewList() {
			return new RLStaffListRecordList();
		}


	} // RLStaffListRecordList
	/// <summary>
	/// RecordList type <code>RLStaffListList</code> that represents a record list of
	///  <code>StaffIdentifier, Text</code>
	/// </summary>
	[Serializable()]
	public partial class RLStaffListList: GenericRecordList<STStaffListStructure>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override STStaffListStructure GetElementDefaultValue() {
			return new STStaffListStructure("");
		}

		public T[] ToArray<T>(Func<STStaffListStructure, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLStaffListList recordlist, Func<STStaffListStructure, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLStaffListList ToList<T>(T[] array, Func <T, STStaffListStructure> converter) {
			RLStaffListList result = new RLStaffListList();
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
		public RLStaffListList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLStaffListList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLStaffListList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLStaffListList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[0];
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<STStaffListStructure> NewList() {
			return new RLStaffListList();
		}


	} // RLStaffListList
}

namespace ssCaseConferencing {
	[XmlType("StaffList")]
	public class WORCStaffListRecord {
		[System.Xml.Serialization.XmlElement("StaffID")]
		public int varWSStaffID;

		[System.Xml.Serialization.XmlElement("StaffName")]
		public string varWSStaffName;

		public WORCStaffListRecord() {
			varWSStaffID = (int) 0;
			varWSStaffName = (string) "";
		}

		public WORCStaffListRecord(STStaffListStructure r) {
			varWSStaffID = (int) r.ssStaffID;
			varWSStaffName = BaseAppUtils.RemoveControlChars(r.ssStaffName);
		}

		public static RLStaffListList ToRecordList(WORCStaffListRecord[] array) {
			RLStaffListList rl = new RLStaffListList();
			if (array != null) {
				foreach(WORCStaffListRecord val in array) {
					rl.Append(val);
				}
			}
			return rl;
		}

		public static WORCStaffListRecord[] FromRecordList(RLStaffListList rl) {
			WORCStaffListRecord[] array = new WORCStaffListRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial struct RCStaffListRecord {
		public static implicit operator WORCStaffListRecord(RCStaffListRecord r) {
			return new WORCStaffListRecord(r.ssSTStaffList);
		}

		public static implicit operator RCStaffListRecord(WORCStaffListRecord w) {
			RCStaffListRecord r = new RCStaffListRecord("");
			if (w != null) {
				r.ssSTStaffList = w;
			}
			return r;
		}

	}

	partial struct STStaffListStructure {
		public static implicit operator WORCStaffListRecord(STStaffListStructure r) {
			return new WORCStaffListRecord(r);
		}

		public static implicit operator STStaffListStructure(WORCStaffListRecord w) {
			STStaffListStructure r = new STStaffListStructure("");
			if (w != null) {
				r.ssStaffID = (int) w.varWSStaffID;
				r.ssStaffName = ((string) w.varWSStaffName ?? "");
			}
			return r;
		}

	}
}


namespace ssCaseConferencing {
	[Serializable()]
	public partial class WORLStaffListRecordList {
		public WORCStaffListRecord[] Array;


		public WORLStaffListRecordList(WORCStaffListRecord[] r) {
			if (r == null)
			Array = new WORCStaffListRecord[0];
			else
			Array = r;
		}
		public WORLStaffListRecordList() {
			Array = new WORCStaffListRecord[0];
		}

		public WORLStaffListRecordList(RLStaffListRecordList rl) {
			rl=(RLStaffListRecordList) rl.Duplicate();
			Array = new WORCStaffListRecord[rl.Length];
			while (!rl.Eof) {
				Array[rl.CurrentRowNumber] = new WORCStaffListRecord(rl.CurrentRec);
				rl.Advance();
			}
		}

	}
}

namespace ssCaseConferencing {
	partial class RLStaffListRecordList {
		public static implicit operator RLStaffListRecordList(WORCStaffListRecord[] array) {
			RLStaffListRecordList rl = new RLStaffListRecordList();
			if (array != null) {
				foreach(WORCStaffListRecord val in array) {
					rl.Append((RCStaffListRecord) val);
				}
			}
			return rl;
		}
		public static implicit operator WORCStaffListRecord[](RLStaffListRecordList rl) {
			WORCStaffListRecord[] array = new WORCStaffListRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = (RCStaffListRecord) rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial class WORLStaffListRecordList {
		public static implicit operator RLStaffListRecordList(WORLStaffListRecordList w) {
			return w.Array;
		}
		public static implicit operator WORLStaffListRecordList(RLStaffListRecordList rl) {
			return new WORLStaffListRecordList(rl);
		}
		public static implicit operator WORCStaffListRecord[](WORLStaffListRecordList w) {
			if (w != null) {
				return w.Array;
			}
			return null;
		}
		public static implicit operator WORLStaffListRecordList(WORCStaffListRecord[] array) {
			return new WORLStaffListRecordList(array);
		}
	}
}

namespace ssCaseConferencing {
	[Serializable()]
	public partial class WORLStaffListList {
		public WORCStaffListRecord[] Array;


		public WORLStaffListList(WORCStaffListRecord[] r) {
			if (r == null)
			Array = new WORCStaffListRecord[0];
			else
			Array = r;
		}
		public WORLStaffListList() {
			Array = new WORCStaffListRecord[0];
		}

		public WORLStaffListList(RLStaffListList rl) {
			rl=(RLStaffListList) rl.Duplicate();
			Array = new WORCStaffListRecord[rl.Length];
			while (!rl.Eof) {
				Array[rl.CurrentRowNumber] = rl.CurrentRec.Duplicate();
				rl.Advance();
			}
		}

	}
}

namespace ssCaseConferencing {
	partial class RLStaffListList {
		public static implicit operator RLStaffListList(WORCStaffListRecord[] array) {
			RLStaffListList rl = new RLStaffListList();
			if (array != null) {
				foreach(WORCStaffListRecord val in array) {
					rl.Append((STStaffListStructure) val);
				}
			}
			return rl;
		}
		public static implicit operator WORCStaffListRecord[](RLStaffListList rl) {
			WORCStaffListRecord[] array = new WORCStaffListRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = (STStaffListStructure) rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial class WORLStaffListList {
		public static implicit operator RLStaffListList(WORLStaffListList w) {
			return w.Array;
		}
		public static implicit operator WORLStaffListList(RLStaffListList rl) {
			return new WORLStaffListList(rl);
		}
		public static implicit operator WORCStaffListRecord[](WORLStaffListList w) {
			if (w != null) {
				return w.Array;
			}
			return null;
		}
		public static implicit operator WORLStaffListList(WORCStaffListRecord[] array) {
			return new WORLStaffListList(array);
		}
	}
}

