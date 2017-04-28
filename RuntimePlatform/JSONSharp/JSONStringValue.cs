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
using System.Text;
using System.Collections.Generic;
using OutSystems.RuntimeCommon;

namespace OutSystems.HubEdition.RuntimePlatform.JSONSharp.Values {
    /// <summary>
    /// JSONStringValue is a collection of zero or more Unicode characters, wrapped in double quotes, 
    /// using backslash escapes. A character is represented as a single character string. A string 
    /// is very much like a C# string.
    /// </summary>
    public class JSONStringValue : JSONValue {
        private string _value;
        private bool _escapeSolidus;

        /// <summary>
        /// Public constructor that accepts a value of type string
        /// </summary>
        /// <param name="value">string value</param>
        public JSONStringValue(string value)
            : base() {
            this._value = value;
            this._escapeSolidus = false;
        }

        /// <summary>
        /// Public constructor that accepts a value of type string
        /// </summary>
        /// <param name="value">string value</param>
        /// <param name="escapeSolidus">whether "/" shall be escaped</param>
        public JSONStringValue(string value, bool escapeSolidus)
            : base() {
            this._value = value;
            this._escapeSolidus = escapeSolidus;
        }

        internal override void ToStringBuilder(StringBuilder sb) {
            ToJSONStringBuilder(this._value, _escapeSolidus, sb);
        }

         //<summary>
         //Required override of the ToString() method.
         //</summary>
         //<returns>contained string in JSON-compliant form</returns>
        public override string ToString()
        {
            // This is done to properly translate the call to Java (only used in tests).
            // This class is not translated to Java. It's equivalent counterpart extends
            // the org.json.JSONValue and redifines to toJSONString method.
            return base.ToString();
        }

        private static void ToJSONStringBuilder(string text, bool escapeSolidus, StringBuilder sb) {
            sb.Append("\"");
            char[] charArray = text.ToCharArray();
            foreach (char c in charArray) {
                if (((int)c) == 8)              //Backspace
                    sb.Append("\\b");
                else if (((int)c) == 9)         //Horizontal tab
                    sb.Append("\\t");
                else if (((int)c) == 10)        //Newline
                    sb.Append("\\n");
                else if (((int)c) == 12)        //Formfeed
                    sb.Append("\\f");
                else if (((int)c) == 13)        //Carriage return
                    sb.Append("\\r");
                else if (((int)c) == 34)        //Double-quotes (")
                    sb.Append("\\" + c.ToString());
                else if (((int)c) == 47 && escapeSolidus)   //Solidus   (/)
                    sb.Append("\\" + c.ToString());
/*              else if (((int)c) == 44)        //Comma (,)
                    output.Add("\\" + c.ToString());
                else if (((int)c) == 47)        //Solidus   (/)
                    output.Add("\\" + c.ToString());*/
                else if (((int)c) == 92)        //Reverse solidus   (\)
                    sb.Append("\\" + c.ToString());
                else if (c == '\u0085')         // Next Line
                    sb.Append(@"\u0085");
                else if (c == '\u2028')         // Line Separator
                    sb.Append(@"\u2028");
                else if (c == '\u2029')         // Paragraph Separator
                    sb.Append(@"\u2029");
                else if (((int)c) > 31)
                    sb.Append(c.ToString());
                //TODO: add support for hexadecimal
            }
            sb.Append("\"");
        }

        public override bool Equals(object obj) {
            if (!(obj is JSONStringValue)) {
                return false;
            }

            var other = (JSONStringValue)obj;
            return _value.Equals(other._value) && _escapeSolidus.Equals(other._escapeSolidus);
        }

        public override int GetHashCode() {
            return _value.GetHashCode() ^ _escapeSolidus.GetHashCode();
        }
    }
}
