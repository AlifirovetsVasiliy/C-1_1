//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
Console.Write("Введите первое число: ");
int numbera = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int numberb = int.Parse(Console.ReadLine()!);


if(numbera > numberb)
{
    Console.Write("Большее число: ");
    Console.WriteLine(numbera);
    Console.Write("Меньшее число: ");
    Console.WriteLine(numberb);
}
else
{
    Console.Write("Большее число: ");
    Console.WriteLine(numberb);
    Console.Write("Меньшее число: ");
    Console.WriteLine(numbera);
}
