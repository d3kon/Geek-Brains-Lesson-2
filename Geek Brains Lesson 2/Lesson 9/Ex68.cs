using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geek_Brains_Lesson_2
{
    internal class Ex68
    {
        public static int AkkermanFunction(int a, int b)
        {
            if (a == 0)
            {
                return b + 1;
            }
            if (a > 0 && b == 0)
            {
                return AkkermanFunction(a - 1, 1);
            }
            return AkkermanFunction(a - 1, AkkermanFunction(a, b - 1));
        }
    }
}
