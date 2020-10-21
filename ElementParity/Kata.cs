using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementParity
{
    public class Kata
    {
        public static int LinqSolve(List<int> arr)
        {
            foreach (var num in arr)
                if (!arr.Contains(-num))
                    return num;
            return 0;
        }

        public static int Solve(List<int> arr)
        {
            return arr.Distinct().Sum();
        }

    }
}
