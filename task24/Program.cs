// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

 Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNumbers(number);
Console.Write($"Сумма чисел от 1 до {number} = {sumNumbers}");

int SumNumbers(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i; // sum += i тоже самое
    }
    return sum;
}


// int GetSumNums(int number)
// {
//     int sum = 0;
//     while(number > 0)
//     {
//         sum = sum + number;
//         number--;
//     }
//     return sum;
// }
// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());

// int num2 = int.Parse(Console.ReadLine());   // Можно вызвать один метод несколько раз, не прописывая его для каждой переменной.
// int num3 = int.Parse(Console.ReadLine());

// Console.WriteLine($"Сумма цифр = {GetSumNums(num)}");
// Console.WriteLine($"Сумма цифр = {GetSumNums(num2)}");
// Console.WriteLine($"Сумма цифр = {GetSumNums(num3)}");

//int sumOne = GetSumNums(num);           // Продолжить работу с итогом то вызываем промежуточный результат так.
//Console.WriteLine(sumOne);