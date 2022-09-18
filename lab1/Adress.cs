using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Adress
    {
        private string country;
        private string city;
        private string street;
        private int house;

        public Adress()
        {
            this.country = "Ukraine";
            this.city = "Kherson";
            this.street = "Ushakova";
            this.house = 9;
        }

        public Adress(string Country, string City, string Street, int House)
        {
            this.country = Country;
            this.city = City;
            this.street = Street;
            this.house = House;
        }

        public string toString()
        {
            string str =
                "Country: " + this.country + "\n" +
                "City: " + this.city + "\n" +
                "Street: " + this.street + "\n" +
                "House: " + this.house.ToString() + "\n";
            return str;
        }
       
        public Adress inputadress()
        {
            Console.WriteLine("Country: ");
            string country = Console.ReadLine();
            Console.WriteLine("City: ");
            string city = Console.ReadLine();
            Console.WriteLine("Street: ");
            string street = Console.ReadLine();
            Console.WriteLine("House: ");
            int house = int.Parse(Console.ReadLine());
            Adress adress = new Adress(country, city, street, house);
            return adress;
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        public int House
        {
            get { return house; }
            set { house = value; }
        }
    }
}