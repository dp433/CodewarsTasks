using NUnit.Framework;
using System;
using MostValuable;



namespace Tests
{
    [TestFixture]
    public class MostValuableTest
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual('a', Kata.solve("a"));
            Assert.AreEqual('a', Kata.solve("aa"));
            Assert.AreEqual('b', Kata.solve("bcd"));
            Assert.AreEqual('x', Kata.solve("axyzxyz"));
            Assert.AreEqual('a', Kata.solve("dcbadcba"));
            Assert.AreEqual('c', Kata.solve("aabccc"));
            Assert.AreEqual('e', Kata.solve("efgefg"));
            Assert.AreEqual('e', Kata.solve("efghijefghi"));
            Assert.AreEqual('a', Kata.solve("acefacef"));
            Assert.AreEqual('a', Kata.solve("acefacefacef"));
        }
    }
}
