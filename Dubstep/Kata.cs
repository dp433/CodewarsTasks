using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dubstep
{
	public class Kata
	{
		public static string SongDecoder(string input)
		{
			string[] separator = { "WUB" };
			var s = input.Split(separator, StringSplitOptions.RemoveEmptyEntries);
			return string.Join(" ", s);
		}
	}
}
