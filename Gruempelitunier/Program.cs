using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Gruempelitunier
{
    internal class Program
    {
        internal  readonly List<Team> teams = new List<Team>();
        internal List<Game> Games = new List<Game>();


        private static void CreateTeam()
        {
            var team = Team.Create();
            team.PrintPlayer();
            teams.Add(team);
        }
        private static void Main(string[] args)
        {
            bool isRunning = true; //isRunning weil neues wort gross
            //string test = "Test";
            //File.WriteAllText(@"C:\Users\fireh\Desktop\Praktikum\EGELI\Aufgaben\Gruempelitunier\Test.txt", "Test");


            while (isRunning) {
                Console.WriteLine("Team erstellen u. Spieler hinzufügen (1)");
                Console.WriteLine("Teamname bearbeiten (2)");
                Console.WriteLine("Spieler bearbeiten (3)");
                Console.WriteLine("Quit (q)");

                switch (Console.ReadLine()) {
                    case "1":
                        CreateTeam();
                        break;
                    case "2":
                        ChangeName();
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