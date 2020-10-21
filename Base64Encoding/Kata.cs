using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base64Encoding
{
	public class Kata
	{
		public static string ToBase64(string s)
		{
			var bytes = ASCIIEncoding.ASCII.GetBytes(s);
			return Convert.ToBase64String(bytes);
		}

		public static string FromBase64(string s)
		{
			var bytes = Convert.FromBase64String(s);
			return ASCIIEncoding.ASCII.GetString(bytes);
		}
	}
}
