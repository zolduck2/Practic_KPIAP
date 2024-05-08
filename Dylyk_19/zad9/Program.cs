using System;

/// <summary>
/// Делегат RandomNumberMethod представляет методы для генерации случайных чисел.
/// </summary>
/// <returns>Случайное число.</returns>
delegate int RandomNumberMethod();

class Program
{
    /// <summary>
    /// Точка входа в программу.
    /// </summary>
    static void Main()
    {
        RandomNumberMethod[] methods = new RandomNumberMethod[5];
        Random random = new Random();

        for (int i = 0; i < methods.Length; i++)
        {
            methods[i] = delegate () { return random.Next(1, 100); };
        }

        double average = CalculateAverage(methods);
        Console.WriteLine("Среднее значение: " + average);
    }

    /// <summary>
    /// Метод CalculateAverage вычисляет среднее значение результатов выполнения методов.
    /// </summary>
    /// <param name="methods">Массив методов для выполнения.</param>
    /// <returns>Среднее значение результатов выполнения методов.</returns>
    static double CalculateAverage(RandomNumberMethod[] methods)
    {
        int sum = 0;
        foreach (var method in methods)
        {
            sum += method();
        }
        return (double)sum / methods.Length;
    }
}
