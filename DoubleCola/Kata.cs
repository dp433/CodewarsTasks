using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleCola
{
	public class Kata
	{
        public static string WhoIsNext(string[] names, long n)
        {
            n--;
            while (n >= names.Length)
            {
                n = (long)Math.Floor((double)(n - names.Length) / 2);
            }
            return names[n];
        }
    }
}
