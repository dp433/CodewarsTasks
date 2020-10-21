using System.Linq;

namespace IQTest
{
	public class Kata
	{
		public static int Test(string numbers)
		{
			var arr = numbers.Split();
			var oddIndex = 0;
			var evenIndex = 0;
			var odd = 0;
			var even = 0;

			for (var i = 0; i < arr.Length; i++)
			{
				if ((odd > 1 && even == 1) || (even > 1 && odd == 1))
					break;

				var num = int.Parse(arr[i]);
				if (num % 2 == 0)
				{
					evenIndex = i + 1;
					even++;
				}
				else
				{
					oddIndex = i + 1;
					odd++;
				}
			}

			return odd == 1 ? oddIndex : evenIndex;
		}

		public static int Test1(string numbers)
		{
			var arr = numbers.Split().Select((v, i) => new { Value = int.Parse(v), Index = i + 1 });
			var even = arr.Where(x => x.Value % 2 == 0);
			var odd = arr.Where(x => x.Value % 2 != 0);

			return even.Count() == 1 ? even.First().Index : odd.First().Index;
		}
	}
}
