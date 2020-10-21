namespace SumOfPositive
{
    public class Kata
    {
        public static int PositiveSum(int[] arr)
        {
            var sumOfPositive = 0;
            foreach(var num in arr)
                if (num >= 0)
                    sumOfPositive += num;
            return sumOfPositive;
        }
    }
}
