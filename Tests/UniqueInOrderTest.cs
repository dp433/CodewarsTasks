using NUnit.Framework;
using UniqueInOrder;

namespace Tests
{
    [TestFixture]
	class UniqueInOrderTest
	{
        [TestCase("", "")]
        [TestCase("AAAABBBCCDAABBB", "ABCDAB")]
        public void EmptyTest(string input, string expected)
        {
            Assert.AreEqual(Kata.UniqueInOrder(input), expected);
        }
    }
}
