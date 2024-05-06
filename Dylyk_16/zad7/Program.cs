using System;
using System.IO;

class Program
{
    static void Main()
    {
        string sourcePath = "C:\\KPIAP";
        string destinationPath = @"D:\Example_36tp";
        string file1 = "file1.txt";
        string file2 = "file2.txt";
        string file3 = "file3.txt";

        ListAllFiles();
        CreateDirectory(destinationPath);
        CopyFiles(sourcePath, destinationPath, file1, file2, file3);
        ChangeFileAttributes(destinationPath, file1, file2, file3);
        CreateShortcutFiles(destinationPath, file1, file2, file3);
    }

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

    static void CreateDirectory(string path)
    {
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
    }

    static void CopyFiles(string sourcePath, string destinationPath, params string[] files)
    {
        foreach (string file in files)
        {
            File.Copy(Path.Combine(sourcePath, file), Path.Combine(destinationPath, file), true);
        }
    }

    static void ChangeFileAttributes(string path, params string[] files)
    {
        foreach (string file in files)
        {
            string filePath = Path.Combine(path, file);
            File.SetAttributes(filePath, File.GetAttributes(filePath) | FileAttributes.Hidden);
        }
    }

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
