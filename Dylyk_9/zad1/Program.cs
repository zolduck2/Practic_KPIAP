using System;

interface Iy
{
    double IxF0(double w);
    double IxF1(double w);
}

interface Iz
{
    double IxF0(double w);
    double IxF1(double w);
    double F0(double w);
    double F1(double w);
}
class MyObject : Iy, Iz
{
    public double IxF0(double w)
    {
        return Math.Abs(w);
    }

    public double IxF1(double w)
    {
        return Math.Abs(w);
    }

    double Iz.IxF0(double w)
    {
        return Math.Sin(w);
    }

    double Iz.IxF1(double w)
    {
        return Math.Sin(w);
    }

    public double F0(double w)
    {
        return w + 2;
    }

    public double F1(double w)
    {
        return w + 2;
    }
}
class Program
{
    static void Main()
    {
        double w = 3.14;

        MyObject obj = new MyObject();

        Console.WriteLine($"IxF0: {obj.IxF0(w)}");
        Console.WriteLine($"IxF1: {obj.IxF1(w)}");
        Console.WriteLine($"F0: {obj.F0(w)}");
        Console.WriteLine($"F1: {obj.F1(w)}");
    }
}
