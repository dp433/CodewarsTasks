using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InterviewQuestion
{
    public class Kata
    {
        public static string GetStrings(string city)
        {
            var letters = GetLettersDictionary(city);
            var result = string.Join(",", letters.Select(x => $"{x.Key}:{x.Value}").ToArray());

            return result;
        }

        private static Dictionary<char, string> GetLettersDictionary(string city)
        {
            var exeptedSymols = new[] { '-', ' ', '!' };
            var letters = new Dictionary<char, string>();

            foreach (var el in city.ToLower())
            {
                if (!exeptedSymols.Contains(el))
                {
                    if (!letters.ContainsKey(el)) letters.Add(el, "*");
                    else letters[el] += "*";
                }
            }
            return letters;
        }

        public static string GetStringsLinq(string city)
        {
            var result = city
                .ToLower()
                .Where(c => c != ' ')
                .GroupBy(c => c)
                .Select(g => $"{g.Key}:{new string('*', g.Count())}");

            return string.Join(",", result);
        }
    }
}
