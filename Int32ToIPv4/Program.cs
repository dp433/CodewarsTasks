using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Int32ToIPv4
{
	class Program
	{
		static void Main(string[] args)
		{
			uint x = 256;

			var res = Kata.UInt32ToIP(x);
			Console.WriteLine(res);
			Console.ReadKey();
		}
	}
}
