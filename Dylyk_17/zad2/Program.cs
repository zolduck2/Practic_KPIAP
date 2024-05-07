using zad2;

class Program
{
    static void Main(string[] args)
    {
        Train train1 = new Train("123", "Минск", "Брест", 120.0);
        Train train2 = new Train("456", "Гродно", "Витебск", 110.0);

        Station station = new Station("Центральная");
        station.AddTrain(train1);
        station.AddTrain(train2);

        station.DisplayStationInfo();
    }
}