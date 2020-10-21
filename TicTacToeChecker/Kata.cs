using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeChecker
{
	public class Kata
	{
		public static int IsSolved(int[,] board)
		{
			if (IsDraw(board))
				return 0;
			if (IsWinner(board, 1))
				return 1;
			if (IsWinner(board, 2))
				return 2;
			return -1;
		}

		private static bool CheckRows(int[,] board, int p1)
		{
			if (board[0, 0] == p1 && board[0, 1] == p1 && board[0, 2] == p1) return true;
			if (board[1, 0] == p1 && board[1, 1] == p1 && board[1, 2] == p1) return true;
			if (board[2, 0] == p1 && board[2, 1] == p1 && board[2, 2] == p1) return true;
			return false;
		}

		private static bool CheckColumns(int[,] board, int p1)
		{
			if (board[0, 0] == p1 && board[1, 0] == p1 && board[2, 0] == p1) return true;
			if (board[0, 1] == p1 && board[1, 1] == p1 && board[2, 1] == p1) return true;
			if (board[0, 2] == p1 && board[1, 2] == p1 && board[2, 2] == p1) return true;
			return false;
		}

		private static bool CheckDiagonals(int[,] board, int p1)
		{
			if (board[0, 0] == p1 && board[1, 1] == p1 && board[2, 2] == p1) return true;
			if (board[0, 2] == p1 && board[1, 1] == p1 && board[2, 0] == p1) return true;
			return false;
		}

		private static bool IsWinner(int[,] board, int p1)
		{
			return CheckColumns(board, p1) ||
				CheckRows(board, p1) ||
				CheckDiagonals(board, p1);
		}
		private static bool IsDraw(int[,] board)
		{
			foreach(var el in board)
				if (el == 0)
					return false;
			return true;
		}
	}
}
