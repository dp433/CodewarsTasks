using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueInOrder
{
	public class Kata
	{
		public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
		{
			T prev = default;
			foreach(var element in iterable)
			{
				if (element.Equals(prev))
					continue;
				prev = element;
				yield return element;
			}
		}
	}
}
