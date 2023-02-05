// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.Write("Введите первое число: ");
int numbera = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int numberb = int.Parse(Console.ReadLine()!);

Console.Write("Введите третье число: ");
int numberc = int.Parse(Console.ReadLine()!);

int max = numbera;


if(numberb > max) max = numberb;
if(numberc > max) max = numberc;

Console.Write("max = ");
Console.Write(max);
