using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentWeekdays
{
	public class Kata
	{
		public static string[] MostFrequentDays(int year)
		{
			var firstDay = new DateTime(year, 1, 1);
			var lastDay = new DateTime(year, 12, 31);
			var dayOfWeekInYear = new Dictionary<DayOfWeek, int>
			{
				{ DayOfWeek.Monday, 0 },
				{ DayOfWeek.Tuesday, 0 },
				{ DayOfWeek.Wednesday, 0 },
				{ DayOfWeek.Thursday, 0 },
				{ DayOfWeek.Friday, 0 },
				{ DayOfWeek.Saturday, 0 },
				{ DayOfWeek.Sunday, 0 }
			};
			
			for (var day = firstDay; day <= lastDay; day = day.AddDays(1))
				dayOfWeekInYear[day.DayOfWeek]++;

			var max = dayOfWeekInYear.Max(d => d.Value);
			return dayOfWeekInYear
				.Where(day => day.Value == max)
				.Select(day => day.Key.ToString())
				.ToArray();
		}
	}
}
