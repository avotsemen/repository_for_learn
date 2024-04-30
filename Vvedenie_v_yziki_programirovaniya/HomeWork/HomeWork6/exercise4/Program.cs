using System;

class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16"); // Устанавливаем кодировку ввода на UTF-16
        Console.WriteLine("Введите строку из слов, разделенных пробелами:");
        string input = Console.ReadLine();

        string reversedString = ReverseWords(input);
        
        Console.WriteLine("Строка c обратным порядком слов:");
        Console.WriteLine(reversedString);
    }

    static string ReverseWords(string str)
    {
        // Разбиваем строку на слова
        string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // Обратный порядок слов
        Array.Reverse(words);

        // Объединяем слова обратно в строку с пробелами
        return string.Join(" ", words);
    }
}