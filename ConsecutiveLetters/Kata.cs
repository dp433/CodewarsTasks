using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsecutiveLetters
{
	public class Kata
	{
		public static bool solve(string s)
		{
			var alphabet = "abcdefghijklmnopqrstuvwxyz";
			var minIdx = alphabet.IndexOf(s.Min());
			var maxIdx = alphabet.IndexOf(s.Max());
			var diff = maxIdx - minIdx + 1;
			return diff == s.Length;
		}

		public static bool solve2(string s)
		{
			var alphabet = "abcdefghijklmnopqrstuvwxyz";

			return alphabet.Contains(string.Concat(s.OrderBy(c => c)));
		}
	}
}
