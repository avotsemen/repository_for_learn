void PrintSquares(int limit)
{
    int i =1;
    while (i<=limit)
    {
        System.Console.Write($"{i*i} ");
        i++;
    }
}
PrintSquares(5);
System.Console.WriteLine();
PrintSquares(10);
System.Console.WriteLine();
PrintSquares(15);