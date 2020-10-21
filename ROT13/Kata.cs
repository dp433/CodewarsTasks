using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROT13
{
	public class Kata
	{
		public static string Rot13(string input)
		{
			var intab = "NOPQRSTUVWXYZABCDEFGHIJKLMnopqrstuvwxyzabcdefghijklm";
			var outab = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
			var rot13Table = MakeTable(intab, outab);
			var result = new StringBuilder();

			foreach (var el in input)
				if (rot13Table.ContainsKey(el)) result.Append(rot13Table[el]);
				else result.Append(el);
			return result.ToString();
		}

		private static Dictionary<char, char> MakeTable(string intab, string outab) =>
			Enumerable.Range(0, intab.Length).ToDictionary(k => intab[k], k => outab[k]);
	}
}
