using Base64Encoding;
using NUnit.Framework;

namespace Tests
{
	[TestFixture]
	class Base64EncodingTest
	{
        [TestCase("this is a string!!", "dGhpcyBpcyBhIHN0cmluZyEh")]
        [TestCase("ee", "ZWU=")]
        [TestCase("e", "ZQ==")]
        [TestCase("", "")]
        public void SampleValueEncodeTest(string value, string expected)
        {
            Assert.AreEqual(expected, Kata.ToBase64(value));
        }

        [TestCase("dGhpcyBpcyBhIHN0cmluZyEh", "this is a string!!")]
        [TestCase("ZWU=", "ee")]
        [TestCase("ZQ==", "e")]
        [TestCase("", "")]
        public void SampleValueDecodeTest(string value, string expected)
        {
            Assert.AreEqual(expected, Kata.FromBase64(value));
        }
    }
}
