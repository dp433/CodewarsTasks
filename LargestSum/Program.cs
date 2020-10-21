using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var LargestSum = Kata.LargestPairSum(new int[] { -8, -8, -16, -18, -19 });
            Console.WriteLine(LargestSum);
            Console.ReadKey();
        }
    }
}
