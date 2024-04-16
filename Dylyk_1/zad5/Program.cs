using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите A: ");
        int A = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите B: ");
        int B = Convert.ToInt32(Console.ReadLine());

        if (A >= B || A < 1 || A > 100 || B < 1 || B > 100)
        {
            Console.WriteLine("Введены некорректные значения A и B.");
            return;
        }

        int count = 0;
        for (int i = B - 1; i > A; i--)
        {
            Console.WriteLine(i);
            count++;
        }

        Console.WriteLine($"Количество чисел между A и B: {count}");
    }
}

