// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Вводим первое число:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вводим второе число:");
int n = Convert.ToInt32(Console.ReadLine());

int numDegree = NumberDegree(m, n);
Console.WriteLine($"Ответ: {numDegree}");

int NumberDegree(int num1, int num2)
{

    if (num1 == num2) return num2;
    return num2 + NumberDegree(num1, num2 - 1);
}