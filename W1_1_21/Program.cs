// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.Write("Введите координату X первой точки: ");
int x1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату Y первой точки: ");
int y1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату Z первой точки: ");
int z1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату X второй точки: ");
int x2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату Y второй точки: ");
int y2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату Z первой точки: ");
int z2 = int.Parse(Console.ReadLine()!);

double res1 = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2);
double res2 = Math.Sqrt(res1);
Console.Write($"А({x1},{y1},{z1}); B({x2},{y2},{z2}) -> {res2:f2} ");