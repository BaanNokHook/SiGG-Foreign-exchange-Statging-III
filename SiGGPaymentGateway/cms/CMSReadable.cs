using System;
using System.IO;

namespace MySiGGPayment.Org.BouncyCastle.Cms
{
	public interface CmsReadable
	{
		Stream GetInputStream();
	}
}
