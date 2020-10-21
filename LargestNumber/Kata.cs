using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestNumber
{
    public class Kata
    {
        public static int GetNumber(string str)
        {
            var sub = str.Substring(0, str.Length - 4);
            var subMax = sub.Max(x => x);
            var bigNum = "";

            for (var i = sub.IndexOf(subMax.ToString()); i < sub.Length; i++)
            {
                if (subMax == sub[i])
                {
                    var newNum = str.Substring(i, 5);
                    bigNum = newNum.CompareTo(bigNum) == 1 ? newNum : bigNum;
                }
            }
            return int.Parse(bigNum);
        }
        public static int GetNumber1(string str)
        {
            return Enumerable
                .Range(0, str.Length - 4)
                .Select(i => Convert.ToInt32(str.Substring(i, 5)))
                .ToList()
                .Max();
        }
    }
}
