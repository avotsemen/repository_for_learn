//int n = 10;
int[] array = { 2, 2, 8, 6, 4, 8, 9, 28, 252, 2 };
int i = 0;

while (i < array.Length)
{
    if (array[i] % 2 == 0)
    {
        System.Console.Write($"{array[i]} ");
    }
    i++;
}