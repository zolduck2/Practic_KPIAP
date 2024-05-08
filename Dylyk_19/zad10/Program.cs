using System;
using System.IO;
using System.Linq;

/// <summary>
/// Класс Program содержит основную логику программы.
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу.
    /// </summary>
    static void Main()
    {
        // Читает все строки из файла f.txt
        string[] lines = File.ReadAllLines("D:\\Practic_KPIAP\\Dylyk_16\\zad1/Files/f.txt");

        // Преобразует каждую строку в число и фильтрует числа, которые не делятся на 7
        var numbers = lines.Select(int.Parse).Where(n => n % 7 != 0);

        // Записывает отфильтрованные числа в файл g.txt
        File.WriteAllLines("D:\\Practic_KPIAP\\Dylyk_16\\zad1/Files/g.txt", numbers.Select(n => n.ToString()));
    }
}
