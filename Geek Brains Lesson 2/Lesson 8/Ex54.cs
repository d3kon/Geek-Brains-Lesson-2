using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Geek_Brains_Lesson_2
{
    internal class Ex54
    {
        public static void SortRows(ref int m, ref int n, int[,] array)
        {
            // Создание массива массивов (jagged array)
            int[][] jArr = new int[array.GetLength(0)][];

            // Инициализация подмассивов jArr
            for (int i = 0; i < array.GetLength(0); i++)
            {
                jArr[i] = new int[array.GetLength(1)];
            }

            // Копирование строк из источника в подмассивы
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    jArr[i][j] = array[i, j];
                }
            }

            // Сортировка пузырьком в порядке убывания
            for (int i = 0; i < jArr.Length; i++)
            {
                jArr[i] = BubbleSort(jArr[i]);
            }

            // Копирование из подмассивов в двумерный массив
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = jArr[i][j];
                }
            }

            // Вывод массива в консоль для проверки
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }
           
        }

        // Метод сортировки пузырьком в порядке убывания
        public static int[] BubbleSort(int[] jArr)
        {
            int temp;
            for (int i = 0; i < jArr.Length; i++)
            {
                for (int j = i + 1; j < jArr.Length; j++)
                {
                    if (jArr[i] < jArr[j])
                    {
                        temp = jArr[i];
                        jArr[i] = jArr[j];
                        jArr[j] = temp;
                    }
                }
            }
            return jArr;
        }
    }
}
