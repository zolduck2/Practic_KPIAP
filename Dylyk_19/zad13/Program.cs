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
        // Читает все строки из файлов file1.txt и file2.txt
        string[] file1 = File.ReadAllLines("D:\\Practic_KPIAP\\Dylyk_16\\zad4\\Files\\file1.txt");
        string[] file2 = File.ReadAllLines("D:\\Practic_KPIAP\\Dylyk_16\\zad4\\Files\\file2.txt");

        // Проверяет, имеют ли файлы одинаковое количество строк
        if (file1.Length != file2.Length)
        {
            Console.WriteLine("Файлы имеют разное количество строк.");
            return;
        }

        // Сравнивает строки в файлах
        for (int i = 0; i < file1.Length; i++)
        {
            if (file1[i] != file2[i])
            {
                Console.WriteLine($"Строки файлов начинают отличаться на строке {i + 1}");
                return;
            }
        }

        // Если все строки совпадают
        Console.WriteLine("Все строки файлов совпадают.");
    }
}
