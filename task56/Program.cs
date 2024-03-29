﻿// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка





int[,] CreateMatrix(int rows, int columns, int min, int max)
{                         //  0      1
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)   // наш 0 (строки)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // наша 1 (столбцы)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix2)
{
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            Console.Write($"{matrix2[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

int MinSumLine(int[,] array)
{
    int row = 0;
    int minsum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minsum = minsum + array[0, i];
    }

    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        if (minsum > sum)
        {
            minsum = sum;
            row = i;
        }
    }
    return row;
}

int[,] array2d = CreateMatrix(4, 4, 0, 10);
Console.WriteLine("Исходный массив");
PrintMatrix(array2d);
Console.WriteLine();
Console.WriteLine($"{MinSumLine(array2d)} - строка с наименьшей суммой");