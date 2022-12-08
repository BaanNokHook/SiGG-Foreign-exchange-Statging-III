using System;

using MySiGGPayment.Org.BouncyCastle.Crypto.Parameters;
using MySiGGPayment.Org.BouncyCastle.Crypto.Signers;

namespace MySiGGPayment.Org.BouncyCastle.Crypto.Tls
{
    public class TlsDssSigner
        :   TlsDsaSigner
    {
        public override bool IsValidPublicKey(AsymmetricKeyParameter publicKey)
        {
            return publicKey is DsaPublicKeyParameters;
        }

        protected override IDsa CreateDsaImpl(byte hashAlgorithm)
        {
            return new DsaSigner(new HMacDsaKCalculator(TlsUtilities.CreateHash(hashAlgorithm)));
        }

        protected override byte SignatureAlgorithm
        {
            get { return Tls.SignatureAlgorithm.dsa; }
        }
    }
}
