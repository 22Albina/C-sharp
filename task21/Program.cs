// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

                                    // AB = √((xb - xa)2 + (yb - ya)2 + (zb - za)2)

Console.Write("Введите координату X точки А: ");
int numx1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки А: ");
int numy1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z точки А: ");
int numz1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату X точки B: ");
int numx2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки B: ");
int numy2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z точки B: ");
int numz2 = Convert.ToInt32(Console.ReadLine());

double dlinna = Dlinna(numx1, numx2, numy1, numy2, numz1, numz2);
Console.Write("Расстояние между точками =  " + Math.Round (dlinna, 2, MidpointRounding.ToZero));

double Dlinna(int x1, int x2, int y1, int y2, int z1, int z2)
{
    int A = (x2-x1)*(x2-x1);
    int B = (y2-y1)*(y2-y1);
    int C = (z2-z1)*(z2-z1);
    double result = Math.Sqrt(A+B+C);
    return result;
} 

// Console.Write("Введите координату X точки А: ");
// int x1 = int.Parse(Console.ReadLine());
// Console.Write("Введите координату Y точки А: ");
// int y1 = int.Parse(Console.ReadLine());
// Console.Write("Введите координату Z точки A: ");
// int z1 = int.Parse(Console.ReadLine());
// Console.Write("Введите координату X точки B: ");
// int x2 = int.Parse(Console.ReadLine());
// Console.Write("Введите координату Y точки B: ");
// int y2 = int.Parse(Console.ReadLine());
// Console.Write("Введите координату Z точки B: ");
// int z2 = int.Parse(Console.ReadLine());

// int A = (x2-x1)*(x2-x1);
// int B = (y2-y1)*(y2-y1);
// int C = (z2-z1)*(z2-z1);
// double rast = Math.Sqrt(A+B+C);                            // Math.Sqrt() вычисление квадратного корня
// Console.Write("Расстояние между точками =  " + Math.Round (rast, 2));