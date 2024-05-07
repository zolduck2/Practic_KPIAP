using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    public class Train
    {
        public string TrainNumber { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public double Speed { get; set; }

        public Train(string trainNumber, string origin, string destination, double speed)
        {
            TrainNumber = trainNumber;
            Origin = origin;
            Destination = destination;
            Speed = speed;
        }

        public void DisplayTrainInfo()
        {
            Console.WriteLine($"Номер поезда: {TrainNumber}, От: {Origin}, До: {Destination}, Скорость: {Speed} км/ч");
        }
    }
}
