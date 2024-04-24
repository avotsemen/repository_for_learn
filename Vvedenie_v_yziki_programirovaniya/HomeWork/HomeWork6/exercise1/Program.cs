// Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.

char[,] CreateMatrix(int rowCount, int columsCount) //функция создания случайного массива из символов
{
    char[,] matrix = new char[rowCount, columsCount];

    string chars = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&";
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Random rnd = new Random();
            matrix[i, j] = chars[rnd.Next(0, chars.Length)];
        }
    }
    return matrix;
}

string GetCharToString(char[,] matrix) //Функция создания строки из двумерного массива символов
{
    string str = "";
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            str = str + matrix[i,j];
        }
    }
    return str;
}

System.Console.WriteLine("Введите количество сторок в массиве: ");
int rowCount = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов в массиве: ");
int columsCount = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(GetCharToString(CreateMatrix(rowCount,columsCount))); //Выводим строку в консоль
