// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int siie, int min, int max, int round = 1)
{
    double[] arr = new double[siie];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

double MinMax(double[] array, double min, double max)   // double min, double max это можно убрать
{
    double minnum = array[0];
    double maxnum = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxnum)
        {
            maxnum = array[i];
        }
        if (array[i] < minnum)
        {
            minnum = array[i];
        }
    }
    double res = maxnum - minnum;
    return res;
}
void PrintMinMax(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}
double[] array = CreateArrayRndDouble(4, -10, 10);
PrintMinMax(array);
Console.WriteLine();
double result = MinMax(array, 0, 0);   // 0, 0, можно тогда тоже надо убрать (смотри 18 строку)
Console.WriteLine($"Разница между максимальным и минимальным значением = {result}");
