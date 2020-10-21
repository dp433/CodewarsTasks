using NUnit.Framework;
using MultiplesOf3Or5;

namespace Tests
{
	[TestFixture]
	class MultiplesOf3Or5Test
	{
		[Test]
		public void Test()
		{
			Assert.AreEqual(23, Kata.Solution(10));
		}
	}
}
