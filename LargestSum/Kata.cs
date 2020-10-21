using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestSum
{
    public class Kata
    {
        public static int LargestPairSum(int[] numbers)
        {
            var max = int.MinValue;
            var secondMax = int.MinValue;

            for (var i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max && numbers[i] > secondMax)
                {
                    secondMax = max;
                    max = numbers[i];
                }
                else if (numbers[i] <= max && numbers[i] > secondMax)
                {
                    secondMax = numbers[i];
                }
            }
            return max + secondMax;
        }
    }
}
