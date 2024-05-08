using System;

/// <summary>
/// Делегат StringDelegate представляет методы для работы со строками.
/// </summary>
/// <param name="str">Строка для обработки.</param>
/// <returns>Обработанная строка.</returns>
delegate string StringDelegate(string str);

class Program
{
    /// <summary>
    /// Метод Reverse переворачивает строку.
    /// </summary>
    /// <param name="str">Строка для переворачивания.</param>
    /// <returns>Перевернутая строка.</returns>
    static string Reverse(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    /// <summary>
    /// Метод ToUpper преобразует строку в верхний регистр.
    /// </summary>
    /// <param name="str">Строка для преобразования.</param>
    /// <returns>Строка в верхнем регистре.</returns>
    static string ToUpper(string str)
    {
        return str.ToUpper();
    }

    /// <summary>
    /// Метод ToLower преобразует строку в нижний регистр.
    /// </summary>
    /// <param name="str">Строка для преобразования.</param>
    /// <returns>Строка в нижнем регистре.</returns>
    static string ToLower(string str)
    {
        return str.ToLower();
    }

    /// <summary>
    /// Метод Main - точка входа в программу.
    /// </summary>
    static void Main(string[] args)
    {
        StringDelegate stringDelegate;

        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();

        stringDelegate = Reverse;
        string result = stringDelegate(input);
        Console.WriteLine($"Перевернутая строка: {result}");

        stringDelegate = ToUpper;
        result = stringDelegate(input);
        Console.WriteLine($"Строка в верхнем регистре: {result}");

        stringDelegate = ToLower;
        result = stringDelegate(input);
        Console.WriteLine($"Строка в нижнем регистре: {result}");
    }
}
