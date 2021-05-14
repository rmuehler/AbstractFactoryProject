using System;

namespace AbstractFactoryApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Out.WriteLine("What type of food do you want?: Italian/French");
            string input = Console.ReadLine();
            var factory = GetFactory.Get(input);
            var appitizer = factory.GenerateAppetizerMenu();
            var main = factory.GenerateMainMenu();
            var drink = factory.GenerateDrinkMenu();
            var dessert = factory.GenerateDessertMenu();
            
            Console.WriteLine("Appetizer Menu:");
            appitizer.PrintMenu();
            Console.WriteLine("Main Menu");
            main.PrintMenu();
            Console.Out.WriteLine("Drink Menu");
            drink.PrintMenu();
            Console.Out.WriteLine("Dessert Menu");
            dessert.PrintMenu();
        }
    }
}