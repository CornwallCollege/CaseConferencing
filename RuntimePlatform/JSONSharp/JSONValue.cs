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

using OutSystems.RuntimeCommon;
using System.Text;

namespace OutSystems.HubEdition.RuntimePlatform.JSONSharp {
    /// <summary>
    /// JSONValue represents the core object in JSONSharp.  It is used to represent values
    /// to be contained within a JSON-compliant string of characters.
    /// 
    /// A JSON value can be a string in double quotes, a number, true or false, null, an 
    /// object or an array. These structures can be nested.
    /// </summary>
    public abstract class JSONValue {
        /// <summary>
        /// Named element to represent a horizontal tab character. Used for PrettyPrint().
        /// </summary>
        protected readonly string HORIZONTAL_TAB = "\t";

        /// <summary>
        /// Static counter used for PrettyPrint().
        /// </summary>
        public static int CURRENT_INDENT = 0;

        internal JSONValue() {
        }

        /// <summary>
        /// Any implementation must override the base ToStringBuilder() method, used for
        /// producing the contained object data in JSON-compliant form.
        /// </summary>
        internal abstract void ToStringBuilder(StringBuilder bob);

        /// <summary>
        /// Any implementation must override the base ToStringBuilder() method, used for
        /// producing the contained object data in JSON-compliant form.
        /// </summary>
        /// <returns>The value as a string, formatted in compliance with RFC 4627.</returns>
        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            this.ToStringBuilder(sb);
            return sb.ToString();
        }
    }
}
