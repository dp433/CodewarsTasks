using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotVerySecure
{
	public class Kata
	{

		public static bool Alphanumeric(string str)
		{
			return str.All(c => char.IsLetterOrDigit(c) && string.IsNullOrEmpty(str));
		}
	}
}
