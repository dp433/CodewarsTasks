using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingZerosToTheEnd
{
	public class Kata
	{
		public static int[] MoveZeroes(int[] arr)
		{
			return arr.OrderBy(x => x == 0).ToArray();
		}
	}
}
