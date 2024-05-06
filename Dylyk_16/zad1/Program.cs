using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("D:\\Practic_KPIAP\\Dylyk_16\\zad1/Files/f.txt");
        var numbers = lines.Select(int.Parse).Where(n => n % 7 != 0);
        File.WriteAllLines("D:\\Practic_KPIAP\\Dylyk_16\\zad1/Files/g.txt", numbers.Select(n => n.ToString()));
    }
}
