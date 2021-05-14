using System;

namespace AbstractFactoryApp
{
    public class FrenchMain : IMenu
    {
        public void PrintMenu() => Console.WriteLine("Streak Frites, Chicken Cordon Bleu, Quiche");
        
    }
}