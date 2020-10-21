using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreTheySame
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] a = new int[] { 2, 2, 3 };
			int[] b = new int[] { 4, 9, 9 };

			Console.WriteLine(Kata.comp(a, b));
			Console.ReadKey();
		}
	}
}
