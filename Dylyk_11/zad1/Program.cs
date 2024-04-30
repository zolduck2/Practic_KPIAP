using System;

public abstract class Bird
{
    public string Breed { get; set; }

    public Bird(string breed)
    {
        Breed = breed;
    }

    public abstract double FoodPerDay();
}

public class Stork : Bird
{
    public double WingSpan { get; set; }

    public Stork(string breed, double wingSpan) : base(breed)
    {
        WingSpan = wingSpan;
    }

    public override double FoodPerDay()
    {
        return WingSpan * 1 / 2000;
    }
}

public class Crow : Bird
{
    public double Height { get; set; }

    public Crow(string breed, double height) : base(breed)
    {
        Height = height;
    }

    public override double FoodPerDay()
    {
        return 0.8 * Height;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Bird[] birds = new Bird[5]
        {
            new Stork("Белый аист", 215),
            new Crow("Американская ворона", 40),
            new Stork("Черный аист", 200),
            new Crow("Серая ворона", 48),
            new Stork("Аист Марабу", 270)
        };

        foreach (Bird bird in birds)
        {
            Console.WriteLine($"Порода: {bird.Breed}, Количество пищи в день: {bird.FoodPerDay()}");
        }
    }
}

