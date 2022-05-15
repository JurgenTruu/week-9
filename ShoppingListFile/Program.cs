using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ShoppingListFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\37253\samples\ShoppingList";
            string fileName = @"\\MyShoppingList.txt";
            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> MyShoppingList = arrayFromFile.ToList<string>();
            bool loopActive = true;
            while (loopActive)
            {
                Console.WriteLine("Would you like to add a product to your shopping list? Y/N:");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());
                if (userInput == 'y')
                {
                    Console.WriteLine("Enter product name:");
                    string userProduct = Console.ReadLine();
                    MyShoppingList.Add(userProduct);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Have a nice shopping!");
                }
            }
            Console.Clear();
            foreach (string product in MyShoppingList)
            {
                Console.WriteLine($"Your product: {product}");
            }
            File.WriteAllLines($"{fileLocation}{fileName}", MyShoppingList);
        }
    }
}
