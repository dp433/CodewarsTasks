
using NUnit.Framework;
using TicTacToeChecker;

namespace Tests
{
	[TestFixture]
	class TicTacToeCheckerTest
	{
		[Test]
		public void test1()
		{
			int[,] board = new int[,] { { 1, 1, 1 }, { 0, 2, 2 }, { 0, 0, 0 } };
			Assert.AreEqual(1, Kata.IsSolved(board));
		}
	}
}
