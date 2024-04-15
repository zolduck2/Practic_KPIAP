using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите трехзначное число:");
        int num = Convert.ToInt32(Console.ReadLine());

        int firstDigit = num / 100;
        int secondDigit = (num / 10) % 10;
        int thirdDigit = num % 10;

        int newNum = firstDigit * 100 + thirdDigit * 10 + secondDigit;

        Console.WriteLine($"Новое число: {newNum}");
    }
}

