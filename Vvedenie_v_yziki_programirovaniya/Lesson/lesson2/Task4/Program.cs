//int n = 5;
int[] array = { 59, 6, 4, 5, 58 };
int i = 0;
int max = array[0];

while (i < array.Length)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    i++;
}
System.Console.WriteLine(max);

max = array[0];
for(int j = 0; j < array.Length; j++)
{
    if (array[j] > max)
    {
        max = array[j];
    }
}
System.Console.WriteLine(max);

max = array[0];
foreach (int e in array)
{
    if (e > max)
    {
        max = e;
    }
}
System.Console.WriteLine(max);