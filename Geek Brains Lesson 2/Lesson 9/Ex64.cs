using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geek_Brains_Lesson_2
{
    internal class Ex64
    {
        public static void SequenceNumber(int a)
        {
            Console.WriteLine(a);
            if (a > 1) SequenceNumber(a - 1);
            return;
        }
    }
}
