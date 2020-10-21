using MergedStringChecker;
using NUnit.Framework;

namespace Tests
{
	[TestFixture]
	class MergedStringCheckerTest
	{
		[Test]
		public void HappyPath1()
		{
			Assert.IsTrue(Kata.isMerge("codewars", "code", "wars"), "codewars can be created from code and wars");
		}

		[Test]
		public void HappyPath2()
		{
			Assert.IsTrue(Kata.isMerge("codewars", "cdwr", "oeas"), "codewars can be created from cdwr and oeas");
		}

		[Test]
		public void SadPath1()
		{
			Assert.IsFalse(Kata.isMerge("codewars", "cod", "wars"), "Codewars are not codwars");
		}
	}
}
