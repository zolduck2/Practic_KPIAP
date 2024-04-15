using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение x");
        double x = Convert.ToDouble(Console.ReadLine());
        double y = 3 * Math.Pow(x, 2) + (Math.Exp(x) / (2 * Math.PI)) - Math.Log(Math.Sqrt(3 - Math.Pow(Math.Sin(x), 2)));
        Console.WriteLine($"Значение y для x = {x} равно: {y}");
    }
}
