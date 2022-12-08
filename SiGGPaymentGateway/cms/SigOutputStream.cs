using System;

using MySiGGPayment.Org.BouncyCastle.Crypto;
using MySiGGPayment.Org.BouncyCastle.Utilities.IO;
using MySiGGPayment.Org.BouncyCastle.Security;

namespace MySiGGPayment.Org.BouncyCastle.Cms
{
	internal class SigOutputStream
		: BaseOutputStream
	{
		private readonly ISigner sig;

		internal SigOutputStream(ISigner sig)
		{
			this.sig = sig;
		}

		public override void WriteByte(byte b)
		{
			try
			{
				sig.Update(b);
			}
			catch (SignatureException e)
			{
				throw new CmsStreamException("signature problem: " + e);
			}
		}

		public override void Write(byte[] b, int off, int len)
		{
			try
			{
				sig.BlockUpdate(b, off, len);
			}
			catch (SignatureException e)
			{
				throw new CmsStreamException("signature problem: " + e);
			}
		}
	}
}