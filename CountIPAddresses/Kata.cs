using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountIPAddresses
{
	public class Kata
	{
		public static long IpsBetween(string start, string end)
		{
			return GetIpValue(end) - GetIpValue(start);
		}

		private static int GetIpValue(string ip)
		{
			var splittedIp = ip.Split('.');
			var ipValue = 0;
			for (var i = 0; i < splittedIp.Length; i++)
				ipValue += int.Parse(splittedIp[i]) << (24 - i * 8);
			return ipValue;
		}
	}
}
