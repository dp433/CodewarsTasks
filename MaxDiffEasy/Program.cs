using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxDiffEasy
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new[] { 5, 20, 10 };

            Console.WriteLine(Kata.maxDiff(test));

            Console.ReadKey();
        }
    }
}
