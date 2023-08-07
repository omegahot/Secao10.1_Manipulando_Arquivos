using System.IO;

class Program
{
    private static void Main(string[] args)
    {
        string path = @"C:\Temporarios\arquivos\file1.txt";
        Console.WriteLine(Path.GetDirectoryName(path));
        Console.WriteLine(Path.GetFileName(path));
        Console.WriteLine(Path.DirectorySeparatorChar);
    }
}