using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите двухзначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number < 10 || number > 99)
        {
            Console.WriteLine("Введенное число не является двухзначным.");
            return;
        }

        int sum = (number / 10) + (number % 10); 

        if (sum % 2 == 0)
        {
            Console.WriteLine("Сумма цифр числа является четной.");
        }
        else
        {
            Console.WriteLine("Сумма цифр числа не является четной.");
        }
    }
}
