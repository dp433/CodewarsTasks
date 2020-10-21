using System;
using System.Collections;
using System.Linq;

namespace TheSupermarketQueue
{
	public class Kata
	{
		public static long QueueTime(int[] customers, int n)
		{
			if (customers.Length < n) 
				return customers.Length == 0 ? customers.FirstOrDefault() : customers.Max();

			var queue = new Queue(customers);
			var times = new int[n];

			for (var i = 0; i < n - 1; i++)
				times[i] = 0;

			while (queue.Count > 0)
			{
				var minIndex = Array.IndexOf(times, times.Min());
				times[minIndex] += (int)queue.Dequeue();
			}

			return times.Max();
		}
	}
}
