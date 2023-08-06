using System.IO;

class Program
{
    private static void Main(string[] args)
    {
        string path = @"C:\Temporarios\arquivos\file1.txt";

        try
        {
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine("Arquivo não encontrado: " + path);
        }
        catch (IOException e)
        {
            Console.WriteLine("Erro ao ler o arquivo: ");
            Console.WriteLine(e.Message);
        }
    }
}