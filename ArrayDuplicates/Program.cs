using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDuplicates
{
	class Program
	{
		static void Main(string[] args)
		{
			var test = new[] { "ccx" };

			Console.WriteLine(string.Concat(Kata.dup(test)));
			Console.ReadKey();
		}
	}
}
