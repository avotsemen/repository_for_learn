// Напишите программу, которая на вход 
// принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.

void Main(int n)
{

    if (n > 0)
    {
        int divider = 10;
        while (divider <= n )
        {
            divider*=10;
        }
        divider /=10;
        int currentDigit = 0;
        while (divider >= 10)
        {
            currentDigit = n / divider;
            n = n % divider;
            System.Console.Write($"{currentDigit}, ");
            divider /= 10;
        }
        currentDigit = n / divider;
        System.Console.Write($"{currentDigit}");
    }
    else
    {
        System.Console.WriteLine("Введите значение больше 0.");
        n = Convert.ToInt32(Console.ReadLine());
        Main(n);
    }
}


Console.Write("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Main(n);
