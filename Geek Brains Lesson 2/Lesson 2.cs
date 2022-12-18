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
                char[] cen_mas = new char[a.Length];
                for (int i = 0; i < a.Length; i++)
                {
                    cen_mas[i] = a[i];
                }
                Console.WriteLine(cen_mas[1]);
            }
            else
            {
                Console.WriteLine("Не трехзначное число!!");
                Console.ReadLine();
            }
           
        }
        public static void Number_3()
        {
            string a = Console.ReadLine();
            if (a.Length >= 3)
            {
                char[] cen_mas = new char[a.Length];
                for (int i = 0; i < a.Length; i++)
                {
                    cen_mas[i] = a[i];
                }
                Console.WriteLine(cen_mas[2]);
            }
            else
            {
                Console.WriteLine("Третьего числа нет");
                Console.ReadLine();
            }
        }
    }
}
