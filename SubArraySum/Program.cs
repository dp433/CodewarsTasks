using System;

namespace SubArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new[] { new[] { 3, 2, 1, 0 }, new[] { 4 }, new[] { 9, 8, 7, 4 } };

            Console.WriteLine(Kata.ElementsSum(test));
            Console.WriteLine(test.Length);
            Console.ReadKey();
        }
    }
}
