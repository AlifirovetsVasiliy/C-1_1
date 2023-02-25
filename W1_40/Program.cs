// Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.

bool CheckTriangele(int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;
}

Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите число c: ");
int c = int.Parse(Console.ReadLine()!);

if(CheckTriangele(a, b, c))
{
    Console.WriteLine("Треугольник существует");
}
else
{
    Console.WriteLine("Треугольник не существует");
}