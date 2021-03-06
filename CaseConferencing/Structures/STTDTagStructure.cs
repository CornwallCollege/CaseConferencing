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
	/// Structure <code>STTDTagStructure</code> that represents the Service Studio structure
	///  <code>TDTag</code> <p> Description: </p>
	/// </summary>
	[Serializable()]
	public partial struct STTDTagStructure: ISerializable, ITypedRecord<STTDTagStructure>, ISimpleRecord {
		private static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("shmcdFKEAEWXZGfrlZEwCQ*tJJ2dvqPY0qY7dTNGP+dgg");
		private static readonly GlobalObjectKey IdValue = GlobalObjectKey.Parse("shmcdFKEAEWXZGfrlZEwCQ*XUgU92gYqEOI9Ac89EyhrQ");
		private static readonly GlobalObjectKey IdClass = GlobalObjectKey.Parse("shmcdFKEAEWXZGfrlZEwCQ*MEploKhSPEaIM7OgbYc4DA");
		private static readonly GlobalObjectKey IdTitle = GlobalObjectKey.Parse("shmcdFKEAEWXZGfrlZEwCQ*_VEciRFhJUuUbtQKtdJsEw");
		private static readonly GlobalObjectKey IdColspan = GlobalObjectKey.Parse("shmcdFKEAEWXZGfrlZEwCQ*5MPn6XvKRUKwEztd002OeA");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Name")]
		public string ssName;

		[System.Xml.Serialization.XmlElement("Value")]
		public string ssValue;

		[System.Xml.Serialization.XmlElement("Class")]
		public string ssClass;

		[System.Xml.Serialization.XmlElement("Title")]
		public string ssTitle;

		[System.Xml.Serialization.XmlElement("Colspan")]
		public int ssColspan;


		public BitArray OptimizedAttributes;

		public STTDTagStructure(params string[] dummy) {
			OptimizedAttributes = null;
			ssName = "";
			ssValue = "";
			ssClass = "";
			ssTitle = "";
			ssColspan = 0;
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
			ssName = r.ReadText(index++, "TDTag.Name", "");
			ssValue = r.ReadText(index++, "TDTag.Value", "");
			ssClass = r.ReadText(index++, "TDTag.Class", "");
			ssTitle = r.ReadText(index++, "TDTag.Title", "");
			ssColspan = r.ReadInteger(index++, "TDTag.Colspan", 0);
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
		public void ReadIM(STTDTagStructure r) {
			this = r;
		}


		public static bool operator == (STTDTagStructure a, STTDTagStructure b) {
			if (a.ssName != b.ssName) return false;
			if (a.ssValue != b.ssValue) return false;
			if (a.ssClass != b.ssClass) return false;
			if (a.ssTitle != b.ssTitle) return false;
			if (a.ssColspan != b.ssColspan) return false;
			return true;
		}

		public static bool operator != (STTDTagStructure a, STTDTagStructure b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(STTDTagStructure)) return false;
			return (this == (STTDTagStructure) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssName.GetHashCode()
				^ ssValue.GetHashCode()
				^ ssClass.GetHashCode()
				^ ssTitle.GetHashCode()
				^ ssColspan.GetHashCode()
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

		public STTDTagStructure(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssName = "";
			ssValue = "";
			ssClass = "";
			ssTitle = "";
			ssColspan = 0;
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fields[0] .FieldType.IsSerializable)
			ssName = (string) info.GetValue(fields[0] .Name, fields[0] .FieldType);
			if (fields[1] .FieldType.IsSerializable)
			ssValue = (string) info.GetValue(fields[1] .Name, fields[1] .FieldType);
			if (fields[2] .FieldType.IsSerializable)
			ssClass = (string) info.GetValue(fields[2] .Name, fields[2] .FieldType);
			if (fields[3] .FieldType.IsSerializable)
			ssTitle = (string) info.GetValue(fields[3] .Name, fields[3] .FieldType);
			if (fields[4] .FieldType.IsSerializable)
			ssColspan = (int) info.GetValue(fields[4] .Name, fields[4] .FieldType);
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public STTDTagStructure Duplicate() {
			STTDTagStructure t;
			t.ssName = this.ssName;
			t.ssValue = this.ssValue;
			t.ssClass = this.ssClass;
			t.ssTitle = this.ssTitle;
			t.ssColspan = this.ssColspan;
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
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Name")) VarValue.AppendAttribute(recordElem, "Name", ssName, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Name");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Value")) VarValue.AppendAttribute(recordElem, "Value", ssValue, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Value");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Class")) VarValue.AppendAttribute(recordElem, "Class", ssClass, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Class");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Title")) VarValue.AppendAttribute(recordElem, "Title", ssTitle, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Title");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Colspan")) VarValue.AppendAttribute(recordElem, "Colspan", ssColspan, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "Colspan");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "name") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
			} else if (head == "value") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Value")) variable.Value = ssValue; else variable.Optimized = true;
			} else if (head == "class") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Class")) variable.Value = ssClass; else variable.Optimized = true;
			} else if (head == "title") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Title")) variable.Value = ssTitle; else variable.Optimized = true;
			} else if (head == "colspan") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Colspan")) variable.Value = ssColspan; else variable.Optimized = true;
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
			if (key == IdName) {
				return ssName;
			} else if (key == IdValue) {
				return ssValue;
			} else if (key == IdClass) {
				return ssClass;
			} else if (key == IdTitle) {
				return ssTitle;
			} else if (key == IdColspan) {
				return ssColspan;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssName = (string) other.AttributeGet(IdName);
			ssValue = (string) other.AttributeGet(IdValue);
			ssClass = (string) other.AttributeGet(IdClass);
			ssTitle = (string) other.AttributeGet(IdTitle);
			ssColspan = (int) other.AttributeGet(IdColspan);
		}
	} // STTDTagStructure
	/// <summary>
	/// Structure <code>RCTDTagRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCTDTagRecord: ISerializable, ITypedRecord<RCTDTagRecord> {
		private static readonly GlobalObjectKey IdTDTag = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*_o_DwqgwRfiAvmeR5+UUuw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("TDTag")]
		public STTDTagStructure ssSTTDTag;


		public static implicit operator STTDTagStructure(RCTDTagRecord r) {
			return r.ssSTTDTag;
		}

		public static implicit operator RCTDTagRecord(STTDTagStructure r) {
			RCTDTagRecord res = new RCTDTagRecord(null);
			res.ssSTTDTag = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCTDTagRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTTDTag = new STTDTagStructure(null);
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
					ssSTTDTag.OptimizedAttributes = value[0];
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
			ssSTTDTag.Read(r, ref index);
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
		public void ReadIM(RCTDTagRecord r) {
			this = r;
		}


		public static bool operator == (RCTDTagRecord a, RCTDTagRecord b) {
			if (a.ssSTTDTag != b.ssSTTDTag) return false;
			return true;
		}

		public static bool operator != (RCTDTagRecord a, RCTDTagRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCTDTagRecord)) return false;
			return (this == (RCTDTagRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTTDTag.GetHashCode()
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

		public RCTDTagRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTTDTag = new STTDTagStructure(null);
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fields[0] .FieldType.IsSerializable)
			ssSTTDTag = (STTDTagStructure) info.GetValue(fields[0] .Name, fields[0] .FieldType);
		}

		public void RecursiveReset() {
			ssSTTDTag.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTTDTag.InternalRecursiveSave();
		}


		public RCTDTagRecord Duplicate() {
			RCTDTagRecord t;
			t.ssSTTDTag = (STTDTagStructure) this.ssSTTDTag.Duplicate();
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
				ssSTTDTag.ToXml(this, recordElem, "TDTag", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "tdtag") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".TDTag")) variable.Value = ssSTTDTag; else variable.Optimized = true;
				variable.SetFieldName("tdtag");
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
			if (key == IdTDTag) {
				return ssSTTDTag;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTTDTag.FillFromOther((IRecord) other.AttributeGet(IdTDTag));
		}
	} // RCTDTagRecord
	/// <summary>
	/// RecordList type <code>RLTDTagRecordList</code> that represents a record list of <code>TDTag</code>
	/// </summary>
	[Serializable()]
	public partial class RLTDTagRecordList: GenericRecordList<RCTDTagRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCTDTagRecord GetElementDefaultValue() {
			return new RCTDTagRecord("");
		}

		public T[] ToArray<T>(Func<RCTDTagRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLTDTagRecordList recordlist, Func<RCTDTagRecord, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLTDTagRecordList ToList<T>(T[] array, Func <T, RCTDTagRecord> converter) {
			RLTDTagRecordList result = new RLTDTagRecordList();
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
		public RLTDTagRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLTDTagRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLTDTagRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLTDTagRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
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
		protected override OSList<RCTDTagRecord> NewList() {
			return new RLTDTagRecordList();
		}


	} // RLTDTagRecordList
	/// <summary>
	/// RecordList type <code>RLTDTagList</code> that represents a record list of <code>Text, Text, Text,
	///  Text, Integer</code>
	/// </summary>
	[Serializable()]
	public partial class RLTDTagList: GenericRecordList<STTDTagStructure>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override STTDTagStructure GetElementDefaultValue() {
			return new STTDTagStructure("");
		}

		public T[] ToArray<T>(Func<STTDTagStructure, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLTDTagList recordlist, Func<STTDTagStructure, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLTDTagList ToList<T>(T[] array, Func <T, STTDTagStructure> converter) {
			RLTDTagList result = new RLTDTagList();
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
		public RLTDTagList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLTDTagList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLTDTagList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLTDTagList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[0];
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<STTDTagStructure> NewList() {
			return new RLTDTagList();
		}


	} // RLTDTagList
}

namespace ssCaseConferencing {
	[XmlType("TDTag")]
	public class WORCTDTagRecord {
		[System.Xml.Serialization.XmlElement("Name")]
		public string varWSName;

		[System.Xml.Serialization.XmlElement("Value")]
		public string varWSValue;

		[System.Xml.Serialization.XmlElement("Class")]
		public string varWSClass;

		[System.Xml.Serialization.XmlElement("Title")]
		public string varWSTitle;

		[System.Xml.Serialization.XmlElement("Colspan")]
		public int varWSColspan;

		public WORCTDTagRecord() {
			varWSName = (string) "";
			varWSValue = (string) "";
			varWSClass = (string) "";
			varWSTitle = (string) "";
			varWSColspan = (int) 0;
		}

		public WORCTDTagRecord(STTDTagStructure r) {
			varWSName = BaseAppUtils.RemoveControlChars(r.ssName);
			varWSValue = BaseAppUtils.RemoveControlChars(r.ssValue);
			varWSClass = BaseAppUtils.RemoveControlChars(r.ssClass);
			varWSTitle = BaseAppUtils.RemoveControlChars(r.ssTitle);
			varWSColspan = (int) r.ssColspan;
		}

		public static RLTDTagList ToRecordList(WORCTDTagRecord[] array) {
			RLTDTagList rl = new RLTDTagList();
			if (array != null) {
				foreach(WORCTDTagRecord val in array) {
					rl.Append(val);
				}
			}
			return rl;
		}

		public static WORCTDTagRecord[] FromRecordList(RLTDTagList rl) {
			WORCTDTagRecord[] array = new WORCTDTagRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial struct RCTDTagRecord {
		public static implicit operator WORCTDTagRecord(RCTDTagRecord r) {
			return new WORCTDTagRecord(r.ssSTTDTag);
		}

		public static implicit operator RCTDTagRecord(WORCTDTagRecord w) {
			RCTDTagRecord r = new RCTDTagRecord("");
			if (w != null) {
				r.ssSTTDTag = w;
			}
			return r;
		}

	}

	partial struct STTDTagStructure {
		public static implicit operator WORCTDTagRecord(STTDTagStructure r) {
			return new WORCTDTagRecord(r);
		}

		public static implicit operator STTDTagStructure(WORCTDTagRecord w) {
			STTDTagStructure r = new STTDTagStructure("");
			if (w != null) {
				r.ssName = ((string) w.varWSName ?? "");
				r.ssValue = ((string) w.varWSValue ?? "");
				r.ssClass = ((string) w.varWSClass ?? "");
				r.ssTitle = ((string) w.varWSTitle ?? "");
				r.ssColspan = (int) w.varWSColspan;
			}
			return r;
		}

	}
}


namespace ssCaseConferencing {
	[Serializable()]
	public partial class WORLTDTagRecordList {
		public WORCTDTagRecord[] Array;


		public WORLTDTagRecordList(WORCTDTagRecord[] r) {
			if (r == null)
			Array = new WORCTDTagRecord[0];
			else
			Array = r;
		}
		public WORLTDTagRecordList() {
			Array = new WORCTDTagRecord[0];
		}

		public WORLTDTagRecordList(RLTDTagRecordList rl) {
			rl=(RLTDTagRecordList) rl.Duplicate();
			Array = new WORCTDTagRecord[rl.Length];
			while (!rl.Eof) {
				Array[rl.CurrentRowNumber] = new WORCTDTagRecord(rl.CurrentRec);
				rl.Advance();
			}
		}

	}
}

namespace ssCaseConferencing {
	partial class RLTDTagRecordList {
		public static implicit operator RLTDTagRecordList(WORCTDTagRecord[] array) {
			RLTDTagRecordList rl = new RLTDTagRecordList();
			if (array != null) {
				foreach(WORCTDTagRecord val in array) {
					rl.Append((RCTDTagRecord) val);
				}
			}
			return rl;
		}
		public static implicit operator WORCTDTagRecord[](RLTDTagRecordList rl) {
			WORCTDTagRecord[] array = new WORCTDTagRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = (RCTDTagRecord) rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial class WORLTDTagRecordList {
		public static implicit operator RLTDTagRecordList(WORLTDTagRecordList w) {
			return w.Array;
		}
		public static implicit operator WORLTDTagRecordList(RLTDTagRecordList rl) {
			return new WORLTDTagRecordList(rl);
		}
		public static implicit operator WORCTDTagRecord[](WORLTDTagRecordList w) {
			if (w != null) {
				return w.Array;
			}
			return null;
		}
		public static implicit operator WORLTDTagRecordList(WORCTDTagRecord[] array) {
			return new WORLTDTagRecordList(array);
		}
	}
}

namespace ssCaseConferencing {
	[Serializable()]
	public partial class WORLTDTagList {
		public WORCTDTagRecord[] Array;


		public WORLTDTagList(WORCTDTagRecord[] r) {
			if (r == null)
			Array = new WORCTDTagRecord[0];
			else
			Array = r;
		}
		public WORLTDTagList() {
			Array = new WORCTDTagRecord[0];
		}

		public WORLTDTagList(RLTDTagList rl) {
			rl=(RLTDTagList) rl.Duplicate();
			Array = new WORCTDTagRecord[rl.Length];
			while (!rl.Eof) {
				Array[rl.CurrentRowNumber] = rl.CurrentRec.Duplicate();
				rl.Advance();
			}
		}

	}
}

namespace ssCaseConferencing {
	partial class RLTDTagList {
		public static implicit operator RLTDTagList(WORCTDTagRecord[] array) {
			RLTDTagList rl = new RLTDTagList();
			if (array != null) {
				foreach(WORCTDTagRecord val in array) {
					rl.Append((STTDTagStructure) val);
				}
			}
			return rl;
		}
		public static implicit operator WORCTDTagRecord[](RLTDTagList rl) {
			WORCTDTagRecord[] array = new WORCTDTagRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = (STTDTagStructure) rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial class WORLTDTagList {
		public static implicit operator RLTDTagList(WORLTDTagList w) {
			return w.Array;
		}
		public static implicit operator WORLTDTagList(RLTDTagList rl) {
			return new WORLTDTagList(rl);
		}
		public static implicit operator WORCTDTagRecord[](WORLTDTagList w) {
			if (w != null) {
				return w.Array;
			}
			return null;
		}
		public static implicit operator WORLTDTagList(WORCTDTagRecord[] array) {
			return new WORLTDTagList(array);
		}
	}
}

