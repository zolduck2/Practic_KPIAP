using System.IO;

class Program
{
    static void Main()
    {
        string path = @"D:\Practic_KPIAP\Dylyk_16\zad2\New_folder";

        DirectoryInfo di = Directory.CreateDirectory(path);
    }
}
