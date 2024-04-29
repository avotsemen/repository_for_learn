//Задайте произвольную строку. Выясните, является ли она палиндромом.


bool CheckPalindrom(string str)
{
    string norm = new string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
    for (int i = 0; i < norm.Length; i++)
    {
        if (norm[i] == norm[norm.Length - 1 - i])
        {

        }
        else
        {
            return false;
        }
    }
    return true;
}
Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");
System.Console.WriteLine("Введите произвольную строку: ");
string str = Console.ReadLine();
if (CheckPalindrom(str) == true)
{
    System.Console.WriteLine($"Строка '{str}' является палиндромом");
}
else
{
    System.Console.WriteLine($"Строка '{str}' не является палиндромом");
}




// public class Task3
// {
//     public static void Main(string[] args)
//     {
//         // Входная строка для проверки
//         string input = "шалщш";
//         // Вызов метода для проверки, является ли строка палиндромом
//         bool isPalindrome = IsPalindrome(input);
//         // Вывод результата
//         Console.WriteLine(isPalindrome ? "Да" : "Нет");
//     }
//     // Метод для проверки, является ли строка палиндромом
//     public static bool IsPalindrome(string str)
//     {
//         // Нормализация строки путем удаления не буквенно-цифровыхсимволов и приведения к нижнему регистру
//         string normalized = new string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
//         // Сравнение строки с ее перевернутым вариантом
//         return normalized.SequenceEqual(normalized.Reverse());
//     }
// }