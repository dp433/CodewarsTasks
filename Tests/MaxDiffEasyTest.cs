using NUnit.Framework;
using MaxDiffEasy;

namespace Tests
{
    [TestFixture]
    class MaxDiffEasyTest
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual(Kata.maxDiff(new[] { 0, 1, 2, 3, 4, 5, 6 }), 6);
            Assert.AreEqual(Kata.maxDiff(new[] { -0, 1, 2, -3, 4, 5, -6 }), 11);
            Assert.AreEqual(Kata.maxDiff(new[] { 0, 1, 2, 3, 4, 5, 16 }), 16);
            Assert.AreEqual(Kata.maxDiff(new[] { 16 }), 0);
            Assert.AreEqual(Kata.maxDiff(new int[] { }), 0);
        }
    }
}
