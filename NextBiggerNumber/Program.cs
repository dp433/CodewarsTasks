using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextBiggerNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			var t = 321;
			var z = t.ToString().ToArray();
			Array.Sort(z);
			Array.Reverse(z);
			Console.WriteLine(Kata.NextBiggerNumber(414));
			Console.ReadKey();
		}
	}
}
