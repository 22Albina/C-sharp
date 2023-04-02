// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Матрицу P можно умножить на матрицу K только в том случае, 
// если число столбцов матрицы P равняется числу строк матрицы K. 
// Матрицы, для которых данное условие не выполняется, умножать нельзя.





// if (строкаmartrix1 != столбецmartrix2)
// {
//     Console.WriteLine(" Матрицы умножать нельзя!");
//     break;
// }

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

void MultiplyMatrix(int[,] martrix1, int[,] martrix2, int[,] matrixMultiply)
{
    for (int i = 0; i < matrixMultiply.GetLength(0); i++)
    {
        for (int j = 0; j < matrixMultiply.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < martrix1.GetLength(1); k++)
            {
                sum += martrix1[i, k] * martrix2[k, j];
            }
            sum = matrixMultiply[i, j];
        }
    }
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }

        Console.Write("|");
        Console.WriteLine();

    }
}

int[,] martrix1 = CreateMatrix(3, 3, 0, 5);
Console.WriteLine("Матрица 1:");
PrintMatrix(martrix1);
Console.WriteLine();

int[,] martrix2 = CreateMatrix(3, 3, 0, 5);
Console.WriteLine("Матрица 2:");
PrintMatrix(martrix2);
Console.WriteLine();

int[,] matrixMultiply = CreateMatrix(3, 3, 0, 5);
MultiplyMatrix(martrix1, martrix2, matrixMultiply);
Console.WriteLine("Произведение матриц:");
PrintMatrix(matrixMultiply);