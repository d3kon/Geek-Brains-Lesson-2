using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geek_Brains_Lesson_2
{
    public static class Lesson2
    {
        public static void Center()
        {
            string a = Console.ReadLine();
            if (a.Length == 3)
            {
                Console.WriteLine(a[1]);
            }
            else
            {
                Console.WriteLine("Не трехзначное число!!");
            }
           
        }
        public static void Number_3()
        {
            string a = Console.ReadLine();
            if (a.Length >= 3)
            {
                Console.WriteLine(a[2]);
            }
            else
            {
                Console.WriteLine("Третьего числа нет");
            }
        }
        public static void Day()
        {
            int day = int.Parse(Console.ReadLine());
            if (day > 0 & day < 6)
            {
                Console.WriteLine("Будний!");
            }
            else if (day >= 6 & day <= 7)
            {
                Console.WriteLine("Выходной!");
            }
            else
            {
                Console.WriteLine("Такого дня не существует!");
            }
        }
    }
}
