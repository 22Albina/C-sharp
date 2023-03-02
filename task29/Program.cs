//Задача № 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


void MakeMas(int[] array)
{
    int length = array.Length;

    for (int index = 0; index < length; index++)
    {
        array[index] = new Random().Next(0, 1000);
        // Console.Write(array[index] + " ");              // Промежуточный вывод массива
    }
}

void PrintArray(int[] mas)
{
    int len = mas.Length;
    for (int i = 0; i < len; i++)
    {
        Console.Write(mas[i] + " ");
    }
}

int[] arr = new int[8];
MakeMas(arr);
PrintArray(arr);