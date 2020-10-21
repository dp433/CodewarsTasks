using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NumbersInStrings
{
	public class Kata
	{
		public static int Solve(string s)
		{
			return new Regex(@"\d+")
				.Matches(s)
				.OfType<Match>()
				.Select(m => int.Parse(m.Value))
				.Max(n => n);
		}
	}
}
