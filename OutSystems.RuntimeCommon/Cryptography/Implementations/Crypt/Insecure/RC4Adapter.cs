/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

using System;
using System.Text;
using OutSystems.RuntimeCommon.Cryptography.Interfaces;

namespace OutSystems.RuntimeCommon.Cryptography.Implementations.Crypt.Insecure {   
    // WARNING: This file and its inner usages can only use the Activation assembly because of the backoffice.
    /// <summary>
    /// NOTE: This algorithm is NOT FIPS compliant...
    /// </summary>
    [Obsolete("NOT FIPS compliant")]
    internal sealed class RC4Adapter : ISymmetricCrypt
    {
        public byte[] Encrypt(byte[] bytes, byte[] key)
        {
            string stringKey = Encoding.UTF8.GetString(key);
            RC4.EncryptByte(bytes, stringKey);
            return bytes;
            
        }

        
        public byte[] Decrypt(byte[] bytes, byte[] key)
        {
            return Encrypt(bytes, key);
        }
    }
}