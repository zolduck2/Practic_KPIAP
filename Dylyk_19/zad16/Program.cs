using System;
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
        string sourcePath = "C:\\KPIAP";
        string destinationPath = @"D:\Example_36tp";
        string file1 = "file1.txt";
        string file2 = "file2.txt";
        string file3 = "file3.txt";

        // Перечисляет все файлы, создает директорию, копирует файлы, изменяет атрибуты файлов и создает ярлыки файлов
        ListAllFiles();
        CreateDirectory(destinationPath);
        CopyFiles(sourcePath, destinationPath, file1, file2, file3);
        ChangeFileAttributes(destinationPath, file1, file2, file3);
        CreateShortcutFiles(destinationPath, file1, file2, file3);
    }

    /// <summary>
    /// Метод ListAllFiles перечисляет все файлы на всех логических дисках.
    /// </summary>
    static void ListAllFiles()
    {
        string[] drives = Environment.GetLogicalDrives();
        foreach (string drive in drives)
        {
            Console.WriteLine($"Drive: {drive}");
            try
            {
                string[] files = Directory.GetFiles(drive, "*.*", SearchOption.AllDirectories);
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error accessing files in drive {drive}: {ex.Message}");
            }
        }
    }

    /// <summary>
    /// Метод CreateDirectory создает директорию по указанному пути, если она еще не существует.
    /// </summary>
    /// <param name="path">Путь для создания директории.</param>
    static void CreateDirectory(string path)
    {
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
    }

    /// <summary>
    /// Метод CopyFiles копирует указанные файлы из исходного пути в путь назначения.
    /// </summary>
    /// <param name="sourcePath">Исходный путь.</param>
    /// <param name="destinationPath">Путь назначения.</param>
    /// <param name="files">Файлы для копирования.</param>
    static void CopyFiles(string sourcePath, string destinationPath, params string[] files)
    {
        foreach (string file in files)
        {
            File.Copy(Path.Combine(sourcePath, file), Path.Combine(destinationPath, file), true);
        }
    }

    /// <summary>
    /// Метод ChangeFileAttributes изменяет атрибуты указанных файлов, делая их скрытыми.
    /// </summary>
    /// <param name="path">Путь к файлам.</param>
    /// <param name="files">Файлы для изменения атрибутов.</param>
    static void ChangeFileAttributes(string path, params string[] files)
    {
        foreach (string file in files)
        {
            string filePath = Path.Combine(path, file);
            File.SetAttributes(filePath, File.GetAttributes(filePath) | FileAttributes.Hidden);
        }
    }

    /// <summary>
    /// Метод CreateShortcutFiles создает ярлыки указанных файлов.
    /// </summary>
    /// <param name="path">Путь к файлам.</param>
    /// <param name="files">Файлы для создания ярлыков.</param>
    static void CreateShortcutFiles(string path, params string[] files)
    {
        foreach (string file in files)
        {
            string shortcutPath = Path.Combine(path, $"{file}.lnk");
            using (StreamWriter writer = new StreamWriter(shortcutPath))
            {
                writer.WriteLine($"Shortcut to {file}");
            }
        }
    }
}
