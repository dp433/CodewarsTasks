using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatePhoneNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			var x = new[] { 1, 2, 3, 4, 5 };

			var res = long.Parse(string.Concat(x)).ToString("(000) 00");
			Console.WriteLine(res);
			Console.ReadKey();
		}
	}
}
