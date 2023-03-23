// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

int NoEvenPositions(int[] array)
{
    int count = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        if (i % 2 != 0)
        {
            count = count + array[i];
        }
    }
    return count;
}

void PrintNoEvenPositions(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

int[] array = CreateArrayRndInt(4, -10, 10);
PrintNoEvenPositions(array);
Console.WriteLine();
int result = NoEvenPositions(array);
Console.WriteLine($"Сумма элементов на нечетных позициях: {result}");