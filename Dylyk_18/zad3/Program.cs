using System;
using System.Collections.Generic;

public class Vacation
{
    public string Destination { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }

    public Vacation(string destination, DateTime? startDate, DateTime? endDate)
    {
        Destination = destination;
        StartDate = startDate;
        EndDate = endDate;
    }

    public Vacation Clone()
    {
        return new Vacation(Destination, StartDate, EndDate);
    }
}

class Program
{
    static void Main()
    {
        List<Vacation> vacations = new List<Vacation>();

        Vacation vacation1 = new Vacation("Мальдивы", new DateTime(2024, 12, 1), new DateTime(2024, 12, 15));
        vacations.Add(vacation1);

        Vacation vacation2 = vacation1.Clone();
        vacations.Add(vacation2);

        vacations.Remove(vacation1);

        Dictionary<string, Vacation> vacationDict = new Dictionary<string, Vacation>();
        vacationDict.Add("Отпуск 1", vacation1);
        vacationDict.Add("Отпуск 2", vacation2);

        foreach (var vacation in vacations)
        {
            Console.WriteLine($"Пункт назначения: {vacation.Destination}, Дата начала: {vacation.StartDate}, Дата окончания: {vacation.EndDate}");
        }

        foreach (var item in vacationDict)
        {
            Console.WriteLine($"{item.Key}: Пункт назначения - {item.Value.Destination}, Дата начала - {item.Value.StartDate}, Дата окончания - {item.Value.EndDate}");
        }
    }
}
