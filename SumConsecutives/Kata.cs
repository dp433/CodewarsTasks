using System.Collections.Generic;

namespace SumConsecutives
{
	public class Kata
	{
		public static List<int> SumConsecutives1(List<int> sequence)
		{
			var resultSequence = new List<int>();
			var current = sequence[0];
			var count = sequence[0];

			for (var i = 1; i < sequence.Count; i++)
			{
				if (current == sequence[i])
					count += current;
				else
				{
					resultSequence.Add(count);
					count = sequence[i];
					current = sequence[i];
				}
			}
			resultSequence.Add(current);
			return resultSequence;
		}

		public static List<int> SumConsecutives(List<int> sequence)
		{
			var resultSequence = new List<int>();
			var last = sequence[0];
			var count = 0;

			foreach(var n in sequence)
			{
				if (n == last) count += last;
				else
				{
					resultSequence.Add(count);
					count = last = n;
				}
			}
			resultSequence.Add(count);
			return resultSequence;

		}
	}
}
