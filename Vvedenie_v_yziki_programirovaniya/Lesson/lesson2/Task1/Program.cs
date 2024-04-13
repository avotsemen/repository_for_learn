int[] arr = new int [5];
arr[0] = 5;
arr[1] = 7;
arr[2] = 2;
arr[3] = 6;
arr[4] = 3;
System.Console.WriteLine(arr[0]);
System.Console.WriteLine(arr[1]);
System.Console.WriteLine(arr[2]);
System.Console.WriteLine(arr[3]);
System.Console.WriteLine(arr[4]);

//System.Console.WriteLine(arr[5]);

int[] arr2 = new int[5]{1,2,3,4,5};

int[] arr3 = {5,4,3,2,1};

System.Console.WriteLine($"Массив 'arr2':");
for (int i = 0; i < arr2.Length; i++)
{
    System.Console.Write($"{arr2[i]}, ");
}
