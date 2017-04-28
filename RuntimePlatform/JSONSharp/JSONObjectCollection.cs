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
using OutSystems.HubEdition.RuntimePlatform.JSONSharp.Values;
using OutSystems.RuntimeCommon;

namespace OutSystems.HubEdition.RuntimePlatform.JSONSharp.Collections {
    /// <summary>
    /// JSONObjectCollection is an unordered set of name/value pairs. An object begins 
    /// with "{" (left brace) and ends with "}" (right brace). Each name is followed 
    /// by ":" (colon) and the name/value pairs are separated by "," (comma).
    /// </summary>
    public class JSONObjectCollection : JSONValueCollection {
        private Dictionary<JSONStringValue, JSONValue> _namevaluepairs;
        private readonly string NAMEVALUEPAIR_SEPARATOR = ":";

        /// <summary>
        /// Public constructor that accepts a Dictionary of name/value pairs.
        /// </summary>
        /// <param name="namevaluepairs">Dictionary collection of name/value pairs (JSONStringValue=name,JSONValue=pair)</param>
        public JSONObjectCollection(Dictionary<JSONStringValue, JSONValue> namevaluepairs)
            : base() {
            this._namevaluepairs = namevaluepairs;
        }

        /// <summary>
        /// Empty public constructor. Use this method in conjunction with
        /// the Add method to populate the internal dictionary of name/value pairs.
        /// </summary>
        public JSONObjectCollection()
            : base() {
            this._namevaluepairs = new Dictionary<JSONStringValue, JSONValue>();
        }

        /// <summary>
        /// Adds a JSONStringValue as the "name" and a JSONValue as the "value" to the 
        /// internal Dictionary.  Values are checked to ensure no duplication occurs 
        /// in the internal Dictionary.
        /// </summary>
        /// <param name="name">JSONStringValue "name" to add to the internal dictionary</param>
        /// <param name="value">JSONValue "value" to add to the internal dictionary</param>
        public void Add(JSONStringValue name, JSONValue value) {
            if (!this._namevaluepairs.ContainsKey(name))
                this._namevaluepairs.Add(name, value);
        }

        /// <summary>
        /// Required override of the CollectionToString() method.
        /// </summary>
        /// <returns>the entire collection as a string in JSON-compliant format</returns>
        internal override void CollectionToString(StringBuilder sb) {
            string separator = "";
            foreach (KeyValuePair<JSONStringValue, JSONValue> kvp in this._namevaluepairs) {
                sb.Append(separator);
                separator = base.JSONVALUE_SEPARATOR;
                kvp.Key.ToStringBuilder(sb);
                sb.Append(this.NAMEVALUEPAIR_SEPARATOR);
                kvp.Value.ToStringBuilder(sb);
            }
        }

        /// <summary>
        /// Required override of the BeginMarker property
        /// </summary>
        protected override string BeginMarker {
            get { return "{"; }
        }

        /// <summary>
        /// Required override of the EndMarker property
        /// </summary>
        protected override string EndMarker {
            get { return "}"; }
        }
    }
}
