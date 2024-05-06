using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 20, 10, 4, -1, -2, 0, 0, 0, -10, 41, 62 };
        File.WriteAllLines("D:\\Practic_KPIAP\\Dylyk_16\\zad5\\Files\\input.txt", numbers.Select(x => x.ToString()));

        var lines = File.ReadAllLines("D:\\Practic_KPIAP\\Dylyk_16\\zad5\\Files\\input.txt");
        var list = lines.Select(int.Parse).ToList();

        var result = new List<int>();
        int sum = list[0];
        for (int i = 1; i < list.Count; i++)
        {
            if ((list[i] == 0 && sum == 0) || (list[i] > 0 && sum > 0) || (list[i] < 0 && sum < 0))
            {
                sum += list[i];
            }
            else
            {
                result.Add(sum);
                sum = list[i];
            }
        }
        result.Add(sum);

        File.WriteAllLines("D:\\Practic_KPIAP\\Dylyk_16\\zad5\\Files\\output.txt", result.Select(x => x.ToString()));
    }
}
