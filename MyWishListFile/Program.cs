using System;

namespace MyWishListFile
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string fileLocation = @"C:\Users\....\Samples\wishlist";
                string fileName = @"\\MyWishList.txt";

                string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
                List<string> MyWishList = arrayFromFile.ToList<string>();

                bool loopActive = true;

                while (loopActive)
                {
                    Console.WriteLine("would you care to add someting Y/N: ");
                    char userInput = Convert.ToChar(Console.ReadLine().ToLower());
                    if (userInput == 'y')
                    {
                        Console.WriteLine("Enter your wish: ");
                        string userWish = Console.ReadLine();
                        MyWishList.Add(userWish);
                    }
                    else
                    {
                        loopActive = false;
                        Console.WriteLine("Take care!");
                    }
                }
                Console.Clear();
                foreach (string wish in MyWishList)
                {
                    Console.WriteLine($"Your wish:{wish}");
                }
                File.WriteAllLines($"{fileLocation}{fileName}", MyWishList);
            }
    }
}
