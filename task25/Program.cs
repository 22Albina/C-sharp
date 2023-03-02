// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


int DegrNum(int number1, int number2)
{
  int result = 1;
  for(int i=1; i <= number2; i++)
  {
    result = result * number1;
  }
    return result;
}

  Console.Write("Введите число 1: ");
  int number1 = int.Parse(Console.ReadLine());
  Console.Write("Введите число 2: ");
  int number2 = int.Parse(Console.ReadLine());
  int Degree = DegrNum(number1, number2);
  Console.WriteLine("Ответ: " + Degree);