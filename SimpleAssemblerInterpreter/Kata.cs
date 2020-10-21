using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAssemblerInterpreter
{
	public class Kata
	{
		public static Dictionary<string, int> Interpret(string[] program)
		{
			var result = new Dictionary<string, int>();
			int GetValue(string s) => int.TryParse(s, out int temp) ? temp : result[s];

			for (var i = 0; i < program.Length; i++)
			{
				var command = program[i].Split();
				var name = command[0];
				var variable = command[1];

				switch (name)
				{
					case "mov":
						var opt = command[2];
						result[variable] = GetValue(opt);
						break;
					case "inc":
						result[variable]++;
						break;
					case "dec":
						result[variable]--;
						break;
					case "jnz":
						var step = command[2];
						if(GetValue(variable) != 0) 
							i += int.Parse(step) - 1;
						break;
				}
			}
			return result;
		}
	}
}
