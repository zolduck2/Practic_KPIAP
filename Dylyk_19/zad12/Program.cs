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
        string[] lines = CreateFile();
        DisplayFileContent(lines);
        CountLines(lines);
        CountCharactersInEachLine(lines);
        RemoveLastLine(lines);
        DisplayLinesFromS1ToS2(lines, 1, 3);
        FindLongestLine(lines);
        DisplayLinesStartingWithChar(lines, 'В');
        ReverseLinesInFile(lines);
    }

    /// <summary>
    /// Метод CreateFile создает файл и заполняет его строками.
    /// </summary>
    /// <returns>Массив строк, записанных в файл.</returns>
    static string[] CreateFile()
    {
        string[] lines = { "Первая строка", "Вторая строка", "Третья строка", "Четвертая строка", "Пятая строка" };
        File.WriteAllLines("D:\\Practic_KPIAP\\Dylyk_16\\zad3\\Files\\file.txt", lines);
        return lines;
    }

    /// <summary>
    /// Метод DisplayFileContent выводит содержимое файла.
    /// </summary>
    /// <param name="lines">Массив строк для вывода.</param>
    static void DisplayFileContent(string[] lines)
    {
        Console.WriteLine("Содержимое файла:");
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }

    /// <summary>
    /// Метод CountLines подсчитывает количество строк.
    /// </summary>
    /// <param name="lines">Массив строк для подсчета.</param>
    static void CountLines(string[] lines)
    {
        Console.WriteLine($"Количество строк: {lines.Length}");
    }

    /// <summary>
    /// Метод CountCharactersInEachLine подсчитывает количество символов в каждой строке.
    /// </summary>
    /// <param name="lines">Массив строк для подсчета.</param>
    static void CountCharactersInEachLine(string[] lines)
    {
        foreach (string line in lines)
        {
            Console.WriteLine($"Количество символов в строке '{line}': {line.Length}");
        }
    }

    /// <summary>
    /// Метод RemoveLastLine удаляет последнюю строку из массива строк и записывает результат в новый файл.
    /// </summary>
    /// <param name="lines">Массив строк для обработки.</param>
    static void RemoveLastLine(string[] lines)
    {
        File.WriteAllLines("D:\\Practic_KPIAP\\Dylyk_16\\zad3\\Files\\newFile.txt", lines.Take(lines.Length - 1));
    }

    /// <summary>
    /// Метод DisplayLinesFromS1ToS2 выводит строки с индексами от s1 до s2.
    /// </summary>
    /// <param name="lines">Массив строк для вывода.</param>
    /// <param name="s1">Начальный индекс.</param>
    /// <param name="s2">Конечный индекс.</param>
    static void DisplayLinesFromS1ToS2(string[] lines, int s1, int s2)
    {
        Console.WriteLine($"Строки с {s1} по {s2}:");
        foreach (string line in lines.Skip(s1 - 1).Take(s2 - s1 + 1))
        {
            Console.WriteLine(line);
        }
    }

    /// <summary>
    /// Метод FindLongestLine находит самую длинную строку.
    /// </summary>
    /// <param name="lines">Массив строк для поиска.</param>
    static void FindLongestLine(string[] lines)
    {
        int maxLength = lines.Max(line => line.Length);
        Console.WriteLine($"Длина самой длинной строки: {maxLength}");
    }

    /// <summary>
    /// Метод DisplayLinesStartingWithChar выводит строки, начинающиеся с указанного символа.
    /// </summary>
    /// <param name="lines">Массив строк для вывода.</param>
    /// <param name="startChar">Символ для поиска.</param>
    static void DisplayLinesStartingWithChar(string[] lines, char startChar)
    {
        Console.WriteLine($"Строки, начинающиеся с буквы '{startChar}':");
        foreach (string line in lines.Where(line => line.StartsWith(startChar)))
        {
            Console.WriteLine(line);
        }
    }

    /// <summary>
    /// Метод ReverseLinesInFile переворачивает строки в файле.
    /// </summary>
    /// <param name="lines">Массив строк для обработки.</param>
    static void ReverseLinesInFile(string[] lines)
    {
        File.WriteAllLines("D:\\Practic_KPIAP\\Dylyk_16\\zad3\\Files\\reversedFile.txt", lines.Reverse());
    }
}
