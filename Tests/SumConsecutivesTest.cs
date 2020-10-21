using System;
using System.Collections.Generic;
using NUnit.Framework;
using SumConsecutives;

namespace Tests
{
	class SumConsecutivesTest
	{
        [Test]
        public static void test1()
        {
            List<int> i = new List<int> { 1, 4, 4, 4, 0, 4, 3, 3, 1 };
            List<int> o = new List<int> { 1, 12, 0, 4, 6, 1 };
            Console.WriteLine("Input: {1,4,4,4,0,4,3,3,1}");
            Assert.AreEqual(o, Kata.SumConsecutives(i));
            i = new List<int> { -5, -5, 7, 7, 12, 0 };
            o = new List<int> { -10, 14, 12, 0 };
            Console.WriteLine("Input: {-5,-5,7,7,12,0}");
            Assert.AreEqual(o, Kata.SumConsecutives(i));
        }
    }
}
