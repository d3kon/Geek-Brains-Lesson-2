using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geek_Brains_Lesson_2
{
    internal class Ex66
    {
        private static int result;
        public static int SumInRange(int m, int n)
        {
            if (n > m)
            {
                result += n;
                n--;
                SumInRange(m, n);
            }
            return result;
        }
    }
}
