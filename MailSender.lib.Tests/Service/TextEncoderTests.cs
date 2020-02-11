using MailSender.lib.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.lib.Tests.Service
{
    [TestClass]
    public class TextEncoderTests
    {
        [TestMethod]
        public void Encode_ABC_to_BCD_with_key_1()
        {
            const string str = "ABC";
            const int key = 1;
            const string expected_str = "BCD";

            var actual_str = TextEncoder.Encode(str, key);

            Assert.AreEqual(expected_str, actual_str);
        }

        [TestMethod]
        public void Encode_XYZ_to_YZA_with_key_1()
        {
            const string str = "XYZ";
            const int key = 1;
            const string expected_str = "YZA";

            var actual_str = TextEncoder.Encode(str, key);

            Assert.AreEqual(expected_str, actual_str);
        }

        [TestMethod]
        public void Decode_YZA_to_XYZ_with_key_1()
        {
            const string str = "YZA";
            const int key = 1;
            const string expected_str = "XYZ";

            var actual_str = TextEncoder.Decode(str, key);

            Assert.AreEqual(expected_str, actual_str);
        }

        [TestMethod]
        public void Encode_ABC_to_ZAB_with_key_minus_1()
        {
            const string str = "ABC";
            const int key = -1;
            const string expected_str = "ZAB";

            var actual_str = TextEncoder.Encode(str, key);

            Assert.AreEqual(expected_str, actual_str);
        }

        [TestMethod]
        public void Decode_ZAB_to_ABC_with_key_minus_1()
        {
            const string str = "ZAB";
            const int key = -1;
            const string expected_str = "ABC";

            var actual_str = TextEncoder.Decode(str, key);

            Assert.AreEqual(expected_str, actual_str);
        }
    }
}
