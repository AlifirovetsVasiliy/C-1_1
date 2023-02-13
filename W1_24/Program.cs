//Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Clear();

Console.Write("Введите  A: ");
int N = int.Parse(Console.ReadLine()!);
// int Sum = 0;
// for (int n = 1; n <= A; n++)
// {
//     Sum = Sum + n;
// }
//     Console.WriteLine($"{A} = {Sum}");

int GetSum (int A)
{
    int sum = 0;
    for (int i = 1; i <= A; i++)
    {
        sum +=i; // sum = sum + i
    }
    return sum;
}
 Console.WriteLine($"Сумма чисел от 1 до {N} равна {GetSum(N)}");