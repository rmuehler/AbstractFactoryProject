namespace AbstractFactoryApp
{
    public class FrenchMenuFactory : IMenuFactory
    {
        public IMenu GenerateAppetizerMenu() => new FrenchAppetizer();


        public IMenu GenerateMainMenu() => new FrenchMain();


        public IMenu GenerateDessertMenu() => new FrenchDessert();
 

        public IMenu GenerateDrinkMenu() => new FrenchDrink();

    }
}