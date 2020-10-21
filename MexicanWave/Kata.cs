using System.Collections.Generic;

namespace MexicanWave
{
	public class Kata
	{
		public List<string> wave(string str)
		{
			var result = new List<string>();
			for (var i = 0; i < str.Length; i++)
			{
				var arr = str.ToCharArray();
				if (char.IsWhiteSpace(arr[i]))
					continue;
				arr[i] = char.ToUpper(arr[i]);
				result.Add(new string(arr));
			}
			return result;
		}
	}
}
