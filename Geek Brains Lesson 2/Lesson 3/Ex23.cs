using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geek_Brains_Lesson_2;

public static class Ex23
{
    public static void CubePow(int input)
    {
        for (int i = 1; i < input+1; i++)
        {
            if ((i % 1 == 0) & (i % i == 0))
            {
                Console.Write(i);
            }
            else
            {
                Console.WriteLine("");
            }  
        }
    }
}
