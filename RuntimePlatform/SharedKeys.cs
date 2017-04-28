using System.Runtime.CompilerServices;

#if TESTS
namespace OutSystems.TestsCommon {
#else
namespace OutSystems.HubEdition.RuntimePlatform {

#endif
    internal sealed class SharedKeys {

        public static string SettingsWeakSymmetricKey() {
            return string.Empty;
        }

        public static string ConfidentialInformationSymmetricKey() {
            return string.Empty;
        }

        public static string PrivateSalt() {
            return "cdjnes3h4w";
        }
        
    }
}