using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedNumber
{
    public class Kata
    {
        public static string BalancedNumber(int number)
        {
            var strNum = number.ToString();
            string leftSide, rightSide;
            int leftSum, rightSum;

            if (strNum.Length % 2 != 0)
            {
                
                leftSide = strNum.Substring(0, strNum.Length / 2 + 1);
                rightSide = strNum.Substring(strNum.Length / 2);
                leftSum = GetSum(leftSide);
                rightSum = GetSum(rightSide);
            }
            else
            {
                leftSide = strNum.Substring(0, strNum.Length / 2 - 1);
                rightSide = strNum.Substring(strNum.Length / 2 + 1);
                leftSum = GetSum(leftSide);
                rightSum = GetSum(rightSide);
            }

            return leftSum == rightSum ? "Balanced" : "Not Balanced";
        }
        
        private static int GetSum(string side)
        {
            return side.Sum(x => int.Parse(x.ToString()));
        }
    }
}
