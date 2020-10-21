using NUnit.Framework;
using PositiveToNegativeBinary;

namespace Tests
{
    [TestFixture]
    class PositiveToNegativeBinaryTest
    {
        int[] Test1 = new int[] { 0, 0, 0, 0 };
        int[] Test2 = new int[] { 0, 0, 1, 0 };
        int[] Test3 = new int[] { 0, 0, 1, 1 };
        int[] Test4 = new int[] { 0, 1, 0, 0 };
        [Test]
        public void BasicTesting()
        {
            Assert.AreEqual(Test1, Kata.positive2Negative(Test1));
            Assert.AreEqual(new int[] { 1, 1, 1, 0 }, Kata.positive2Negative(Test2));
            Assert.AreEqual(new int[] { 1, 1, 0, 1 }, Kata.positive2Negative(Test3));
            Assert.AreEqual(new int[] { 1, 1, 0, 0 }, Kata.positive2Negative(Test4));
        }
    }
}
