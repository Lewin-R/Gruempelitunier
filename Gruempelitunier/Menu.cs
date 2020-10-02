using System;
using System.Collections.Generic;
using System.Text;

namespace Gruempelitunier
{
    class Menu
    {
        private readonly TeamManager _teamManager = new TeamManager();
        private readonly PersonManager _personManager = new PersonManager();
        private bool isRunning = true; //isRunning weil neues wort gross

        internal void MainMenu()
        {
            while (isRunning) {
                Console.WriteLine("Team bearbeiten (1)");
                Console.WriteLine("Spieler bearbeiten(2)");
                Console.WriteLine("Quit (q)");

                switch (Console.ReadLine()) {
                    case "1":
                        TeamEdit();
                        break;
                    case "2":
                        PersonEdit();
                        break;
                    case "q":
                        isRunning = false;
                        break;

                    default: {
                        throw new NotImplementedException();
                    }
                }
            }
        }

        internal void TeamEdit()
        {
            while (isRunning) {
                Console.Clear();
                Console.WriteLine("Team erstellen u. Spieler hinzufügen (1)");
                Console.WriteLine("Teamname bearbeiten (2)");
                Console.WriteLine("Team löschen (3)");
                Console.WriteLine("Spiler zu Team hinzufügen (4)");
                Console.WriteLine("Spieler von Team entfernen (5)");
                Console.WriteLine("Press q to exit");
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
                    case "4":

                        break;
                    case "5":

                        break;
                    case "q":
                        isRunning = false;
                        break;

                    default: throw new NotImplementedException();
                }
            }
        }

        internal void PersonEdit() 
        {
            Console.Clear();
            Console.WriteLine("Spieler erstellen und zu Team hinzufügen (1)");
            Console.WriteLine("Spieler bearbeiten (2)");
            Console.WriteLine("Spieler löschen (3)");
            switch (Console.ReadLine()) {
                case "1":
                    _personManager.CreatePlayer();
                    break;
                case "2":
                    _personManager.ChangePlayerAttributes();
                    break;
                case "3":
                    _personManager.DeletePlayer();
                    break;
                

                default: throw new NotImplementedException();
            }

        }
    }
}
