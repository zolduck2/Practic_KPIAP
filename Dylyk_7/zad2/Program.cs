using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст: ");

        string text = Console.ReadLine();

        Regex russianRegex = new Regex(@"[а-яА-ЯёЁ]");
        MatchCollection russianMatches = russianRegex.Matches(text);

        if (russianMatches.Count > 0)
        {
            Console.WriteLine("Текст написан на русском языке.");
        }
        else
        {
            Console.WriteLine("Текст не написан на русском языке.");
        }
    }
}

