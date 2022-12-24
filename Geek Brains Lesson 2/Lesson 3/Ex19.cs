using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geek_Brains_Lesson_2
{
    public static class Ex19
    {
        public static string Mirror(int number)
        {
            if (number.ToString().Length != 5) return "Число не пятизначное";
            char[] check = number.ToString().ToCharArray();
            Array.Reverse(check);
            string result = new string(check);
            if (result == number.ToString())
            {
                return "Да";
            }
            else return "Нет";
        }
    }
}
