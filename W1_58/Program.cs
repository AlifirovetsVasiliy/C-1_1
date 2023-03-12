// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int[,] MultiplyMatrix(int[,] firstArray, int[,] secondArray)
{
    int[,] resultArray = new int[firstArray.GetLength(0), secondArray.GetLength(1)];
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            for (int k = 0; k < secondArray.GetLength(0); k++)
            {
                resultArray[i, j] += firstArray[i, k] * secondArray[k, j];
            }
        }
    }
    return resultArray;
}

Console.Clear();
Console.Write("row1, col2 должны быть больше либо равны col1, row2");
Console.WriteLine();
Console.Write("row1 = ");
int row1 = int.Parse(Console.ReadLine()!);
Console.Write("col1 = row2 = ");
int col1 = int.Parse(Console.ReadLine()!);
int row2 = col1;
Console.Write("col2 = ");
int col2 = int.Parse(Console.ReadLine()!);
Console.WriteLine();
int[,] array1 = GetArray(row1, col1, -10, 10);
int[,] array2 = GetArray(row2, col2, -10, 10);
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();
PrintArray(MultiplyMatrix(array1, array2));
Console.WriteLine();


