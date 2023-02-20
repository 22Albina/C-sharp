// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


Console.Write("Ввведите число: ");
int N = int.Parse(Console.ReadLine());
int x = 1;
while (x <= N)
{
    int y = x * x;
    x++;
    Console.WriteLine(y);
}