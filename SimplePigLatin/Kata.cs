using System.Linq;

namespace SimplePigLatin
{
	public class Kata
	{
		public static string PigIt(string str)
		{
			var arr = str.Split();
			
			for(var i = 0; i < arr.Length; i++)
			{
				if (char.TryParse(arr[i], out char result))
					if (char.IsPunctuation(result))
						continue;
				arr[i] = $"{arr[i].Substring(1)}{arr[i].First()}{"ay"}"; 
			}
			return string.Join(" ", arr);
		}
	}
}
