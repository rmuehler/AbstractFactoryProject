using System;

namespace AbstractFactoryApp
{
    public class ItalianAppetizer : IMenu
    {
        public void PrintMenu()
        {
            Console.WriteLine("Mozarella Sticks, Tomato Basil Soup, Caesar Salad, Bread Sticks");
        }
    }
}