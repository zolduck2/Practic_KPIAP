using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите A: ");
        int A = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите B: ");
        int B = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите X: ");
        int X = Convert.ToInt32(Console.ReadLine());

        // Используя цикл while
        Console.WriteLine("\nРезультаты с использованием цикла while:");
        int i = A;
        while (i <= B)
        {
            if (i % 10 == X)
            {
                Console.WriteLine(i);
            }
            i++;
        }

        // Используя цикл do while
        Console.WriteLine("\nРезультаты с использованием цикла do while:");
        i = A;
        do
        {
            if (i % 10 == X)
            {
                Console.WriteLine(i);
            }
            i++;
        } while (i <= B);

        // Используя цикл for
        Console.WriteLine("\nРезультаты с использованием цикла for:");
        for (i = A; i <= B; i++)
        {
            if (i % 10 == X)
            {
                Console.WriteLine(i);
            }
        }
    }
}

