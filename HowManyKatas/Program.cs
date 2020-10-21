using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowManyKatas
{
    public class Program
    {
        static void Main(string[] args)
        {
            var time1 = new DateTime(2018, 1, 2);
            var time2 = new DateTime(2018, 1, 1);
            Console.WriteLine(Kata.SolvedKatasSince(time1, time2));
            Console.WriteLine(time1.Day);
            Console.ReadKey();
        }
    }
}