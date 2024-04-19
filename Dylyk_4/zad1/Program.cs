using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double y1 = 1 - 4 / (4 * x + 8);
            Console.WriteLine($"y = 1 - 4 / (4x + 8) = {y1}");

            double y2 = Math.Tan(x) * Math.Tan(x) + 1 / (x - 1);
            Console.WriteLine($"y = tg^2(x) + 1 / (x - 1) = {y2}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Ошибка: деление на ноль.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: неверный формат ввода.");
        }
    }
}
