using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.GetStrings("Las Vegas"));
            Console.WriteLine(Kata.GetStringsLinq("Las Vegas"));
            Console.ReadKey();

        }
    }
}
