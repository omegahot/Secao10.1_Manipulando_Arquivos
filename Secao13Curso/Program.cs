using System.IO;

class Program
{
    private static void Main(string[] args)
    {
        string sourcePath = @"C:\Temporarios\arquivos\file1.txt";
        string targetPath = @"C:\Temporarios\arquivos\file2.txt";

        try
        {
            FileInfo fileInfo = new FileInfo(sourcePath);
            // fileInfo.CopyTo(targetPath);
            string[] lines = File.ReadAllLines(sourcePath);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("Um erro ocorreu!");
            Console.WriteLine(e.Message);
        }
    }
}