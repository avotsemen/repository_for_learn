//Напишите программу, 
//которая принимает на вход число и проверяет, 
//кратно ли оно одновременно 7 и 23.

void CheckMultiplicity(int num)
{
    if (num % 7 == 0 && num % 23 == 0)
    {
        System.Console.WriteLine($"число {num} кратно числу 7 и 23");
    }
    else
    {
        System.Console.WriteLine($"число {num} не кратно числу 7 и 23");
    }
}

Console.Write("Введите число: ");//выводим в консоль сообщение
int num = Convert.ToInt32(Console.ReadLine());//запрос ввода цифры

//System.Console.WriteLine(DeleteSecondDigit(num));
CheckMultiplicity(num);