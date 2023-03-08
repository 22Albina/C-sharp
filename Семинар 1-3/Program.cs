// Задачи Семинаров с 1 - 3:

// Задача №0 Напишите программу, которая 
// 1.на вход принимает число и
// 2. выдает его квадрат (число умножаем само на себя).


// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

// Console.WriteLine("Введите целое число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int square = number * number;
// Console.WriteLine($"Квадрат числа {number} = {square}");


//Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

// Console.WriteLine("Введите первое целое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе целое число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// int sqr = number2 * number2;
// if (sqr == number1)
// {
//     Console.WriteLine("Первое число является квадратом второго");
// }
// else
// {
// Console.WriteLine("Первое число не является квадратом второго");
// }

// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

// Console.Write("Введите число от 1 до 7: ");
// int a = int.Parse(Console.ReadLine());
// if (a == 1)
// {
//  Console.Write("Понедельник");   
// }
// if (a == 2)
// {
//  Console.Write("Вторник");   
// }
// if (a == 3)
// {
//  Console.Write("Среда");   
// }
// if (a == 4)
// {
//  Console.Write("Четверг");   
// }
// if (a == 5)
// {
//  Console.Write("Пятница");   
// }
// if (a == 6)
// {
//  Console.Write("Суббота");   
// }
// if (a == 7)
// {
//  Console.Write("Воскресенье");   
// }
// if (a < 1 || a >= 8)
// {
// Console.Write("Задано неверное число");
// }



// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

// Console.WriteLine("Введите целое положительное число");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = -number;
// while(count <= number)
// {
// Console.Write($"{count} ");
// count++;
// }

// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8
// Console.Write("введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num >= 100 && num <= 999)
// {
// int numLast = num % 10;
// Console.WriteLine(numLast);
// }
// else
// {
// Console.WriteLine("введите ТРЁХзначное число");
// }


// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("введите число 1: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите число 2: ");
// int b = Convert.ToInt32(Console.ReadLine());
// if (a > b)
// {
//     Console.WriteLine("Max = " + a);
// }
// else
// {
//     Console.WriteLine("Max = " + b);
// }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Write("введите число 1: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите число 2: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите число 3: ");
// int c = Convert.ToInt32(Console.ReadLine());
// int max = a;
// if (b > max)
// {
//     max = b;
// }
// if (c > max)
// {
//     max = c;
// }
// Console.WriteLine("Максимальное число: " + max);


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Write("введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a % 2 == 0)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }



// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.Write("введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// for (int i = 2; i <= a; i+=2)
// {
//     Console.Write($"{i} ");
// }




//Console.WriteLine("Введите целое положительное число");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = -number;
// while(count <= number)
// {
// Console.Write($"{count} ");
// count++;
// }