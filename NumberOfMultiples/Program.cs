using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfMultiples
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Kata.Multiples(3, 5.0);
            foreach(var num in nums)
                Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}
