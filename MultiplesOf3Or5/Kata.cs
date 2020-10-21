using System.Linq;

namespace MultiplesOf3Or5
{
	public class Kata
	{
		public static int Solution(int value)
		{
			var numberToValue = Enumerable.Range(0, value);
			return numberToValue
				.Where(num => num % 3 == 0 || num % 5 == 0)
				.Sum();
		}
	}
}
