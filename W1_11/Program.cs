//Напишите программу, которая выводит случайное
//трехзначное число и удаляет вторую цифру этого
//числа.


Console.Clear();

int num = new Random().Next(100, 1000); // 100 - 999
int a1 = num / 100;
int a2 = num % 10;

int result = (a1 * 10 + a2);

Console.WriteLine($"Результат действия числа {num} равна {result}");
