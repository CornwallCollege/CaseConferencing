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
	/// Structure <code>STReporting_RAGLastUpdatedGraphPointsStructure</code> that represents the Service
	///  Studio structure <code>Reporting_RAGLastUpdatedGraphPoints</code> <p> Description: </p>
	/// </summary>
	[Serializable()]
	public partial struct STReporting_RAGLastUpdatedGraphPointsStructure: ISerializable, ITypedRecord<STReporting_RAGLastUpdatedGraphPointsStructure>, ISimpleRecord {
		private static readonly GlobalObjectKey IdLabel = GlobalObjectKey.Parse("shmcdFKEAEWXZGfrlZEwCQ*7_JscX8zCEiRpl0SXD0dKw");
		private static readonly GlobalObjectKey IdNumberOfLearners = GlobalObjectKey.Parse("shmcdFKEAEWXZGfrlZEwCQ*wz_2vMxhakS3_zhOlp5qZQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Label")]
		public string ssLabel;

		[System.Xml.Serialization.XmlElement("NumberOfLearners")]
		public int ssNumberOfLearners;


		public BitArray OptimizedAttributes;

		public STReporting_RAGLastUpdatedGraphPointsStructure(params string[] dummy) {
			OptimizedAttributes = null;
			ssLabel = "";
			ssNumberOfLearners = 0;
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
			ssLabel = r.ReadText(index++, "Reporting_RAGLastUpdatedGraphPoints.Label", "");
			ssNumberOfLearners = r.ReadInteger(index++, "Reporting_RAGLastUpdatedGraphPoints.NumberOfLearners", 0);
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
		public void ReadIM(STReporting_RAGLastUpdatedGraphPointsStructure r) {
			this = r;
		}


		public static bool operator == (STReporting_RAGLastUpdatedGraphPointsStructure a, STReporting_RAGLastUpdatedGraphPointsStructure b) {
			if (a.ssLabel != b.ssLabel) return false;
			if (a.ssNumberOfLearners != b.ssNumberOfLearners) return false;
			return true;
		}

		public static bool operator != (STReporting_RAGLastUpdatedGraphPointsStructure a, STReporting_RAGLastUpdatedGraphPointsStructure b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(STReporting_RAGLastUpdatedGraphPointsStructure)) return false;
			return (this == (STReporting_RAGLastUpdatedGraphPointsStructure) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssLabel.GetHashCode()
				^ ssNumberOfLearners.GetHashCode()
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

		public STReporting_RAGLastUpdatedGraphPointsStructure(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssLabel = "";
			ssNumberOfLearners = 0;
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fields[0] .FieldType.IsSerializable)
			ssLabel = (string) info.GetValue(fields[0] .Name, fields[0] .FieldType);
			if (fields[1] .FieldType.IsSerializable)
			ssNumberOfLearners = (int) info.GetValue(fields[1] .Name, fields[1] .FieldType);
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public STReporting_RAGLastUpdatedGraphPointsStructure Duplicate() {
			STReporting_RAGLastUpdatedGraphPointsStructure t;
			t.ssLabel = this.ssLabel;
			t.ssNumberOfLearners = this.ssNumberOfLearners;
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
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Label")) VarValue.AppendAttribute(recordElem, "Label", ssLabel, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Label");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".NumberOfLearners")) VarValue.AppendAttribute(recordElem, "NumberOfLearners", ssNumberOfLearners, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "NumberOfLearners");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "label") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Label")) variable.Value = ssLabel; else variable.Optimized = true;
			} else if (head == "numberoflearners") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".NumberOfLearners")) variable.Value = ssNumberOfLearners; else variable.Optimized = true;
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
			if (key == IdLabel) {
				return ssLabel;
			} else if (key == IdNumberOfLearners) {
				return ssNumberOfLearners;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssLabel = (string) other.AttributeGet(IdLabel);
			ssNumberOfLearners = (int) other.AttributeGet(IdNumberOfLearners);
		}
	} // STReporting_RAGLastUpdatedGraphPointsStructure
	/// <summary>
	/// Structure <code>RCReporting_RAGLastUpdatedGraphPointsRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCReporting_RAGLastUpdatedGraphPointsRecord: ISerializable, ITypedRecord<RCReporting_RAGLastUpdatedGraphPointsRecord> {
		private static readonly GlobalObjectKey IdReporting_RAGLastUpdatedGraphPoints = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*VkFFEIUUMdqdgazKLSaIXw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Reporting_RAGLastUpdatedGraphPoints")]
		public STReporting_RAGLastUpdatedGraphPointsStructure ssSTReporting_RAGLastUpdatedGraphPoints;


		public static implicit operator STReporting_RAGLastUpdatedGraphPointsStructure(RCReporting_RAGLastUpdatedGraphPointsRecord r) {
			return r.ssSTReporting_RAGLastUpdatedGraphPoints;
		}

		public static implicit operator RCReporting_RAGLastUpdatedGraphPointsRecord(STReporting_RAGLastUpdatedGraphPointsStructure r) {
			RCReporting_RAGLastUpdatedGraphPointsRecord res = new RCReporting_RAGLastUpdatedGraphPointsRecord(null);
			res.ssSTReporting_RAGLastUpdatedGraphPoints = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCReporting_RAGLastUpdatedGraphPointsRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTReporting_RAGLastUpdatedGraphPoints = new STReporting_RAGLastUpdatedGraphPointsStructure(null);
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
					ssSTReporting_RAGLastUpdatedGraphPoints.OptimizedAttributes = value[0];
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
			ssSTReporting_RAGLastUpdatedGraphPoints.Read(r, ref index);
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
		public void ReadIM(RCReporting_RAGLastUpdatedGraphPointsRecord r) {
			this = r;
		}


		public static bool operator == (RCReporting_RAGLastUpdatedGraphPointsRecord a, RCReporting_RAGLastUpdatedGraphPointsRecord b) {
			if (a.ssSTReporting_RAGLastUpdatedGraphPoints != b.ssSTReporting_RAGLastUpdatedGraphPoints) return false;
			return true;
		}

		public static bool operator != (RCReporting_RAGLastUpdatedGraphPointsRecord a, RCReporting_RAGLastUpdatedGraphPointsRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCReporting_RAGLastUpdatedGraphPointsRecord)) return false;
			return (this == (RCReporting_RAGLastUpdatedGraphPointsRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTReporting_RAGLastUpdatedGraphPoints.GetHashCode()
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

		public RCReporting_RAGLastUpdatedGraphPointsRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTReporting_RAGLastUpdatedGraphPoints = new STReporting_RAGLastUpdatedGraphPointsStructure(null);
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fields[0] .FieldType.IsSerializable)
			ssSTReporting_RAGLastUpdatedGraphPoints = (STReporting_RAGLastUpdatedGraphPointsStructure) info.GetValue(fields[0] .Name, fields[0] .FieldType);
		}

		public void RecursiveReset() {
			ssSTReporting_RAGLastUpdatedGraphPoints.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTReporting_RAGLastUpdatedGraphPoints.InternalRecursiveSave();
		}


		public RCReporting_RAGLastUpdatedGraphPointsRecord Duplicate() {
			RCReporting_RAGLastUpdatedGraphPointsRecord t;
			t.ssSTReporting_RAGLastUpdatedGraphPoints = (STReporting_RAGLastUpdatedGraphPointsStructure) this.ssSTReporting_RAGLastUpdatedGraphPoints.Duplicate();
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
				ssSTReporting_RAGLastUpdatedGraphPoints.ToXml(this, recordElem, "Reporting_RAGLastUpdatedGraphPoints", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "reporting_raglastupdatedgraphpoints") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Reporting_RAGLastUpdatedGraphPoints")) variable.Value = ssSTReporting_RAGLastUpdatedGraphPoints; else variable.Optimized = true;
				variable.SetFieldName("reporting_raglastupdatedgraphpoints");
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
			if (key == IdReporting_RAGLastUpdatedGraphPoints) {
				return ssSTReporting_RAGLastUpdatedGraphPoints;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTReporting_RAGLastUpdatedGraphPoints.FillFromOther((IRecord) other.AttributeGet(IdReporting_RAGLastUpdatedGraphPoints));
		}
	} // RCReporting_RAGLastUpdatedGraphPointsRecord
	/// <summary>
	/// RecordList type <code>RLReporting_RAGLastUpdatedGraphPointsRecordList</code> that represents a
	///  record list of <code>Reporting_RAGLastUpdatedGraphPoints</code>
	/// </summary>
	[Serializable()]
	public partial class RLReporting_RAGLastUpdatedGraphPointsRecordList: GenericRecordList<RCReporting_RAGLastUpdatedGraphPointsRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCReporting_RAGLastUpdatedGraphPointsRecord GetElementDefaultValue() {
			return new RCReporting_RAGLastUpdatedGraphPointsRecord("");
		}

		public T[] ToArray<T>(Func<RCReporting_RAGLastUpdatedGraphPointsRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLReporting_RAGLastUpdatedGraphPointsRecordList recordlist, Func<RCReporting_RAGLastUpdatedGraphPointsRecord, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLReporting_RAGLastUpdatedGraphPointsRecordList ToList<T>(T[] array, Func <T, RCReporting_RAGLastUpdatedGraphPointsRecord> converter) {
			RLReporting_RAGLastUpdatedGraphPointsRecordList result = new RLReporting_RAGLastUpdatedGraphPointsRecordList();
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
		public RLReporting_RAGLastUpdatedGraphPointsRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLReporting_RAGLastUpdatedGraphPointsRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLReporting_RAGLastUpdatedGraphPointsRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLReporting_RAGLastUpdatedGraphPointsRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
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
		protected override OSList<RCReporting_RAGLastUpdatedGraphPointsRecord> NewList() {
			return new RLReporting_RAGLastUpdatedGraphPointsRecordList();
		}


	} // RLReporting_RAGLastUpdatedGraphPointsRecordList
	/// <summary>
	/// RecordList type <code>RLReporting_RAGLastUpdatedGraphPointsList</code> that represents a record
	///  list of <code>Text, Integer</code>
	/// </summary>
	[Serializable()]
	public partial class RLReporting_RAGLastUpdatedGraphPointsList: GenericRecordList<STReporting_RAGLastUpdatedGraphPointsStructure>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override STReporting_RAGLastUpdatedGraphPointsStructure GetElementDefaultValue() {
			return new STReporting_RAGLastUpdatedGraphPointsStructure("");
		}

		public T[] ToArray<T>(Func<STReporting_RAGLastUpdatedGraphPointsStructure, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLReporting_RAGLastUpdatedGraphPointsList recordlist, Func<STReporting_RAGLastUpdatedGraphPointsStructure, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLReporting_RAGLastUpdatedGraphPointsList ToList<T>(T[] array, Func <T, STReporting_RAGLastUpdatedGraphPointsStructure> converter) {
			RLReporting_RAGLastUpdatedGraphPointsList result = new RLReporting_RAGLastUpdatedGraphPointsList();
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
		public RLReporting_RAGLastUpdatedGraphPointsList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLReporting_RAGLastUpdatedGraphPointsList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLReporting_RAGLastUpdatedGraphPointsList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLReporting_RAGLastUpdatedGraphPointsList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[0];
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<STReporting_RAGLastUpdatedGraphPointsStructure> NewList() {
			return new RLReporting_RAGLastUpdatedGraphPointsList();
		}


	} // RLReporting_RAGLastUpdatedGraphPointsList
}

namespace ssCaseConferencing {
	[XmlType("Reporting_RAGLastUpdatedGraphPoints")]
	public class WORCReporting_RAGLastUpdatedGraphPointsRecord {
		[System.Xml.Serialization.XmlElement("Label")]
		public string varWSLabel;

		[System.Xml.Serialization.XmlElement("NumberOfLearners")]
		public int varWSNumberOfLearners;

		public WORCReporting_RAGLastUpdatedGraphPointsRecord() {
			varWSLabel = (string) "";
			varWSNumberOfLearners = (int) 0;
		}

		public WORCReporting_RAGLastUpdatedGraphPointsRecord(STReporting_RAGLastUpdatedGraphPointsStructure r) {
			varWSLabel = BaseAppUtils.RemoveControlChars(r.ssLabel);
			varWSNumberOfLearners = (int) r.ssNumberOfLearners;
		}

		public static RLReporting_RAGLastUpdatedGraphPointsList ToRecordList(WORCReporting_RAGLastUpdatedGraphPointsRecord[] array) {
			RLReporting_RAGLastUpdatedGraphPointsList rl = new RLReporting_RAGLastUpdatedGraphPointsList();
			if (array != null) {
				foreach(WORCReporting_RAGLastUpdatedGraphPointsRecord val in array) {
					rl.Append(val);
				}
			}
			return rl;
		}

		public static WORCReporting_RAGLastUpdatedGraphPointsRecord[] FromRecordList(RLReporting_RAGLastUpdatedGraphPointsList rl) {
			WORCReporting_RAGLastUpdatedGraphPointsRecord[] array = new WORCReporting_RAGLastUpdatedGraphPointsRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial struct RCReporting_RAGLastUpdatedGraphPointsRecord {
		public static implicit operator WORCReporting_RAGLastUpdatedGraphPointsRecord(RCReporting_RAGLastUpdatedGraphPointsRecord r) {
			return new WORCReporting_RAGLastUpdatedGraphPointsRecord(r.ssSTReporting_RAGLastUpdatedGraphPoints);
		}

		public static implicit operator RCReporting_RAGLastUpdatedGraphPointsRecord(WORCReporting_RAGLastUpdatedGraphPointsRecord w) {
			RCReporting_RAGLastUpdatedGraphPointsRecord r = new RCReporting_RAGLastUpdatedGraphPointsRecord("");
			if (w != null) {
				r.ssSTReporting_RAGLastUpdatedGraphPoints = w;
			}
			return r;
		}

	}

	partial struct STReporting_RAGLastUpdatedGraphPointsStructure {
		public static implicit operator WORCReporting_RAGLastUpdatedGraphPointsRecord(STReporting_RAGLastUpdatedGraphPointsStructure r) {
			return new WORCReporting_RAGLastUpdatedGraphPointsRecord(r);
		}

		public static implicit operator STReporting_RAGLastUpdatedGraphPointsStructure(WORCReporting_RAGLastUpdatedGraphPointsRecord w) {
			STReporting_RAGLastUpdatedGraphPointsStructure r = new STReporting_RAGLastUpdatedGraphPointsStructure("");
			if (w != null) {
				r.ssLabel = ((string) w.varWSLabel ?? "");
				r.ssNumberOfLearners = (int) w.varWSNumberOfLearners;
			}
			return r;
		}

	}
}


namespace ssCaseConferencing {
	[Serializable()]
	public partial class WORLReporting_RAGLastUpdatedGraphPointsRecordList {
		public WORCReporting_RAGLastUpdatedGraphPointsRecord[] Array;


		public WORLReporting_RAGLastUpdatedGraphPointsRecordList(WORCReporting_RAGLastUpdatedGraphPointsRecord[] r) {
			if (r == null)
			Array = new WORCReporting_RAGLastUpdatedGraphPointsRecord[0];
			else
			Array = r;
		}
		public WORLReporting_RAGLastUpdatedGraphPointsRecordList() {
			Array = new WORCReporting_RAGLastUpdatedGraphPointsRecord[0];
		}

		public WORLReporting_RAGLastUpdatedGraphPointsRecordList(RLReporting_RAGLastUpdatedGraphPointsRecordList rl) {
			rl=(RLReporting_RAGLastUpdatedGraphPointsRecordList) rl.Duplicate();
			Array = new WORCReporting_RAGLastUpdatedGraphPointsRecord[rl.Length];
			while (!rl.Eof) {
				Array[rl.CurrentRowNumber] = new WORCReporting_RAGLastUpdatedGraphPointsRecord(rl.CurrentRec);
				rl.Advance();
			}
		}

	}
}

namespace ssCaseConferencing {
	partial class RLReporting_RAGLastUpdatedGraphPointsRecordList {
		public static implicit operator RLReporting_RAGLastUpdatedGraphPointsRecordList(WORCReporting_RAGLastUpdatedGraphPointsRecord[] array) {
			RLReporting_RAGLastUpdatedGraphPointsRecordList rl = new RLReporting_RAGLastUpdatedGraphPointsRecordList();
			if (array != null) {
				foreach(WORCReporting_RAGLastUpdatedGraphPointsRecord val in array) {
					rl.Append((RCReporting_RAGLastUpdatedGraphPointsRecord) val);
				}
			}
			return rl;
		}
		public static implicit operator WORCReporting_RAGLastUpdatedGraphPointsRecord[](RLReporting_RAGLastUpdatedGraphPointsRecordList rl) {
			WORCReporting_RAGLastUpdatedGraphPointsRecord[] array = new WORCReporting_RAGLastUpdatedGraphPointsRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = (RCReporting_RAGLastUpdatedGraphPointsRecord) rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial class WORLReporting_RAGLastUpdatedGraphPointsRecordList {
		public static implicit operator RLReporting_RAGLastUpdatedGraphPointsRecordList(WORLReporting_RAGLastUpdatedGraphPointsRecordList w) {
			return w.Array;
		}
		public static implicit operator WORLReporting_RAGLastUpdatedGraphPointsRecordList(RLReporting_RAGLastUpdatedGraphPointsRecordList rl) {
			return new WORLReporting_RAGLastUpdatedGraphPointsRecordList(rl);
		}
		public static implicit operator WORCReporting_RAGLastUpdatedGraphPointsRecord[](WORLReporting_RAGLastUpdatedGraphPointsRecordList w) {
			if (w != null) {
				return w.Array;
			}
			return null;
		}
		public static implicit operator WORLReporting_RAGLastUpdatedGraphPointsRecordList(WORCReporting_RAGLastUpdatedGraphPointsRecord[] array) {
			return new WORLReporting_RAGLastUpdatedGraphPointsRecordList(array);
		}
	}
}

namespace ssCaseConferencing {
	[Serializable()]
	public partial class WORLReporting_RAGLastUpdatedGraphPointsList {
		public WORCReporting_RAGLastUpdatedGraphPointsRecord[] Array;


		public WORLReporting_RAGLastUpdatedGraphPointsList(WORCReporting_RAGLastUpdatedGraphPointsRecord[] r) {
			if (r == null)
			Array = new WORCReporting_RAGLastUpdatedGraphPointsRecord[0];
			else
			Array = r;
		}
		public WORLReporting_RAGLastUpdatedGraphPointsList() {
			Array = new WORCReporting_RAGLastUpdatedGraphPointsRecord[0];
		}

		public WORLReporting_RAGLastUpdatedGraphPointsList(RLReporting_RAGLastUpdatedGraphPointsList rl) {
			rl=(RLReporting_RAGLastUpdatedGraphPointsList) rl.Duplicate();
			Array = new WORCReporting_RAGLastUpdatedGraphPointsRecord[rl.Length];
			while (!rl.Eof) {
				Array[rl.CurrentRowNumber] = rl.CurrentRec.Duplicate();
				rl.Advance();
			}
		}

	}
}

namespace ssCaseConferencing {
	partial class RLReporting_RAGLastUpdatedGraphPointsList {
		public static implicit operator RLReporting_RAGLastUpdatedGraphPointsList(WORCReporting_RAGLastUpdatedGraphPointsRecord[] array) {
			RLReporting_RAGLastUpdatedGraphPointsList rl = new RLReporting_RAGLastUpdatedGraphPointsList();
			if (array != null) {
				foreach(WORCReporting_RAGLastUpdatedGraphPointsRecord val in array) {
					rl.Append((STReporting_RAGLastUpdatedGraphPointsStructure) val);
				}
			}
			return rl;
		}
		public static implicit operator WORCReporting_RAGLastUpdatedGraphPointsRecord[](RLReporting_RAGLastUpdatedGraphPointsList rl) {
			WORCReporting_RAGLastUpdatedGraphPointsRecord[] array = new WORCReporting_RAGLastUpdatedGraphPointsRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = (STReporting_RAGLastUpdatedGraphPointsStructure) rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial class WORLReporting_RAGLastUpdatedGraphPointsList {
		public static implicit operator RLReporting_RAGLastUpdatedGraphPointsList(WORLReporting_RAGLastUpdatedGraphPointsList w) {
			return w.Array;
		}
		public static implicit operator WORLReporting_RAGLastUpdatedGraphPointsList(RLReporting_RAGLastUpdatedGraphPointsList rl) {
			return new WORLReporting_RAGLastUpdatedGraphPointsList(rl);
		}
		public static implicit operator WORCReporting_RAGLastUpdatedGraphPointsRecord[](WORLReporting_RAGLastUpdatedGraphPointsList w) {
			if (w != null) {
				return w.Array;
			}
			return null;
		}
		public static implicit operator WORLReporting_RAGLastUpdatedGraphPointsList(WORCReporting_RAGLastUpdatedGraphPointsRecord[] array) {
			return new WORLReporting_RAGLastUpdatedGraphPointsList(array);
		}
	}
}

