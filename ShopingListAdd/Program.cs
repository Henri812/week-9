using System;

namespace ShopingListAdd
{
    class Program
    {
        static void Main(string[] args)
        {

            string fileLocation = @"C:\Users\...\Samples\Shopinglist";
            string fileName = @"\\ShopingList.txt";

            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> ShopingList = arrayFromFile.ToList<string>();

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Kas soovite midagi oma nimekirja lisada Y/N: ");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());
                if (userInput == 'Y')
                {
                    Console.WriteLine("Lisage see nimekirja: ");
                    string userList = Console.ReadLine();
                    ShopingList.Add(userList);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Take care!");
                }
            }
            Console.Clear();
            foreach (string Lisa in ShopingList)
            {
                Console.WriteLine($"Your wish:{Lisa}");
            }
            File.WriteAllLines($"{fileLocation}{fileName}", ShopingList);
        }
    }
}
