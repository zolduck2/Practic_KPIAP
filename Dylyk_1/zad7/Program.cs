using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        double[] a = new double[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите действительное число a{i + 1}: ");
            a[i] = Convert.ToDouble(Console.ReadLine());
        }

        double maxAbsoluteValue = Math.Abs(a[0]);
        for (int i = 1; i < n; i++)
        {
            if (Math.Abs(a[i]) > maxAbsoluteValue)
            {
                maxAbsoluteValue = Math.Abs(a[i]);
            }
        }

        Console.WriteLine($"Максимальное абсолютное значение среди данных действительных чисел: {maxAbsoluteValue}");
    }
}
