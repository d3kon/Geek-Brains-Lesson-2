using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geek_Brains_Lesson_2
{
    internal class Ex58
    {
        public static int[,] MatrixMultiplication()
        {
            int[,] array1 = new int[,] { { 2, 4 }, { 3, 2 } };
            int[,] array2 = new int[,] { { 3, 4 }, { 3, 3 } };
            int[,] result = new int[array1.GetLength(0), array1.GetLength(1)];

            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    for (int k = 0; k < array2.GetLength(1); k++)
                    {
                        result[i, j] += array1[i, k] * array2[k, j];
                    }
                }
            }
            return result;
        }
    }
}
