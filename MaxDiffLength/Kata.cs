using System;
using System.Linq;

namespace MaxDiffLength
{
    public class Kata
    {
        public static int Mxdiflg(string[] a1, string[] a2)
        {
            if (a1.Length == 0 || a2.Length == 0)
                return -1;
            var res1 = Math.Abs(a1.Max(word => word.Length) - a2.Min(word => word.Length));
            var res2 = Math.Abs(a2.Max(word => word.Length) - a1.Min(word => word.Length));
            return Math.Max(res1, res2);
        }
    }
}
