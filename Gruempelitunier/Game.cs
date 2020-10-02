using System;

namespace Gruempelitunier
{
    internal class Game
    {
        public string Date { get; set; } //string weil Time nicht geht.
        public int GoalT1 { get; set; }
        public int GoalT2 { get; set; }

        //internal void GameRun()
        //{
        //    int write = RandomGoals();
        //    Console.WriteLine(write);
            
        //}

        //private int RandomGoals()
        //{
        //    var random = new Random();
        //    int randomnumber = random.Next();
        //    return randomnumber;
        //}
    }
}