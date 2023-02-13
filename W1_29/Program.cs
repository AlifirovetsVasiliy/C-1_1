// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и 
//выводит их на экран.
Console.Clear();

int[] genArray(int Length, int minV, int maxV)
{
    int[] array = new int[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minV, maxV + 1);
    }
    return array;
}

void printArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
        Console.Write($"{inArray[i]} ");
}
Console.Write("Введите длину массива: ");
int L = int.Parse(Console.ReadLine()!);
Console.Write("Минимальное значение случайной величины: ");
int minNum = int.Parse(Console.ReadLine()!);
Console.Write("Максимальное значение случайной величины: ");
int maxNum = int.Parse(Console.ReadLine()!);

int[] array = genArray(L, minNum, maxNum);
printArray(array);