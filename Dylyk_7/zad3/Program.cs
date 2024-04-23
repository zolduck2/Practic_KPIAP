using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст: ");
        string sentence = Console.ReadLine();

        Regex wordRegex = new Regex(@"\b\w+\b");
        MatchCollection wordMatches = wordRegex.Matches(sentence);

        foreach (Match match in wordMatches)
        {
            Console.WriteLine(match.Value);
        }
    }
}

