using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        double A = -5.0;
        double B = 5.0;
        double step = 0.1; 

        int count = (int)((B - A) / step) + 1; 

        double[] results = new double[count]; 

        Parallel.For(0, count, i =>
        {
            double x = A + i * step;
            results[i] = Math.Atan(x); 
        });

        for (int i = 0; i < count; i++)
        {
            double x = A + i * step;
            Console.WriteLine($"Arctg({x}) = {results[i]}");
        }
    }
}
