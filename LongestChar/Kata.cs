using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestChar
{
	public class Kata
	{
		public static Tuple<char?, int> LongestRepetition(string input)
		{
			if (input.Length == 0) return Tuple.Create((char?)null, 0);
			var current = new StringBuilder();
			var longest = new StringBuilder();
			current.Append(input[0]);


			for (var i = 1; i < input.Length; i++)
			{
				if (current[0] == input[i])
					current.Append(input[i]);
				else if (current[0] != input[i] && current.Length > longest.Length)
				{
					longest.Clear();
					longest.Append(current);
					current.Clear();
					current.Append(input[i]);
				}
				else
				{
					current.Clear();
					current.Append(input[i]);
				}
			}
			if (current.Length <= longest.Length)
				return Tuple.Create((char?)longest[0], longest.Length);
			return Tuple.Create((char?)current[0], current.Length);
		}

		public static Tuple<char?, int> LongestRepetition1(string input)
		{
			if (input.Length == 0) return Tuple.Create((char?)null, 0);
			var longestRepeatedChar = new char();
			var longestLenght = 0;
			var currentChar = input[0];
			var currentLenght = 1;
			
			for(var i = 1; i < input.Length ; i++)
			{
				if (currentChar == input[i])
					currentLenght++;

				if (currentLenght > longestLenght)
				{
					longestRepeatedChar = currentChar;
					longestLenght = currentLenght;
				}

				if (currentChar != input[i])
				{
					currentChar = input[i];
					currentLenght = 1;
				}
				
			}
			return Tuple.Create((char?)longestRepeatedChar, longestLenght);
		}
	}
}
