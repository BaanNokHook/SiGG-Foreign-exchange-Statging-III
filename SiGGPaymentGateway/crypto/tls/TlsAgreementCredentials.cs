using System;
using System.IO;

namespace MySiGGPayment.Org.BouncyCastle.Crypto.Tls
{
    public interface TlsAgreementCredentials
        :   TlsCredentials
    {
        /// <exception cref="IOException"></exception>
        byte[] GenerateAgreement(AsymmetricKeyParameter peerPublicKey);
    }
}
