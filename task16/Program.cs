// Задача № 16: Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

// Console.Write("Введите первое число: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int b = int.Parse(Console.ReadLine());
// if (a == b*b || b == a*a)
// {
//     Console.WriteLine("ДА");
// }
// else
// {
//     Console.WriteLine("НЕТ");
// }

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
int sqr1 = a*a;
if (sqr1 == b)
   {
  Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
} 
int sqr2 = b*b;
if (sqr2 == a)
{
  Console.WriteLine("Второе число является квадратом первого");
}
else
{
    Console.WriteLine("Второе число не является квадратом первого");
}