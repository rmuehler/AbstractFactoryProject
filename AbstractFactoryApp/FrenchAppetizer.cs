using System;

namespace AbstractFactoryApp
{
    public class FrenchAppetizer : IMenu
    {
        public void PrintMenu()
        {
            Console.WriteLine("Escargot, Basil Soup, Devilled Eggs");
        }
    }
}