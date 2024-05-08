using System;

/// <summary>
/// Главный класс программы.
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу.
    /// </summary>
    static void Main()
    {
        Console.Write("Введите a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите h: ");
        double h = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\n x \t f(x)");

        for (double x = a; x <= b; x += h)
        {
            double fx;

            /// <summary>
            /// Вычисление функции f(x) в зависимости от значения x.
            /// </summary>
            if (x <= 2)
                fx = Math.Pow(Math.Tan(x), 2) + Math.Pow(a * x, 5.0 / 2.0);
            else if (x > 2 && x <= 5)
                fx = 3 - Math.Pow(a * x, 2);
            else
                fx = (2 * Math.Pow(x, 3)) / x + (a * b) / 3;

            Console.WriteLine($"{x}\t{fx}");
        }
    }
}
