using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace SumsOfParts
{
	public class Kata
	{
		public static int[] PartsSums(int[] ls)
		{
			var result = new int[ls.Length + 1];
			var sum = ls.Sum();
			var count = 0;

			for (var i = 0; i < ls.Length; i++)
			{
				result[i] = sum - count;
				count += ls[i];
			}
			return result;
		}
	}
}
