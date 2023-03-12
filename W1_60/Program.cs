// 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.

int[,,] GetArray(int m, int n, int r, int minValue, int maxValue)
{
    int[,,] result = new int[m, n, r];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < r; k++)
            {
                int temp = result[i, j, k];
                result[i, j, k] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }
    return result;
}

void Sort(int[,,] array)
{
       for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++) 
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j] = array[i, m])
                {
                        int temp = array[i, j];
                        array[i, j] = array[i, m];
                        array[i, m] = temp;
                }
            }
        }
    }
}


void PrintArray(int[,,] inArray)
{
    for (int k = 0; k < inArray.GetLength(2); k++)
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                Console.Write($"{inArray[i, j, k]}({i},{j},{k})\t ");
            }
            Console.WriteLine();
        }
    }
}

Console.Clear();
Console.Write("row = ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("col = ");
int col = int.Parse(Console.ReadLine()!);
Console.Write("level = ");
int level = int.Parse(Console.ReadLine()!);
int[,,] array2D = GetArray(row, col, level, 10, 99);
PrintArray(array2D);
