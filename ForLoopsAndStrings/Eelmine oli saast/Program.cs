using System;

namespace Eelmine_oli_saast
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma eesnimi");
            string firstname = Console.ReadLine();
            Console.WriteLine(firstname[0]);
            int firstnamelenght = firstname.Length;
            Console.WriteLine($"Teie nimi on {firstnamelenght} sümbolit pikk");
            Console.WriteLine(firstname[firstnamelenght - 1]);
        }
    }
}
