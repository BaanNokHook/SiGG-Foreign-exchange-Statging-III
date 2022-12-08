using System;
using System.IO;

using MySiGGPayment.Org.BouncyCastle.Asn1;
using MySiGGPayment.Org.BouncyCastle.Asn1.X509;
using MySiGGPayment.Org.BouncyCastle.Crypto;
using MySiGGPayment.Org.BouncyCastle.Crypto.Parameters;
using MySiGGPayment.Org.BouncyCastle.Security;
using MySiGGPayment.Org.BouncyCastle.Utilities.Date;
using MySiGGPayment.Org.BouncyCastle.Utilities.IO;

namespace MySiGGPayment.Org.BouncyCastle.Cms
{
	public class CmsAuthenticatedGenerator
		: CmsEnvelopedGenerator
	{
		/**
		* base constructor
		*/
		public CmsAuthenticatedGenerator()
		{
		}

		/**
		* constructor allowing specific source of randomness
		*
		* @param rand instance of SecureRandom to use
		*/
		public CmsAuthenticatedGenerator(
			SecureRandom rand)
			: base(rand)
		{
		}
	}
}
