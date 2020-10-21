using NUnit.Framework;
using ArrayDuplicates;
using System;

namespace Tests
{
	[TestFixture]
	class ArrayDuplicatesTest
	{
		[Test]
		public void ExampleTests()
		{
			Assert.AreEqual(new String[] { "codewars", "picaniny", "hubububo" }, Kata.dup(new String[] { "ccooddddddewwwaaaaarrrrsssss", "piccaninny", "hubbubbubboo" }));
			Assert.AreEqual(new String[] { "abracadabra", "alote", "asese" }, Kata.dup(new String[] { "abracadabra", "allottee", "assessee" }));
			Assert.AreEqual(new String[] { "keles", "kenes" }, Kata.dup(new String[] { "kelless", "keenness" }));

		}
	}
}
