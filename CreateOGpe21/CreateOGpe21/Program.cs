using System;
using System.IO;

namespace CreateOGpe21
{
    class Program
    {
        static void Main(string[] args)
        {
            string newDirectory = "Logitpe21";
            CreateMyDirectory(newDirectory);




        }
        private static void CreateMyDirectory(string mydirectoryname)
        {
            string rootDirectory = @"C:\users\opilane\samples";
            string directoryfullpath = $@"{rootDirectory}\{mydirectoryname}";
            if (Directory.Exists(directoryfullpath))
            {
                Console.WriteLine($"Directory {mydirectoryname} already exists in {rootDirectory}");
            }
            else
            {
                Directory.CreateDirectory(directoryfullpath);
                Console.WriteLine($"Directory {mydirectoryname} has been created.");
            }
        }
    }
}
