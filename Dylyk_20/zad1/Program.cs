using System;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var task1 = Task.Factory.StartNew(() => SwapDigits(123));
        Console.WriteLine($"Результат задачи 1: {task1.Result}");

        var task2 = new Task<int>(() => SwapDigits(456));
        task2.Start();
        Console.WriteLine($"Результат задачи 2: {task2.Result}");

        var task3 = Task.Run(() => SwapDigits(789));
        Console.WriteLine($"Результат задачи 3: {task3.Result}");

        Console.ReadLine();
    }

    static int SwapDigits(int number)
    {
        if (number < 100 || number > 999)
        {
            throw new ArgumentException("Число должно быть трехзначным");
        }

        int firstDigit = number / 100;
        int secondDigit = (number / 10) % 10;
        int thirdDigit = number % 10;

        return firstDigit * 100 + thirdDigit * 10 + secondDigit;
    }
}
