using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        double result = CalculateFunction(n);

        Console.WriteLine("Результат: " + result);
    }

    static double CalculateFunction(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            double factorial = CalculateFactorial(n);
            return (1 + factorial) / factorial;
        }
    }

    static double CalculateFactorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * CalculateFactorial(n - 1);
        }
    }
}

