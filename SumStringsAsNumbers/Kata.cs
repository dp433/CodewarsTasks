using System.Numerics;

namespace SumStringsAsNumbers
{
	public static class Kata
	{
		public static string sumStrings(string a, string b)
		{
			BigInteger first, second;
			BigInteger.TryParse(a, out first);
			BigInteger.TryParse(b, out second);
			var sum = first + second;

			return sum.ToString();
		}
	}
}
