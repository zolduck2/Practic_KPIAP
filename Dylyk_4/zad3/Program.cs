using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Введите число K: ");
            int K = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите цифру D1: ");
            int D1 = Convert.ToInt32(Console.ReadLine());
            if (D1 < 0 || D1 > 9)
            {
                throw new ArgumentOutOfRangeException("D1", "Цифра D1 должна быть в диапазоне от 0 до 9.");
            }

            Console.Write("Введите цифру D2: ");
            int D2 = Convert.ToInt32(Console.ReadLine());
            if (D2 < 0 || D2 > 9)
            {
                throw new ArgumentOutOfRangeException("D2", "Цифра D2 должна быть в диапазоне от 0 до 9.");
            }

            K = AddRightDigit(D1, K);
            Console.WriteLine($"После добавления D1: {K}");

            K = AddRightDigit(D2, K);
            Console.WriteLine($"После добавления D2: {K}");
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

    static int AddRightDigit(int D, int K)
    {
        return K * 10 + D;
    }
}
