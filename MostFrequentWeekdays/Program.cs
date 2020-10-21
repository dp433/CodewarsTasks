using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentWeekdays
{
	class Program
	{
		static void Main(string[] args)
		{
			var test = Kata.MostFrequentDays(1968);
			foreach(var el in test)
				Console.WriteLine(el);

			Console.ReadKey();
		}
	}
}
