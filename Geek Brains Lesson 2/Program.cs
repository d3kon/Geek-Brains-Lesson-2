// See https://aka.ms/new-console-template for more information
using Geek_Brains_Lesson_2;
using System.Runtime.InteropServices;

Console.WriteLine(new string('_', 50));

/*Console.Write("Введите числа через запятую, без пробелов. \nПример: 1,2,3,4 \n");
string input = Console.ReadLine();
Console.WriteLine($"Чисел больше нуля: {Ex41.Counter(input)}");*/

double x = 0;
double y = 0;
Console.Write("Введите значение b1: ");
double b1 = int.Parse(Console.ReadLine());
Console.Write("Введите значение k1: ");
double k1 = int.Parse(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = int.Parse(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = int.Parse(Console.ReadLine());
Ex43.FindCrossVector(b1, k1, b2, k2, ref x, ref y); ;
Console.WriteLine($"Линии пересекутся в точке [{Math.Round(x, 2)} ; {Math.Round(y, 2)}]");