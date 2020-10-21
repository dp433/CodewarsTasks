using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreTheySame
{
	public class Kata
	{
		public static bool comp(int[] a, int[] b)
		{
			try
			{
				var sortedA = a.Select(n => n * n).OrderBy(n => n);
				var sortedB = b.OrderBy(n => n);

				return sortedA.SequenceEqual(sortedB);
			}
			catch (ArgumentNullException)
			{
				return false;
			}
				
		}
	}
}
