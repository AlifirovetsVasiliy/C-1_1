// Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}

int[] CloneArray(int[] inArray)
{
    int[] newArr = new int [inArray.Length];

    for (int i = 0; i < inArray.Length; i++)
    {
        newArr[i] = inArray[i];
    }
    return newArr;
}

Console.Clear();
int[] array = GetArray(5, -10, 10);
Console.WriteLine(String.Join(", ", array));
int[] clone = CloneArray(array);
Console.WriteLine("Clone: " + String.Join(", ", clone));