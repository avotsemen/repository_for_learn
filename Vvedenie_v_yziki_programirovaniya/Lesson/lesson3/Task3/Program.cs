void ZeroEvenElements(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}

void PrintArray(int[] arr)
{
    foreach (var e in arr)
    {
        System.Console.Write($"{e} ");
    }
}

int[] array = { 8, 2, 3, 4, 6 };
ZeroEvenElements(array);
PrintArray(array);