using System;
using System.Collections.Generic;
using System.Text;

namespace Gruempelitunier
{
    class Menu
    {
        private readonly TeamManager _teamManager = new TeamManager();

        internal void TeamEdit()
        {
            Console.Clear();
            Console.WriteLine("Team erstellen u. Spieler hinzufügen (1)");
            Console.WriteLine("Teamname bearbeiten (2)");
            Console.WriteLine("Team löschen (3)");
            switch (Console.ReadLine()) {
                case "1":
                    _teamManager.CreateTeam();
                    break;
                case "2":
                    _teamManager.ChangeTeamName();
                    break;
                case "3":
                    _teamManager.DeleteTeam();
                    break;

                default: throw new NotImplementedException();
            }
        }
    }
}
