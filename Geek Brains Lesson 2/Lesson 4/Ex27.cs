using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geek_Brains_Lesson_2
{
    public static class Ex27
    {
        public static int Summ_Num(int b)
        {
            string b_string = b.ToString();
            int result = 0;
            for (int i = 0; i < b_string.Length; i++)
            {
                result += int.Parse(b_string[i].ToString());
            }
            return result;
        }
    }
}