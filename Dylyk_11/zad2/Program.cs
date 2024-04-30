using System;

public abstract class Publication
{
    public string Title { get; set; }
    public double Price { get; set; }

    public Publication(string title, double price)
    {
        Title = title;
        Price = price;
    }

    public abstract void Display();
}

public class Newspaper : Publication
{
    public Newspaper(string title, double price) : base(title, price) { }

    public override void Display()
    {
        Console.WriteLine($"Газета: {Title}, Цена: {Price}");
    }
}

public class Magazine : Publication
{
    public Magazine(string title, double price) : base(title, price) { }

    public override void Display()
    {
        Console.WriteLine($"Журнал: {Title}, Цена: {Price}");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Publication[] publications = new Publication[5]
        {
            new Newspaper("Times", 1.5),
            new Magazine("Vogue", 3.99),
            new Newspaper("Guardian", 2.2),
            new Magazine("Cosmopolitan", 4.5),
            new Newspaper("Mirror", 1.8)
        };

        double totalNewspaperPrice = 0;
        int newspaperCount = 0;
        double totalMagazinePrice = 0;
        int magazineCount = 0;

        foreach (Publication publication in publications)
        {
            publication.Display();

            if (publication is Newspaper)
            {
                totalNewspaperPrice += publication.Price;
                newspaperCount++;
            }
            else if (publication is Magazine)
            {
                totalMagazinePrice += publication.Price;
                magazineCount++;
            }
        }

        Console.WriteLine($"Средняя стоимость газет: {totalNewspaperPrice / newspaperCount}");
        Console.WriteLine($"Средняя стоимость журналов: {totalMagazinePrice / magazineCount}");
    }
}
