//Задача № 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


int[] array = new int[8];
Array(array);
PrintArray(array);

void Array(int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 101);
    }
}

void PrintArray(int [] printarray)
{
    for (int i = 0; i < printarray.Length; i++)
    {
        Console.Write(printarray[i] + " ");
    }
}