using System;
using System.Linq;

namespace SingleCharacterPalindromes
{
	public static class Kata
	{
		public static string solve(string s)
		{
			if (s.IsPalindrome()) return "OK";
			for (int i = 0; i < s.Length; i++)
				if (s.Remove(i, 1).IsPalindrome()) return "remove one";
			return "not possible";
		}

		private static bool IsPalindrome(this string s)
	  => s.Reverse().SequenceEqual(s);
	}
}
