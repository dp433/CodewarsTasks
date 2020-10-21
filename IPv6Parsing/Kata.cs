using System;
using System.Text;

namespace IPv6Parsing
{
	public static class Kata
	{
		public static string ParseIPv6(string iPv6)
		{
			var result = new StringBuilder();
			var part = 0;
			foreach (var el in iPv6)
			{
				if (el.IsHex())
					part += Convert.ToInt32(el.ToString(), 16);
				else
				{
					result.Append(part);
					part = 0;
				}
			}
			result.Append(part);
			return result.ToString();
		}

		private static bool IsHex(this char c) =>
			((c >= '0' && c <= '9') ||
			(c >= 'A' && c <= 'F'));
	}
}
