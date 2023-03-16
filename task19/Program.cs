// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int a = num / 10000;
int b = num / 1000 % 10;
int c = num % 100 / 10;
int d = num % 10;

bool palindrom = Palindrom(a, b, c, d);
Console.WriteLine(palindrom ? "ПАЛИНДРОМ" : "НЕ ПАЛИНДРОМ");
if (num < 9999 || num > 99999)
{
    Console.WriteLine("Вы ввели неправильное число, повторите попытку");
}
bool Palindrom(int a1, int b1, int c1, int d1)
{
    return a == d && b == c;
}


// Console.WriteLine("Введите пятизначное число: ");
// int a = int.Parse(Console.ReadLine());
// int b1 = a / 10000;
// int b2 = a / 1000 % 10;
// int b4 = a % 100 / 10;
// int b5 = a % 10;

// if (b1 == b5 || b2 == b4)
// {
//     Console.WriteLine("это палиндром");
// }
// else
// {
//     Console.WriteLine("это не палиндром");
// }



//                  Второй вариан решения
// Console.WriteLine("введите число");
// int number = int.Parse(Console.ReadLine());
// int pal = 0;
// int num = number;

// while (number > 0) 
// {   
//     pal = pal * 10 + number % 10;
//     number /= 10; 
// }
// Console.WriteLine(num == pal ? "палиндром" : "не палиндром");
