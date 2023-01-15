using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geek_Brains_Lesson_2
{
    public static class Ex36
    {
        public static int Even_Position(int n)
        {
            var rnd = new Random();
            double[] array = new double[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(10);
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    result += (int)array[i];
                }
            }
            return result;
        }
    }
}