using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gruempelitunier
{
    public class TeamManager
    {
        internal readonly List<Team> teams = new List<Team>();

        //Create Team method
        internal void CreateTeam()
        {
            var team = Team.Create();
            team.PrintPlayer();
            teams.Add(team);
        }

        //Change Team Name method
        internal void ChangeTeamName()
        {
            if (teams.Count == 0) {
                Console.WriteLine("Es existieren keine Teams!");
                CreateTeam();
            }
            PrintTeamName();
            var team = ChooseTeam();
            team.ChangeName();
        }

        internal void DeleteTeam()
        {
            PrintTeamName();
            var team = ChooseTeam();
            teams.Remove(team);
        }

        //Choose team method, is used by change name and delete team
        internal Team ChooseTeam()
        {
            Console.WriteLine("Wählen Sie ein Team aus: ");
            Team team = null; //take the Variable team out, in order to make the while-loop
            do {
                string input = Console.ReadLine();
                team = teams.FirstOrDefault(t => input == t.TName); //First or default is like a method, also has a return...
                //To catch the default expression fo the FirstOrDefault
                if (team == null) {
                    Console.WriteLine("Geben Sie einen gültigen Namen ein");
                }
            } while (team == null);

            return team;
        }

        //Output of the teams in an Console List
        private void PrintTeamName()
        {
            var table = new ConsoleTable("Team Name");
            foreach (var team in teams) {
                table.AddRow(team.TName);
            }

            table.Write();
        }

        internal void AddPlayerToTeam()
        {
            if (teams.Count == 0) 
            {
                Console.WriteLine("Es sind keine Teams hinzugefügt worden");
                CreateTeam();
            }
           PrintTeamName();
           Team team =  ChooseTeam();
           team.PA.Add(Player.Create());

        }
    }
}