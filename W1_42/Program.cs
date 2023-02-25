//  Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

string ConvertNumber(int num)
{
    string result = String.Empty;
    while (num != 0)
    {
        result = (num % 2).ToString() + result;
        num /= 2;
    }
    return result;
}

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(ConvertNumber(n));