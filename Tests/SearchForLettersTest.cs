using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using SearchForLetters;

namespace Tests
{
    [TestFixture]
    class SearchForLettersTest
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData("a **&  bZ")
                                             .Returns("11000000000000000000000001");
                yield return new TestCaseData("!!a$%&RgTT")
                                             .Returns("10000010000000000101000000");
            }
        }

        [Test, TestCaseSource("testCases")]
        public string Test(string input) => SearchForLetters.Kata.Change(input);
    }
}

