using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

/// <summary>
/// Класс Program содержит основную логику программы.
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу.
    /// </summary>
    static void Main()
    {
        // Массив чисел для записи в файл
        int[] numbers = { 20, 10, 4, -1, -2, 0, 0, 0, -10, 41, 62 };

        // Запись чисел в файл input.txt
        File.WriteAllLines("D:\\Practic_KPIAP\\Dylyk_16\\zad5\\Files\\input.txt", numbers.Select(x => x.ToString()));

        // Чтение строк из файла input.txt и преобразование их в список целых чисел
        var lines = File.ReadAllLines("D:\\Practic_KPIAP\\Dylyk_16\\zad5\\Files\\input.txt");
        var list = lines.Select(int.Parse).ToList();

        // Создание списка для хранения результата
        var result = new List<int>();
        int sum = list[0];

        // Обработка чисел в списке
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

        // Запись результата в файл output.txt
        File.WriteAllLines("D:\\Practic_KPIAP\\Dylyk_16\\zad5\\Files\\output.txt", result.Select(x => x.ToString()));
    }
}
