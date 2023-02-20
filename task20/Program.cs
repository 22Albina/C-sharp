// Задача № 20: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


// AB = √((xb - xa)2 + (yb - ya)2)



Console.Write("Введите координату X точки А: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y точки А: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату X точки B: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y точки B: ");
int y2 = int.Parse(Console.ReadLine());
int A = (x2-x1)*(x2-x1);
int B = (y2-y1)*(y2-y1);
double AB = Math.Sqrt(A+B);                            // Math.Sqrt() вычисление квадратного корня
Console.Write("Расстояние между точками =  " + Math.Round (AB, 2));  // Math.Round (AB, 2) сокращает количество знаков после запятой
                                                                     // (2 - количество знаков которое нам нужно после запятой)