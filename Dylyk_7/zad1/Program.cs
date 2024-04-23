using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст: ");
        string text = Console.ReadLine();

        // Регулярное выражение для поиска вопросительных предложений
        Regex questionRegex = new Regex(@"[^.!?]*\?");
        MatchCollection questionMatches = questionRegex.Matches(text);
        Console.WriteLine("Вопросительные предложения:");
        foreach (Match match in questionMatches)
        {
            Console.WriteLine(match.Value.Trim());
        }

        // Регулярное выражение для поиска восклицательных предложений
        Regex exclamationRegex = new Regex(@"[^.!?]*!");
        MatchCollection exclamationMatches = exclamationRegex.Matches(text);
        Console.WriteLine("\nВосклицательные предложения:");
        foreach (Match match in exclamationMatches)
        {
            Console.WriteLine(match.Value.Trim());
        }
    }
}


