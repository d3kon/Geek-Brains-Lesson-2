using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geek_Brains_Lesson_2
{
    public static class Ex25
    {
        public static int Degree(int a,int degree)
        {
            int input = 1;    
            for (int i = 0; i < degree; i++)
            {
                input = input * a;
            }
            return input;
        }
    }
}
