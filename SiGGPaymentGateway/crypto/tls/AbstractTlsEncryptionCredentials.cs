using System;
using System.IO;

namespace MySiGGPayment.Org.BouncyCastle.Crypto.Tls
{
    public abstract class AbstractTlsEncryptionCredentials
        : AbstractTlsCredentials, TlsEncryptionCredentials
    {
        /// <exception cref="IOException"></exception>
        public abstract byte[] DecryptPreMasterSecret(byte[] encryptedPreMasterSecret);
    }
}
