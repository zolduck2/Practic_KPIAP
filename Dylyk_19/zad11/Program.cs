using System.IO;

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
        // Путь к новой папке
        string path = @"D:\Practic_KPIAP\Dylyk_16\zad2\New_folder";

        // Создание новой папки по указанному пути
        DirectoryInfo di = Directory.CreateDirectory(path);
    }
}
