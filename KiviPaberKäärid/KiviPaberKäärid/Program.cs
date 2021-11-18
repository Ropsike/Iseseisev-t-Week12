using System;

namespace KiviPaberKäärid
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine($"Tere, vali kas kivi, paber või käärid.");
            string userChoice = Console.ReadLine();
            int count = 0;
            int count1 = 0;

            Random r = new Random();
            int computerChoice = r.Next(4);

            if (computerChoice == 1)
            {
                if (userChoice == "Kivi.")
                {
                    Console.WriteLine("Arvuti valis kivi.");
                    Console.WriteLine("See on viik.");
                }
                else if (userChoice == "paber.")
                {
                    Console.WriteLine("Arvuti valis paberi.");
                    Console.WriteLine("See on viik.");
                }
                else if (userChoice == "käärid.")
                {
                    Console.WriteLine("Arvuti valis kääre.");
                    Console.WriteLine("Viik.");
                }
                

            }

            else if (computerChoice == 2)
            {
                if (userChoice == "Kivi.")
                {
                    Console.WriteLine("Arvuti valis paberi.");
                    Console.WriteLine("Kaotasid, paber katab kivi.");
                    count1++;
                }
                else if (userChoice == "paber.")
                {
                    Console.WriteLine("Arvuti valis kääre.");
                    Console.WriteLine("Sinu kaotus, käärid lõikavad paberi.");
                    count1++;
                }
                else if (userChoice == "käärid.")
                {
                    Console.WriteLine("Arvuti valis kivi.");
                    Console.WriteLine("Sinu kaotus, kivi taob kääre.");
                    count1++;
                }
                
            }

            else if (computerChoice == 3)
            {
                if (userChoice == "Kivi.")
                {
                    Console.WriteLine("Arvuti valis Kääre.");
                    Console.WriteLine("Sinu võit..");
                    count++;
                }
                else if (userChoice == "paber.")
                {
                    Console.WriteLine("Arvuti valis kivi.");
                    Console.WriteLine("Võitsid.");
                    count++;
                }
                else if (userChoice == "käärid.")
                {
                    Console.WriteLine("Arvuti valis paberit.");
                    Console.WriteLine("Võitsid, tubli.");
                    count++;
                }
                Console.ReadLine()
            }
            
            
        
        }
        

    }
}