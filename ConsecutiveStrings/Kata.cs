using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsecutiveStrings
{
	public class Kata
	{
		public static String LongestConsec(string[] strarr, int k)
		{
			var arrLen = strarr.Length;
			if (arrLen == 0 || k > arrLen || k <= 0) return "";

			var longestStr = "";
			for (var i = 0; i <= strarr.Length - k; i++)
			{
				var builder = new StringBuilder();

				for (var j = i; j < i + k; j++)
					builder.Append(strarr[j]);
				if (longestStr.Length < builder.Length)
				{
					longestStr = builder.ToString();
					builder.Clear();
				}
			}
			return longestStr;
		}
	}
}
