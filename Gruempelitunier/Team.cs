using System;
using System.Collections.Generic;
using System.Text;

namespace Gruempelitunier
{
    abstract class Team
    {
        public abstract string TName {get; set;}
        public abstract int Points { get; set; }

        public static Team Create()
        {
            Console.WriteLine("Geben Sie bitte den Namen für das Team ein: ");
            var TName = Console.ReadLine();

            return new Player
            {
                TName = TName

            };
        }
    }
}
