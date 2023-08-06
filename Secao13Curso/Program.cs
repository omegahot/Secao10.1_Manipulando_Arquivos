using System.IO;

class Program
{
    private static void Main(string[] args)
    {
        string path = @"C:\Temporarios\arquivos\file1.txt";

        FileStream fs = null;
        StreamReader sr = null;



        try
        {
            fs = new FileStream(path, FileMode.Open);
            sr = new StreamReader(fs);
            string line = sr.ReadLine(); 
            Console.WriteLine(line);

        }
        catch (IOException e)
        {
            Console.WriteLine("Um erro ocorreu!");
            Console.WriteLine(e.Message);
        }
        finally
        {
            if (fs != null) { 
                fs.Close();
            }

            if (sr != null) { 
                sr.Close();
            }
        }

        
    }
}