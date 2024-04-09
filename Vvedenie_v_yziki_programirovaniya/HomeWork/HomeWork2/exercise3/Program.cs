// Напишите программу, которая принимает 
// на вход целое число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

void FindMaxDigit(int n)
{

    if (9 < n && n < 100)
    {
        int ed = n % 10;
        int des = n / 10;
        if (ed >= des)
        {
            System.Console.WriteLine(ed);
        }
        else 
        {
            System.Console.WriteLine(des);
        }
    }
    else
    {
        System.Console.WriteLine("Вы ввели не двухзначное число");
    }
}

Console.Write("Введите двухзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
FindMaxDigit(n);
