using NUnit.Framework;
using UrisSort;
using System;

namespace Tests
{
	[TestFixture]
	class UrisSortTest
	{
        [Test]
        public void SimpleTests()
        {
            var source = new[] {
          "http://www.google.en/?x=jsdfkj",
          "http://www.google.de/?x=jsdfkj",
          "http://www.google.com/?x=jsdfkj",
          "http://www.google.com/?x=jsdfkj",
          "http://www.google.org/?x=jsdfkj",
          "http://www.google.gov/?x=jsdfkj",
      };
            var result = source.OrderByDomain();

			//Assert.IsTrue(SortingTaskUtils.AreDomainsEquals(result, source));

			//should be sorted  to
			//"http://www.google.com/?x=jsdfkj",
			//"http://www.google.com/?x=jsdfkj",
			//"http://www.google.gov/?x=jsdfkj",
			//"http://www.google.org/?x=jsdfkj",
			//"http://www.google.de/?x=jsdfkj",
			//"http://www.google.en/?x=jsdfkj",
		}
    }
}
