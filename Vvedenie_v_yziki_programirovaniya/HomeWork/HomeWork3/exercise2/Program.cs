using System;
using System.Linq;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{ 
    // Подсчет количества четных элементов массива
    // numbers - массив, в котором ведется подсчет
    public static int CountEvenItems(int[] numbers)
    {
        //Напишите свое решение здесь
        int count = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }
    
    public static void PrintResult(int[] array)
    {
        //Напишите свое решение здесь
        int[] WriteInArray(int size, int min, int max) //Функция записи в массив 
        {
            array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(min, max + 1);
            }
            return array;
        }
        void PrintArray(int[] array) // функция печати массива
        {
            for (int i = 0; i < array.Length; i++)
            {
                System.Console.Write(array[i] + " ");
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
        System.Console.Write($"В массиве четных чисел: ");
        System.Console.WriteLine(CountEvenItems(array));
    }
}

//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        int[] array;
        

        if (args.Length >= 1) {
            // Объединяем все аргументы командной строки в одну строку
            string joinedArgs = string.Join(" ", args);

            // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
            array = joinedArgs.Split(", ")
                                  .Select(int.Parse)
                                  .ToArray();
            
            // Теперь arr содержит преобразованные в целые числа из командной строки
        
        } else {
           // Если аргументов на входе нет
            array = new int[] {2, 5, 2, 3, 6, 3, 7, 8, 2, 4}; // Создание массива
        }
        UserInputToCompileForTest.PrintResult(array);
    }
}