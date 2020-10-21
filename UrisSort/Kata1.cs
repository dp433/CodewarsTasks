using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrisSort
{
    public static class Kata1
    {
        readonly static string[] mainTLD = new[] { ".com", ".gov", ".org" };

        private static string GetTLD(this string input) =>
            Path.GetExtension(new Uri(input).Host);

        public static IEnumerable<string> OrderByDomainNew(this IEnumerable<string> source)
		{
            var main = source.Where(url => mainTLD.Contains(url.GetTLD()));
            var other = source.Where(url => !main.Contains(url));
            return main.OrderBy(url => url.GetTLD()).Concat(other.OrderBy(url => url.GetTLD()));
        }
            
    }
}
