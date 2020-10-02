using System;
using System.Collections.Generic;

namespace Gruempelitunier
{
    public class Player
    {
        
        public string Name { get; set; }
        public string Prename { get; set; }
        public string PhoneNumber { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string Place { get; set; }
        public string Zip { get; set; }


        //Add Player
        public static Player Create()
        {
            //Input
            Console.WriteLine("Name: ");
            var Name = Console.ReadLine();

            Console.WriteLine("Prename: ");
            var Prename = Console.ReadLine();

            Console.WriteLine("Phone: ");
            var PhoneNumber = Console.ReadLine();

            Console.WriteLine("Street: ");
            var Street = Console.ReadLine();

            Console.WriteLine("House Number: ");
            var HouseNumber = Console.ReadLine();

            Console.WriteLine("Place: ");
            var Place = Console.ReadLine();

            Console.WriteLine("Zip-Code: ");
            var Zip = Console.ReadLine();


            return new Player {
                Name = Name,
                Prename = Prename,
                PhoneNumber = PhoneNumber,
                Street = Street,
                HouseNumber = HouseNumber,
                Place = Place,
                Zip = Zip
            };


        }

        //Override return
        public override string ToString()
        {
            return $"{Name}, {Prename}, {PhoneNumber}, {Street}, {HouseNumber}, {Place}, {Zip}";
        }

        internal void ChangePlayer()
        {
            Console.WriteLine("Welche Attribute möchten Sie bearbeiten");
            Console.WriteLine($"De aktuelle Name ist:{Name}. Geben Sie bitte den neuen Namen ein: ");
            Name = Console.ReadLine();
        }

    }
}