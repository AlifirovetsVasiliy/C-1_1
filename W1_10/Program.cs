//Напишите программу, которая принимает на вход трёхзначное число и на выходе 
//показывает вторую цифру этого числа.


Console.Clear();

int num = new Random().Next(100, 1000); // 100 - 999
int a1 = num % 100;
int a2 = a1 / 10;

Console.WriteLine($"Результат действия числа {num} равна {a2}");
