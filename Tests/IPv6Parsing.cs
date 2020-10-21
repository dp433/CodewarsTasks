using NUnit.Framework;
using IPv6Parsing;

namespace Tests
{
	[TestFixture]
	class IPv6Parsing
	{
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("10264228481217", Kata.ParseIPv6("1234:5678:9ABC:D00F:1111:2222:3333:4445"));
            Assert.AreEqual("18544240608532", Kata.ParseIPv6("5454:FBFD:9ABC:AAAA:FFFF:2222:FBDE:0101"));
            Assert.AreEqual("00000000", Kata.ParseIPv6("0000:0000:0000:0000:0000:0000:0000:0000"));
            Assert.AreEqual("6060444864304", Kata.ParseIPv6("FFFF:FFFF:BBBB:CCCC:1212:AABC:0000:1111"));
            Assert.AreEqual("48242406085346", Kata.ParseIPv6("ACDD-0101-9ABC-AAAA-FFFF-2222-FBDE-ACCC"));
        }

        [Test]
        public void AdvancedTests()
        {
            Assert.AreEqual("18544230558532", Kata.ParseIPv6("5454rFBFDr9ABCrAA0ArFAFFr2222rFBDEr0101"));
            Assert.AreEqual("24264228481221", Kata.ParseIPv6("F234#5678#9ABC#D00F#1111#2222#3333#4485"));
        }
    }
}
