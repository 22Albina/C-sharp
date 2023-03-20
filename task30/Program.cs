// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


int[] array = new int[8];
Array(array);
PrintArray(array);

void Array(int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
}

void PrintArray(int [] printarray)
{
    for (int i = 0; i < printarray.Length; i++)
    {
        Console.Write(printarray[i] + " ");
    }
}