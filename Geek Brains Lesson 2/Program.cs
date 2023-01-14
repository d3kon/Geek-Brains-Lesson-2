// See https://aka.ms/new-console-template for more information
using Geek_Brains_Lesson_2;
using System.Runtime.InteropServices;

/*Console.WriteLine(new string('_', 50));

Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень:");
int degree = int.Parse(Console.ReadLine());
Console.WriteLine(Ex25.Degree(a,degree));

Console.WriteLine(new string('_', 50));

Console.WriteLine("Введите число:");
int b = int.Parse(Console.ReadLine());
Console.WriteLine(Ex27.Summ_Num(b));*/

Console.WriteLine(new string('_', 50));

Console.WriteLine("Введите числа через запятую:");
var massiv = Console.ReadLine();
var result = Ex29.Array(massiv);
foreach(var item in result)
{
    Console.Write(item+" ");
}