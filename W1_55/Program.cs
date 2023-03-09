// 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

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

int[,] SwapRowCol(int[,] oldArray)
{
    int[,] result = new int[oldArray.GetLength(1), oldArray.GetLength(0)];
    for (int i = 0; i < oldArray.GetLength(0); i++)
    {
        for (int j = 0; j < oldArray.GetLength(1); j++)
        {
            result[j, i] = oldArray[i, j];
        }
    }
    return result;
}

Console.Clear();
Console.Write("row = ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("col = ");
int col = int.Parse(Console.ReadLine()!);
int[,] array2D = GetArray(row, col, -10, 10);
PrintArray(array2D);

Console.WriteLine();
if (row != col)
{
    Console.WriteLine("преобразование невозможно");
}
else
{
    int[,] newArray = SwapRowCol(array2D);
    PrintArray(newArray);
}