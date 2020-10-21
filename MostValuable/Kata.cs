using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MostValuable
{
    public class Kata
    {
        public static char solve(string str)
        {
            var mostValuableChar = str[0];
            var mostValuableDiff = 0;
            
            foreach(var c in str)
            {
                var startIndex = str.IndexOf(c);
                var lastIndex = str.LastIndexOf(c);
                var diff = lastIndex - startIndex;

                if (diff > mostValuableDiff)
                {
                    mostValuableChar = c;
                    mostValuableDiff = diff;
                }
                else if (diff == mostValuableDiff &&
                    c < mostValuableChar)
                    mostValuableChar = c;
            }
            return mostValuableChar;
        }
    }
}
