using NUnit.Framework;
using SumofOddCubedNumbers;

namespace Tests
{
    [TestFixture]
    class SumOfOddCubedNumbersTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(28, Kata.CubeOdd(new int[] { 1, 2, 3, 4 }));
            Assert.AreEqual(0, Kata.CubeOdd(new int[] { -3, -2, 2, 3 }));
        }
    }
}
