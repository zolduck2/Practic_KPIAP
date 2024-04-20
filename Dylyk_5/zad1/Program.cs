using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        Console.WriteLine("Введите размерность массива: ");
        int arrayLength = Convert.ToInt32(Console.ReadLine()); 
        double[] array = new double[arrayLength];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.NextDouble() * (rand.Next(1, 10)); 
        }

        double product = 1.0;

        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0) 
            {
                product *= array[i];
            }
        }

        Console.WriteLine("Произведение элементов на четных позициях: " + product);
    }
}
