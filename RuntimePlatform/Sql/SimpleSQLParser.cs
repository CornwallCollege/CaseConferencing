/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

using System;
using System.Text;
using System.Text.RegularExpressions;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.ObjectKeys;
using OutSystems.RuntimeCommon;

namespace OutSystems.HubEdition.RuntimePlatform.Sql {

    public abstract class SimpleSQLParser {

        private static readonly Regex _stringLiteralsRegEx = new Regex(@"('(''|[^'])*')", RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant | RegexOptions.Singleline);
        protected static readonly Regex sqlComments = new Regex(@"/\*(.|[\r\n])*?\*/", RegexOptions.Compiled);
        protected static readonly Regex sqlLiterals = new Regex(@"/\*(.|[\r\n])*?\*/|'[^']*'|""[^""]*""", RegexOptions.Compiled);
        protected static readonly Regex sqlCommands = new Regex(@"^/\*\s*%(\w+)%\s*=\s*(.*)\s*\*/$", RegexOptions.Compiled);
        protected static readonly Regex special_GetLogicDb = new Regex(@"GetLogicalDatabase\([""{]?(\w+)[""}]?\)", RegexOptions.Compiled);
        protected const int sqlCommandsCmdGroupIndex = 1;
        protected const int sqlCommandsValGroupIndex = 2;
        protected const int special_GetLogicDbEntnameGroupIndex = 1;
                
        protected SimpleSQLParser() {
        }

        public string ParseSQL(string sql) {
            MatchCollection mc = null;
            bool isliteralgap = false;
            int last = 0;
            int pos = 0;
            string[] spans = null;
            int count;

            isliteralgap = false;
            last = 0;
            pos = 0;

            // Get the literal matches for the string
            mc = _stringLiteralsRegEx.Matches(sql);

            // We'll assume we'll need n*2+1 spans ('n' being the number of literal matches).
            count = mc.Count * 2 + 1;
            if (mc.Count > 0) {
                // Should never happen but ... 
                // If we start with a literal it's one less item at the start
                if (mc[0].Index == 0) {
                    isliteralgap = true;
                    count--;
                }
                // If we end with a literal it's one less item at the end
                if (mc[mc.Count - 1].Index + mc[mc.Count - 1].Length == sql.Length) {
                    count--;
                }
            }

            // Split the sql into literal and non-literal spans and process each span accordingly
            spans = new string[count];
            for (int i = 0; i < count; i++) {
                if (!isliteralgap) {
                    if (pos < mc.Count) {
                        // Before we reach the last position we're reading from 'mc'
                        spans[i] = ProcessSQLSpan(sql.Substring(last, mc[pos].Index - last), isliteralgap);
                        last += mc[pos].Index - last;
                    } else {
                        // After the last 'mc' item bulk copy the rest of the string
                        spans[i] = ProcessSQLSpan(sql.Substring(last, sql.Length - last), isliteralgap);
                        last += sql.Length - last;
                    }
                    isliteralgap = true;
                } else {
                    spans[i] = ProcessSQLSpan(sql.Substring(mc[pos].Index, mc[pos].Length), isliteralgap);
                    last = mc[pos].Index + mc[pos].Length;
                    // Advance to next match
                    pos++;
                    isliteralgap = false;
                }
            }

            // Join processed sql
            sql = string.Concat(spans);

            return sql;
        }

        private string ProcessSQLSpan(string sqlSpan, bool isLiteral) {
            if (isLiteral) {
                return ProcessSQLLiteral(sqlSpan);
            } else {
                return ProcessSQLSpan(sqlSpan);
            }
        }

        protected virtual string ProcessSQLLiteral(string sqlSpan) {
            return sqlSpan;
        }

        protected abstract string ProcessSQLSpan(string sqlSpan);
        
        static string GetAdvancedConfigurationSQLSpan(string sqlspan, bool isLiteral, object extra) {
            string result = string.Empty;

            return result;
        }
    }
}
