using System;
using System.Collections;

using MySiGGPayment.Org.BouncyCastle.Asn1;
using MySiGGPayment.Org.BouncyCastle.Asn1.Cms;
using MySiGGPayment.Org.BouncyCastle.Utilities;
using MySiGGPayment.Org.BouncyCastle.X509;
using MySiGGPayment.Org.BouncyCastle.X509.Store;

namespace MySiGGPayment.Org.BouncyCastle.Cms
{
    public class OriginatorInfoGenerator
    {
        private readonly IList origCerts;
        private readonly IList origCrls;

        public OriginatorInfoGenerator(X509Certificate origCert)
        {
            this.origCerts = Platform.CreateArrayList(1);
            this.origCrls = null;
            origCerts.Add(origCert.CertificateStructure);
        }

        public OriginatorInfoGenerator(IX509Store origCerts)
            : this(origCerts, null)
        {
        }

        public OriginatorInfoGenerator(IX509Store origCerts, IX509Store origCrls)
        {
            this.origCerts = CmsUtilities.GetCertificatesFromStore(origCerts);
            this.origCrls = origCrls == null ? null : CmsUtilities.GetCrlsFromStore(origCrls);
        }

        public virtual OriginatorInfo Generate()
        {
            Asn1Set certSet = CmsUtilities.CreateDerSetFromList(origCerts);
            Asn1Set crlSet = origCrls == null ? null : CmsUtilities.CreateDerSetFromList(origCrls);
            return new OriginatorInfo(certSet, crlSet);
        }
    }
}
