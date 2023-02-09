// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.

Console.Clear();

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);

if (a < 100)
{
    Console.Write("третьей цифры нет");
}
else
{
    int b = a / 100;
    int c = b % 10;
    Console.Write(c);
}