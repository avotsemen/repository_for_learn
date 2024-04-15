using System;
using System.Linq;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{
    // Разница между максимальным и минимальным элементами массива

    // Нахождение минимума массива
    public static double FindMin(double[] numbers)
    {
        double minNum = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < minNum)
            {
                minNum = numbers[i];
            }
        }
        return minNum;
    }

    // Нахождение максимума массива
    public static double FindMax(double[] numbers)
    {
        double maxNum = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > maxNum)
            {
                maxNum = numbers[i];
            }
        }
        return maxNum;
    }


    public static void PrintResult(double[] array)
    {
        double[] WriteInArray(int size, int min, int max) //Функция записи в массив 
        {
            array = new double[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(min, max) + new Random().NextDouble();
            }
            return array;
        }

        void PrintArray(double[] array) // функция печати массива
        {
            for (int i = 0; i < array.Length; i++)
            {
                System.Console.Write(Math.Round(array[i],2) + " ");
            }
            System.Console.WriteLine();
        }

        System.Console.WriteLine("Введите размер массива: ");
        int size = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Введите минимальное значение элемента: ");
        int min = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Введите максимальное значение элемента: ");
        int max = Convert.ToInt32(Console.ReadLine());


        WriteInArray(size,min,max);
        PrintArray(array);
        double sum = Math.Round(FindMax(array) - FindMin(array), 2) ;
        System.Console.WriteLine(sum);

    }
}
//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        double[] array;


        if (args.Length >= 1)
        {
            // Объединяем все аргументы командной строки в одну строку
            string joinedArgs = string.Join(" ", args);

            // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
            array = joinedArgs.Split(", ")
                                  .Select(double.Parse)
                                  .ToArray();

            // Теперь arr содержит преобразованные в целые числа из командной строки

        }
        else
        {
            // Если аргументов на входе нет
            array = new double[] { 0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01 }; // Создание массива
        }
        UserInputToCompileForTest.PrintResult(array);
    }
}