using System.IO;
using System.Collections.Generic;

class Program
{
    private static void Main(string[] args)
    {
        string path = @"C:\Temporarios\arquivos";

        try
        {
            // Listar todos os diretórios.
            IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
            Console.WriteLine("DIRECTORIES: ");

            foreach(string folder in folders)
            {
                Console.WriteLine(folder);
            }

            //Listar todos os arquivos.
            Console.WriteLine();
            Console.WriteLine("Listando todos os arquivos:");
            var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }

            //Criando um diretório
            Directory.CreateDirectory(path + @"\new_folder");
        }
        catch (IOException e)
        {
            Console.WriteLine("Um erro ocorreu.");
            Console.WriteLine(e.Message);
        }
    }
}