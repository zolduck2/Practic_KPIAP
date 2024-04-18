using System;

class Program
{
    static double SumFor(double a)
    {
        double sum = 0;
        for (int i = 0; i <= a; i++)
        {
            sum += i;
        }
        return sum;
    }

    static double SumFor(double a, double b)
    {
        double sum = 0;
        for (int i = (int)a; i <= b; i++)
        {
            sum += i;
        }
        return sum;
    }

    static void Main()
    {
        Console.Write("Введите a1: ");
        double a1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите a2: ");
        double a2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите b2: ");
        double b2 = Convert.ToDouble(Console.ReadLine());

        double result = SumFor(a1) * SumFor(a2, b2);
        Console.WriteLine($"Результат: {result}");
    }
}
