using System;

namespace NextMultipleOfFive
{
    public class Kata
    {
        public static int RoundToNext5(int n)
        {
            return (int)Math.Ceiling(n/5.0)*5;
        }
    }
}
