using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geek_Brains_Lesson_2
{
    public static class Ex41
    {
        public static int Counter(string input)
        {
            var array = input.Split(',');

            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (int.Parse(array[i]) > 0) result++;
            }

            return result;
        }
    }
}
