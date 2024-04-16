﻿// Задача 1: Напишите программу, которая бесконечно 
// запрашивает целые числа с консоли. Программа завершается
// при вводе символа ‘q’ или при вводе числа,
// сумма цифр которого чётная.

using System;
class Program
{
    static void Main()
    {
        bool InputNum()
        {
            System.Console.WriteLine("Введите любое целое число или 'q' для выхода: ");
            string input = System.Console.ReadLine();

            if (input == "q")
            {
                System.Console.WriteLine($"Вы ввели букву 'q'. До свидания! ");
                return false;
            }

            else
            {
                if (int.TryParse(input, out int number))
                {
                    int num = Convert.ToInt32(input);
                    if (num > 0)
                    {
                        int lenStr = input.Length;
                        int sum = 0;
                        for (int i = 1; i < lenStr; i++)
                        {
                            sum = sum + num / (int)Math.Pow(10, lenStr - i);
                            num = num % (int)Math.Pow(10, lenStr - i);
                        }
                        sum = sum + num;
                        if (sum % 2 == 0)
                        {
                            System.Console.WriteLine($"Вы ввели число {num}, сумма цифр которого равна {sum} - это четное число. До свидания!");
                            return false;
                        }
                        System.Console.WriteLine($"Вы ввели число {num}, сумма цифр которого равна {sum} - это нечетное число.");
                        return true;
                    }
                    else
                    {
                        System.Console.WriteLine($"Вы ввели число {num}. Число должно быть положительным.");
                        return true;
                    }
                }

            }

            System.Console.WriteLine($"Вы ввели: {input}. Введенные данные не распознаны.");
            return true;
        }



        while (InputNum() == true) { }

    }
}