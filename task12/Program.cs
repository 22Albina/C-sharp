// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1,
//  то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


Console.Write("Введите первое число: ");
int A = int.Parse(Console.ReadLine());       //  int a = int.Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int B = int.Parse(Console.ReadLine());       //  int b = int.Convert.ToInt32(Console.ReadLine());
int C = A % B;
if (C == 0)
{
Console.WriteLine("Второе число является кратным первому ");
}
else 
{
Console.WriteLine("Остаток от деления " + C);
Console.WriteLine("Второе число не кратно первому ");   //Console.WriteLine("не кратно, остаток " + C);  вместо двух строк можно так
}