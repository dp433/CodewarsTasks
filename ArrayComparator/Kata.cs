using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayComparator
{
    public class Kata
    {
        public static int MatchArrays1(int[] v, int[] r)
        {
            var counter = 0;
            foreach(var num in v)
            {
                if (r.Contains(num))
                    counter++;
            }
            return counter;
        }

        public static int MatchArrays2(int[] v, int[] r)
        {
            return v.Where(num => r.Contains(num)).Count();
        }

        public static int MatchArrays(int[] v, int[] r)
        {
            HashSet<int> items = new HashSet<int>(v);

            return r.Count(item => items.Contains(item));
        }

    }
}
