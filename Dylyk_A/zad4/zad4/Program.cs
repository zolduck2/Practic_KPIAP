using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите длину стороны a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите длину стороны b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите длину стороны c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double p = (a + b + c) / 2.0;
        double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

        Console.WriteLine($"Площадь треугольника: {area}");
    }
}
