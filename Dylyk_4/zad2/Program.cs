using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            if (x > -1 && x < 1)
            {
                double f = 3 * Math.Pow(x, 2) + 5 * x;
                Console.WriteLine($"f = 3x^2 + 5x = {f}");
            }
            else if (x >= 1)
            {
                double f = x / (3 * x + 6);
                Console.WriteLine($"f = x / (3x + 6) = {f}");
            }
            else
            {
                throw new ArgumentOutOfRangeException("x", "Значение x выходит за пределы допустимого диапазона.");
            }
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Ошибка: деление на ноль.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: неверный формат ввода.");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}

