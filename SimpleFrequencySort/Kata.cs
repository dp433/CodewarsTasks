using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFrequencySort
{
	public class Kata
	{
		public static int[] sortByFrequency(int[] arr)
		{
			var a = arr
				.Select(n => Tuple.Create(n, arr.Count(c => c == n)))
				.OrderByDescending(t => t.Item2)
				.ThenBy(n => n)
				.Select(t => t.Item1)
				.ToArray();
			return a;
		}


	}
}
