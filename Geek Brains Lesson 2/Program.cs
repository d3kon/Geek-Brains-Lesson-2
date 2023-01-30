// See https://aka.ms/new-console-template for more information
using Geek_Brains_Lesson_2;
using System;
using System.Runtime.InteropServices;

var data = Ex58.MatrixMultiplication();
for (int i = 0; i < data.GetLength(0); i++)
{
	for (int j = 0; j < data.GetLength(1); j++)
	{
		Console.Write(" " + data[i,j]);
	}
	Console.WriteLine();
}