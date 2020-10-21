using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveToNegativeBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new int[] { 0, 1, 0, 0 };
            var result = Kata.positive2Negative(test);
            
            Console.Write(string.Join(" ", result));

            Console.ReadKey();
        }
    }
}
