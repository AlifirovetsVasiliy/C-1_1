// Напишите программу, которая по заданному номеру
// четверти, показывает диапазон возможных координат
// точек в этой четверти (x и y).


Console.Clear();

Console.Write("Введите число от 1 до 4: ");
    int ch = int.Parse(Console.ReadLine()!);

switch (ch)
{
    case 1:
        Console.Write("X>0, Y>0");
        break;
    case 2:
        Console.Write("X<0, Y>0");
        break;
    case 3:
        Console.Write("X<0, Y<0");
        break;
    case 4:
        Console.Write("X>0, Y<0");
        break;
    default:
        Console.Write("Введите число от 1 до 4: ");
        break;
}