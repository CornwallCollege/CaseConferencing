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
	/// Structure <code>STListItemStructure</code> that represents the Service Studio structure
	///  <code>ListItem</code> <p> Description: </p>
	/// </summary>
	[Serializable()]
	public partial struct STListItemStructure: ISerializable, ITypedRecord<STListItemStructure>, ISimpleRecord {
		private static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("shmcdFKEAEWXZGfrlZEwCQ*6V1kEXiOAEe_eECI_QuURQ");
		private static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("shmcdFKEAEWXZGfrlZEwCQ*A1b4Ccwnw0WHa8XxXLOoFA");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Id")]
		public string ssId;

		[System.Xml.Serialization.XmlElement("Description")]
		public string ssDescription;


		public BitArray OptimizedAttributes;

		public STListItemStructure(params string[] dummy) {
			OptimizedAttributes = null;
			ssId = "";
			ssDescription = "";
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
			ssId = r.ReadText(index++, "ListItem.Id", "");
			ssDescription = r.ReadText(index++, "ListItem.Description", "");
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
		public void ReadIM(STListItemStructure r) {
			this = r;
		}


		public static bool operator == (STListItemStructure a, STListItemStructure b) {
			if (a.ssId != b.ssId) return false;
			if (a.ssDescription != b.ssDescription) return false;
			return true;
		}

		public static bool operator != (STListItemStructure a, STListItemStructure b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(STListItemStructure)) return false;
			return (this == (STListItemStructure) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssId.GetHashCode()
				^ ssDescription.GetHashCode()
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

		public STListItemStructure(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssId = "";
			ssDescription = "";
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fields[0] .FieldType.IsSerializable)
			ssId = (string) info.GetValue(fields[0] .Name, fields[0] .FieldType);
			if (fields[1] .FieldType.IsSerializable)
			ssDescription = (string) info.GetValue(fields[1] .Name, fields[1] .FieldType);
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public STListItemStructure Duplicate() {
			STListItemStructure t;
			t.ssId = this.ssId;
			t.ssDescription = this.ssDescription;
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
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Id")) VarValue.AppendAttribute(recordElem, "Id", ssId, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Id");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Description")) VarValue.AppendAttribute(recordElem, "Description", ssDescription, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Description");
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
			} else if (head == "description") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Description")) variable.Value = ssDescription; else variable.Optimized = true;
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
			if (key == IdId) {
				return ssId;
			} else if (key == IdDescription) {
				return ssDescription;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssId = (string) other.AttributeGet(IdId);
			ssDescription = (string) other.AttributeGet(IdDescription);
		}
	} // STListItemStructure
	/// <summary>
	/// Structure <code>RCListItemRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCListItemRecord: ISerializable, ITypedRecord<RCListItemRecord> {
		private static readonly GlobalObjectKey IdListItem = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*V8Ot8pOPirkp818Syd34xQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("ListItem")]
		public STListItemStructure ssSTListItem;


		public static implicit operator STListItemStructure(RCListItemRecord r) {
			return r.ssSTListItem;
		}

		public static implicit operator RCListItemRecord(STListItemStructure r) {
			RCListItemRecord res = new RCListItemRecord(null);
			res.ssSTListItem = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCListItemRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTListItem = new STListItemStructure(null);
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
					ssSTListItem.OptimizedAttributes = value[0];
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
			ssSTListItem.Read(r, ref index);
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
		public void ReadIM(RCListItemRecord r) {
			this = r;
		}


		public static bool operator == (RCListItemRecord a, RCListItemRecord b) {
			if (a.ssSTListItem != b.ssSTListItem) return false;
			return true;
		}

		public static bool operator != (RCListItemRecord a, RCListItemRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCListItemRecord)) return false;
			return (this == (RCListItemRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTListItem.GetHashCode()
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

		public RCListItemRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTListItem = new STListItemStructure(null);
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fields[0] .FieldType.IsSerializable)
			ssSTListItem = (STListItemStructure) info.GetValue(fields[0] .Name, fields[0] .FieldType);
		}

		public void RecursiveReset() {
			ssSTListItem.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTListItem.InternalRecursiveSave();
		}


		public RCListItemRecord Duplicate() {
			RCListItemRecord t;
			t.ssSTListItem = (STListItemStructure) this.ssSTListItem.Duplicate();
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
				ssSTListItem.ToXml(this, recordElem, "ListItem", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "listitem") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ListItem")) variable.Value = ssSTListItem; else variable.Optimized = true;
				variable.SetFieldName("listitem");
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
			if (key == IdListItem) {
				return ssSTListItem;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTListItem.FillFromOther((IRecord) other.AttributeGet(IdListItem));
		}
	} // RCListItemRecord
	/// <summary>
	/// RecordList type <code>RLListItemRecordList</code> that represents a record list of
	///  <code>ListItem</code>
	/// </summary>
	[Serializable()]
	public partial class RLListItemRecordList: GenericRecordList<RCListItemRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCListItemRecord GetElementDefaultValue() {
			return new RCListItemRecord("");
		}

		public T[] ToArray<T>(Func<RCListItemRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLListItemRecordList recordlist, Func<RCListItemRecord, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLListItemRecordList ToList<T>(T[] array, Func <T, RCListItemRecord> converter) {
			RLListItemRecordList result = new RLListItemRecordList();
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
		public RLListItemRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLListItemRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLListItemRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLListItemRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
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
		protected override OSList<RCListItemRecord> NewList() {
			return new RLListItemRecordList();
		}


	} // RLListItemRecordList
	/// <summary>
	/// RecordList type <code>RLListItemList</code> that represents a record list of <code>Text,
	///  Text</code>
	/// </summary>
	[Serializable()]
	public partial class RLListItemList: GenericRecordList<STListItemStructure>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override STListItemStructure GetElementDefaultValue() {
			return new STListItemStructure("");
		}

		public T[] ToArray<T>(Func<STListItemStructure, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLListItemList recordlist, Func<STListItemStructure, T> converter) {
			T[] result = new T[recordlist.Length];
			recordlist.StartIteration();
			while (!recordlist.Eof) {
				result[recordlist.CurrentRowNumber] = converter(recordlist.CurrentRec);
				recordlist.Advance();
			}
			recordlist.EndIteration();
			return result;
		}

		public static RLListItemList ToList<T>(T[] array, Func <T, STListItemStructure> converter) {
			RLListItemList result = new RLListItemList();
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
		public RLListItemList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLListItemList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLListItemList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLListItemList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[0];
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<STListItemStructure> NewList() {
			return new RLListItemList();
		}


	} // RLListItemList
}

namespace ssCaseConferencing {
	[XmlType("ListItem")]
	public class WORCListItemRecord {
		[System.Xml.Serialization.XmlElement("Id")]
		public string varWSId;

		[System.Xml.Serialization.XmlElement("Description")]
		public string varWSDescription;

		public WORCListItemRecord() {
			varWSId = (string) "";
			varWSDescription = (string) "";
		}

		public WORCListItemRecord(STListItemStructure r) {
			varWSId = BaseAppUtils.RemoveControlChars(r.ssId);
			varWSDescription = BaseAppUtils.RemoveControlChars(r.ssDescription);
		}

		public static RLListItemList ToRecordList(WORCListItemRecord[] array) {
			RLListItemList rl = new RLListItemList();
			if (array != null) {
				foreach(WORCListItemRecord val in array) {
					rl.Append(val);
				}
			}
			return rl;
		}

		public static WORCListItemRecord[] FromRecordList(RLListItemList rl) {
			WORCListItemRecord[] array = new WORCListItemRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial struct RCListItemRecord {
		public static implicit operator WORCListItemRecord(RCListItemRecord r) {
			return new WORCListItemRecord(r.ssSTListItem);
		}

		public static implicit operator RCListItemRecord(WORCListItemRecord w) {
			RCListItemRecord r = new RCListItemRecord("");
			if (w != null) {
				r.ssSTListItem = w;
			}
			return r;
		}

	}

	partial struct STListItemStructure {
		public static implicit operator WORCListItemRecord(STListItemStructure r) {
			return new WORCListItemRecord(r);
		}

		public static implicit operator STListItemStructure(WORCListItemRecord w) {
			STListItemStructure r = new STListItemStructure("");
			if (w != null) {
				r.ssId = ((string) w.varWSId ?? "");
				r.ssDescription = ((string) w.varWSDescription ?? "");
			}
			return r;
		}

	}
}


namespace ssCaseConferencing {
	[Serializable()]
	public partial class WORLListItemRecordList {
		public WORCListItemRecord[] Array;


		public WORLListItemRecordList(WORCListItemRecord[] r) {
			if (r == null)
			Array = new WORCListItemRecord[0];
			else
			Array = r;
		}
		public WORLListItemRecordList() {
			Array = new WORCListItemRecord[0];
		}

		public WORLListItemRecordList(RLListItemRecordList rl) {
			rl=(RLListItemRecordList) rl.Duplicate();
			Array = new WORCListItemRecord[rl.Length];
			while (!rl.Eof) {
				Array[rl.CurrentRowNumber] = new WORCListItemRecord(rl.CurrentRec);
				rl.Advance();
			}
		}

	}
}

namespace ssCaseConferencing {
	partial class RLListItemRecordList {
		public static implicit operator RLListItemRecordList(WORCListItemRecord[] array) {
			RLListItemRecordList rl = new RLListItemRecordList();
			if (array != null) {
				foreach(WORCListItemRecord val in array) {
					rl.Append((RCListItemRecord) val);
				}
			}
			return rl;
		}
		public static implicit operator WORCListItemRecord[](RLListItemRecordList rl) {
			WORCListItemRecord[] array = new WORCListItemRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = (RCListItemRecord) rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial class WORLListItemRecordList {
		public static implicit operator RLListItemRecordList(WORLListItemRecordList w) {
			return w.Array;
		}
		public static implicit operator WORLListItemRecordList(RLListItemRecordList rl) {
			return new WORLListItemRecordList(rl);
		}
		public static implicit operator WORCListItemRecord[](WORLListItemRecordList w) {
			if (w != null) {
				return w.Array;
			}
			return null;
		}
		public static implicit operator WORLListItemRecordList(WORCListItemRecord[] array) {
			return new WORLListItemRecordList(array);
		}
	}
}

namespace ssCaseConferencing {
	[Serializable()]
	public partial class WORLListItemList {
		public WORCListItemRecord[] Array;


		public WORLListItemList(WORCListItemRecord[] r) {
			if (r == null)
			Array = new WORCListItemRecord[0];
			else
			Array = r;
		}
		public WORLListItemList() {
			Array = new WORCListItemRecord[0];
		}

		public WORLListItemList(RLListItemList rl) {
			rl=(RLListItemList) rl.Duplicate();
			Array = new WORCListItemRecord[rl.Length];
			while (!rl.Eof) {
				Array[rl.CurrentRowNumber] = rl.CurrentRec.Duplicate();
				rl.Advance();
			}
		}

	}
}

namespace ssCaseConferencing {
	partial class RLListItemList {
		public static implicit operator RLListItemList(WORCListItemRecord[] array) {
			RLListItemList rl = new RLListItemList();
			if (array != null) {
				foreach(WORCListItemRecord val in array) {
					rl.Append((STListItemStructure) val);
				}
			}
			return rl;
		}
		public static implicit operator WORCListItemRecord[](RLListItemList rl) {
			WORCListItemRecord[] array = new WORCListItemRecord[rl == null ? 0: rl.Length];
			for (int i = 0; i < array.Length; i++) {
				array[i] = (STListItemStructure) rl.Data[i];
			}
			return array;
		}
	}
}

namespace ssCaseConferencing {
	partial class WORLListItemList {
		public static implicit operator RLListItemList(WORLListItemList w) {
			return w.Array;
		}
		public static implicit operator WORLListItemList(RLListItemList rl) {
			return new WORLListItemList(rl);
		}
		public static implicit operator WORCListItemRecord[](WORLListItemList w) {
			if (w != null) {
				return w.Array;
			}
			return null;
		}
		public static implicit operator WORLListItemList(WORCListItemRecord[] array) {
			return new WORLListItemList(array);
		}
	}
}

