using System;

namespace AbstractFactoryApp
{
    public class ItalianDrink : IMenu
    {
        public void PrintMenu()
        {
            Console.WriteLine("Negroni, Americano, Campari, Coffee");
        }
    }
}