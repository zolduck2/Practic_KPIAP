using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] file1 = File.ReadAllLines("D:\\Practic_KPIAP\\Dylyk_16\\zad4\\Files\\file1.txt");
        string[] file2 = File.ReadAllLines("D:\\Practic_KPIAP\\Dylyk_16\\zad4\\Files\\file2.txt");

        if (file1.Length != file2.Length)
        {
            Console.WriteLine("Файлы имеют разное количество строк.");
            return;
        }

        for (int i = 0; i < file1.Length; i++)
        {
            if (file1[i] != file2[i])
            {
                Console.WriteLine($"Строки файлов начинают отличаться на строке {i + 1}");
                return;
            }
        }

        Console.WriteLine("Все строки файлов совпадают.");
    }
}
