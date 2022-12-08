using System;
using System.Collections;
using System.IO;
using System.Text;

using MySiGGPayment.Org.BouncyCastle.Asn1;
using MySiGGPayment.Org.BouncyCastle.Asn1.X509;
using MySiGGPayment.Org.BouncyCastle.Crypto.Agreement;
using MySiGGPayment.Org.BouncyCastle.Crypto.Agreement.Srp;
using MySiGGPayment.Org.BouncyCastle.Crypto.Digests;
using MySiGGPayment.Org.BouncyCastle.Crypto.Encodings;
using MySiGGPayment.Org.BouncyCastle.Crypto.Engines;
using MySiGGPayment.Org.BouncyCastle.Crypto.Generators;
using MySiGGPayment.Org.BouncyCastle.Crypto.IO;
using MySiGGPayment.Org.BouncyCastle.Crypto.Parameters;
using MySiGGPayment.Org.BouncyCastle.Crypto.Prng;
using MySiGGPayment.Org.BouncyCastle.Math;
using MySiGGPayment.Org.BouncyCastle.Security;
using MySiGGPayment.Org.BouncyCastle.Utilities;
using MySiGGPayment.Org.BouncyCastle.Utilities.Date;

namespace MySiGGPayment.Org.BouncyCastle.Crypto.Tls
{
    [Obsolete("Use 'TlsClientProtocol' instead")]
    public class TlsProtocolHandler
        :   TlsClientProtocol
    {
        public TlsProtocolHandler(Stream stream, SecureRandom secureRandom)
            :   base(stream, stream, secureRandom)
        {
        }

        /// <remarks>Both streams can be the same object</remarks>
        public TlsProtocolHandler(Stream input, Stream output, SecureRandom	secureRandom)
            :   base(input, output, secureRandom)
        {
        }
    }
}
