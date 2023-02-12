// Задача №17. Напишите программу, которая
// принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти
// плоскости, в которой находится эта точка.

Console.Clear();

Console.Write("Введите координату X (не равна 0): ");
    int corX = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату Y (не равна 0): ");
    int corY = int.Parse(Console.ReadLine()!);

    while (corX == 0 || corY == 0)
    {
        Console.Write("Введите координату X (не равна 0): ");
        corX = int.Parse(Console.ReadLine()!);

        Console.Write("Введите координату Y (не равна 0): ");
        corY = int.Parse(Console.ReadLine()!);
    }
    int q = 0;
    if (corX > 0 && corY > 0)
    {
            q = 1;
    }
    else
    {
        if (corX < 0 && corY > 0)
        {
            q = 2;
        }
        else
        {
            if (corX < 0 && corY < 0)
            {
                q = 3;
            }
            else
            {
                if (corX > 0 && corY < 0)
                {
                    q = 4;
                }
            }
        }
    }
Console.WriteLine($"Координаты находятся в {q} четверти");
