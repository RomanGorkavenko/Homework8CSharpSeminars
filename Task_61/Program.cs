
// double mul = Factorial(5);
// Console.WriteLine(mul);
// Console.WriteLine();

PrintTrianglePascal(5);

double Factorial(int number)
{
    double multiplication = 1;
    for (int i = 1; i <= number; i++)
    {
        multiplication *= i; 
    }
    return multiplication;
}

void PrintTrianglePascal(int numberRow)
{
    // n! / (k! * (n - k)!)
    for (int n = 0; n < numberRow; n++)
    {
        for (int i = 0; i < numberRow - n; i++)
        {
            Console.Write(" ");
        }
        for (int k = 0; k <= n; k++)
        {
            Console.Write($"{Factorial(n) / (Factorial(k) * (Factorial(n - k)))} ");
        }
        Console.WriteLine();
    }
}
