// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет


Console.Write("Введите номер строки: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int num2 = int.Parse(Console.ReadLine());


int[,] array2d = CreateMatrix(4, 4, -10, 10);

if(num1 > 0 && num2 > 0) PrintMatrix(array2d);
else Console.WriteLine("Числа должны быть больше 0");

ElementSearch(array2d, num1, num2);


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


void ElementSearch(int[,] array, int number1, int number2)
{
    if (number1 > array.GetLength(0) || number2 > array.GetLength(1))
    {
        Console.WriteLine("Такого элемента нет");
    }
    else
    {
        Console.WriteLine($"Значение элемента {number1} строки и {number2} столбца = {array[number1 - 1, number2 - 1]}");
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
        Console.WriteLine("|");
    }
}