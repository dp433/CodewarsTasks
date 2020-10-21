using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfMultiples
{
    public class Kata
    {
        public static double[] Multiples(int m, double n)
        {
            var result = new double[m];

            for (var i = 0; i < m; i++)
                result[i] = (i + 1) * n;

            return result;
        }

    }
}
