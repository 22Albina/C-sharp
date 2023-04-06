// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29



Console.WriteLine("Вводим первое положительное число:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вводим второе положительное число:");
int n = Convert.ToInt32(Console.ReadLine());

int result = Akker(m, n);
Console.WriteLine($"Ответ: {result}");



int Akker(int m, int n)
{
    {
        if (m == 0) 
        return n + 1;
        else if (n == 0) 
        return Akker(m - 1, 1);
        else return Akker(m - 1, Akker(m, n - 1));
    }
}