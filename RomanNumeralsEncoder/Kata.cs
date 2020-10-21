using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsEncoder
{
	public class Kata
	{
        static int[] arabics = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        static string[] romans = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

        public static string Solution(int n)
        {
            var roman = string.Empty;

            for (var i = 0; n != 0; i++)
            {
                while (n >= arabics[i])
                {
                    n -= arabics[i];
                    roman += romans[i];
                }
            }
            return roman;
        }
    }
}
