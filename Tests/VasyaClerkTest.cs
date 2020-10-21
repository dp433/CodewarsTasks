using NUnit.Framework;
using VasyaClerk;

namespace Tests
{
	[TestFixture]
	class VasyaClerkTest
	{
        [Test]
        public void Test1()
        {
            int[] peopleInLine = new int[] { 25, 25, 50, 50 };
            Assert.AreEqual("YES", Kata.Tickets(peopleInLine));
        }

        [Test]
        public void Test2()
        {
            int[] peopleInLine = new int[] { 25, 100 };
            Assert.AreEqual("NO", Kata.Tickets(peopleInLine));
        }
    }
}
