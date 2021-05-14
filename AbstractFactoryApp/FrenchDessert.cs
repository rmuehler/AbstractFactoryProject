using System;

namespace AbstractFactoryApp
{
    public class FrenchDessert : IMenu
    {
        public void PrintMenu()
        {
            Console.WriteLine("Crepes, Creme Brule, Creme Caramel, Madelenines, Chocolate Mousse");
        }
    }
}