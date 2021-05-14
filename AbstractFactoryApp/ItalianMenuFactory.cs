using System;

namespace AbstractFactoryApp
{
    public class ItalianMenuFactory : IMenuFactory
    {
        public IMenu GenerateAppetizerMenu()
        {
            return new ItalianAppetizer();
        }

        public IMenu GenerateMainMenu()
        {
            return new ItalianMain();
        }

        public IMenu GenerateDessertMenu()
        {
            return new ItalianDessert();
        }

        public IMenu GenerateDrinkMenu()
        {
            return new ItalianDrink();
        }
    }
}