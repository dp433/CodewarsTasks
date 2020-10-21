using NUnit.Framework;
using MatrixAddition;

namespace Tests
{
	[TestFixture]
	class MatrixAdditionTest
	{
		[Test]
		public void SampleTest()
		{
			Assert.AreEqual(new int[][] {new int[] {3, 5},
								   new int[] {3, 5}}, Kata.MatrixAddition(new int[][] {new int[] {1, 2},
																					   new int[] {1, 2}},
																							 new int[][] {new int[] {2, 3},
																									new int[] {2, 3}}));
		}
	}
}
