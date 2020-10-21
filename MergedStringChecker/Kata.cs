using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergedStringChecker
{
	public class Kata
	{
		public static bool isMerge(string s, string part1, string part2)
		{
			if (s.Equals(""))
				return part1.Equals("") && part2.Equals("");
			else
			{
				bool isMerge1 = false, isMerge2 = false;
				if (part1.Length > 0 && s.ElementAt(0) == part1.ElementAt(0))
					isMerge1 = isMerge(s.Substring(1), part1.Substring(1), part2);
				if (part2.Length > 0 && s.ElementAt(0) == part2.ElementAt(0))
					isMerge2 = isMerge(s.Substring(1), part1, part2.Substring(1));
				return isMerge1 || isMerge2;
			}
		}
	}
}
