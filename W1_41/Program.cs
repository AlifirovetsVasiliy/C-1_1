// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 
// ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int GetPositiveNum(int[] array)
{
    int positive = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        positive += 1;
    }
    return positive;
}

int[] GetArray(int size)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите следующее число: ");
        int num = int.Parse(Console.ReadLine()!);
        result[i] = num;
    }
    return result;
}
Console.Clear();
Console.Write("Введите колличество чисел M: ");
int m = int.Parse(Console.ReadLine()!);
int[] array = GetArray(m);
Console.Write(string.Join(", ",  array) + " колличество чисел > 0 = " + GetPositiveNum(array));


