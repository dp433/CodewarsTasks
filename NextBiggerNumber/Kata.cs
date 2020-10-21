using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NextBiggerNumber
{
	public class Kata
	{
		static void Swap(char[] arr, int i, int j)
		{
			var temp = arr[i];
			arr[i] = arr[j];
			arr[j] = temp;
		}

		public static long NextBiggerNumber(long n)
		{
			var arr = n.ToString().ToArray();

			int i;

			//Check possibility
			for (i = arr.Length - 1; i > 0; i--)
				if (arr[i] > arr[i - 1])
					break;
			if (i == 0) return -1;

			//Find position(index) with smallest digit from right side
			var x = arr[i - 1];
			var min = i;

			for (var j = i + 1; j < arr.Length; j++)
				if (arr[j] > x && arr[j] < arr[min])
					min = j;

			//Swap digits and get next bigger (long) number
			Swap(arr, i - 1, min);
			Array.Sort(arr, i, arr.Length - i);

			return long.Parse(string.Concat(arr));
		}

		static string GetNumbers(long n) =>
			string.Concat(n.ToString().OrderByDescending(x => x));

		public static long NextBiggerNumber1(long n)
		{
			var str = GetNumbers(n);
			for (var i = n + 1; i <= long.Parse(str); i++)
				if (GetNumbers(n) == GetNumbers(i))
					return i;
			return -1;
		}
	}
}
