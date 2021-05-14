namespace AbstractFactoryApp
{
    public interface IMenuFactory
    {
        IMenu GenerateAppetizerMenu();
        IMenu GenerateMainMenu();
        IMenu GenerateDessertMenu();
        IMenu GenerateDrinkMenu();
    }
}