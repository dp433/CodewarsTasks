using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SubArraySum
{
    public class Kata
    {
        public static int ElementsSum1(int[][] arr, int d = 0)
        {
            var result = 0;

            for(var i = 0; i < arr.Length; i++)
                result += arr[i].Length >= arr.Length - i ? arr[i][arr.Length - i - 1] : d;

            return result;
        }
        public static int ElementsSum(int[][] arr, int d = 0)
        {
            return arr
                .Select((sub, i) => sub.Length >= arr.Length - i ? sub[arr.Length - i - 1] : d)
                .Sum();
        }
    }
}
