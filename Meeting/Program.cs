using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = "Alexis:Wahl;John:Bell;Victoria:Schwarz;Abba:Dorny;Grace:Meta;Ann:Arno;Madison:STAN;Alex:Cornwell;Lewis:Kern;Megan:Stan;Alex:Korn";
            var n = Kata.Meeting(test);
            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
