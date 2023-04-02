// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] array2d = CreateMatrix(4, 4, -10, 10);
Console.WriteLine("Исходный массив");
PrintMatrix(array2d);
Console.WriteLine();
RegularizeMatrix(array2d);
Console.WriteLine("Измененный массив");
PrintMatrix(array2d);



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

void RegularizeMatrix(int[,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < matrix1.GetLength(1) - 1; k++)
            {
                if (matrix1[i, k] < matrix1[i, k + 1])
                {
                    int temp = 0;
                    temp = matrix1[i, k];
                    matrix1[i, k] = matrix1[i, k + 1];
                    matrix1[i, k + 1] = temp;
                }
            }
        }
    }
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