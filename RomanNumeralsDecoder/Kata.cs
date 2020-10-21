using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsDecoder
{
	public class Kata
	{
		private static readonly Dictionary<string, int> decoder = new Dictionary<string, int>
		{
			{ "I", 1 },
			{ "V", 5 },
			{ "X", 10 },
			{ "L", 50 },
			{ "C", 100 },
			{ "D", 500 },
			{ "M", 1000 }
		};

		public static int Solution(string roman)
		{
			if (roman.Length == 1) return decoder[roman];

			var romans = roman.Select(c => c.ToString()).ToArray();
			var arabic = decoder[romans.First()];
			for (var i = 1; i < roman.Length; i++)
			{
				var prev = decoder[romans[i - 1]];
				var curr = decoder[romans[i]];
				if (prev < curr)
					arabic += curr - prev * 2;
				else
					arabic += curr;
			}

			return int.Parse(arabic.ToString());
		}
	}
}
