// 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д

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

// int GetSumArray(int[,] newArray)
// {
//     int sum = 0;
//     for (int i = 0; i < newArray.GetLength(0); i++)
//     {
    
//         for (int j = 0; j < newArray.GetLength(1); j++)
//         {
//             if (i == j) sum += newArray[i, j];
//         }
//     }
//     return sum;
// }
int GetSumArray(int[,] newArray)
{
    int sum = 0;
    int size = newArray.GetLength(0) > newArray.GetLength(1) ? newArray.GetLength(1) : newArray.GetLength(0);
    for (int i = 0; i < size; i++)
    {
        {
        sum += newArray[i, i];
        }
    }
    return sum;
}


Console.Clear();
Console.Write("Кол-во строк = ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Кол-во столбцов = ");
int col = int.Parse(Console.ReadLine()!);

int[,] array2D = GetArray(row, col, -10, 10);
PrintArray(array2D);
Console.WriteLine();
Console.Write($"Сумма главной диагонали равна: {GetSumArray(array2D)}");