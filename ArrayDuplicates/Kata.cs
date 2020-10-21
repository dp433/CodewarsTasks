using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDuplicates
{
	public class Kata
	{
		public static string[] dup(string[] arr)
		{
			var result = new string[arr.Length];
			for (var i = 0; i < arr.Length; i++)
			{
				var builder = new StringBuilder();
				var word = arr[i];
				builder.Append(word.First());
				for(var j = 1; j < word.Length; j++)
				{
					var prev = word[j - 1];
					var curr = word[j];
					if (prev != curr)
						builder.Append(curr);
				}
				result[i] = builder.ToString();
				builder.Clear();
			}
			return result;
		}
	}
}
