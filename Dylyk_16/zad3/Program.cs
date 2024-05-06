using System;
using System.IO;
using System.Linq;

class Program
{
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

    static string[] CreateFile()
    {
        string[] lines = { "Первая строка", "Вторая строка", "Третья строка", "Четвертая строка", "Пятая строка" };
        File.WriteAllLines("D:\\Practic_KPIAP\\Dylyk_16\\zad3\\Files\\file.txt", lines);
        return lines;
    }

    static void DisplayFileContent(string[] lines)
    {
        Console.WriteLine("Содержимое файла:");
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }

    static void CountLines(string[] lines)
    {
        Console.WriteLine($"Количество строк: {lines.Length}");
    }

    static void CountCharactersInEachLine(string[] lines)
    {
        foreach (string line in lines)
        {
            Console.WriteLine($"Количество символов в строке '{line}': {line.Length}");
        }
    }

    static void RemoveLastLine(string[] lines)
    {
        File.WriteAllLines("D:\\Practic_KPIAP\\Dylyk_16\\zad3\\Files\\newFile.txt", lines.Take(lines.Length - 1));
    }

    static void DisplayLinesFromS1ToS2(string[] lines, int s1, int s2)
    {
        Console.WriteLine($"Строки с {s1} по {s2}:");
        foreach (string line in lines.Skip(s1 - 1).Take(s2 - s1 + 1))
        {
            Console.WriteLine(line);
        }
    }

    static void FindLongestLine(string[] lines)
    {
        int maxLength = lines.Max(line => line.Length);
        Console.WriteLine($"Длина самой длинной строки: {maxLength}");
    }

    static void DisplayLinesStartingWithChar(string[] lines, char startChar)
    {
        Console.WriteLine($"Строки, начинающиеся с буквы '{startChar}':");
        foreach (string line in lines.Where(line => line.StartsWith(startChar)))
        {
            Console.WriteLine(line);
        }
    }

    static void ReverseLinesInFile(string[] lines)
    {
        File.WriteAllLines("D:\\Practic_KPIAP\\Dylyk_16\\zad3\\Files\\reversedFile.txt", lines.Reverse());
    }
}
