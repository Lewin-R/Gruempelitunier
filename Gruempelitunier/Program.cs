using System;

namespace Gruempelitunier
{
    internal class Program
    {
        private static readonly Menu _menu = new Menu();

        private static void Main(string[] args)
        {
            _menu.MainMenu();

            Console.WriteLine("Beliebige Taste drücken um zu beenden");
            Console.ReadKey();
        }
    }
}