using System;

namespace AbstractFactoryApp
{
    public class ItalianMain : IMenu
    {
        public void PrintMenu()
        {
            Console.WriteLine("Alfredo, Pasta, Pizza, Chicken Parmesan");
        }
    }
}