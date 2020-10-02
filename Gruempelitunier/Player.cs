using System;

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

            switch (Console.ReadLine().ToLower()) {
                case "name":
                    Console.WriteLine("Geben Sie einen neuen Namen ein: ");
                    Name = Console.ReadLine();
                    break;

                case "vorname":
                    Console.WriteLine("Geben Sie einen neuen Vornamen ein: ");
                    Prename = Console.ReadLine();
                    break;

                case "telefonnummer":
                    Console.WriteLine("Geben Sie eine neue Telefonnummer ein: ");
                    PhoneNumber = Console.ReadLine();
                    break;

                case "strasse":
                    Console.WriteLine("Geben Sie eine neue Strasse ein: ");
                    Street = Console.ReadLine();
                    break;

                case "hausnummer":
                    Console.WriteLine("Geben Sie eine neue Hasnummer ein: ");
                    HouseNumber = Console.ReadLine();
                    break;

                case "ort":
                    Console.WriteLine("Geben Sie einen neuen Ort ein: ");
                    Place = Console.ReadLine();
                    break;

                case "plz":
                    Console.WriteLine("Geben Sie eine neue PLZ ein: ");
                    Zip = Console.ReadLine();
                    break;
            }
        }
    }
}