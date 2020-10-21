using System;
using System.Collections.Generic;
using System.Linq;

namespace NotVerySecure
{
	class Program
	{
		static void Main(string[] args)
		{
			var res = FirstOrDefault(new[] { 1, 2, 3 }, x => x > 2);
			Console.WriteLine(string.Join(" ", res));
			Console.ReadKey();

		}

		private static T FirstOrDefault<T>(IEnumerable<T> source, Func<T, bool> filter)
		{
			foreach (var el in source)
				if (filter(el)) return el;
			return default;
		}

		private static IEnumerable<T> Take<T>(IEnumerable<T> source, int count)
		{
			if (count != 0)
			{
				foreach (var element in source)
				{
					if (count > 0)
						yield return element;
					if (--count == 0)
						yield break;
				}
			}
		}
	}
}
