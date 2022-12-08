using System;

using MySiGGPayment.Org.BouncyCastle.Utilities;

namespace MySiGGPayment.Org.BouncyCastle.Cms
{
	internal class BaseDigestCalculator
		: IDigestCalculator
	{
		private readonly byte[] digest;

		internal BaseDigestCalculator(
			byte[] digest)
		{
			this.digest = digest;
		}

		public byte[] GetDigest()
		{
			return Arrays.Clone(digest);
		}
	}
}
