using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geek_Brains_Lesson_2
{
    internal class Ex50
    {
        public static string FindInSArray(int[,] array, int m, int n)
        {
            try
            {
                return Convert.ToString(array[m, n]);
            }

            catch
            {
                return "Значение не существует";
            }
        }
    }
}
