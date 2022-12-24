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
        for (int i = 1; i <= input; i++)
        {
            Console.Write($"{Math.Pow(i, 3)}__");
        }
        Console.WriteLine("");
    }
}
