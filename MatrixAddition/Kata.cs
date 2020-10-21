using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixAddition
{
	public class Kata
	{
		public static int[][] MatrixAddition(int[][] a, int[][] b)
		{
			var result = new int[a.Length][];
			for (var k = 0; k < a.Length; k++)
			{
				result[k] = new int[a[k].Length];
				for (var i = 0; i < a[k].Length; i++)
					result[k][i] = a[k][i] + b[k][i];
			}
				
			return result;
		}

		public static int[][] MatrixAddition1(int[][] a, int[][] b) =>
			a.Select((arr, i) => arr.Select((n, j) => n + b[i][j]).ToArray()).ToArray();

	}
}
