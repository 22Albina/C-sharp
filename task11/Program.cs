// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int num = new Random().Next(100,1000); 
Console.WriteLine (num);
int A = num / 100;
int B = num % 10;
Console.WriteLine($"{A}{B}"); // Console.WriteLine(A + "" + B);

// Еще 1 вариант решения этой задачи:
// int number = new Random().Next(100, 1000);
// Console.WriteLine(number);
// int number1 = number / 100;
// Console.WriteLine(number1);
// int number2 = number % 100 / 10;
// Console.WriteLine(number2);
// int number3 = number % 10;
// Console.WriteLine(number3);
// Console.WriteLine(number1 * 10 + number3);