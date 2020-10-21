using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortTheOdd
{
	public class Kata
	{
		public static int[] SortArray1(int[] array)
		{
			for (var i = 0; i < array.Length; i++)
			{
				if (array[i] % 2 == 0) continue;
				for (var j = i; j < array.Length; j++)
				{
					if (array[j] % 2 == 0) continue;
					if (array[i] > array[j])
					{
						var min = array[j];
						array[j] = array[i];
						array[i] = min;
					}
				}
			}
			return array;
		}

		public static int[] SortArray(int[] array)
		{
			var queue = new Queue<int>(array.Where(n => n % 2 == 1).OrderBy(n => n));
			return array.Select(n => n % 2 == 1 ? queue.Dequeue() : n).ToArray();
		}
	}
}
