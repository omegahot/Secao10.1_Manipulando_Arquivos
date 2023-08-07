using System.IO;

class Program
{
    private static void Main(string[] args)
    {
        string sourcePath = @"C:\Temporarios\arquivos\file1.txt";
        string targetPath = @"C:\Temporarios\arquivos\file2.txt";

        try
        {

            string[] lines = File.ReadAllLines(sourcePath);
            using (StreamWriter sw = File.AppendText(targetPath))
            {
                foreach (string line in lines)
                {
                    sw.WriteLine(line.ToUpper());
                }
            }

        }
        catch (IOException e)
        {
            Console.WriteLine("Um erro ocorreu.");
            Console.WriteLine(e.Message);
        }
    }
}