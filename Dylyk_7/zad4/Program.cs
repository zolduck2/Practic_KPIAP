using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст: ");
        string text = Console.ReadLine();

        Regex lowerCaseWordRegex = new Regex(@"\b[a-zа-яё]+\b");
        MatchCollection lowerCaseWordMatches = lowerCaseWordRegex.Matches(text);

        foreach (Match match in lowerCaseWordMatches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
