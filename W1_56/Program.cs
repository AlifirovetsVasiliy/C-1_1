// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

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
int[] Transform2DTo1D(int[,] array2D)
{
    int[] array1D = new int[array2D.GetLength(0)];
    int k = 0;
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            sum = sum + array2D[i, j];
        }
        array1D[k++] = sum;
    }
    return array1D;
}
int SearchMinSum(int[] array1D)
{
    int min = array1D[0];
    int minRow = 1;
    for(int i = 1; i < array1D.Length; i++)
    {
        if (min > array1D[i])
        {
            min = array1D[i];
            minRow = i + 1; 
        }
    }
    return minRow;
}

Console.Clear();
Console.Write("row = ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("col = ");
int col = int.Parse(Console.ReadLine()!);
int[,] array2D = GetArray(row, col, -10, 10);
PrintArray(array2D);
Console.WriteLine();
int[] sumArray = Transform2DTo1D(array2D);
Console.Write($"{SearchMinSum(sumArray)} строка");
