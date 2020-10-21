using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumofOddCubedNumbers
{
    public class Kata
    {
        public static int CubeOdd1(int[] arr)
        {
            var sum = 0;

            foreach(var num in arr)
                if (num % 2 != 0)
                    sum += num * num * num;

            return sum;
        }

        public static int CubeOdd(int[] arr)
        {
            return arr
                .Where(num => num % 2 != 0)
                .Select(num => num * num * num)
                .Sum();
        }
    }
}
