using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geek_Brains_Lesson_2
{
    internal class Ex43
    {
        public static void FindCrossVector(double b1, double k1, double b2, double k2, ref double x, ref double y)
        {
            x = (-b2 + b1) / (-k1 + k2);
            y = k2 * x + b2;
        }
    }
}
