﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidParentheses
{
	class Program
	{
		static void Main(string[] args)
		{
			var t = "hi(hi)";
			Console.WriteLine(Kata.ValidParentheses(t));
			Console.ReadKey();
		}
	}
}
