using System;

namespace AbstractFactoryApp
{
    public class ItalianDessert : IMenu
    {
        public void PrintMenu() => Console.WriteLine("Tiramisu, Connoli, Panaccotta");

    }
}