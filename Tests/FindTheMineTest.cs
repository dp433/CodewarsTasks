using NUnit.Framework;
using System;
using System.Collections.Generic;
using FIndTheMine;

namespace Tests
{
    [TestFixture]
    class FindTheMineTest
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(new int[,] { { 1, 0 }, { 0, 0 } }).Returns(new Tuple<int, int>(0, 0));
                yield return new TestCaseData(new int[,] { { 1, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } }).Returns(new Tuple<int, int>(0, 0));
                yield return new TestCaseData(new int[,] { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 0 } }).Returns(new Tuple<int, int>(2, 2));
            }
        }

        [Test, TestCaseSource("testCases")]
        public Tuple<int, int> Test(int[,] field) => Kata.MineLocation(field);
    }
}
