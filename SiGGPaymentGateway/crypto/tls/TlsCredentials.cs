using System;

namespace MySiGGPayment.Org.BouncyCastle.Crypto.Tls
{
	public interface TlsCredentials
	{
		Certificate Certificate { get; }
	}
}
