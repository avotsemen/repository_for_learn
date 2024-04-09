// Напишите программу, которая принимает 
// на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер 
// координатной четверти плоскости, в 
// которой находится эта точка.

void QuarterPlane(double x, double y)
{
    if (x > 0 && y > 0)
    {
        System.Console.WriteLine($"Точка находится в первой координатной четверти.");
    }
    else if (x < 0 && y > 0)
    {
        System.Console.WriteLine($"Точка находится во второй координатной четверти.");
    }
    else if (x < 0 && y < 0)
    {
        System.Console.WriteLine($"Точка находится в третьей координатной четверти.");
    }
    else if (x > 0 && y < 0)
    {
        System.Console.WriteLine($"Точка находится в четвертой координатной четверти.");
    }
    else if (x == 0 || y == 0)
    {
        System.Console.WriteLine($"Точка находится в начале координат или на какой либо оси.");
    }
    
}

Console.Write("Введите координату Х: ");//выводим в консоль сообщение
double x = Convert.ToDouble(Console.ReadLine());//запрос ввода цифры
Console.Write("Введите координату У: ");//выводим в консоль сообщение
double y = Convert.ToDouble(Console.ReadLine());//запрос ввода цифры

QuarterPlane(x,y);