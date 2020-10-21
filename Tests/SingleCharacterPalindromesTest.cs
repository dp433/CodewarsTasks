using NUnit.Framework;
using System;
using SingleCharacterPalindromes;

namespace Tests
{
	[TestFixture]
	class SingleCharacterPalindromesTest
	{
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual("OK", Kata.solve("abba"));
            Assert.AreEqual("remove one", Kata.solve("abbaa"));
            Assert.AreEqual("not possible", Kata.solve("abbaab"));
            Assert.AreEqual("remove one", Kata.solve("madmam"));
            Assert.AreEqual("not possible", Kata.solve("raydarm"));
            Assert.AreEqual("OK", Kata.solve("hannah"));

        }
    }
}
