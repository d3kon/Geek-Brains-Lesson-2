using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geek_Brains_Lesson_2
{
    internal class Ex56
    {
        public static void SumOfRows(ref int m, ref int n, int[,] arr)
        {
            // Создание массива массивов (jagged array)
            int[][] jArr = new int[arr.GetLength(0) + 1][];

            // Инициализация подмассивов jArr
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                jArr[i] = new int[arr.GetLength(1)];
            }

            jArr[arr.GetLength(0)] = new int[arr.GetLength(0)];

            // Копирование строк из источника в подмассивы
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    jArr[i][j] = arr[i, j];
                }
            }

            // Вычисление суммы строк и запись их в доп подмассив.
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    jArr[arr.GetLength(0)][i] += jArr[i][j];
                }
            }

            Console.WriteLine($"Строка {Array.IndexOf(jArr[arr.GetLength(0)], jArr[arr.GetLength(0)].Min()) + 1} имеет наименьшую сумму.");

        }
    }
}
