using System;

/// <summary>
/// Класс Program содержит основную логику программы.
/// </summary>
class Program
{
    /// <summary>
    /// Метод SumFor вычисляет сумму чисел от 0 до a.
    /// </summary>
    /// <param name="a">Верхний предел суммы.</param>
    /// <returns>Сумма чисел от 0 до a.</returns>
    static double SumFor(double a)
    {
        double sum = 0;
        for (int i = 0; i <= a; i++)
        {
            sum += i;
        }
        return sum;
    }

    /// <summary>
    /// Метод SumFor вычисляет сумму чисел от a до b.
    /// </summary>
    /// <param name="a">Нижний предел суммы.</param>
    /// <param name="b">Верхний предел суммы.</param>
    /// <returns>Сумма чисел от a до b.</returns>
    static double SumFor(double a, double b)
    {
        double sum = 0;
        for (int i = (int)a; i <= b; i++)
        {
            sum += i;
        }
        return sum;
    }

    /// <summary>
    /// Метод Main - точка входа в программу.
    /// </summary>
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
