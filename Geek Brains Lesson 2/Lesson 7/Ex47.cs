using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Geek_Brains_Lesson_2
{
    internal class Ex47
    {
        public static int[,] SDimArray(int m, int n)
        {
            int[,] array = new int[m, n];
            var rnd = new Random();

            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = rnd.Next(-100, 100);
                }
            }

            // Показ массива в консоль
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }
            return array;
        }
    }
}
