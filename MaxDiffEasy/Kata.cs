using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxDiffEasy
{
    public class Kata
    {
        public static int maxDiffSlow(int[] lst)
        {
            if (lst.Length == 0) return 0;
            Array.Sort(lst);
            return lst.Last() - lst.First();
        }

        public static int maxDiff(int[] lst)
        {
            return lst.Length != 0 ? lst.Max() - lst.Min() : 0;
        }

    }
}
