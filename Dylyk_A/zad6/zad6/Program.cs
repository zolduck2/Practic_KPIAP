using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите трехзначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int lastDigit = number % 10;
        string numberAsString = number.ToString();
        int firstDigit = Convert.ToInt32(numberAsString[0].ToString());

        Console.WriteLine($"Первая цифра: {firstDigit}, последняя цифра: {lastDigit}");
    }
}