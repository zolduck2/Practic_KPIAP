using System;

public class Time
{
    private int hour;
    private int minute;
    private int second;

    public int Hour
    {
        get { return hour; }
        set
        {
            if (value >= 0 && value < 24)
                hour = value;
            else
                throw new Exception("Недопустимое значение часа");
        }
    }

    public int Minute
    {
        get { return minute; }
        set
        {
            if (value >= 0 && value < 60)
                minute = value;
            else
                throw new Exception("Недопустимое значение минуты");
        }
    }

    public int Second
    {
        get { return second; }
        set
        {
            if (value >= 0 && value < 60)
                second = value;
            else
                throw new Exception("Недопустимое значение секунды");
        }
    }

    public void AddHours(int hours)
    {
        Hour += hours;
        if (Hour >= 24)
            Hour -= 24;
    }

    public void AddMinutes(int minutes)
    {
        Minute += minutes;
        if (Minute >= 60)
        {
            AddHours(Minute / 60);
            Minute %= 60;
        }
    }

    public void AddSeconds(int seconds)
    {
        Second += seconds;
        if (Second >= 60)
        {
            AddMinutes(Second / 60);
            Second %= 60;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Time time = new Time { Hour = 10, Minute = 30, Second = 45 };
        Console.WriteLine($"Текущее время: {time.Hour}:{time.Minute}:{time.Second}");

        time.AddHours(5);
        Console.WriteLine($"После добавления 5 часов: {time.Hour}:{time.Minute}:{time.Second}");

        time.AddMinutes(25);
        Console.WriteLine($"После добавления 25-ти минут: {time.Hour}:{time.Minute}:{time.Second}");

        time.AddSeconds(5);
        Console.WriteLine($"После добавления 5-ти секунд: {time.Hour}:{time.Minute}:{time.Second}");
    }
}
