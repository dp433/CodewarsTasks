using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Kata.CompleteSeries(new[] { 1, 4, 4, 6 });
            foreach(var el in arr)
                Console.WriteLine(el);
            Console.ReadKey();
        }
    }
}
