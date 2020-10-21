using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteSeries
{
    public class Kata
    {
        public static int[] CompleteSeries(int[] arr)
        {
            var max = arr.Max();
            var result = new int[max + 1];
            for (var i = 0; i <= max; i++)
                if (arr.Count(num => num == i) <= 1) result[i] = i;
                else return new[] { 0 };
            return result;
        }
    }
}
