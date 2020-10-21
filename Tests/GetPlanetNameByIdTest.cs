using NUnit.Framework;
using GetPlanetNameByID;

namespace Tests
{
    class GetPlanetNameByIdTest
    {
        [TestFixture]
        public class SolutionTest
        {
            [Test]
            public void Test()
            {
                Assert.AreEqual("Venus", Kata.GetPlanetName(2));
                Assert.AreEqual("Jupiter", Kata.GetPlanetName(5));
            }
        }
    }
}
