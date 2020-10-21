using System;
using NUnit.Framework;
using NextMultipleOfFive;

namespace Tests
{
    [TestFixture]
    public class NextMultipleOfFiveTest
    {
        [Test]
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(1, ExpectedResult = 5)]
        [TestCase(3, ExpectedResult = 5)]
        [TestCase(5, ExpectedResult = 5)]
        [TestCase(7, ExpectedResult = 10)]
        [TestCase(39, ExpectedResult = 40)]
        public static int FixedTest(int n)
        {
            return NextMultipleOfFive.Kata.RoundToNext5(n);
        }
    }
}
