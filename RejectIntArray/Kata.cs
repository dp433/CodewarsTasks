using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace RejectIntArray
{
    public class Kata
    {
        public static int[] Reject(int[] array, Func<int, bool> predicate)
        {
            return array
              .Where(num => !predicate(num))
              .ToArray();
        }
    }
}
