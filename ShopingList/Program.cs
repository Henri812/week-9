using System;

namespace ShopingList
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                string rootDirectory = @"C:\Users\..\Samples";
                Console.WriteLine("Sisestage loodava kausta nimi: ");
                string newDirectory = Console.ReadLine();
                Console.WriteLine("Sistage looava faili nimi: ");
                string fileName = Console.ReadLine();

                if (Directory.Exists($"{rootDirectory}\\{newDirectory}") && File.Exists($"{rootDirectory}\\{ newDirectory}\\{ fileName}"))
                {
                    Console.WriteLine($"Directory and  file exists.");
                }
                else
                {
                    Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");
                    File.Create($"{rootDirectory}\\{ newDirectory}\\{ fileName}");
                }
    }
}
