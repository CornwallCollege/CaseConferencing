using System;

namespace OutSystems.HubEdition.RuntimePlatform {
    
    internal sealed class EncryptPasswordForWebServiceRequest {
        private const string ENCRYPTED_SYMMETRIC_PREFIX = "#";

        public static string Encrypt(string password, bool serverUsesExternalAuthentication, Version targetServerVersion) {
    
            return ENCRYPTED_SYMMETRIC_PREFIX 
                + SecureConfidentialInformationEncryption.EncryptWithAlgorithm(password, SecureConfidentialInformationEncryption.FixedKeyAES256.Instance);

        }
    }
}
