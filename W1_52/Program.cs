// 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.

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

double GetAverage(int[,] newArray)
{
    double average = 0;
    for (int j = 0; j < newArray.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < newArray.GetLength(0); i++)
        {
            sum += newArray[i, j];
        }
        average = sum / newArray.GetLength(0);
        average = Math.Round(average, 2);
        Console.Write($"{average}; ");
    }
    return average = 0;
}

Console.Clear();
Console.Write("Кол-во строк = ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Кол-во столбцов = ");
int col = int.Parse(Console.ReadLine()!);
int[,] array2D = GetArray(row, col, -10, 10);
PrintArray(array2D);
Console.WriteLine();
double result = GetAverage(array2D);