double CalcuateFormula(int a, int b, int c, int d)
{
    double numenator = a * b;
    int denomerator = c + d;
    double result = numenator / denomerator;
    return result;
}

double result = CalcuateFormula(1, 2, 3, 4);
System.Console.WriteLine(result);