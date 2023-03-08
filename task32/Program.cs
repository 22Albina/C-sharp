// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];//создание массива
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

void ReplaceIndex(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        inArray[i] = inArray[i] * -1;
    }
}

int[] array = GetArray(12, -9, 9);
PrintArray(array);
System.Console.WriteLine();
ReplaceIndex(array);
System.Console.WriteLine();
PrintArray(array);
