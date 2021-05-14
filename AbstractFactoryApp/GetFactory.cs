namespace AbstractFactoryApp
{
    public static class GetFactory
    {
        public static IMenuFactory Get(string input)
        {
            switch (input)
            {
                case "Italian":
                    return new ItalianMenuFactory();
                case "French":
                    return new FrenchMenuFactory();
                default:
                    return new ItalianMenuFactory();
            }
        }
    }
}