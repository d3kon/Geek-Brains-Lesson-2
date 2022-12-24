// See https://aka.ms/new-console-template for more information
using Geek_Brains_Lesson_2;
using System.Runtime.InteropServices;

Console.WriteLine("Введите пятизначное число");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(Ex19.Mirror(number));

Console.WriteLine(new string('_', 50));

Console.Write("A1:");
double A1 = double.Parse(Console.ReadLine());
Console.Write("A2:");
double A2 = double.Parse(Console.ReadLine());
Console.Write("A3:");
double A3 = double.Parse(Console.ReadLine());
Console.Write("B1:");
double B1 = double.Parse(Console.ReadLine());
Console.Write("B2:");
double B2 = double.Parse(Console.ReadLine());
Console.Write("B3:");
double B3 = double.Parse(Console.ReadLine());
Console.Write("Расстояние:");
Console.WriteLine(Ex21.ThirdDimDist(A1, A2, A3, B1, B2, B3));

Console.WriteLine(new string('_', 50));

Console.Write("Введите число:");
int input = int.Parse(Console.ReadLine());
Ex23.CubePow(input);