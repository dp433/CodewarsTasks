using NUnit.Framework;
using RomanNumeralsDecoder;

namespace Tests
{
	[TestFixture]
	class RomanNumeralsDecoderTest
	{
		[TestCase(1666, "MDCLXVI")]
		[TestCase(2008, "MMVIII")]
		[TestCase(1990, "MCMXC")]
		[TestCase(21, "XXI")]
		[TestCase(1, "I")]
		public void Test(int expected, string roman)
		{
			Assert.AreEqual(expected, Kata.Solution(roman));
		}
	}
}
