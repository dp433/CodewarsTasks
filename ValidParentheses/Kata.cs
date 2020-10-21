using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidParentheses
{
	public class Kata
	{
		public static bool ValidParentheses(string input)
		{
			var stack = new Stack<char>();
			foreach(var el in input)
			{
				switch (el)
				{
					case '(':
						stack.Push(el);
						break;
					case ')':
						if (stack.Count == 0)
							return false;
						stack.Pop();
						break;
				}
			}
			return stack.Count == 0;
		}
	}
}
