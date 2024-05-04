// Задайте произвольный массив. Выведете его элементы, 
// начиная с конца. Использовать рекурсию, не использовать циклы.


int[] CreateArray(int size, int min, int max) //функция создания массива
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void PrintArray(int[] array, int index) // функция печати массива с начала с помощью рекурсии
{
    if (index >= array.Length)
    {
        System.Console.WriteLine();
        return;
    }

    System.Console.Write(array[index] + " ");

    PrintArray(array, index + 1);
}

void PrintArrayRevers(int[] array, int index) // функция печати массива с конца с помощью рекурсии
{
    if (index < 0)
    {
        System.Console.WriteLine();
        return;
    }

    System.Console.Write(array[index] + " ");

    PrintArrayRevers(array, index - 1);
}

System.Console.WriteLine($"Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Введите минимальное значение элемента: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Введите максимальное значение элемента: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size, min, max);
System.Console.Write("Вывод массива сначала: ");
PrintArray(array, 0);
System.Console.Write("Вывод массива с конца: ");
PrintArrayRevers(array, array.Length - 1);
