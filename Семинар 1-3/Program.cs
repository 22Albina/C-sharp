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


// Задача 9: Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

// int number = new Random().Next(10, 100);
// Console.WriteLine($"случайное число из отрезка 10 - 99 -> {number}");
// int firstDigit = number / 10;
// int secondDigit = number % 10;
// if (firstDigit > secondDigit)
// {
// Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");
// }
// else
// {
//     Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}");
// }
//                      int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;  (если первое число больше второго, 
//                                                                                         то выводим первое, иначе выводим второе
//                                                                                          аналог if else. {Тернарный Оператор})
//                      Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

///////////////////////////////////////////// Решение через метод
// int result = MaxDigit(number);
// Console.WriteLine($"Наибольшая цифра числа -> {result}");
// int MaxDigit(int num)  // num = number
// {
//     int firstDigit = num / 10;
//     int secondDigit = num % 10;
//     int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
//     return maxDigit;
// }


// Задача №11: Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

// int number = new Random().Next(100, 1000);
// Console.WriteLine($"случайное число из отрезка 100 - 999 -> {number}");

// int rsd = DeliteSecondDigit(number);
// Console.WriteLine($"Полученный результат -> {rsd}");

// int DeliteSecondDigit(int num)
// {
//     int firstDigit = num / 100;
//     int thirdDigit = num % 10;
//     int result = firstDigit * 10 + thirdDigit;
//     return result;
// }


// Задача №12: Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// Console.Write("Введите число 1: ");
// int firstDigit = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число 2: ");
// int secondDigit = Convert.ToInt32(Console.ReadLine());

// int number = MultipleDigit(firstDigit, secondDigit);

// if (number == 0)
//     Console.WriteLine("Число кратно");
// else
//     Console.WriteLine("Число не кратно, остаток: " + number);

// int MultipleDigit(int num1, int num2)
// {
//     int remaider = num1 % num2;
//     return remaider;
// }

// Задача №14: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
// 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число 1-ое для кратности: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число 2- ое для кратности: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// bool result = MultipleDigit(number, number1, number2);  //number1 = 7;  number2 = 23
// Console.WriteLine(result ? "Да" : "Нет");

// bool MultipleDigit(int num, int num1, int num2)
// {
//     return (num % num1 == 0 && num % num2 == 0);
// }


//Задача № 16: Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

// Console.Write("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// bool result = Sqr(number1, number2);
// Console.WriteLine(result ? "ДА" : "НЕТ");

// bool Sqr(int num1, int num2)
// {
//     return num1 * num1 == num2 || num2 * num2 == num1;
// }


// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Write("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int secondDigit = SecondDigit(number);
// // if (number < 100 && number > 1000)
// // {
// //     Console.Write("Задано неверное число");
// //     return;
// // }
// Console.WriteLine($"Полученный результат -> {secondDigit}");

// int SecondDigit(int num)
// {
//     return (num / 10) % 10;
// }






// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введите число: ");
// int a = int.Parse(Console.ReadLine());
// if (a<100)
// {
//   Console.WriteLine("Третьей цифры нет");
// }
// else 
// {
//   while (a > 999)
//   {
//     a = a/10;
//   }
//   int thirdNumber = a % 10;
//   Console.WriteLine($"Третья цифра числа {thirdNumber}");
// }




//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.Write("Введи цифру соответствующую дню недели: ");
// int a = int.Parse(Console.ReadLine());
// int second = SecondDigit(a);

// int SecondDigit(int a1)
// {
//     if (a1 == 6 || a1 == 7)
//     {
//         Console.WriteLine("этот день выходной");
//     }
//     if (a1 < 1 || a1 > 7)
//     {
//         Console.WriteLine("вы ошиблись, попробуйте еще раз");
//     }
//     if (a1 >= 1 & a1 <= 5)
//     {
//         Console.WriteLine("этот день не выходной");
//     }
// }




// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// Console.Write("Введи координату Х точки: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введи координату Y точки: ");
// int y = Convert.ToInt32(Console.ReadLine());

// int quarter = Quarter(x, y);
// string result = quarter > 0 
//                              ? $"Указанные координаты соответствуют четверти -> {quarter}"
//                              : "Введены некорректные координаты";                          // тернарный оператор
// Console.Write(result);

// int Quarter(int x1, int y1)
// {
//     if (x1 > 0 && y1 > 0) return 1;
//     if (x1 < 0 && y1 > 0) return 2;
//     if (x1 < 0 && y1 < 0) return 3;
//     if (x1 > 0 && y1 < 0) return 4;
//     return 0;
// }




// Задача № 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

// Console.Write("Введи номер четверти: ");
// int number = Convert.ToInt32(Console.ReadLine());

// string quarter = Quarter(number);

// Console.Write(quarter);

// string Quarter(int chetvert)
// {
//     if (chetvert == 1) return "x > 0, y > 0";
//     if (chetvert == 2) return "x < 0, y > 0";
//     if (chetvert == 3) return "x < 0, y < 0";
//     if (chetvert == 4) return "x > 0, y < 0";
//     return "Введена некорректная четверть";
// }


// Задача № 20: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// AB = √((xb - xa)2 + (yb - ya)2)

// Console.Write("Введите координату X точки А: ");
// int numx1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Y точки А: ");
// int numy1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату X точки B: ");
// int numx2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Y точки B: ");
// int numy2 = Convert.ToInt32(Console.ReadLine());

// double dlinna = Dlinna(numx1, numx2, numy1, numy2);

// double Dlinna(int x1, int x2, int y1, int y2)
// {
//     int A = (x2-x1)*(x2-x1);
//     int B = (y2-y1)*(y2-y1);
//     double C = Math.Sqrt(A+B);
//     return C;
// } 
// Console.Write("Расстояние между точками =  " + Math.Round (dlinna, 2, MidpointRounding.ToZero));



// Задача № 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Sqr(num);
// void Sqr(int number)
// {
//     int count = 1;
//     while (count <= number)
//     {
//         int result = count * count;
//         Console.WriteLine($"{count, 3} -> {result, 5}"); // 3 и 5 длинна строки в которуюю пишется результат (для выравнивания)
//         count++;
//     }
// }


// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите пятизначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int a = num / 10000;
// int b = num / 1000 % 10;
// int c = num % 100 / 10;
// int d = num % 10;

// bool palindrom = Palindrom(a, b, c, d);
// Console.WriteLine(palindrom ? "ПАЛИНДРОМ" : "НЕ ПАЛИНДРОМ");
// if (num < 9999 || num > 99999)
// {
//     Console.WriteLine("Вы ввели неправильное число, повторите попытку");
// }
// bool Palindrom(int a1, int b1, int c1, int d1)
// {
//     return a == d && b == c;
// }

// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Write("Введите координату X точки А: ");
// int numx1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Y точки А: ");
// int numy1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Z точки А: ");
// int numz1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату X точки B: ");
// int numx2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Y точки B: ");
// int numy2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Z точки B: ");
// int numz2 = Convert.ToInt32(Console.ReadLine());

// double dlinna = Dlinna(numx1, numx2, numy1, numy2, numz1, numz2);

// double Dlinna(int x1, int x2, int y1, int y2, int z1, int z2)
// {
//     int A = (x2-x1)*(x2-x1);
//     int B = (y2-y1)*(y2-y1);
//     int C = (z2-z1)*(z2-z1);
//     double result = Math.Sqrt(A+B+C);
//     return result;
// } 
// Console.Write("Расстояние между точками =  " + Math.Round (dlinna, 2, MidpointRounding.ToZero));




// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Sqr(num);
// void Sqr(int number)
// {
//     int count = 1;
//     while (count <= number)
//     {
//         int result = count * count * count;
//         Console.WriteLine($"{count, 3} -> {result, 5}"); // 3 и 5 длинна строки в которуюю пишется результат (для выравнивания)
//         count++;
//     }
// }



// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int sumNumbers = SumNumbers(number);
// Console.Write($"Сумма чисел от 1 до {number} = {sumNumbers}");

// int SumNumbers(int num)
// {
//     int sum = 0;
//     for (int i = 1; i <= num; i++)
//     {
//         sum = sum + i; // sum += i тоже самое
//     }
//     return sum;
// }



// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int countDigit = CountDigit(number);
// Console.WriteLine($"Колличество цифр в числе {number}: {countDigit}");

// int CountDigit(int num)
// {
//     int count = 0;
// while (num > 0 || num < 0)  // (num != 0)  можно и так
// {
//     count++;
//     num /= 10;
// }
// return count;
// }


// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int factorial = Factorial(number);
// Console.Write($"Произведение чисел от 1 до {number} = {factorial}");

// int Factorial(int num)
// {
//     int multi = 1;
//     for (int i = 2; i <= num; i++)
//     {
//         checked  // если памяти в int не хватит при умножении то выдаст ошибку
//         {
//             multi *= i; // multi = multi * i тоже самое
//         }
//     }
//     return multi;
// }



// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] array = new int[8];
// Array(array);
// PrintArray(array);

// void Array(int [] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(0, 2);
//     }
// }

// void PrintArray(int [] printarray)
// {
//     for (int i = 0; i < printarray.Length; i++)
//     {
//         Console.Write(printarray[i] + " ");
//     }
// }


// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Console.WriteLine("Введите Первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int degre = Degree(num1, num2);
// Console.WriteLine("Ответ: " + degre);

// int Degree(int number1, int number2)
// {
//     int result = 1;
//     for (int i = 1; i <= number2; i++)
//     {
//         result = result * number1;
//     }
//     return result;
// }




// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine());

// int sumNumber = SumNumber(number);
// Console.WriteLine("Сумма цифр: " + sumNumber);

//   int SumNumber(int number)
//   {
//     int count = Convert.ToString(number).Length;
//     int advance = 0;
//     int temp = 0;

//     for (int i = 0; i < count; i++)
//     {
//       advance = number - number % 10;
//       temp = temp + (number - advance);
//       number = number / 10;
//     }
//    return temp;
//   }












//Задача № 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


// int[] array = new int[8];
// Array(array);
// PrintArray(array);

// void Array(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(0, 101);
//     }
// }

// void PrintArray(int[] printarray)
// {
//     for (int i = 0; i < printarray.Length; i++)
//     {
//         Console.Write(printarray[i] + " ");
//     }
// }




// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();

//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }
//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
//         else Console.Write($"{arr[i]}");
//     }
//     Console.Write("]");
// }
// int SumNegativeElements(int[] arr)
// {
//     int sum = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] < 0) sum += arr[i];
//     }
//     return sum;
// }

// int SumPositiveElements(int[] arr)
// {
//     int sum = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > 0) sum += arr[i];
//     }
//     return sum;
// }

// int[] array = CreateArrayRndInt(12, -9, 9);
// PrintArray(array);
// Console.WriteLine();
// int sumNegativeElem = SumNegativeElements(array);
// int sumPositiveElem = SumPositiveElements(array);
// Console.WriteLine($"Сумма положительных элементов = {sumPositiveElem}");
// Console.WriteLine($"Сумма отрицательных элементов = {sumNegativeElem}");



// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие 
// отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();

//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }
//     return arr;
// }

// int[] MultiplicationArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] *= -1;
//         if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
//         else Console.Write($"{arr[i]}");
//     }
//     Console.Write("]");
//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
//         else Console.Write($"{arr[i]}");
//     }
//     Console.Write("]");
// }

// int[] array = CreateArrayRndInt(6, -10, 10);
// PrintArray(array);
// Console.WriteLine();
// MultiplicationArray(array);