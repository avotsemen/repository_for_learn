int n = 10;
int[] arr = new int[n];
int i = 0;

while (i < arr.Length)
{
    arr[i] = i + 1;
    //System.Console.Write(arr[i]);
    //System.Console.Write(' ');
    System.Console.Write($"{arr[i]} ");
    i++;
}