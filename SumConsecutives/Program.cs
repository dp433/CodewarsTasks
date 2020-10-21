using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumConsecutives
{
	class Program
	{
		static void Main(string[] args)
		{
			var test = new List<int> { 1, 4, 4, 4, 0, 4, 3, 3, 1 };
			var result = new List<int> { 1, 12, 0, 4, 6, 1 };
			var r = Kata.SumConsecutives(test);

			Console.WriteLine();
			foreach (var el in r)
				Console.WriteLine(el);
			Console.ReadKey();
		}
	}
}
