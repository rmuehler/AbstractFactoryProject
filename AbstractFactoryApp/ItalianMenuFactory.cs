using System;

namespace AbstractFactoryApp
{
    public class ItalianMenuFactory : IMenuFactory
    {
        public IMenu GenerateAppetizerMenu() => new ItalianAppetizer();

        public IMenu GenerateMainMenu() => new ItalianMain();

        public IMenu GenerateDessertMenu() => new ItalianDessert();

        public IMenu GenerateDrinkMenu() => new ItalianDrink();
    }
}