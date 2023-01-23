using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geek_Brains_Lesson_2
{
    internal class Ex52
    {
        public static double[] AverageArray(int[,] array)
        {


            double[] result = new double[array.GetLength(1)];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    result[j] += ((double)array[i, j] / array.GetLength(0));
                }

            }
            return result;

        }
    }
}
