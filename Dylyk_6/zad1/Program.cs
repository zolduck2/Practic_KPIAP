using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Введите текст: ");
        string text = Console.ReadLine();

        string pattern = "[аеёиоуыэюяАЕЁИОУЫЭЮЯ]";
        string replacement = "*";

        string result = Regex.Replace(text, pattern, replacement);

        Console.WriteLine("Результат: " + result);
    }
}
