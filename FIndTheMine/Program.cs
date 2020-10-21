using System;

namespace FIndTheMine
{
    class Program
    {
        static void Main(string[] args)
        {
            var bomb = Kata.MineLocation(new int[,] { { 1, 0}, { 0, 0} });
            Console.WriteLine(bomb);

            Console.ReadKey();
        }
    }
}
