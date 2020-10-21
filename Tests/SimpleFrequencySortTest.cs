using NUnit.Framework;
using SimpleFrequencySort;

namespace Tests
{
	[TestFixture]
	class SimpleFrequencySortTest
	{
		[Test]
		[TestCase(new[] { 3, 3, 3, 5, 5, 7, 7, 2, 9 }, 
			new[] { 2, 3, 5, 3, 7, 9, 5, 3, 7 })]
		[TestCase(new[] { 1, 1, 1, 0, 0, 6, 6, 8, 8, 2, 3, 5, 9 }, 
			new[] { 1, 2, 3, 0, 5, 0, 1, 6, 8, 8, 6, 9, 1 })]
		[TestCase(new[]{9, 9, 9, 9, 4, 4, 5, 5, 6, 6}, 
			new[]{5, 9, 6, 9, 6, 5, 9, 9, 4, 4})]
		[TestCase(new[] { 1, 1, 2, 2, 3, 3, 4, 4, 5, 8 }, 
			new [] { 4, 4, 2, 5, 1, 1, 3, 3, 2, 8 })]
		[TestCase(new[] { 0, 0, 4, 4, 9, 9, 3, 5, 7, 8 }, 
			new [] { 4, 9, 5, 0, 7, 3, 8, 4, 9, 0 })]
		public void FixedTests(int[] expectedOutput, int[] input)
		{
			Assert.AreEqual(expectedOutput, Kata.sortByFrequency(input));
		}
	}
}
