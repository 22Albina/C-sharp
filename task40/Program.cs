// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник 
// с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.Write("Введите первую стонону: ");
int numb1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую сторону: ");
int numb2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третью сторону: ");
int numb3 = Convert.ToInt32(Console.ReadLine());

bool result = IsExistTriangle(numb1, numb2, numb3);
Console.WriteLine(result ? "Существует" : "НЕ существует");

bool IsExistTriangle(int n1, int n2, int n3)
{
    if (n1 < n2 +n3 && n2 < n1 + n3 && n3 < n1 + n2) return true;
    else return false;
}