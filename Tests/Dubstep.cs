using NUnit.Framework;
using System;
using Dubstep;

namespace Tests
{
	[TestFixture]
	class Dubstep
	{
        [Test]
        public void Test1()
        {
            Assert.AreEqual("ABC", Kata.SongDecoder("WUBWUBABCWUB"));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual("R L", Kata.SongDecoder("RWUBWUBWUBLWUB"));
        }
    }
}
