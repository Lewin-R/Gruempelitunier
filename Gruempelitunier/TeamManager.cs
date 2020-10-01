using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleTables;

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
            PrintTeam();
            var team = ChooseTeam();
            team.ChangeName();
        }

        //Choose team method, is used by change name and delete team
        private Team ChooseTeam()
        {
            Console.WriteLine("Wählen Sie ein Team aus: ");
            Team team = null; //take the Variable team out, in order to make the while-loop
            do {
                string imput = Console.ReadLine();
                team = teams.FirstOrDefault(t => imput == t.TName); //First or default is like a method, also has a return...
                //To catch the default expression fo the FirstOrDefault
                if (team == null) {
                    Console.WriteLine("Geben Sie einen gültigen Namen ein");
                }
            } while (team == null);

            return team;
        }

        //Output of the teams in an Console List
        private void PrintTeam()
        {
            ConsoleTable
                .From<Team>(teams)
                .Configure(o => o.NumberAlignment = Alignment.Right)
                .Write(Format.Alternative);
        }

    }
}