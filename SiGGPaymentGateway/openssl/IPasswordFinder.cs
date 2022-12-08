using System;

namespace MySiGGPayment.Org.BouncyCastle.OpenSsl
{
	public interface IPasswordFinder
	{
		char[] GetPassword();
	}
}
