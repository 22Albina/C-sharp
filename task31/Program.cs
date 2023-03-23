// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.



int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void PrintArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        Console.Write($"{inArray[i]} ");
    }

}

void FindSum(int[] array)
{
    int positiveSum = 0;
    int negativeSum = 0;

    foreach (int el in array)
    {
        if (el > 0)
        {
            positiveSum += el;
        }
        else
        {
            negativeSum += el;
        }
    }
    Console.WriteLine($"Сумма положительных чисел = {positiveSum}, сумма отрицательных чисел = {negativeSum}");
}

int[] array = GetArray(12, -9, 9);
PrintArray(array);
Console.WriteLine();
FindSum(array);



// int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();

//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }
//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
//         else Console.Write($"{arr[i]}");
//     }
//     Console.Write("]");
// }
// int SumNegativeElements(int[] arr)
// {
//     int sum = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] < 0) sum += arr[i];
//     }
//     return sum;
// }

// int SumPositiveElements(int[] arr)
// {
//     int sum = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > 0) sum += arr[i];
//     }
//     return sum;
// }

// int[] array = CreateArrayRndInt(12, -9, 9);
// PrintArray(array);
// Console.WriteLine();
// int sumNegativeElem = SumNegativeElements(array);
// int sumPositiveElem = SumPositiveElements(array);
// Console.WriteLine($"Сумма положительных элементов = {sumPositiveElem}");
// Console.WriteLine($"Сумма отрицательных элементов = {sumNegativeElem}");