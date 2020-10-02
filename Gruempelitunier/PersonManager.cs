﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleTables;

namespace Gruempelitunier
{
    class PersonManager
    {
        internal List<Player> PA { get; set; } = null;
        internal List<Team> teams { get; set; }


        //Create Team method
        internal void CreatePlayer()
        {
            var player = Player.Create();
            PA.Add(player);
            Team team = new Team();
            //? Warum fnktioniert das nicht
        }

        //Change Team Name method
        internal void ChangePlayerAttributes()
        {
            if (PA.Count == 0) {
                Console.WriteLine("Es gibt keine Spieler");
                CreatePlayer();
                //Wie komme ich aus diesem heraus???
            }
            PrintPlayer();
            var player = ChoosePlayer();
            player.ChangePlayer();

        }

        internal void DeletePlayer()
        {
            PrintPlayer();
            var player = ChoosePlayer();
            PA.Remove(player);
        }

        //Choose team method, is used by change name and delete team
        internal Player ChoosePlayer()
        {
            Console.WriteLine("Wählen Sie eien Spieler aus: ");
            Player player = null; //take the Variable team out, in order to make the while-loop
            do {
                string input = Console.ReadLine();
                player = PA.FirstOrDefault(t => input == t.Name); //First or default is like a method, also has a return...
                //To catch the default expression fo the FirstOrDefault
                if (player == null) {
                    Console.WriteLine("Geben Sie einen gültigen Namen ein");
                }
            } while (player == null);

            return player;
        }

        //Output of the teams in an Console List
        private void PrintPlayer()
        {
            var table = new ConsoleTable("Name", "Vorname", "Telefonnummer", "Strasse", "Hausnummer", "Ort", "PLZ");
            foreach (var player in PA) {

                table.AddRow(player.Name, player.Prename, player.PhoneNumber, player.Street, player.HouseNumber, player.Place, player.Zip);
            }

            table.Write();
        }
    }
}