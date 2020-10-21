using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MaxMinArrays
{
	public class Kata
	{
		public static List<int> Solve(List<int> list)
		{
			var arr = list.OrderBy(x => x).ToList();
			var len = arr.Count();
			var result= new List<int>(new int[len]);

			var low = 0;
			var high = len - 1;
			var flag = true;

			for (var i = 0; i < len; i++)
			{
				if (flag)
					result[i] = arr[high--];
				else
					result[i] = arr[low++];

				flag = !flag;
			}
			return result;
		}
	}
}
