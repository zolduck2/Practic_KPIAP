using System;
using System.Collections.Generic;

class TRAIN
{
    public string Destination { get; set; }
    public string TrainNumber { get; set; }
    public string DepartureTime { get; set; }
}

class Program
{
    static void Main()
    {
        List<TRAIN> trains = new List<TRAIN>();

        for (int i = 0; i < 6; i++)
        {
            Console.Write("Введите пункт назначения: ");
            string destination = Console.ReadLine();

            Console.Write("Введите номер поезда: ");
            string trainNumber = Console.ReadLine();

            Console.Write("Введите время отправления: ");
            string departureTime = Console.ReadLine();

            trains.Add(new TRAIN { Destination = destination, TrainNumber = trainNumber, DepartureTime = departureTime });
        }

        trains.Sort((a, b) => string.Compare(a.DepartureTime, b.DepartureTime));

        Console.Write("Введите пункт назначения для поиска: ");
        string searchDestination = Console.ReadLine();

        bool found = false;
        foreach (var train in trains)
        {
            if (train.Destination == searchDestination)
            {
                Console.WriteLine($"Поезд {train.TrainNumber} отправляется в {train.Destination} в {train.DepartureTime}");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine($"Поездов, направляющихся в {searchDestination}, не найдено.");
        }
    }
}
