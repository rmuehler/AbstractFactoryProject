using System;

namespace AbstractFactoryApp
{
    public class FrenchDrink : IMenu
    {
        public void PrintMenu()
        {
            Console.WriteLine("Absinthe, Cognac, Cidre, Champagne, Perrier");
        }
    }
}