using System;

using MySiGGPayment.Org.BouncyCastle.Asn1.Cms;
using MySiGGPayment.Org.BouncyCastle.Crypto.Parameters;
using MySiGGPayment.Org.BouncyCastle.Security;

namespace MySiGGPayment.Org.BouncyCastle.Cms
{
	interface RecipientInfoGenerator
	{
		/// <summary>
		/// Generate a RecipientInfo object for the given key.
		/// </summary>
		/// <param name="contentEncryptionKey">
		/// A <see cref="KeyParameter"/>
		/// </param>
		/// <param name="random">
		/// A <see cref="SecureRandom"/>
		/// </param>
		/// <returns>
		/// A <see cref="RecipientInfo"/>
		/// </returns>
		/// <exception cref="GeneralSecurityException"></exception>
		RecipientInfo Generate(KeyParameter contentEncryptionKey, SecureRandom random);
	}
}
