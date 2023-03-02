// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int FindLen(int number)    // Название функции сами придумываем (FindLen - найти длинну)
{
    int kolich = 0;
    while(number > 0)
    {
        number = number / 10;
        kolich++;
    }
    return kolich;
}
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"Количество цифр = {FindLen(num)}");