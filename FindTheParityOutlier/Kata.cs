using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheParityOutlier
{
    public class Kata
    {
        public static int Find(int[] integers)
        {
            var oddCounter = 0;
            var evenCounter = 0;
            var oddOutlier = 0;
            var evenOutlier = 0;

            foreach (var num in integers)
            {
                if (num % 2 == 0)
                {
                    evenCounter += 1;
                    if (evenCounter == 1)
                        evenOutlier = num;
                }
                else
                {
                    oddCounter += 1;
                    if (oddCounter == 1)
                        oddOutlier = num;
                }
            }
            return oddCounter < evenCounter ? oddOutlier : evenOutlier;
        }
    }
}