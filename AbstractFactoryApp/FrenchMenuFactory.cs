namespace AbstractFactoryApp
{
    public class FrenchMenuFactory : IMenuFactory
    {
        public IMenu GenerateAppetizerMenu()
        {
            return new FrenchAppetizer();
        }

        public IMenu GenerateMainMenu()
        {
            return new FrenchMain();
        }

        public IMenu GenerateDessertMenu()
        {
            return new FrenchDessert();
        }

        public IMenu GenerateDrinkMenu()
        {
            return new FrenchDrink();
        }
    }
}