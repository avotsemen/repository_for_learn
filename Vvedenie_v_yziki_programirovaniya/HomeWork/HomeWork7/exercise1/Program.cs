// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

void PrintMtoN(int m, int n)
{
    if (m > n)
    {
        if (n > 0)
        {
            System.Console.Write($"{n} ");
        } 
        PrintMtoN(m, n + 1);
    }
    if (m < n)
    {
        if (m > 0)
        {
            System.Console.Write($"{m} ");
        } 
        PrintMtoN(m + 1, n);
    }
    if (m == n)
    {
        if (m > 0)
        {
            System.Console.Write($"{m} ");
        } 
        else
        {
            System.Console.WriteLine($"В промежутке чисел от M до N нет натуральных чисел");
        }
    }
}


System.Console.WriteLine("Ввведите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Ввведите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

PrintMtoN(m, n);