using NUnit.Framework;
using System;
using CountIPAddresses;

namespace Tests
{
    [TestFixture]
	class CountIPAddressesTest
	{
        [Test]
        public void SmapleTest()
        {
            Assert.AreEqual(50, Kata.IpsBetween("10.0.0.0", "10.0.0.50"));
            Assert.AreEqual(246, Kata.IpsBetween("20.0.0.10", "20.0.1.0"));
        }
    }
}
