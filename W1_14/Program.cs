// Напишите программу, которая принимает на вход
//число и проверяет, кратно ли оно одновременно
//7 и 23.

Console.Clear();

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
int b = 7;
int c = 23;
int d = a % b;
int e = a % c;
if (d == 0 & e == 0)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}