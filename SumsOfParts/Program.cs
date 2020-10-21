using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumsOfParts
{
	class Program
	{
		static void Main(string[] args)
		{
			var arr = new int[] { 0, 1, 3, 6, 10 };
			foreach(var el in Kata.PartsSums(arr))
				Console.WriteLine(el);
			Console.ReadKey();
		}
	}
}
