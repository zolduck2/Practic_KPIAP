using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение x:");
        double x = Convert.ToDouble(Console.ReadLine());

        double z1 = (Math.Pow(x, 2) + 2 * x - 3 + (x + 1) * Math.Sqrt(Math.Pow(x, 2) - 9)) /
                    (Math.Pow(x, 2) - 2 * x - 3 + (x - 1) * Math.Sqrt(Math.Pow(x, 2) - 9));

        double z2 = Math.Sqrt(x + 3) / (Math.Sqrt(x) - 3);

        Console.WriteLine($"z1: {z1}");
        Console.WriteLine($"z2: {z2}");
    }
}

