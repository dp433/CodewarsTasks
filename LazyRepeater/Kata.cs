using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LazyRepeater
{
	public class Kata
	{
		public static Func<char> MakeLooper(string str)
		{
			var enumerator = str.GetEnumerator();

			char GetNextChar()
			{
				if (!enumerator.MoveNext())
				{
					enumerator.Reset();
					enumerator.MoveNext();
				}
				return enumerator.Current;
			}
			return GetNextChar;
		}
	}
}
