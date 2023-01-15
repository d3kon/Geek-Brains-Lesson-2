using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geek_Brains_Lesson_2
{
    public static class Ex34
    {
        public static int Even_Arr(int input)
        {
            var rnd = new Random();
            double[] array = new double[input];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(100,1000);
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] +" ");
            }

            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    result++;
                }
            }
            return result;

        }
    }
}
