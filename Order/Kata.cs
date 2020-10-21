using System.Linq;

namespace Order
{
	public static class Kata
	{
		public static string Order(string words)
		{
			if (words.Length == 0) return string.Empty;
			return string.Join(" ", words.Split()
										.OrderBy(word => word.ToList().Find(c => char.IsDigit(c))));
		}
	}
}
