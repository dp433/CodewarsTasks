using System;
using NUnit.Framework;
using PersistentBugger;

namespace Tests
{
	[TestFixture]
	class PersistentBuggerTest
	{
		[Test]
		public void Test1()
		{
			Console.WriteLine("****** Basic Tests");
			Assert.AreEqual(3, Kata.Persistence(39));
			Assert.AreEqual(0, Kata.Persistence(4));
			Assert.AreEqual(2, Kata.Persistence(25));
			Assert.AreEqual(4, Kata.Persistence(999));
		}
	}
}
