//  Задайте одномерный массив из 10 целых чисел от 1 до 100.
//  Найдите количество элементов массива, 
//  значения которых лежат в отрезке [10,90].

using System;
using System.Linq;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{
    // Подсчет количества элементов массива, попадающих в заданный диапазон
    // numbers - массив, в котором ведется подсчет
    // minRange - минимальная граница диапазона
    // maxRange - максимальная граница диапазона


    public static int CountItemsRange(int[] numbers, int minRange, int maxRange)
    {
        //Введите сюда свое решение
        int count = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] >= minRange && numbers[i] <= maxRange)
            {
                count++;
            }
        }
        return count;
    }

    public static void PrintResult(int[] array)
    {
        // int[] WriteInArray(int size, int min, int max) //Функция записи в массив 
        // {
        //     array = new int[size];
        //     for (int i = 0; i < array.Length; i++)
        //     {
        //         array[i] = new Random().Next(min, max + 1);
        //     }
        //     return array;
        // }
        // void PrintArray(int[] array) // функция печати массива
        // {
        //     for (int i = 0; i < array.Length; i++)
        //     {
        //         System.Console.Write(array[i] + " ");
        //     }
        //     System.Console.WriteLine();
        // }
        //System.Console.WriteLine("Введите размер массива: ");
        //int size = Convert.ToInt32(Console.ReadLine());
        // System.Console.WriteLine("Введите минимальное значение элемента: ");
        // int min = Convert.ToInt32(Console.ReadLine());
        // System.Console.WriteLine("Введите максимальное значение элемента: ");
        // int max = Convert.ToInt32(Console.ReadLine());
        //System.Console.WriteLine("Введите минимальное значение границы диапазона: ");
        int minRange = 10; //Convert.ToInt32(Console.ReadLine());
        //System.Console.WriteLine("Введите максимальное значение границы диапазона: ");
        int maxRange = 90; //Convert.ToInt32(Console.ReadLine());

        //WriteInArray(size,min,max);
        //PrintArray(array);
        System.Console.WriteLine(CountItemsRange(array, minRange, maxRange));
    }

}


//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        int[] array;


        if (args.Length >= 1)
        {
            // Объединяем все аргументы командной строки в одну строку
            string joinedArgs = string.Join(" ", args);

            // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
            array = joinedArgs.Split(", ")
                                  .Select(int.Parse)
                                  .ToArray();

            // Теперь arr содержит преобразованные в целые числа из командной строки

        }
        else
        {
            // Если аргументов на входе нет
            array = new int[] { 1, 5, 10, 20, 30, 40, 99, 4, 90, 3 }; // Создание массива
        }
        UserInputToCompileForTest.PrintResult(array);
    }
}