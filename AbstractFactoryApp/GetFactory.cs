using System;

namespace AbstractFactoryApp
{
    public static class GetFactory
    {
        public static IMenuFactory Get(string input)
        {
            switch (input)
            {
                case "italian":
                    return new ItalianMenuFactory();
                case "french":
                    return new FrenchMenuFactory();
                case "exit":
                    Console.WriteLine("exiting program, but here is the Italian menu...");
                    return new ItalianMenuFactory();
                default:
                    Console.WriteLine("Invalid input, but here is the French menu...");
                    return new FrenchMenuFactory();
            }
        }
    }
}