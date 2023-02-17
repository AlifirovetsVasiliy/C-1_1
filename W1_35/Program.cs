//  одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99]. 

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

int printArray(int[] inArray, int minNumber, int maxNumber)
{
    int resultNum = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i] >= minNumber && inArray[i] <= maxNumber)
        {
            resultNum += 1;
        }
    }
    return resultNum;
}

int[] array = GetArray(123, 0, 300);
Console.WriteLine(string.Join(", ", array));
int resultN = printArray(array, 10, 99);
Console.WriteLine($"Колличество чисел в диапозоне значений от 10 до 99  равно {resultN}");

