using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dubstep
{
	class Program
	{
		static void Main(string[] args)
		{
			var test = "WUBWUBABCWUB";
			var res = Kata.SongDecoder(test);

			Console.WriteLine(res);
			Console.ReadKey();
		}
	}
}
