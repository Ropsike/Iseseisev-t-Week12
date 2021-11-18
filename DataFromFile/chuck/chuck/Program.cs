using System;
using System.IO;


namespace DataFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootdirectory = @"C:\Users\opilane\Samples";
            string filename = "chuck.txt";
            string fullfilePath = $@"{rootdirectory}\{filename}";

            string[] dataFromFile = File.ReadAllLines(fullfilePath);
            Random rndl = new Random();
            Console.WriteLine(dataFromFile[rndl.Next(dataFromFile)]);

        }
   



    }
}
