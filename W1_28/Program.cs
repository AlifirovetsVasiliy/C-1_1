//Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Clear();

int Multi (int n)
{
    int prod = 1;

    for(int i = 1; i <= n; i++)
    {
        prod *= i; 
    }
    return prod;
}

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{N} = {Multi(N)}");



