// Задайте одномерный массив, заполненный случайными числами. Найдите сумму 
// элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}
int SumArray(int[] array)
{
    int result = 0;
    for (int i = 1; i <= array.Length; i += 2)
    {
        result += array[i];
    }
    return result;
}
int[] inArray = GetArray(10, -99, 99);
Console.WriteLine(string.Join(", ", inArray));
int sum = SumArray(inArray);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна :{sum}");