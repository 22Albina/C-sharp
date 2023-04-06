// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29



Console.WriteLine("Вводим первое положительное число:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вводим второе положительное число:");
int n = Convert.ToInt32(Console.ReadLine());

int result = Akker(m, n);
Console.WriteLine($"Ответ: {result}");



int Akker(int num1, int num2)
{
    if (num1 < 0 || num2 < 0) return 0;
    if (num1 == 0)
    return num2 + 1;
    else if (num2 == 0)
    return Akker(num1 - 1, 1);
    return Akker(num1 - 1, Akker(num1, num2 - 1));

}