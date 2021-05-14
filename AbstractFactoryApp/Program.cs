using System;

namespace AbstractFactoryApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Out.WriteLine("What type of food do you want?: ");
            string input = Console.ReadLine();
            var factory = GetFactory.Get(input);
        }
    }
}