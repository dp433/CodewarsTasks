using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIndTheMine
{
    public class Kata
    {
        public static Tuple<int, int> MineLocation(int[,] field)
        {
            var rows = field.GetLength(0);
            var columns = field.GetLength(1);

            for (var i = 0; i < rows; i++)
                for (var j = 0; j < columns; j++)
                    if (field[i, j] == 1)
                        return Tuple.Create(i, j);

            throw new Exception("Bomb is not found");
        }
    }
}
