using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace UrisSort
{
	public static class Kata
	{
		public static IEnumerable<string> OrderByDomain(this IEnumerable<string> source) =>
			source.OrderBy(url => url, new DomainComparer());
	}


	class DomainComparer : IComparer<string>
	{
		public int Compare(string x, string y)
		{
			var domains = new Dictionary<string, int> { { ".com", 1 }, { ".gov", 10 }, { ".org", 20 } };
			var hostX = new Uri(x).Host;
			var hostY = new Uri(y).Host;

			var domainX = Path.GetExtension(hostX);
			var domainY = Path.GetExtension(hostY);

			const int notFound = 50;
			var xValue = notFound;
			var yValue = notFound;

			if (domains.ContainsKey(domainX))
				xValue = domains[domainX];

			if (domains.ContainsKey(domainY))
				yValue = domains[domainY];

			if (xValue == yValue)
			{
				if (xValue == notFound)
					return string.Compare(domainX, domainY, StringComparison.Ordinal);
				return 0;
			}
			
			if (xValue == notFound) return 1;
			if (yValue == notFound) return -1;
			return xValue - yValue;
		}
	}
}
