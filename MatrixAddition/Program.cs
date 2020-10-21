using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixAddition
{
	class Program
	{
		static void Main(string[] args)
		{
			var a = new int[][] { new[] { 1, 1, 1 }, new[] { 1, 1, 1 } };
			var b = new int[][] { new[] { 2, 2, 2 }, new[] { 2, 2, 2 } };
			var r = Kata.MatrixAddition(a, b);
			Console.WriteLine(r);
			Console.WriteLine(a);
			Console.ReadKey();
		}
	}
}
