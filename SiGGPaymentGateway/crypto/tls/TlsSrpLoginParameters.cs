using System;

using MySiGGPayment.Org.BouncyCastle.Crypto.Parameters;
using MySiGGPayment.Org.BouncyCastle.Math;

namespace MySiGGPayment.Org.BouncyCastle.Crypto.Tls
{
    public class TlsSrpLoginParameters
    {
        protected readonly Srp6GroupParameters mGroup;
        protected readonly BigInteger mVerifier;
        protected readonly byte[] mSalt;

        public TlsSrpLoginParameters(Srp6GroupParameters group, BigInteger verifier, byte[] salt)
        {
            this.mGroup = group;
            this.mVerifier = verifier;
            this.mSalt = salt;
        }

        public virtual Srp6GroupParameters Group
        {
            get { return mGroup; }
        }

        public virtual byte[] Salt
        {
            get { return mSalt; }
        }

        public virtual BigInteger Verifier
        {
            get { return mVerifier; }
        }
    }
}
