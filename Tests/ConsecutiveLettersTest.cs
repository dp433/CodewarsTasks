using NUnit.Framework;
using ConsecutiveLetters;

namespace Tests
{
	[TestFixture]
	class ConsecutiveLettersTest
	{
		[Test]
		public void ExampleTests()
		{
			Assert.AreEqual(true, Kata.solve("abc"));
			Assert.AreEqual(false, Kata.solve("abd"));
			Assert.AreEqual(true, Kata.solve("dabc"));
			Assert.AreEqual(false, Kata.solve("abbc"));
		}
	}
}
