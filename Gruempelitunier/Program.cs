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
            bool isRunning = true; //isRunning weil neues wort gross
            //string test = "Test";
            //File.WriteAllText(@"C:\Users\fireh\Desktop\Praktikum\EGELI\Aufgaben\Gruempelitunier\Test.txt", "Test");


            while (isRunning) {
                Console.WriteLine("Team bearbeiten (1)");
                Console.WriteLine("Spieler bearbeiten(2)");
                Console.WriteLine("(3)");
                Console.WriteLine("Quit (q)");

                switch (Console.ReadLine()) {
                    case "1":
                         _menu.TeamEdit();
                        break;
                    case "2":
                      
                        break;
                    case "3":
                     
                        break;
                    case "q":
                        isRunning = false;
                        break;

                    default: throw new NotImplementedException();
                }

                //break; for every loop


                //if (Console.ReadLine() == "2") {
                //    Console.Clear();
                //    Console.WriteLine("Team hinzufüen (1)");
                //    Console.WriteLine("Team löschen (2)");
                //    Console.WriteLine("Team bearbeiten (3)");

                //}
                //if (Console.ReadLine() == "3") {
                //    Console.Clear();
                //    Console.WriteLine("Spiel hinzufüen (1)");
                //    Console.WriteLine("Spiel löschen (2)");
                //    Console.WriteLine("Spiel bearbeiten (3)");

                //}


            }

            Console.WriteLine("Beliebige Taste drücken um zu beenden");
            Console.ReadKey();
        }
    }
}