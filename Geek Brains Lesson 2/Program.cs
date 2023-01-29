// See https://aka.ms/new-console-template for more information
using Geek_Brains_Lesson_2;
using System;
using System.Runtime.InteropServices;

Console.WriteLine(new string('_', 50));

Console.Write("Введите высоту массива 'm': ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите ширину массива 'n': ");
int n = int.Parse(Console.ReadLine());
int[,] array = Ex47.SDimArray(m, n);
Console.WriteLine();

Ex54.SortRows(ref m, ref n, array);