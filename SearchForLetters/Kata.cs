using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchForLetters
{
    public class Kata
    {
        public static string Change(string input)
        {
            var alphabet = "abcdefghijklmnopqrstuvwxyz";
            var result = Enumerable.Repeat('0', 26).ToArray();

            foreach (var el in input.ToLower())
            {
                if (alphabet.Contains(el)) result[alphabet.IndexOf(el)] = '1';
            }
            return new string(result);
        }

        public static string Change1(string input)
        {
            return string
                .Concat("abcdefghijklmnopqrstuvwxyz"
                .Select(c => input.ToLower().Contains(c) ? '1' : '0'));
        }
    }
}
