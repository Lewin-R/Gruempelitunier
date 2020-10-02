using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Gruempelitunier
{
    internal class Program
    {

        internal List<Game> _games = new List<Game>();
        private static readonly Menu _menu = new Menu();


        private static void Main(string[] args)
        {
          
            _menu.MainMenu();

            Console.WriteLine("Beliebige Taste drücken um zu beenden");
            Console.ReadKey();
        }
    }
}