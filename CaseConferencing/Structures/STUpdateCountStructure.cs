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
	/// Structure <code>STUpdateCountStructure</code> that represents the Service Studio structure
	///  <code>UpdateCount</code> <p> Description: </p>
	/// </summary>
	[Serializable()]
	public partial struct STUpdateCountStructure: ISerializable, ITypedRecord<STUpdateCountStructure>, ISimpleRecord {
		private static readonly GlobalObjectKey IdUpdateCount = GlobalObjectKey.Parse("shmcdFKEAEWXZGfrlZEwCQ*2uEyDD8IrE6fxnmVslu+oA");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("UpdateCount")]
		public int ssUpdateCount;


		public BitArray OptimizedAttributes;

		public STUpdateCountStructure(params string[] dummy) {
			OptimizedAttributes = null;
			ssUpdateCount = 0;
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
			ssUpdateCount = r.ReadInteger(index++, "UpdateCount.UpdateCount", 0);
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
		public void ReadIM(STUpdateCountStructure r) {
			this = r;
		}


		public static bool operator == (STUpdateCountStructure a, STUpdateCountStructure b) {
			if (a.ssUpdateCount != b.ssUpdateCount) return false;
			return true;
		}

		public static bool operator != (STUpdateCountStructure a, STUpdateCountStructure b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(STUpdateCountStructure)) return false;
			return (this == (STUpdateCountStructure) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssUpdateCount.GetHashCode()
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

		public STUpdateCountStructure(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssUpdateCount = 0;
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fields[0] .FieldType.IsSerializable)
			ssUpdateCount = (int) info.GetValue(fields[0] .Name, fields[0] .FieldType);
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public STUpdateCountStructure Duplicate() {
			STUpdateCountStructure t;
			t.ssUpdateCount = this.ssUpdateCount;
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
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateCount")) VarValue.AppendAttribute(recordElem, "UpdateCount", ssUpdateCount, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateCount");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "updatecount") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateCount")) variable.Value = ssUpdateCount; else variable.Optimized = true;
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
			if (key == IdUpdateCount) {
				return ssUpdateCount;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssUpdateCount = (int) other.AttributeGet(IdUpdateCount);
		}
	} // STUpdateCountStructure
	/// <summary>
	/// Structure <code>RCUpdateCountRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCUpdateCountRecord: ISerializable, ITypedRecord<RCUpdateCountRecord> {
		private static readonly GlobalObjectKey IdUpdateCount = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*x9Ox2GtpVCUYhwpjZ4kJGA");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("UpdateCount")]
		public STUpdateCountStructure ssSTUpdateCount;


		public static implicit operator STUpdateCountStructure(RCUpdateCountRecord r) {
			return r.ssSTUpdateCount;
		}

		public static implicit operator RCUpdateCountRecord(STUpdateCountStructure r) {
			RCUpdateCountRecord res = new RCUpdateCountRecord(null);
			res.ssSTUpdateCount = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCUpdateCountRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTUpdateCount = new STUpdateCountStructure(null);
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
					ssSTUpdateCount.OptimizedAttributes = value[0];
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
			ssSTUpdateCount.Read(r, ref index);
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
		public void ReadIM(RCUpdateCountRecord r) {
			this = r;
		}


		public static bool operator == (RCUpdateCountRecord a, RCUpdateCountRecord b) {
			if (a.ssSTUpdateCount != b.ssSTUpdateCount) return false;
			return true;
		}

		public static bool operator != (RCUpdateCountRecord a, RCUpdateCountRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCUpdateCountRecord)) return false;
			return (this == (RCUpdateCountRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTUpdateCount.GetHashCode()
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

		public RCUpdateCountRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTUpdateCount = new STUpdateCountStructure(null);
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fields[0] .FieldType.IsSerializable)
			ssSTUpdateCount = (STUpdateCountStructure) info.GetValue(fields[0] .Name, fields[0] .FieldType);
		}

		public void RecursiveReset() {
			ssSTUpdateCount.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTUpdateCount.InternalRecursiveSave();
		}


		public RCUpdateCountRecord Duplicate() {
			RCUpdateCountRecord t;
			t.ssSTUpdateCount = (STUpdateCountStructure) this.ssSTUpdateCount.Duplicate();
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
				ssSTUpdateCount.ToXml(this, recordElem, "UpdateCount", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "updatecount") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateCount")) variable.Value = ssSTUpdateCount; else variable.Optimized = true;
				variable.SetFieldName("updatecount");
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
			if (key == IdUpdateCount) {
				return ssSTUpdateCount;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTUpdateCount.FillFromOther((IRecord) other.AttributeGet(IdUpdateCount));
		}
	} // RCUpdateCountRecord
	/// <summary>
	/// RecordList type <code>RLUpdateCountRecordList</code> that represents a record list of
	///  <code>UpdateCount</code>
	/// </summary>
	[Serializable()]
	public partial class RLUpdateCountRecordList: GenericRecordList<RCUpdateCountRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCUpdateCountRecord GetElementDefaultValue() {
			return new RCUpdateCountRecord("");
		}

		public T[] ToArray<T>(Func<RCUpdateCountRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLUpdateCountRecordList recordlist, Func<RCUpdateCountRecord, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLUpdateCountRecordList ToList<T>(T[] array, Func <T, RCUpdateCountRecord> converter) {
			RLUpdateCountRecordList result = new RLUpdateCountRecordList();
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
		public RLUpdateCountRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLUpdateCountRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLUpdateCountRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLUpdateCountRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
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
		protected override OSList<RCUpdateCountRecord> NewList() {
			return new RLUpdateCountRecordList();
		}


	} // RLUpdateCountRecordList
	/// <summary>
	/// RecordList type <code>RLUpdateCountList</code> that represents a record list of
	///  <code>Integer</code>
	/// </summary>
	[Serializable()]
	public partial class RLUpdateCountList: GenericRecordList<STUpdateCountStructure>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override STUpdateCountStructure GetElementDefaultValue() {
			return new STUpdateCountStructure("");
		}

		public T[] ToArray<T>(Func<STUpdateCountStructure, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLUpdateCountList recordlist, Func<STUpdateCountStructure, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLUpdateCountList ToList<T>(T[] array, Func <T, STUpdateCountStructure> converter) {
			RLUpdateCountList result = new RLUpdateCountList();
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
		public RLUpdateCountList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLUpdateCountList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLUpdateCountList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLUpdateCountList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[0];
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<STUpdateCountStructure> NewList() {
			return new RLUpdateCountList();
		}


	} // RLUpdateCountList
}

namespace ssCaseConferencing {
	[XmlType("UpdateCount")]
	public class WORCUpdateCountRecord {
		[System.Xml.Serialization.XmlElement("UpdateCount")]
		public int varWSUpdateCount;

		public WORCUpdateCountRecord() {
			varWSUpdateCount = (int) 0;
		}

		public WORCUpdateCountRecord(STUpdateCountStructure r) {
			varWSUpdateCount = (int) r.ssUpdateCount;
		}

		public static RLUpdateCountList ToRecordList(WORCUpdateCountRecord[] array) {
			RLUpdateCountList rl = new RLUpdateCountList();
			if (array != null) {
				foreach(WORCUpdateCountRecord val in array) {
					rl.Append(val);
				}
			}
			return rl;
		}

		public static WORCUpdateCountRecord[] FromRecordList(RLUpdateCountList rl) {
			WORCUpdateCountRecord[] array = new WORCUpdateCountRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial struct RCUpdateCountRecord {
		public static implicit operator WORCUpdateCountRecord(RCUpdateCountRecord r) {
			return new WORCUpdateCountRecord(r.ssSTUpdateCount);
		}

		public static implicit operator RCUpdateCountRecord(WORCUpdateCountRecord w) {
			RCUpdateCountRecord r = new RCUpdateCountRecord("");
			if (w != null) {
				r.ssSTUpdateCount = w;
			}
			return r;
		}

	}

	partial struct STUpdateCountStructure {
		public static implicit operator WORCUpdateCountRecord(STUpdateCountStructure r) {
			return new WORCUpdateCountRecord(r);
		}

		public static implicit operator STUpdateCountStructure(WORCUpdateCountRecord w) {
			STUpdateCountStructure r = new STUpdateCountStructure("");
			if (w != null) {
				r.ssUpdateCount = (int) w.varWSUpdateCount;
			}
			return r;
		}

	}
}


namespace ssCaseConferencing {
	[Serializable()]
	public partial class WORLUpdateCountRecordList {
		public WORCUpdateCountRecord[] Array;


		public WORLUpdateCountRecordList(WORCUpdateCountRecord[] r) {
			if (r == null)
			Array = new WORCUpdateCountRecord[0];
			else
			Array = r;
		}
		public WORLUpdateCountRecordList() {
			Array = new WORCUpdateCountRecord[0];
		}

		public WORLUpdateCountRecordList(RLUpdateCountRecordList rl) {
			rl=(RLUpdateCountRecordList) rl.Duplicate();
			Array = new WORCUpdateCountRecord[rl.Length];
			while (!rl.Eof) {
				Array[rl.CurrentRowNumber] = new WORCUpdateCountRecord(rl.CurrentRec);
				rl.Advance();
			}
		}

	}
}

namespace ssCaseConferencing {
	partial class RLUpdateCountRecordList {
		public static implicit operator RLUpdateCountRecordList(WORCUpdateCountRecord[] array) {
			RLUpdateCountRecordList rl = new RLUpdateCountRecordList();
			if (array != null) {
				foreach(WORCUpdateCountRecord val in array) {
					rl.Append((RCUpdateCountRecord) val);
				}
			}
			return rl;
		}
		public static implicit operator WORCUpdateCountRecord[](RLUpdateCountRecordList rl) {
			WORCUpdateCountRecord[] array = new WORCUpdateCountRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = (RCUpdateCountRecord) rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial class WORLUpdateCountRecordList {
		public static implicit operator RLUpdateCountRecordList(WORLUpdateCountRecordList w) {
			return w.Array;
		}
		public static implicit operator WORLUpdateCountRecordList(RLUpdateCountRecordList rl) {
			return new WORLUpdateCountRecordList(rl);
		}
		public static implicit operator WORCUpdateCountRecord[](WORLUpdateCountRecordList w) {
			if (w != null) {
				return w.Array;
			}
			return null;
		}
		public static implicit operator WORLUpdateCountRecordList(WORCUpdateCountRecord[] array) {
			return new WORLUpdateCountRecordList(array);
		}
	}
}

namespace ssCaseConferencing {
	[Serializable()]
	public partial class WORLUpdateCountList {
		public WORCUpdateCountRecord[] Array;


		public WORLUpdateCountList(WORCUpdateCountRecord[] r) {
			if (r == null)
			Array = new WORCUpdateCountRecord[0];
			else
			Array = r;
		}
		public WORLUpdateCountList() {
			Array = new WORCUpdateCountRecord[0];
		}

		public WORLUpdateCountList(RLUpdateCountList rl) {
			rl=(RLUpdateCountList) rl.Duplicate();
			Array = new WORCUpdateCountRecord[rl.Length];
			while (!rl.Eof) {
				Array[rl.CurrentRowNumber] = rl.CurrentRec.Duplicate();
				rl.Advance();
			}
		}

	}
}

namespace ssCaseConferencing {
	partial class RLUpdateCountList {
		public static implicit operator RLUpdateCountList(WORCUpdateCountRecord[] array) {
			RLUpdateCountList rl = new RLUpdateCountList();
			if (array != null) {
				foreach(WORCUpdateCountRecord val in array) {
					rl.Append((STUpdateCountStructure) val);
				}
			}
			return rl;
		}
		public static implicit operator WORCUpdateCountRecord[](RLUpdateCountList rl) {
			WORCUpdateCountRecord[] array = new WORCUpdateCountRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = (STUpdateCountStructure) rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial class WORLUpdateCountList {
		public static implicit operator RLUpdateCountList(WORLUpdateCountList w) {
			return w.Array;
		}
		public static implicit operator WORLUpdateCountList(RLUpdateCountList rl) {
			return new WORLUpdateCountList(rl);
		}
		public static implicit operator WORCUpdateCountRecord[](WORLUpdateCountList w) {
			if (w != null) {
				return w.Array;
			}
			return null;
		}
		public static implicit operator WORLUpdateCountList(WORCUpdateCountRecord[] array) {
			return new WORLUpdateCountList(array);
		}
	}
}
