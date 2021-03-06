/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

using System.Text.RegularExpressions;

namespace OutSystems.HubEdition.RuntimePlatform.Sql {
    public sealed class PrepareQueryForCount {

        private static readonly Regex _isSelectRegEx = new Regex(@"^(\s|\()*SELECT\b", RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.ExplicitCapture);
        
        public static bool IsSelectStatement(string sql) {
            return _isSelectRegEx.IsMatch(sql);
        }
    }

    public class InvalidQueryForCount : DataBaseException {
        public InvalidQueryForCount(string sql) : base("Could not calculate the query count. Actual SQL used was: " + sql) {
        }
    }
}