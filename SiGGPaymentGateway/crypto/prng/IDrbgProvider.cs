using System;

using MySiGGPayment.Org.BouncyCastle.Crypto.Prng.Drbg;

namespace MySiGGPayment.Org.BouncyCastle.Crypto.Prng
{
    internal interface IDrbgProvider
    {
        ISP80090Drbg Get(IEntropySource entropySource);
    }
}
