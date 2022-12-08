using System;

using MySiGGPayment.Org.BouncyCastle.Crypto;
using MySiGGPayment.Org.BouncyCastle.Utilities.IO;

namespace MySiGGPayment.Org.BouncyCastle.Cms
{
	internal class DigOutputStream
		: BaseOutputStream
	{
		private readonly IDigest dig;

		internal DigOutputStream(IDigest dig)
		{
			this.dig = dig;
		}

		public override void WriteByte(byte b)
		{
			dig.Update(b);
		}

		public override void Write(byte[] b, int off, int len)
		{
			dig.BlockUpdate(b, off, len);
		}
	}
}
