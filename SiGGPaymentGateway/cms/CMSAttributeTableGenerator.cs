using System;
using System.Collections;

using MySiGGPayment.Org.BouncyCastle.Asn1.Cms;

namespace MySiGGPayment.Org.BouncyCastle.Cms
{
	/// <remarks>
	/// The 'Signature' parameter is only available when generating unsigned attributes.
	/// </remarks>
	public enum CmsAttributeTableParameter
	{
//		const string ContentType = "contentType";
//		const string Digest = "digest";
//		const string Signature = "encryptedDigest";
//		const string DigestAlgorithmIdentifier = "digestAlgID";

		ContentType, Digest, Signature, DigestAlgorithmIdentifier
	}

	public interface CmsAttributeTableGenerator
	{
		AttributeTable GetAttributes(IDictionary parameters);
	}
}
