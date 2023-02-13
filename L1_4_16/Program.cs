﻿// Фибоначчи
// f(1) = 1
// f(2) = 2
// f(n) = f(n-1) + f(n-2)

Console.Clear();

Double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}