using System.Linq;

namespace PositiveToNegativeBinary
{
    public class Kata
    {
        public static int[] positive2Negative(int[] binaryArray)
        {
            //Flip the bits
            var flippedBits = binaryArray.Select(n => n == 0 ? n = 1 : n = 0).ToList();

            //Add 1
            var lastIndexOfZero = flippedBits.LastIndexOf(0);
            if (lastIndexOfZero != -1)
            {
                flippedBits[lastIndexOfZero] = 1;

                for (var i = lastIndexOfZero + 1; i < flippedBits.Count; i++)
                    flippedBits[i] = 0;
                return flippedBits.ToArray();
            }
            return binaryArray;  
        }
    }
}
