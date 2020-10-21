using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueInOrder
{
	class Program
	{
		static void Main(string[] args)
		{
			var test = "AAAABBBCCDAABBB";

			foreach (var el in Kata.UniqueInOrder(test))
				Console.WriteLine(el);
			Console.ReadKey();
		}
	}
}
