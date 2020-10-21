using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROT13
{
	class Program
	{
		static void Main(string[] args)
		{
			var t = "XXXxx";
			Console.WriteLine(Kata.Rot13(t));
			Console.ReadKey();
		}
	}
}
