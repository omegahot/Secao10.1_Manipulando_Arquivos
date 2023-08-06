using System.IO;

class Program
{
    private static void Main(string[] args)
    {
        string path = @"C:\Temporarios\arquivos\file1.txt";

        StreamReader sr = null;

        try
        {
            sr = File.OpenText(path);
            
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }

        }
        catch (IOException e)
        {
            Console.WriteLine("Um erro ocorreu!");
            Console.WriteLine(e.Message);
        }
        finally
        {
            if (sr != null) sr.Close();
        }
    }
}