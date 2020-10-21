using System;
using System.Collections;
using System.Linq;
using System.Text.RegularExpressions;

namespace PhoneDirectory
{
	public class Kata
	{
		public static string Phone(string strng, string num)
		{
			Console.WriteLine(strng);
			var numCount = Regex.Matches(strng, num).Count;

			if (numCount == 0)
				return $"Error => Not found: {num}";
			if (numCount != 1)
				return $"Error => Too many people: {num}";

			var data = ParseData(strng, num);
			var name = ParseName(data);
			var address = ParseAddress(data, num, name);

			return $"Phone => {num}, Name => {name}, Address => {address}";
		}

		private static string ParseName(string data)
		{
			var startIndex = data.IndexOf('<') + 1;
			var length = data.IndexOf('>') - startIndex;
			return data.Substring(startIndex, length);
		}

		private static string ParseData(string strng, string num) =>
			strng.Split('\n').Where(x => x.Contains(num)).Take(1).First();

		private static string ParseAddress(string data, string num, string name)
		{
			var r1 = Regex.Replace(data, num, "");
			var r2 = Regex.Replace(r1, name, "");
			var r3 = Regex.Replace(r2, @"[_\/*<>+;$?!,:]", " ");
			var address = string.Join(" ",
				r3.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
			return address;
		}
	}
}
