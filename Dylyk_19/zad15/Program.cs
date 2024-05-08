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
        // Читает текст из файла и разбивает его на слова
        string path = "D:\\Practic_KPIAP\\Dylyk_16\\zad6\\Files\\text.txt";
        string text = File.ReadAllText(path);
        string[] words = text.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        char letter = 'a';
        int length = 5;

        // Выводит слова, начинающиеся на заданную букву
        PrintWordsStartingWithLetter(words, letter);

        // Выводит слова, длина которых равна заданному числу
        PrintWordsWithLength(words, length);

        // Выводит слова, которые начинаются и заканчиваются одной буквой
        PrintWordsStartingAndEndingWithSameLetter(words);

        // Выводит слова, которые начинаются на ту же букву, что и последнее слово
        PrintWordsStartingWithLastWordFirstLetter(words);
    }

    /// <summary>
    /// Метод PrintWordsStartingWithLetter выводит слова, которые начинаются на заданную букву.
    /// </summary>
    /// <param name="words">Массив слов для обработки.</param>
    /// <param name="letter">Буква для поиска.</param>
    static void PrintWordsStartingWithLetter(string[] words, char letter)
    {
        Console.WriteLine("Слова, которые начинаются на заданную букву:");
        foreach (var word in words.Where(word => word.StartsWith(letter)))
        {
            Console.WriteLine(word);
        }
    }

    /// <summary>
    /// Метод PrintWordsWithLength выводит слова, длина которых равна заданному числу.
    /// </summary>
    /// <param name="words">Массив слов для обработки.</param>
    /// <param name="length">Длина для поиска.</param>
    static void PrintWordsWithLength(string[] words, int length)
    {
        Console.WriteLine("\nСлова, длина которых равна заданному числу:");
        foreach (var word in words.Where(word => word.Length == length))
        {
            Console.WriteLine(word);
        }
    }

    /// <summary>
    /// Метод PrintWordsStartingAndEndingWithSameLetter выводит слова, которые начинаются и заканчиваются одной буквой.
    /// </summary>
    /// <param name="words">Массив слов для обработки.</param>
    static void PrintWordsStartingAndEndingWithSameLetter(string[] words)
    {
        Console.WriteLine("\nСлова, которые начинаются и заканчиваются одной буквой:");
        foreach (var word in words.Where(word => word.First() == word.Last()))
        {
            Console.WriteLine(word);
        }
    }

    /// <summary>
    /// Метод PrintWordsStartingWithLastWordFirstLetter выводит слова, которые начинаются на ту же букву, что и последнее слово.
    /// </summary>
    /// <param name="words">Массив слов для обработки.</param>
    static void PrintWordsStartingWithLastWordFirstLetter(string[] words)
    {
        char lastWordFirstLetter = words.Last().First();
        Console.WriteLine($"\nСлова, которые начинаются на ту же букву, что и последнее слово ({lastWordFirstLetter}):");
        foreach (var word in words.Where(word => word.First() == lastWordFirstLetter))
        {
            Console.WriteLine(word);
        }
    }
}
