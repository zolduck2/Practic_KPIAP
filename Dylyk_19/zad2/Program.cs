using System;

/// <summary>
/// Класс Program содержит основную логику программы.
/// </summary>
class Program
{
    /// <summary>
    /// Метод AddLeftDigit добавляет цифру D слева к числу K.
    /// </summary>
    /// <param name="D">Цифра, которую нужно добавить.</param>
    /// <param name="K">Число, к которому добавляется цифра.</param>
    static void AddLeftDigit(int D, ref int K)
    {
        int power = 1;
        while (power <= K)
        {
            power *= 10;
        }
        K = power * D + K;
    }

    /// <summary>
    /// Метод Main - точка входа в программу.
    /// </summary>
    static void Main()
    {
        Console.Write("Введите число K: ");
        int K = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите цифру D1: ");
        int D1 = Convert.ToInt32(Console.ReadLine());
        AddLeftDigit(D1, ref K);
        Console.WriteLine($"Результат после добавления D1: {K}");

        Console.Write("Введите цифру D2: ");
        int D2 = Convert.ToInt32(Console.ReadLine());
        AddLeftDigit(D2, ref K);
        Console.WriteLine($"Результат после добавления D2: {K}");
    }
}
