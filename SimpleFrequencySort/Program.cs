using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFrequencySort
{
	class Program
	{
		static void Main(string[] args)
		{
			foreach (var el in Kata.sortByFrequency(new[] { 2, 3, 5, 3, 7, 9, 5, 3, 7 }))
				Console.WriteLine(el);
			Console.ReadKey();
		}
	}
}
