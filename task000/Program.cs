// Задача № ???   Ввели массив цифр на выходе получили перевернутый массив

// 12345 --> 54321



Console.WriteLine("введите количество элементов массива: \t");
int A = int.Parse(Console.ReadLine());
int[] a = new int[A];
for (int i = 0; i < a.Length; i++)
{
    Console.WriteLine($"\nВведите элемент массива под индексом {i}:\t");
    a[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("\nВывод массива: ");

    for (int i = a.Length - 1; i >= 0; i--)
    {
    Console.WriteLine(a[i]);
    }