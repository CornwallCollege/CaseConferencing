using System;
using OutSystems.RuntimeCommon;
using OutSystems.RuntimeCommon.Cryptography;
using OutSystems.RuntimeCommon.Cryptography.Insecure;

using OutSystems.HubEdition.RuntimePlatform;

// ReSharper disable once CheckNamespace
internal class CryptMethods {

    internal static string MD5HashWithPrivateSalt(string str) {
        return MD5PasswordHelper.HexDeriveUsingUTF16(str, SharedKeys.PrivateSalt());
    }
}

#if TESTS

}

#endif