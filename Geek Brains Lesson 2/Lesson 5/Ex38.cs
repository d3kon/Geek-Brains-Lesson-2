using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geek_Brains_Lesson_2
{
    public static class Ex38
    {
        public static double Raznost_Max_Min(int g)
        {
            var rnd = new Random();
            double[] array = new double[g];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-100,100) + rnd.NextDouble();
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            return array.Max() - array.Min();
        }
    }
}