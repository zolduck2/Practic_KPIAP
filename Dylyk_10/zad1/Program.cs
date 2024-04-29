using System;
using System.Xml.Linq;

class Segment
{
    private string name; 
    private double x1, y1; 
    private double x2, y2; 

    public Segment(string name, double x1, double y1, double x2, double y2)
    {
        this.name = name;
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
    }

    public double CalculateLength()
    {
        double dx = x2 - x1;
        double dy = y2 - y1;
        return Math.Sqrt(dx * dx + dy * dy);
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Отрезок \"{name}\":");
        Console.WriteLine($"Координаты начальной точки: ({x1}, {y1})");
        Console.WriteLine($"Координаты конечной точки: ({x2}, {y2})");
        Console.WriteLine($"Длина отрезка: {CalculateLength():F2} единиц");
    }
}

class Line : Segment
{
    private string color; 
    private double n;
    private string name;

    public Line(string name, double x1, double y1, double x2, double y2, string color, double n)
        : base(name, x1, y1, x2, y2)
    {
        this.name = name;
        this.color = color;
        this.n = n;
    }

    public void IncreaseLength()
    {
        double newLength = CalculateLength() * n;
        Console.WriteLine($"Увеличенная длина линии \"{name}\": {newLength:F2} единиц");
    }

    public new void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Цвет линии: {color}");
    }
}

class Program
{
    static void Main()
    {
        Segment segment = new Segment("AB", 1, 2, 4, 6);
        Line line = new Line("CD", 2, 3, 5, 8, "Красный", 2.5);

        segment.DisplayInfo();
        Console.WriteLine();
        line.DisplayInfo();
        line.IncreaseLength();
    }
}
