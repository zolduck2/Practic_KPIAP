using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string path = "D:\\Practic_KPIAP\\Dylyk_16\\zad6\\Files\\text.txt"; 
        string text = File.ReadAllText(path);
        string[] words = text.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        char letter = 'a'; 
        int length = 5; 

        PrintWordsStartingWithLetter(words, letter);
        PrintWordsWithLength(words, length);
        PrintWordsStartingAndEndingWithSameLetter(words);
        PrintWordsStartingWithLastWordFirstLetter(words);
    }

    static void PrintWordsStartingWithLetter(string[] words, char letter)
    {
        Console.WriteLine("Слова, которые начинаются на заданную букву:");
        foreach (var word in words.Where(word => word.StartsWith(letter)))
        {
            Console.WriteLine(word);
        }
    }

    static void PrintWordsWithLength(string[] words, int length)
    {
        Console.WriteLine("\nСлова, длина которых равна заданному числу:");
        foreach (var word in words.Where(word => word.Length == length))
        {
            Console.WriteLine(word);
        }
    }

    static void PrintWordsStartingAndEndingWithSameLetter(string[] words)
    {
        Console.WriteLine("\nСлова, которые начинаются и заканчиваются одной буквой:");
        foreach (var word in words.Where(word => word.First() == word.Last()))
        {
            Console.WriteLine(word);
        }
    }

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
