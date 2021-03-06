/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

// ReSharper disable once CheckNamespace
namespace OutSystems.RuntimeCommon.Cryptography {
    /// <summary>
    /// NOTE: This algorithm is FIPS compliant...
    /// </summary>
    public static class SymmCryptHelper {
        /// <summary>
        /// Creates an Encryptor CryptoStream based on the AES 128 OFB algorithm.
        /// </summary>
        /// <param name="outputStream">The output stream.</param>
        /// <param name="key">The Key.</param>
        /// <param name="iv"></param>
        /// <returns>The Encryptor CryptoStream</returns>
        private static CryptoStream GetAES128EncryptorStream(Stream outputStream, string key, string iv) {            
            // Pre: iv is a 16bytes base64 encoded string
            return CryptManager.Instance.GetAES128EncryptorStream(outputStream, CryptManager.DecodeBase64ToBytes(key), 
                CryptManager.DecodeBase64ToBytes(iv));
        }

        /// <summary>
        /// Creates a Decryptor CryptoStream based on the AES 128 OFB algorithm.
        /// </summary>
        /// <param name="inputStream">The input stream.</param>
        /// <param name="key">The Key.</param>
        /// <param name="iv"></param>
        /// <returns>the Decryptor CryptoStream</returns>
        private static CryptoStream GetAES128DecryptorStream(Stream inputStream, string key, string iv) {
            // Pre: iv is a 16bytes base64 encoded string
            return CryptManager.Instance.GetAES128DecryptorStream(inputStream, CryptManager.DecodeBase64ToBytes(key), 
                CryptManager.DecodeBase64ToBytes(iv));
        }
        
        private static void Encrypt(Stream outputStream, Action<Stream> produceContent, Func<Stream, CryptoStream> cryptoStreamCreator) {
            // This stream is used locally only to encrypt the content, allowing the outputStream to stay open
            using (var tempStream = new MemoryStream()) {
                using (var cryptoStream = cryptoStreamCreator(tempStream)) {
                    produceContent(cryptoStream);
                    cryptoStream.FlushFinalBlock();
                    tempStream.Position = 0;
                    StreamUtils.PumpStream(tempStream, outputStream);
                }
            }
        }
   
        private static void Decrypt(Stream inputStream, Action<Stream> consumeContent, Func<Stream, CryptoStream> cryptoStreamCreator) {
            using (var cryptoStream = cryptoStreamCreator(inputStream)) {
                consumeContent(cryptoStream);
            }
        }

        private static string Encrypt(string content, Func<Stream, CryptoStream> cryptoStreamCreator) {    
            using (var outputStream = new MemoryStream()) {
                Encrypt(outputStream, stream => {
                    var data = Encoding.UTF8.GetBytes(content);
                    stream.Write(data, 0, data.Length);
                }, cryptoStreamCreator);

                return Convert.ToBase64String(outputStream.ToArray());
            }
        }

        private static string Decrypt(string cipherText, Func<Stream, CryptoStream> cryptoStreamCreator) {            
            using (var inputStream = new MemoryStream(Convert.FromBase64String(cipherText))) {
                string content = null;

                Decrypt(inputStream, stream => {
                    content = Encoding.UTF8.GetString(StreamUtils.ToArray(stream));
                }, cryptoStreamCreator);

                return content;
            }
        }

        private static int PredictBase64OutputSize(int n) {
            return 4 * (int) Math.Ceiling(n / 3.0);
        }
    
        public static string EncryptWithAES128(string password, string content) {    
            var iv = CryptManager.Instance.GenerateStrongPassword(CryptManager.Instance.AES128InitializationVectorSizeInBytes);
            return iv + Encrypt(content, s => GetAES128EncryptorStream(s, password, iv));
        }

        public static string DecryptWithAES128(string password, string cipherText) {
            try {
                int ivSize = PredictBase64OutputSize(CryptManager.Instance.AES128InitializationVectorSizeInBytes);

                if (cipherText.Length < 2 * ivSize) {
                    throw new InvalidOperationException();
                }

                var iv = cipherText.Substring(0, ivSize);
                return Decrypt(cipherText.Substring(ivSize), s => GetAES128DecryptorStream(s, password, iv));
            } catch (Exception) {
                throw new InvalidOperationException("Cannot decrypt the content");
            }
        }
    }
}