public class Place
{
    public string Name { get; set; }
}

public class Region : Place
{
    public string RegionName { get; set; }
}

public class City : Region
{
    public string CityName { get; set; }
}

public class Metropolis : City
{
    public string MetropolisName { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Metropolis metropolis = new Metropolis
        {
            Name = "Место",
            RegionName = "Область",
            CityName = "Город",
            MetropolisName = "Мегаполис"
        };

        Console.WriteLine($"Место: {metropolis.Name}, Область: {metropolis.RegionName}, Город: {metropolis.CityName}, Мегаполис: {metropolis.MetropolisName}");
    }
}

