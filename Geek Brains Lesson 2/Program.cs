// See https://aka.ms/new-console-template for more information
using Geek_Brains_Lesson_2;
using System.Runtime.InteropServices;

Console.WriteLine(new string('_', 50));

Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень:");
int degree = int.Parse(Console.ReadLine());
Console.WriteLine(Ex25.Degree(a,degree));