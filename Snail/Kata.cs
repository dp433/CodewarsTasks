using System.Collections.Generic;

namespace Snail
{
    class Direction
    {
        public int Right { get; set; }
        public int Left { get; set; }
        public int Top { get; set; }
        public int Bottom { get; set; }
        public int Current { get; set; }

        public Direction(int rigth, int left, int top, int bottom, int current)
        {
            Right = rigth;
            Left = left;
            Top = top;
            Bottom = bottom;
            Current = current;
        }
    }

    public class Kata
    {
        public static int[] Snail(int[][] array)
        {
            if (array.Length <= 1) return array[0];

            var snailList = new List<int>();
            var arrayLen = array.Length * array.Length;
            var direction = new Direction(0, 0, 0, 0, 0);
            for (var i = 0; i < arrayLen; i++)
                Iteration(direction, array, snailList);
            return snailList.ToArray();
        }

        private static void Iteration(Direction direction, int[][] array, List<int> snailList)
        {
            switch (direction.Current %= 4)
            {
                case 0:
                    for (var i = direction.Left; i < array.Length - direction.Right; i++)
                        snailList.Add(array[direction.Top][i]);
                    direction.Top++;
                    break;
                case 1:
                    for (var i = direction.Top; i < array.Length - direction.Bottom; i++)
                        snailList.Add(array[i][array.Length - direction.Right - 1]);
                    direction.Right++;
                    break;
                case 2:
                    for (var i = array.Length - direction.Right - 1; i >= direction.Left; i--)
                        snailList.Add(array[array.Length - direction.Bottom - 1][i]);
                    direction.Bottom++;
                    break;
                default:
                    for (var i = array.Length - direction.Bottom - 1; i >= direction.Right; i--)
                        snailList.Add(array[i][direction.Left]);
                    direction.Left++;
                    break;
            }
            direction.Current++;
        }
    }
}
