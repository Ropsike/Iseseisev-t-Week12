using System;
using System.IO;


namespace DataFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            string somejoke = Console.ReadLine();
            string output = GetLineFromFileData(somejoke);

            if(output.Length != 0)
            {
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("Sorry, color not found.");
            }

        }
        private static string[] ReadDataFromFile()
        {

            string directorypath = @"C:\Users\opilane\Samples";
            string filename = "chuck.txt";
            string fullPath = $@"{directorypath}\{filename}";

            string[] datafromfile = File.ReadAllLines(fullPath);
            return datafromfile;

        }
        private static string GetLineFromFileData(string userinput)
        {
            string[] datafromfile = ReadDataFromFile();
            string result = "";

            foreach (string line in datafromfile)
            {
                if (line.Contains(userinput))
                {
                    Console.WriteLine(line);
                    break;
                }



            }


        }



    }
}
