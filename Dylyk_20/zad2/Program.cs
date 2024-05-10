using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Task<double>[] tasks = new Task<double>[2];

        tasks[0] = Task.Run(() =>
        {
            Thread.Sleep(2000); 
            double x = 5.0;
            double z1 = (Math.Pow(x, 2) + 2 * x - 3 + (x + 1) * Math.Sqrt(Math.Pow(x, 2) - 9)) / (Math.Pow(x, 2) - 2 * x - 3 + (x - 1) * Math.Sqrt(Math.Pow(x, 2) - 9));
            Console.WriteLine($"Значение z1: {z1}");
            return z1;
        });

        tasks[1] = Task.Run(() =>
        {
            Thread.Sleep(5000); 
            double x = 5.0;
            double z2 = (x + 3) / (x - 3);
            Console.WriteLine($"Значение z2: {z2}");
            return z2;
        });

        Task.WhenAll(tasks).Wait();
        Console.WriteLine("Все задачи выполнены");

        tasks[0] = Task.Run(() =>
        {
            Thread.Sleep(2000); 
            double x = 5.0;
            double z1 = (Math.Pow(x, 2) + 2 * x - 3 + (x + 1) * Math.Sqrt(Math.Pow(x, 2) - 9)) / (Math.Pow(x, 2) - 2 * x - 3 + (x - 1) * Math.Sqrt(Math.Pow(x, 2) - 9));
            Console.WriteLine($"Значение z1: {z1}");
            return z1;
        });

        tasks[1] = Task.Run(() =>
        {
            Thread.Sleep(5000); 
            double x = 5.0;
            double z2 = (x + 3) / (x - 3);
            Console.WriteLine($"Значение z2: {z2}");
            return z2;
        });

        int taskIndex = Task.WaitAny(tasks);
        Console.WriteLine($"Задача {taskIndex + 1} завершилась первой.");
    }
}
