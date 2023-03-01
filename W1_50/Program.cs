// 50. Напишите программу, которая на вход принимает позиции элемента в двумерном 
// массиве, и возвращает значение этого элемента или же указание, что такого 
// элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int [m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

void GetNum(int[,] inArray, int m, int n)
{
    int num = 0;
    if(m < inArray.GetLength(0) && n < inArray.GetLength(1))
    {
        num = inArray[m, n];
        Console.Write($"[{m}, {n}] ->Искомое число = {num}");
    }
    else
    {
        Console.Write($"[{m}, {n}] -> такого числа в массиве нет");
    }
}

Console.Clear();
Console.Write("Кол-во строк = ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Кол-во столбцов = ");
int col = int.Parse(Console.ReadLine()!);
int[,] array2D = GetArray(row, col, -10, 10);
PrintArray(array2D);
Console.Write("Номер строки = ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Номер столбца = ");
int n = int.Parse(Console.ReadLine()!);
GetNum(array2D, m, n);

