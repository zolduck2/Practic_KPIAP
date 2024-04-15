using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите масштаб карты (количество километров в одном сантиметре): ");
        double scale = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите расстояние между точками, изображающими населенные пункты (см): ");
        double distanceInCm = Convert.ToDouble(Console.ReadLine());

        double distanceInKm = scale * distanceInCm;

        Console.WriteLine($"Расстояние между населенными пунктами: {distanceInKm} км.");
    }
}

