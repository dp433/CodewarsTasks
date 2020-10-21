using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleCharacterPalindromes
{
	class Program
	{
		static void Main(string[] args)
		{
			var test = "madmam";
			var res = Kata.solve(test);

			Console.WriteLine(res);
			Console.ReadKey();
		}
	}
}
