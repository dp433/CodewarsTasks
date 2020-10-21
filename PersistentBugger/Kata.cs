using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistentBugger
{
	public class Kata
	{
		public static int Persistence(long n)
		{
			Func<int,char,int> multiply = (x, y) => x * (int)char.GetNumericValue(y);
			var counter = 0;
			while (n > 9)
			{
				n = n.ToString().Aggregate(1, multiply);
				counter++;
			}
			return counter;
		}
	}
}
