// See https://aka.ms/new-console-template for more information
using Geek_Brains_Lesson_2;
using System.Runtime.InteropServices;

Console.WriteLine(new string('_', 50));

Console.Write("Введите числа через запятую, без пробелов. \nПример: 1,2,3,4 \n");
string input = Console.ReadLine();
Console.WriteLine($"Чисел больше нуля: {Ex41.Counter(input)}");