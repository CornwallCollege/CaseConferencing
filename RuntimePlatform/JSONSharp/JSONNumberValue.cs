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
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using OutSystems.HubEdition.RuntimePlatform.JSONSharp;
using OutSystems.RuntimeCommon;

namespace OutSystems.HubEdition.RuntimePlatform.JSONSharp.Values {
    /// <summary>
    /// JSONNumberValue is very much like a C# number, except that octal and hexadecimal formats 
    /// are not used.
    /// </summary>
    public class JSONNumberValue : JSONValue {
        private string _value;

        /// <summary>
        /// Number formatting object for handling globalization differences with decimal point separators
        /// </summary>
        protected static NumberFormatInfo JavaScriptNumberFormatInfo;

        static JSONNumberValue() {
            JavaScriptNumberFormatInfo = new NumberFormatInfo();
            JavaScriptNumberFormatInfo.NumberDecimalSeparator = ".";
        }

        internal JSONNumberValue(string value)
            : base() {
            this._value = value;
        }

        /// <summary>
        /// Public constructor that accepts a value of type int
        /// </summary>
        /// <param name="value">int (System.Int32) value</param>
        public JSONNumberValue(int value)
            : this(value.ToString()) {
        }

        /// <summary>
        /// Public constructor that accepts a value of type double
        /// </summary>
        /// <param name="value">double (System.Double) value</param>
        public JSONNumberValue(double value)
            : this(value.ToString(JSONNumberValue.JavaScriptNumberFormatInfo)) {
        }

        /// <summary>
        /// Public constructor that accepts a value of type decimal
        /// </summary>
        /// <param name="value">decimal (System.Decimal) value</param>
        public JSONNumberValue(decimal value)
            : this(value.ToString(JSONNumberValue.JavaScriptNumberFormatInfo)) {
        }

        /// <summary>
        /// Public constructor that accepts a value of type single
        /// </summary>
        /// <param name="value">single (System.Single) value</param>
        public JSONNumberValue(Single value)
            : this(value.ToString("E", JSONNumberValue.JavaScriptNumberFormatInfo)) {
        }

        /// <summary>
        /// Public constructor that accepts a value of type byte
        /// </summary>
        /// <param name="value">byte (System.Byte) value</param>
        public JSONNumberValue(byte value)
            : this(value.ToString()) {
        }

        /// <summary>
        /// Required override of ToStringBuilder() method.
        /// </summary>
        /// <returns>contained numeric value, rendered as a string</returns>
        internal override void ToStringBuilder(StringBuilder sb) {
            sb.Append(this._value);
        }
    }
}
