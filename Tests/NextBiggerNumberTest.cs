using System;
using NUnit.Framework;
using NextBiggerNumber;

namespace Tests
{
	[TestFixture]
	class NextBiggerNumberTest
	{
        [Test]
        public void Test1()
        {
            Console.WriteLine("****** Small Number");
            Assert.AreEqual(21, Kata.NextBiggerNumber(12));
            Assert.AreEqual(531, Kata.NextBiggerNumber(513));
            Assert.AreEqual(2071, Kata.NextBiggerNumber(2017));
            Assert.AreEqual(441, Kata.NextBiggerNumber(414));
            Assert.AreEqual(414, Kata.NextBiggerNumber(144));
        }
    }
}
