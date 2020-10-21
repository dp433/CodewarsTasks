using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowManyKatas
{
    public class Kata
    {
        public static int SolvedKatasSince(DateTime registrationDate, DateTime currentDate)
        {
            var katasGoal = 0;
            var weekend = new[] { DayOfWeek.Saturday, DayOfWeek.Sunday };

            for (var day = registrationDate; day < currentDate; day = day.AddDays(1))
                if (!weekend.Contains(day.DayOfWeek)) 
                    katasGoal++;

            return katasGoal;
        }

        public static int SolvedKatasSince1(DateTime registrationDate, DateTime currentDate)
        {
            var daysPassed = (int)(currentDate - registrationDate).TotalDays;
            return Enumerable.Range(0, daysPassed)
                .Select(day => (int) registrationDate.AddDays(day).DayOfWeek)
                .Count(day => day != 0 && day != 6);
        }
    }
}
