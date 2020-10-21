﻿using NUnit.Framework;
using System;
using HowManyKatas;

namespace Tests
{
    [TestFixture]
    public class HowManyKatasTest
    {
        [Test]
        public void One_Day_Should_Return_1_Finished_Kata()
        {
            Assert.AreEqual(1, HowManyKatas.Kata.SolvedKatasSince(new DateTime(2018, 01, 01), new DateTime(2018, 01, 2)));
        }

        [Test]
        public void One_Week_Should_Return_5_Finished_Katas()
        {
            Assert.AreEqual(5, HowManyKatas.Kata.SolvedKatasSince(new DateTime(2018, 01, 01), new DateTime(2018, 01, 08)));
        }

        [Test]
        public void Four_Weeks_Should_Return_20_Finished_Katas()
        {
            Assert.AreEqual(20, HowManyKatas.Kata.SolvedKatasSince(new DateTime(2018, 01, 01), new DateTime(2018, 01, 29)));
        }

        [Test]
        public void April_2018_Should_Return_21_Finished_Katas()
        {
            Assert.AreEqual(21, HowManyKatas.Kata.SolvedKatasSince(new DateTime(2018, 04, 01), new DateTime(2018, 05, 01)));
        }

        [Test]
        public void Year_2017_Should_Return_260_Finished_Katas()
        {
            Assert.AreEqual(260, HowManyKatas.Kata.SolvedKatasSince(new DateTime(2017, 01, 01), new DateTime(2017, 12, 31)));
        }
    }
}
