using System;

namespace Gruempelitunier
{
    public class Team
    {
        public string TName { get; set; }
        public int Points { get; set; }

        public static Team Create()
        {
            Console.WriteLine("Geben Sie bitte den Namen für das Team ein: ");
            var TName = Console.ReadLine();

            return new Team
            {
                TName = TName
            };
        }

        public override string ToString()
        {
            return $"{TName}";
        }
    }
}