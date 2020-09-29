using ConsoleTables;
using System;
using System.Collections.Generic;

namespace Gruempelitunier
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var PA = new List<Player>();

            do
            {
                Player p1 = Player.Create();
                PA.Add(p1);
                Console.WriteLine("Möchten Sie noch einen Spieler hinzufügen? (y/n): ");
            } while (Console.ReadLine().ToLower() == "y");

            //foreach (var player in PA)
            //{
            //    Console.WriteLine(player.ToString());
            //}

            ConsoleTable
            .From<Player>(PA)
            .Configure(o => o.NumberAlignment = Alignment.Right)
            .Write(Format.Alternative);

            Console.ReadKey();
        }
    }
}