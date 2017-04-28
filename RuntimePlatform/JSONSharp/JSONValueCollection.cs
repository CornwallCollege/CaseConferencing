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
using OutSystems.RuntimeCommon;

namespace OutSystems.HubEdition.RuntimePlatform.JSONSharp {
    /// <summary>
    /// JSONValueCollection represents any collection in JSONSharp.  It is used to 
    /// represent arrays of values to be contained within a JSON-compliant string of characters.
    /// 
    /// A JSONValueCollection is itself a JSONValue object.
    /// </summary>
    public abstract class JSONValueCollection : JSONValue {
        /// <summary>
        /// Named element for the separation character for this JSONValue object.
        /// </summary>
        protected readonly string JSONVALUE_SEPARATOR = ",";

        internal JSONValueCollection() {
        }

        /// <summary>
        /// Any implementation must override the base ToString() method, used for
        /// producing the contained object data in JSON-compliant form.
        /// </summary>
        /// <returns>The value as a string, formatted in compliance with RFC 4627.</returns>
        internal override void ToStringBuilder(StringBuilder sb) {
            sb.Append(this.BeginMarker);
            this.CollectionToString(sb);
            sb.Append(this.EndMarker);
        }

        /// <summary>
        /// Any implementation must override the base ToString() method, used for
        /// producing the contained object data in JSON-compliant form.
        /// </summary>
        /// <returns>The value as a string, formatted in compliance with RFC 4627.</returns>
        internal abstract void CollectionToString(StringBuilder sb);
        /// <summary>
        /// Any implementation must override the BeginMarker property, used for
        /// denoting the lead wrapping character for the collection type.
        /// </summary>
        protected abstract string BeginMarker { get; }

        /// <summary>
        /// Any implementation must override the EndMarker property, used for
        /// denoting the trailing wrapping character for the collection type.
        /// </summary>
        protected abstract string EndMarker { get; }
    }
}
