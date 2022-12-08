using System;

namespace MySiGGPayment.Org.BouncyCastle.Cms
{
	internal interface IDigestCalculator
	{
		byte[] GetDigest();
	}
}
