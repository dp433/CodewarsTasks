using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace CreatePhoneNumber
{
	public class Kata
	{
		public static string CreatePhoneNumber(int[] numbers)
		{
			var first = MakePhonePart(numbers, 0, 3);
			var second = MakePhonePart(numbers, 3, 3);
			var third = MakePhonePart(numbers, 6, 4);
			return $"({first}) {second}-{third}";
		}

		private static string MakePhonePart(int[] numbers, int skipNumbers, int length) =>
			string.Join("",numbers.Skip(skipNumbers).Take(length));

	}
}
