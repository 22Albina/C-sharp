// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] mas = GreatArrayRndInt(5, -9, 9);
PrintArray(mas);
Console.WriteLine();
InverseArray(mas);
PrintArray(mas);

int[] GreatArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

void InverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
}


// РЕШЕНИЕ 2

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

// int[] MultiplicationArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] *= -1;
//         if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
//         else Console.Write($"{arr[i]}");
//     }
//     Console.Write("]");
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

// int[] array = CreateArrayRndInt(6, -10, 10);
// PrintArray(array);
// Console.WriteLine();
// MultiplicationArray(array);



// РЕШЕНИЕ 3

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];//создание массива
//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }

// void PrintArray(int[] inArray)
// {
//     for (int i = 0; i < inArray.Length; i++)
//     {
//         Console.Write($"{inArray[i]} ");
//     }
// }

// void ReplaceIndex(int[] inArray)
// {
//     for (int i = 0; i < inArray.Length; i++)
//     {
//         inArray[i] = inArray[i] * -1;
//     }
// }

// int[] array = GetArray(12, -9, 9);
// PrintArray(array);
// System.Console.WriteLine();
// ReplaceIndex(array);
// System.Console.WriteLine();
// PrintArray(array);