using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Int32ToIPv4
{
	public class Kata
	{
		public static string UInt32ToIP1(uint ip)
		{
			var ipBinary = Convert.ToString(ip, 2);
			var ipv4 = new List<int>();

			if (ipBinary.Length != 32)
				ipBinary = new string('0', 32 - ipBinary.Length) + ipBinary;

			for (var i = 0; i < ipBinary.Length; i += 8)
			{
				var octet = ipBinary.Substring(i, 8);
				ipv4.Add(Convert.ToInt32(octet, 2));
			}
				
			return string.Join(".", ipv4);
		}

		public static string UInt32ToIP(uint ip)
		{
			var bytes = BitConverter.GetBytes(ip);
			Array.Reverse(bytes);
			return new IPAddress(bytes).ToString();
		}
	}
}
