// Напишите цикл, который принимает на вход два числа (A и B) и возводит 
// число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

int Exp(int A, int B)
{
    int exp = 1;
    for (int i = 0; i < B; i++)
    {
        exp *= A;
    }
    return exp;
}
int Exam(int C, int D)
{
    int res1 = 1;
    if (D > 0)
    {
        res1 = Exp(C, D);
        Console.Write($"{res1}");
    }
    else
    {
        Console.Write("Введено не натурвльное значение B");
    }
    return res1;
}

Console.Write("Введите число A: ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите натуральное число B: ");
int y = int.Parse(Console.ReadLine()!);

int res = Exam(x, y);
