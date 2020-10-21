using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsDecoder
{
	class Program
	{
		static void Main(string[] args)
		{
			var roman = "CM";
			Console.WriteLine(Kata.Solution(roman));
			Console.ReadKey();
		}
	}
}
