using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text;

using MySiGGPayment.Org.BouncyCastle.Asn1;
using MySiGGPayment.Org.BouncyCastle.Asn1.CryptoPro;
using MySiGGPayment.Org.BouncyCastle.Asn1.Pkcs;
using MySiGGPayment.Org.BouncyCastle.Asn1.X509;
using MySiGGPayment.Org.BouncyCastle.Asn1.X9;
using MySiGGPayment.Org.BouncyCastle.Crypto;
using MySiGGPayment.Org.BouncyCastle.Crypto.Generators;
using MySiGGPayment.Org.BouncyCastle.Crypto.Parameters;
using MySiGGPayment.Org.BouncyCastle.Math;
using MySiGGPayment.Org.BouncyCastle.Pkcs;
using MySiGGPayment.Org.BouncyCastle.Security;
using MySiGGPayment.Org.BouncyCastle.Security.Certificates;
using MySiGGPayment.Org.BouncyCastle.Utilities.Encoders;
using MySiGGPayment.Org.BouncyCastle.Utilities.IO.Pem;
using MySiGGPayment.Org.BouncyCastle.X509;

namespace MySiGGPayment.Org.BouncyCastle.OpenSsl
{
	/// <remarks>General purpose writer for OpenSSL PEM objects.</remarks>
	public class PemWriter
		: Org.BouncyCastle.Utilities.IO.Pem.PemWriter
	{
		/// <param name="writer">The TextWriter object to write the output to.</param>
		public PemWriter(
			TextWriter writer)
			: base(writer)
		{
		}

		public void WriteObject(
			object obj) 
		{
			try
			{
				base.WriteObject(new MiscPemGenerator(obj));
			}
			catch (PemGenerationException e)
			{
				if (e.InnerException is IOException)
					throw (IOException)e.InnerException;

				throw e;
			}
		}

		public void WriteObject(
			object			obj,
			string			algorithm,
			char[]			password,
			SecureRandom	random)
		{
			base.WriteObject(new MiscPemGenerator(obj, algorithm, password, random));
		}
	}
}
