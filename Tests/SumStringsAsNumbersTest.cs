using System;
using NUnit.Framework;
using SumStringsAsNumbers;

namespace Tests
{
	[TestFixture]
	class SumStringsAsNumbersTest
	{
		[Test]
		[TestCase("579", "123", "456")]
		public void SumOfStrings(string result, string first, string second)
		{
			Assert.AreEqual(result, Kata.sumStrings(first, second));
		}
	}
}
