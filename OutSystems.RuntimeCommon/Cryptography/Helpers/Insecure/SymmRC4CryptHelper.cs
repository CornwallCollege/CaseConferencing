/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

// ReSharper disable once CheckNamespace
namespace OutSystems.RuntimeCommon.Cryptography {
    /// <summary>
    /// NOTE: This algorithm is NOT FIPS compliant...
    /// </summary>
    public static class SymmRC4CryptHelper {
        /// <summary>
        /// Encrypts plain text using Symmetric RC4 algorithm.
        /// </summary>
        /// <param name="plainText">The plain text.</param>
        /// <param name="key">The Symmetric key.</param>
        /// <returns>The encrypted text in Base64.</returns>
        /// <example>string encryptedString = SymmRC4CryptHelper.Encrypt("This is a text example", "asdfEWFADScsdcAsadas13");</example>
        /// <author>dfs</author>
        /// <datetime>18-01-2013-10:58</datetime>
        public static string Encrypt(string plainText, string key) {

            #pragma warning disable 618

            return CryptManager.Instance.Insecure.SymmetricRC4Encrypt(plainText, key);

            #pragma warning restore 618

        }

        /// <summary>
        /// Encrypts the plain text using Symmetric RC4 algorithm.
        /// </summary>
        /// <param name="plainText">The plain text.</param>
        /// <param name="key">The Symmetrickey.</param>
        /// <returns>The encrypted text in array of bytes.</returns>
        /// <example>byte[] arrEncryptedbytes = SymmRC4CryptHelper.EncryptToBytes("This is a plain Text", "asdfEWFADScsdcAsadas13");</example>
        /// <author>dfs</author>
        /// <datetime>18-01-2013-10:58</datetime>
        public static byte[] EncryptToBytes(string plainText, string key) {

            #pragma warning disable 618

            return CryptManager.Instance.Insecure.SymmetricRC4EncryptToBytes(plainText, key);

            #pragma warning restore 618

        }

        /// <summary>
        /// Decrypts Base64 text using Symmetric RC4 algorithm.
        /// </summary>
        /// <param name="encryptedText">The encrypted text text in Base64</param>
        /// <param name="key">The Symmetric key.</param>
        /// <returns>The plain text.</returns>
        /// <example>string decryptedString = SymmRC4CryptHelper.Decrypt(encryptedString, "asdfEWFADScsdcAsadas13");</example>
        /// <author>dfs</author>
        /// <datetime>18-01-2013-10:58</datetime>
        public static string Decrypt(string encryptedText, string key) {

            #pragma warning disable 618

            return CryptManager.Instance.Insecure.SymmetricRC4Decrypt(encryptedText, key);

            #pragma warning restore 618

        }

        /// <summary>
        /// Decrypts array of bytes using Symmetric RC4 algorithm.
        /// </summary>
        /// <param name="bytes">The encrypted array of bytes.</param>
        /// <param name="key">The Symmetric key.</param>
        /// <returns>The plain text.</returns>
        /// <example>string decryptedStringFromBytes = SymmRC4CryptHelper.Decrypt(arrEncryptedbytes, "asdfEWFADScsdcAsadas13");</example>
        /// <author>dfs</author>
        /// <datetime>18-01-2013-10:58</datetime>
        public static string Decrypt(byte[] bytes, string key) {

            #pragma warning disable 618

            return CryptManager.Instance.Insecure.SymmetricRC4Decrypt(bytes, key);

            #pragma warning restore 618

        }
    }
}