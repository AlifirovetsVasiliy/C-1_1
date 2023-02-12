// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между
// ними в 2D пространстве.
// ● A (3,6); B (2,1) -> 5,09
// ● A (7,-5); B (1,-1) -> 7,21


Console.Clear();

Console.Write("Введите координату X первой точки: ");
int x1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату Y первой точки: ");
int y1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату X второй точки: ");
int x2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату Y второй точки: ");
int y2 = int.Parse(Console.ReadLine()!);

double res1 = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2);
double res2 = Math.Sqrt(res1);
Console.Write($"А({x1},{y1}); B({x2},{y2}) -> {res2:f2} ");
