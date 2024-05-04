// Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.    


int AckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (n == 0)
    {
        return AckermannFunction(m - 1, 1);
    }
    else
    {
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
}

void RequestInput()
{
    System.Console.WriteLine("Введите значение m:");
    int m = Convert.ToInt32(Console.ReadLine());

    System.Console.WriteLine("Введите значение n:");
    int n = Convert.ToInt32(Console.ReadLine());
    if (m >= 0 && n >= 0)
    {
        int result = AckermannFunction(m, n);
        System.Console.WriteLine($"Результат функции Аккермана для m = {m} и n = {n}: {result}");
    }
    else
    {
        System.Console.WriteLine("Значения m и n не должны быть отрицательными");
        RequestInput();
    }
}

RequestInput();