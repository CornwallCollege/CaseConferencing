/*
JSONSharp, a c# library for generating strings in JSON format
Copyright (C) 2007 Jeff Rodenburg

Redistribution and use in source and binary forms, with or without modification, 
are permitted provided that the following conditions are met:

    * Redistributions of source code must retain the above copyright notice, this list 
      of conditions and the following disclaimer.
    * Redistributions in binary form must reproduce the above copyright notice, this list 
      of conditions and the following disclaimer in the documentation and/or other materials 
      provided with the distribution.
    * Neither the name of the Jeff Rodenburg nor the names of its contributors may be used to
      endorse or promote products derived from this software without specific prior written permission. 

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS 
OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY 
AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER 
OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, 
OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS 
OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND 
ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING 
NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED 
OF THE POSSIBILITY OF SUCH DAMAGE. 
*/

using System;
using System.Text;
using System.Collections.Generic;
using OutSystems.RuntimeCommon;

namespace OutSystems.HubEdition.RuntimePlatform.JSONSharp.Collections {
    /// <summary>
    /// JSONArrayCollection is an ordered collection of values. An array begins with 
    /// "[" (left bracket) and ends with "]" (right bracket). Array elements are 
    /// separated by "," (comma).
    /// </summary>
    public class JSONArrayCollection : JSONValueCollection {
        /// <summary>
        /// Internal generic list of JSONValue objects that comprise the elements
        /// of the JSONArrayCollection.
        /// </summary>
        protected List<JSONValue> _values;

        /// <summary>
        /// Public constructor that accepts a generic list of JSONValue objects.
        /// </summary>
        /// <param name="values">Generic list of JSONValue objects.</param>
        public JSONArrayCollection(List<JSONValue> values)
            : base() {
            this._values = values;
        }

        /// <summary>
        /// Empty public constructor. Use this method in conjunction with
        /// the Add method to populate the internal array of elements.
        /// </summary>
        public JSONArrayCollection()
            : base() {
            this._values = new List<JSONValue>();
        }

        /// <summary>
        /// Adds a JSONValue to the internal object array.
        /// </summary>
        /// <param name="value">JSONValue to add to the internal array</param>
        public void Add(JSONValue value) {
            this._values.Add(value);
        }

        /// <summary>
        /// Inserts a JSONValue to the internal object array.
        /// </summary>
        /// <param name="index">zero-based index</param>
        /// <param name="value">JSONValue to add to the internal array</param>
        public void Insert(int index, JSONValue value) {
            this._values.Insert(index, value);
        }

        ///<summary>
        ///Required override of the CollectionToString() method.
        ///</summary>
        ///<returns>the entire collection as a string in JSON-compliant format</returns>
        internal override void CollectionToString(StringBuilder sb) {
            string separator = "";
            foreach (JSONValue jv in this._values) {
                sb.Append(separator);
                separator = base.JSONVALUE_SEPARATOR;
                jv.ToStringBuilder(sb);
            }
        }

        /// <summary>
        /// Required override of the BeginMarker property
        /// </summary>
        protected override string BeginMarker {
            get { return "["; }
        }

        /// <summary>
        /// Required override of the EndMarker property
        /// </summary>
        protected override string EndMarker {
            get { return "]"; }
        }

        /// <summary>
        /// Returns the number of elements in the array
        /// </summary>
        /// <returns></returns>
        public int Count {
            get {
                return _values.Count;
            }
        }

        /// <summary>
        /// Clears all the elements in the array
        /// </summary>
        public void Clear() {
            _values.Clear();
        }
    }
}
