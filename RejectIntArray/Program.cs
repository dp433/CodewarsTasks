using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RejectIntArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var rejected = Kata.Reject(new int[] { 1, 2, 3, 4, 5, 6 }, (n) => n % 2 == 0);
            foreach (var el in rejected) Console.WriteLine(el);
            Console.ReadKey();
        }
    }
}
