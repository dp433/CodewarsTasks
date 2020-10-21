using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleCola
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] names = new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" };
			int n = 6;

			Console.WriteLine(Kata.WhoIsNext(names, n));
			Console.ReadKey();
		}
	}
}
