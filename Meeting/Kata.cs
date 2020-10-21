using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting
{
	public class Kata
	{
		public static string Meeting(string s)
		{
			var names = GetListOfNames(s);
			names.Sort();
			var builder = new StringBuilder();

			foreach (var name in names)
				builder.Append($"({name.Item1}, {name.Item2})");
			return builder.ToString();

		}

		private static List<Tuple<string, string>> GetListOfNames(string s)
		{
			var fullNames = s.ToUpper().Split(';');
			var result = new List<Tuple<string, string>>();

			foreach (var fn in fullNames)
			{
				var name = fn.Split(':');
				result.Add(Tuple.Create(name[1], name[0]));
			}

			return result;
		}

		// 2
		public static string Meeting2(string s)
		{
			var names = s
				 .Split(';')
				 .Select(name => name.ToUpper().Split(':'))
				 .Select(name => Tuple.Create(name[1], name[0]))
				 .ToList();

			names.Sort();
			var builder = new StringBuilder();

			foreach (var name in names)
				builder.Append($"({name.Item1}, {name.Item2})");
			return builder.ToString();
		}

		// 3

		public static string Meeting3(string s)
		{
			return string.Join("",
				s
				.ToUpper().Split(';')
				.Select(fn => fn.Split(':'))
				.OrderBy(fn => fn[1]).ThenBy(fn => fn[0])
				.Select(fn => $"({fn[1]}, {fn[0]})")
				);
		}


	}
}
