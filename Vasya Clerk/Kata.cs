using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace VasyaClerk
{
	public class Kata
	{
		public static string Tickets(int[] peopleInLine)
		{
			var wallet = new Dictionary<int, int>
			{
				{ 25, 0 },
				{ 50, 0 }
			};

			foreach (var cash in peopleInLine)
			{
				WalletValidation(wallet, cash);
				if (wallet[25] < 0)
					return "NO";
			}
			return "YES";
		}

		private static void WalletValidation(Dictionary<int, int> wallet, int cash)
		{
			switch (cash)
			{
				case 25:
					wallet[25]++;
					break;
				case 50:
					wallet[25]--;
					wallet[50]++;
					break;
				case 100:
					if (wallet[50] > 0)
						wallet[50]--;
					else
						wallet[25] -= 2;
					wallet[25]--;
					break;
			}
		}
	}
}
