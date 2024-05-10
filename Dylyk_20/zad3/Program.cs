using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Task<Tuple<int, int>> task1 = Task.Run(() =>
        {
            Console.WriteLine("Введите трехзначное число: ");
            int number = Convert.ToInt32(Console.ReadLine()); 
            int firstDigit = number / 100;
            int lastDigit = number % 10;
            return Tuple.Create(firstDigit, lastDigit);
        });

        Task task2 = task1.ContinueWith(task =>
        {
            Tuple<int, int> result = task.Result;
            Console.WriteLine($"Первая цифра: {result.Item1}, последняя цифра: {result.Item2}");
        });

        task2.Wait();
    }
}
