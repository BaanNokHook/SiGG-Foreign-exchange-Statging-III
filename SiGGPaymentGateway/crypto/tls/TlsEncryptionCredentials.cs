using System;
using System.IO;

namespace MySiGGPayment.Org.BouncyCastle.Crypto.Tls
{
    public interface TlsEncryptionCredentials
        :   TlsCredentials
    {
        /// <exception cref="IOException"></exception>
        byte[] DecryptPreMasterSecret(byte[] encryptedPreMasterSecret);
    }
}
