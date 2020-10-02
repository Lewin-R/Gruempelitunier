using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleTables;

namespace Gruempelitunier
{
    internal class Team
    {

        internal List<Player> PA  = new List<Player>();
        internal  string TName { get; set; }
        internal List<Team> teams { get; set; }
        internal int Points { get; set; }

        

        public static Team Create()
        {
            Console.WriteLine("Geben Sie bitte den Namen für das Team ein: ");
            var TName = Console.ReadLine();

            var team = new Team();
            team.TName = TName;

            do {
                Player p1 = Player.Create();
                team.PA.Add(p1);
                Console.WriteLine("Möchten Sie noch einen Spieler hinzufügen? (y/n): ");
            } while (Console.ReadLine().ToLower() == "y");
            return team;
        }

        public override string ToString()
        {
            return $"{TName}";
        }

        internal void PrintPlayer()
        {
            Console.WriteLine($"Team Name: {TName}");
            ConsoleTable
                .From<Player>(PA)
                .Configure(o => o.NumberAlignment = Alignment.Right)
                .Write(Format.Alternative);
        }

        internal void ChangeName()
        {
            Console.WriteLine($"De aktuelle Name ist:{TName}. Geben Sie bitte den neuen Namen ein: ");
            TName = Console.ReadLine();

        }
    }
}