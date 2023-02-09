//Напишите программу, которая будет принимать на
//вход два числа и выводить, является ли второе число
//кратным первому. Если число 2 не кратно числу 1, то
//программа выводит остаток от деления

Console.Clear();

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
int c = a % b;
if (c == 0)
{
    Console.Write("Кратно");
}
else
{
    Console.Write($"не кратно, остаток {c}");
}