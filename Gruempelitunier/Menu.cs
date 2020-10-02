using System;

namespace Gruempelitunier
{
    internal class Menu
    {
        private readonly TeamManager _teamManager = new TeamManager();
        private readonly PersonManager _personManager = new PersonManager();
        private readonly Game _game = new Game();
        //isRunning weil neues wort gross

        internal void MainMenu()
        {
            bool isRunning = true;
            while (isRunning) {
                Console.Clear();
                Console.WriteLine("Team bearbeiten (1)");
                Console.WriteLine("Spieler bearbeiten(2)");
                Console.WriteLine("Spiele (3)");
                Console.WriteLine("Quit (q)");

                switch (Console.ReadLine()) {
                    case "1":
                        TeamEdit();
                        break;

                    case "2":
                        PersonEdit();
                        break;

                    //case "3":
                    //    GamePlay();
                        break;

                    case "q":
                        isRunning = false;

                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Bitte eine der Aufgeführten Nummern angeben");
                        break;
                }
            }
        }

        internal void TeamEdit()
        {
            bool isRunning2 = true;
            while (isRunning2) {
                Console.Clear();
                Console.WriteLine("Team erstellen u. Spieler hinzufügen (1)");
                Console.WriteLine("Teamname bearbeiten (2)");
                Console.WriteLine("Team löschen (3)");
                Console.WriteLine("Teamliste anzeigen (4)");
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
                        _teamManager.PrintTeamName();
                        Console.ReadKey();
                        break;
                    case "q":
                        MainMenu();
                        break;

                    default:
                        Console.WriteLine("Bitte eine der Aufgeführten Nummern angeben");
                        break;
                }
            }
        }
 
        internal void PersonEdit()
        {
            bool isRunning3 = true;
            while (isRunning3) {
                Console.Clear();
                Console.WriteLine("Spieler erstellen und zu Team hinzufügen (1)");
                Console.WriteLine("Spieler bearbeiten (2)");
                Console.WriteLine("Spieler löschen (3)");
                Console.WriteLine("Spielerliste ausgeben (4)");
                Console.WriteLine("press q to exit");
                switch (Console.ReadLine()) {
                    case "1":
                        _teamManager.AddPlayerToTeam();
                        break;

                    case "2":
                        _personManager.ChangePlayerAttributes();
                        break;

                    case "3":
                        _personManager.DeletePlayer();
                        break;
                    case "4":
                        _personManager.PrintPlayer();
                        Console.ReadKey();
                        break;
                    case "q":
                        MainMenu();
                        break;

                    default:
                        Console.WriteLine("Bitte eine der Aufgeführten Nummern angeben");
                        break;
                }
            }
        }

        //internal void GamePlay()
        //{
        //   _game.GameRun();
        //}
    }
}