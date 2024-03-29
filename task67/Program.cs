﻿// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9




Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int sum = SumDigits(number);
Console.WriteLine($"Сумма цифр числа = {sum}");


int SumDigits(int num)
{
    if (num == 0) return 0;       //1! = 1 0! = 1
    else return SumDigits(num / 10) + num % 10;
}