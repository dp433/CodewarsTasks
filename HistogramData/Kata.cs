using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HistogramData
{
    public class Kata
    {
        public static uint[] Histogram(uint[] data, uint binWidth)
        {
            if (data.Length == 0) return new uint[0];

            var hist = new uint[data.Max() / binWidth + 1];

            foreach (var num in data) 
                hist[num / binWidth]++;

            return hist;
        }
    }
}
