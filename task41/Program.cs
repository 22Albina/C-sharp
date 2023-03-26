// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Введите количество элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];

Mas(num);
Console.Write($"\n Чисел больше нуля: {Kol(array)}");

void Mas(int number)
{
    for (int i = 0; i < number; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

}

int Kol(int[] array)
{
    int i = 0;
    int sum = 0;
    while (i < array.Length)
    {
        if (array[i] > 0)
            sum = sum + 1;
        i = i + 1;
    }
    return sum;
}