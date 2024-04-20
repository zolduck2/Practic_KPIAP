using System;
using System.Linq;

class Program
{
    static void Main()
    {
        double[] array = new double[25];
        Random rand = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.NextDouble() * (rand.Next(-10, 10));
        }

        double min = array.Min();
        double max = array.Max();

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                array[i] *= Math.Pow(min, 2);
            }
            else
            {
                array[i] *= Math.Pow(max, 2);
            }
        }

        Array.Sort(array);

        Console.WriteLine("Отсортированный массив:");
        foreach (double num in array)
        {
            Console.Write(" " + num);
        }

        Console.Write("Введите число для поиска: ");
        double k = Convert.ToDouble(Console.ReadLine());
        int index = Array.BinarySearch(array, k);

        if (index < 0)
        {
            Console.WriteLine("Число не найдено.");
        }
        else
        {
            Console.WriteLine("Число найдено на позиции: " + index);
        }
    }
}

