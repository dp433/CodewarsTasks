using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementParity
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Solve(new List<int> { 1, -1, 2, -2, 3 }));
            Console.WriteLine(Kata.Solve(new List<int> { -3, 1, 2, 3, -1, -4, -2 }));
            Console.WriteLine(Kata.Solve(new List<int> { 1, -1, 2, -2, 3, 3 }));
            Console.WriteLine(Kata.Solve(new List<int> { -110, 110, -38, -38, -62, 62, -38, -38, -38 }));
            Console.WriteLine(Kata.Solve(new List<int> { -9, -105, -9, -9, -9, -9, 105 }));
            Console.ReadKey();
        }
    }
}
