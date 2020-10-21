using System;
using NUnit.Framework;
using NumberOfMultiples;

namespace Tests
{
    [TestFixture]
    class NumberOfMultiplesTest
    {
        [Test]
        public void SampleTests()
        {
            Assert.AreEqual(new double[] { 5, 10, 15 }, NumberOfMultiples.Kata.Multiples(3, 5));
        }
    }
}
