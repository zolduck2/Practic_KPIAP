using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    public class Station
    {
        public string StationName { get; set; }
        public List<Train> Trains { get; set; }

        public Station(string stationName)
        {
            StationName = stationName;
            Trains = new List<Train>();
        }

        public void AddTrain(Train train)
        {
            Trains.Add(train);
        }

        public void DisplayStationInfo()
        {
            Console.WriteLine($"Станция: {StationName}");
            Console.WriteLine("Поезда:");
            foreach (var train in Trains)
            {
                train.DisplayTrainInfo();
            }
        }
    }
}
