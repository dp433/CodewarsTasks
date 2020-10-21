using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMinArrays
{
	class Program
	{
		static void Main(string[] args)
		{
			var t = new List<int> { 15, 11, 10, 7, 12 };
			var x = Kata.Solve(t);
			foreach (var el in x)
				Console.Write(el + " ");
			Console.ReadKey();

		}
	}
}
