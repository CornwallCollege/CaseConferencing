/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

using System;
using System.Globalization;
using System.Linq;
using OutSystems.RuntimeCommon.Cryptography;

namespace OutSystems.RuntimeCommon {

    public static class SignUtils {

        private static string JoinObjectsWithSeparator(string separator, params object[] args) {
            return args.Where(arg => arg != null)
                       .Select(arg => Convert.ToString(arg, CultureInfo.InvariantCulture))
                       .StrCat("|");
        }

        public static string SignObjectsWithKey(string key, params object[] args)
        {
            return SignatureHelper.Sign(JoinObjectsWithSeparator("|", args), key);
        }

    }
}