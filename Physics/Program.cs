using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physics
{
	class Program
	{
		static double GetEx3result(double T, double S)
		{
			var t = 60;
			var b = 5.67;
			return b * t * T * T * T * T * S;
		}

		static void Main(string[] args)
		{
			var x = new List<int> { 1,2,3};
			Console.WriteLine();
			Console.WriteLine(GetEx3result(1.5, 14));
			Console.WriteLine(Math.Asin(0.3125));
			Console.WriteLine("\n\n\n\n");
			Console.ReadKey();
		}
	}
}
