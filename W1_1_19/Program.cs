// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

Console.Write("Введите пятизначное число: ");
int N = int.Parse(Console.ReadLine()!);

if (N < 10000) Console.Write("Число не пятизначное");
else
{
    int a0 = N / 10000;
    int a1 = (N / 1000) % 10;
    int a3 = (N / 10) % 10;
    int a4 = N % 10;
    if (a0 == a4 && a1 == a3)
    {
        Console.Write("Да");
    }
    else Console.Write("Нет");
}

