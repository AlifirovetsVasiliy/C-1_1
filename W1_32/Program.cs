//  Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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

void SigChange(int[] newArray)
{
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] *= -1;
    }
}

int[] array = GetArray(12, -9, 9);
Console.WriteLine(string.Join(", ", array));
SigChange(array);
Console.WriteLine(string.Join(", ", array));
