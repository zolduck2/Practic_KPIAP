using System;

class Program
{
    static void Main()
    {
        double A = 2;
        double B = 7;
        int M = 15;
        double H = (B - A) / M;

        for (int i = 0; i <= M; i++)
        {
            double x = A + H * i;
            double F = Math.Atan(x);
            Console.WriteLine($"x = {x}, F(x) = {F}");
        }
    }
}
