using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] array =
            {
                new []{1, 2, 3},
                new []{4, 5, 6},
                new []{7, 8, 9}
            };
            var snail = Kata.Snail(array);
            var print = string.Join(" ", snail);

            Console.WriteLine(print);

            Console.ReadKey();
        }
    }
}
