using NUnit.Framework;
using ValidParentheses;

namespace Tests
{
	[TestFixture]
	class ValidParenthesesTest
	{
        [Test]
        public void SampleTest1()
        {
            Assert.AreEqual(true, Kata.ValidParentheses("()"));
        }

        [Test]
        public void SampleTest2()
        {
            Assert.AreEqual(false, Kata.ValidParentheses(")(((("));
        }
    }
}
