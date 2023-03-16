// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Сube(num);
void Сube(int number)
{
    int count = 1;
    while (count <= number)
    {
        int result = count * count * count;
        Console.WriteLine($"{count, 3} -> {result, 5}"); // 3 и 5 длинна строки в которуюю пишется результат (для выравнивания)
        count++;
    }
}

// Console.Write("Ввведите число: ");
// int N = int.Parse(Console.ReadLine());
// int x = 1;
// while (x <= N)
// {
//     int y = x * x * x;
//     x++;
//     Console.WriteLine(y);
// }