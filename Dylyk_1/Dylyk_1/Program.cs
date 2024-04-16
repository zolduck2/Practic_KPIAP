using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        double y;

        if (x > 2.8 && x < 6)
        {
            y = (x - 1) / (x + 1);
        }
        else if (x > 6)
        {
            y = Math.Exp(x) + Math.Sin(x);
        }
        else
        {
            Console.WriteLine("Ошибка");
            return;
        }

        Console.WriteLine($"Значение y для данного x: {y}");
    }
}

