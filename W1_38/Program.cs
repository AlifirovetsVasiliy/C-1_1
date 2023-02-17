// Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

double[] GetArray(int size, double minValue, double maxValue)
{
    double[] result = new double[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().NextDouble() * (maxValue - minValue) + minValue;//подсмотрел, дальше сам
        result[i] = Math.Round(result[i],2);
    }
    return result;
}
double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}
double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}
double[] newArray = GetArray(10, 1, 50);
Console.WriteLine(string.Join(" | ", newArray));
double difference = FindMax(newArray) - FindMin(newArray);
Console.WriteLine ($"Разница между максимальным и минимальным элементом равна: {difference}");