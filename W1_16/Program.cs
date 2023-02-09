// Напишите программу, которая принимает на вход два
// числа и проверяет, является ли одно число квадратом
// другого.


Console.Clear();

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);

Console.Clear();

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);

if (b * b == a || a * a == b)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}