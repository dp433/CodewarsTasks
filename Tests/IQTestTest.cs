using NUnit.Framework;
using IQTest;

namespace Tests
{
	[TestFixture]
	class IQTestTest
	{
        [Test]
        public void IndexOfEven()
        {
            Assert.AreEqual(3, Kata.Test("2 4 7 8 10"));
        }

        [Test]
        public void IndexOfOdd()
        {
            Assert.AreEqual(1, Kata.Test("1 2 2"));
        }
    }
}
