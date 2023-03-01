// 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

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

void GetSqrArray(int[,] originalArray)
{
    for (int i = 0; i < originalArray.GetLength(0); i++)
    {
        if (i % 2 != 0) continue;
        for (int j = 0; j < originalArray.GetLength(1); j++)
        {
            if (j % 2 == 0) originalArray[i, j] *= originalArray[i, j];
        }
    }
}


Console.Clear();
Console.Write("Кол-во строк = ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Кол-во столбцов = ");
int col = int.Parse(Console.ReadLine()!);

int[,] array2D = GetArray(row, col, -10, 10);
PrintArray(array2D);
Console.WriteLine();
GetSqrArray(array2D);
PrintArray(array2D);
