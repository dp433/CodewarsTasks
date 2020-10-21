using ROT13;
using NUnit.Framework;


namespace Tests
{
	[TestFixture]
	class ROT13Test
	{
		[Test]
		public void Test1()
		{
			Assert.AreEqual("ROT13 example.", Kata.Rot13("EBG13 rknzcyr."));
		}
	}
}
