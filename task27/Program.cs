// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int sumNumber = SumNumber(number);
Console.WriteLine("Сумма цифр: " + sumNumber);

  int SumNumber(int number)
  {
    int count = Convert.ToString(number).Length;
    int advance = 0;
    int temp = 0;

    for (int i = 0; i < count; i++)
    {
      advance = number - number % 10;
      temp = temp + (number - advance);
      number = number / 10;
    }
   return temp;
  }
