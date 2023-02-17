// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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

bool FindElement(int number, int[] collection)
{
    foreach (int el in collection)
    {
        if (el == number)
        {
            return true;
        }
    }
    return false;


}

int[] array = GetArray(12, -9, 9);
Console.WriteLine(string.Join(", ", array));
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
if (FindElement(n, array))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
