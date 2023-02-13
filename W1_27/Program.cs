// Задача 27: Напишите программу, которая принимает на вход число и выдаёт 
// сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

int ReSum (int n)
{
    int res = 0;
    while (n > 0)
    {
        res += n % 10;
        n = n / 10;
    }
    return res;
}


Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма всех чисел в: {N} равна: {ReSum(N)}");