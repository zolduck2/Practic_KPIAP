using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите текст: ");
        string text = Console.ReadLine();

        Console.Write("Введите позицию: ");
        int position = Convert.ToInt32(Console.ReadLine());

        if (position < 0 || position >= text.Length)
        {
            Console.WriteLine("Позиция вне диапазона текста.");
            return;
        }

        string result = text.Substring(0, position) +
                        text.Substring(position).Replace('?', '!');

        Console.WriteLine("Результат: " + result);
    }
}

