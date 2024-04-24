// Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

string CreateNewRandomString(int length) //Функция создания случайной строки длиной length
{
    Random rnd = new Random();
    string str = string.Empty;
    string chars = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&";
    for (int i = 0; i < length; i++)
    {
        str = str + chars[rnd.Next(0, chars.Length)];
    }
    return str;
}

string GetLettersUpToDown(string str) //Функция понижения регистра
{
    string strLow = str.ToLower();
    return strLow;
}

System.Console.WriteLine("Введите длину строки: ");
int length = Convert.ToInt32(Console.ReadLine());
string temp = CreateNewRandomString(length);
System.Console.WriteLine(temp);
System.Console.WriteLine(GetLettersUpToDown(temp));