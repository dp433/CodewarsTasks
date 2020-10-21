using System;
using NUnit.Framework;
using HistogramData;

namespace Tests
{
    [TestFixture]
    class HistogramDataTest
    {
        [Test]
        public void SimpleTest()
        {
            uint[] data = new uint[] { 1, 1, 0, 1, 3, 2, 6 };
            Assert.AreEqual(new uint[] { 1, 3, 1, 1, 0, 0, 1 }, HistogramData.Kata.Histogram(data, 1));
            Assert.AreEqual(new uint[] { 4, 2, 0, 1 }, HistogramData.Kata.Histogram(data, 2));
        }
    }
}
