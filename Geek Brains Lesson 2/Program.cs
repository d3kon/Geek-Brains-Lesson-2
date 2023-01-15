// See https://aka.ms/new-console-template for more information
using Geek_Brains_Lesson_2;
using System.Runtime.InteropServices;

/*Console.WriteLine(new string('_', 50));

Console.Write("Задайте длину массива: ");
int input = int.Parse(Console.ReadLine());
Console.WriteLine($"\nКоличество четных элементов массива: {Ex34.Even_Arr(input)}");*/



Console.WriteLine(new string('_', 50));

Console.Write("Задайте длину массива: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"\nСумма элементов на нечетных позициях: {Ex36.Even_Position(n)}");