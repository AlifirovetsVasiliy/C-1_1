// Напишите программу, которая найдёт точку пересечения двух прямых, заданных
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] GetCoor(double k1, double k2, double b1, double b2)
{
    double[] array = new double[2];
    array[0] = (b2 - b1) / (k1 - k2);
    array[1] = k1 * ((b2 - b1) / (k1 - k2)) + b1;
    return array;
}
Console.Clear();
Console.Write("Введите число k1: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число k2: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите число b1: ");
int c = int.Parse(Console.ReadLine()!);
Console.Write("Введите число b2: ");
int d = int.Parse(Console.ReadLine()!);
if(c != d)
{
    double[] newArray = GetCoor(a, b, c, d);
    Console.WriteLine(String.Join(", ", newArray));
}
else
{
    Console.WriteLine("Прямые параллельны, или пересекаются");
}