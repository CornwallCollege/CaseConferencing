using System;
using System.IO;
using OutSystems.RuntimeCommon;
using OutSystems.RuntimeCommon.Cryptography;
using OutSystems.RuntimeCommon.Cryptography.VersionedAlgorithms;

using OutSystems.Internal.Db;

namespace OutSystems.HubEdition.RuntimePlatform {

    internal abstract class AESBase<TAlgorithm> : SingletonVersionedEncryptAlgorithm<TAlgorithm>, SecureConfidentialInformationEncryption.IAlgorithmWithCachedKey where TAlgorithm : AESBase<TAlgorithm>, new() {
        private string key;
        
        private string Key {
            get {
                if (key == null) {
                    key = GetKeyWithoutUsingCache();
                }

                return key;
            }
        }
        
        protected abstract string GetKeyWithoutUsingCache();

        public void ClearCache() {
            key = null;
        }

        protected override string InnerDecrypt(string encryptedValue) {
            return SymmCryptHelper.DecryptWithAES128(Key, encryptedValue);
        }

        protected override string InnerApplyAlgorithm(string value) {
            return SymmCryptHelper.EncryptWithAES128(Key, value);
        }
    }


    internal sealed class SecureConfidentialInformationEncryption {
        public interface IAlgorithmWithCachedKey {
            void ClearCache();
        }

        public class FixedKeyRC4 : SingletonVersionedEncryptAlgorithm<FixedKeyRC4> {
            protected override string InnerDecrypt(string encryptedValue) {
                return SymmRC4CryptHelper.Decrypt(encryptedValue, SharedKeys.SettingsWeakSymmetricKey());
            }

            protected override string InnerApplyAlgorithm(string value) {
                return SymmRC4CryptHelper.Encrypt(value, SharedKeys.SettingsWeakSymmetricKey());
            }
        }

        public class FixedKeyAES256 : AESBase<FixedKeyAES256> {
            protected override string GetKeyWithoutUsingCache() {
                return PasswordHelper.DeriveKeyFromSecret(SharedKeys.ConfidentialInformationSymmetricKey(), 256 / 8);
            }
        }

#if RUNTIMEPLATFORM

        public class DynamicKeyAES128 : AESBase<DynamicKeyAES128> {
            protected override string GetKeyWithoutUsingCache() { 
                string keyLocation = Settings.Get(Settings.Configs.SettingsKeyPath);

                if (keyLocation == null) {
                    throw new InvalidOperationException("Cannot find the private key path");
                }

                return ReadKeyFromFile(Settings.Get(Settings.Configs.SettingsKeyPath));
            }
        }

#endif

        /// <summary>
        /// List of algorithms by order of security. A more secure algorithm should always be added to the end of this list.
        /// </summary>
        private static readonly VersionedEncryptAlgorithms algorithms = new VersionedEncryptAlgorithms (
            FixedKeyRC4.Instance, 
            FixedKeyAES256.Instance

#if RUNTIMEPLATFORM

            , DynamicKeyAES128.Instance

#endif

        );

#if RUNTIMEPLATFORM

        public static string EncryptWithBestAlgorithm(string text) {
            return algorithms.ApplyBestAlgorithm(text);
        }

        public static string EncryptMaintainingCompatibility(Transaction trans, string text) {
            /* This encrypts to the last algorithm that need to be supported everywhere (ie, we known that every published application supports) */            
            bool useBestAlgorithm;

            try {
                useBestAlgorithm = Settings.GetBool(Settings.Configs.UpgradeSettingsEncryption, trans);
            } catch (Exception) {
                // Since the Settings.GetBool can't get the setting if we don't have DB yet, we assume the default value...
                Boolean.TryParse(Settings.GetDefaultValue(Settings.Configs.UpgradeSettingsEncryption), out useBestAlgorithm);
            }

            return useBestAlgorithm? EncryptWithBestAlgorithm(text): EncryptWithAlgorithm(text, FixedKeyRC4.Instance);
        }

        public static VersionedEncryptAlgorithms Algorithms { get { return algorithms; } }

        public static void ClearEncryptionKeyCaches() {
            for (var i = 0; i <= algorithms.BestAlgorithmIndex; i++) {
                var alg = algorithms.GetSpecificAlgorithmFromIndex(i) as IAlgorithmWithCachedKey;

                if (alg != null) {
                    alg.ClearCache();
                }
            }
        }

#endif

        public static string EncryptWithAlgorithm(string text, IVersionedEncryptAlgorithm algorithm) {
            // The FixedKeyRC4 don't add any separators to keep the same behavior as before... So simply invoke its ApplyAlgorithm method...
            return (algorithm == FixedKeyRC4.Instance)? algorithm.ApplyAlgorithm(text): algorithms.ApplySpecificAlgorithm(text, algorithm);
        }

        public static string Decrypt(string text) {
            return algorithms.Decrypt(text);
        }

        public static string ReadKeyFromFile(string pathToFile) {
            using (var reader = new StreamReader(pathToFile)) {
                string line;
                while ((line = reader.ReadLine()) != null) {
                    if (line.StartsWith("--") || (line.Trim().Length == 0)) {
                        continue;
                    }
                    return line.Trim();
                }
            }

            throw new IOException(String.Format("Could not read the key from '{0}'.", pathToFile));
        }
    }
}
