using NUnit.Framework;
using RomanNumeralsEncoder;

namespace Tests
{
	[TestFixture]
	class RomanNumeralsEncoderTest
	{
		[TestCase(1, "I")]
		[TestCase(2, "II")]
		[TestCase(4, "IV")]
		[TestCase(500, "D")]
		[TestCase(1000, "M")]
		[TestCase(1954, "MCMLIV")]
		[TestCase(1990, "MCMXC")]
		[TestCase(2008, "MMVIII")]
		[TestCase(2014, "MMXIV")]
		public void Test(int value, string expected)
		{
			Assert.AreEqual(expected, Kata.Solution(value));
		}
	}
}
