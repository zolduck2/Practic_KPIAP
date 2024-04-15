using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое число:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите третье число:");
        int num3 = Convert.ToInt32(Console.ReadLine());

        int result = num1 * num2 * num3;

        Console.WriteLine($"{num1}*{num2}*{num3}={result}");
        Console.WriteLine($"{num3}*{num2}*{num1}={result}");
    }
}
