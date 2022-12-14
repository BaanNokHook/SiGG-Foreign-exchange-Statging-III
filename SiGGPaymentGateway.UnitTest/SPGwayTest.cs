using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace MySiGGPaymentPKCS7.UnitTest
{
    [TestClass]
    public class PKCS7Test
    {
        pkcs7Helper pkcs = null;
        string publicKey = "";
        string privateKey = "";
        string privateKeyFileBytes = "";
        string privatePwd = "";
        string stringToTest = "";

        [TestInitialize]
        public void Begin()
        {
            pkcs = new pkcs7Helper();
            publicKey = Path.Combine(Directory.GetCurrentDirectory(), "certs", "merchant.crt");
            privateKey = Path.Combine(Directory.GetCurrentDirectory(), "certs", "merchant.pfx");
            privateKeyFileBytes = Convert.ToBase64String(System.IO.File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "certs", "merchant.pfx")));
            privatePwd = "ToP$3c4et";

            stringToTest = "Hello, 2C2P!";
        }

        [TestCleanup]
        public void End()
        {
            pkcs = null;
            publicKey = "";
            privateKey = "";
            privatePwd = "";

            stringToTest = "";
        }

        [TestMethod]
        public void MySiGGPaymentPKCS7()
        {
            string encData = pkcs.doEncrypt(stringToTest, publicKey);
            string clearData = pkcs.doDecrypt(encData, privateKey, privatePwd);
            Assert.IsTrue(clearData.Equals(stringToTest, StringComparison.OrdinalIgnoreCase));

            //clearData = "";
            clearData = pkcs.doDecryptUsingBase64(encData, privateKeyFileBytes, privatePwd);
            Assert.IsTrue(clearData.Equals(stringToTest, StringComparison.OrdinalIgnoreCase));
            
        }

    }
}
