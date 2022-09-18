using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Human
    {
        private string name;
        private string surname;
        private int age;
        private double weight;
        private double height;
        private bool habbits;
        private Adress adress;

        public Human()
        {
            this.name = "Anastasiia";
            this.surname = "Kobets";
            this.age = 18;
            this.weight = 50;
            this.height = 1.71;
            this.habbits = false;
            this.adress = new Adress();
        }

        public Human(string newName,string newSurname, int newAge, double newHeight, double newWeight, bool newHabbits, Adress adress1)
        {
            this.name = newName;
            this.surname = newSurname;
            this.age = newAge;
            this.weight = newHeight;
            this.height = newWeight;
            this.habbits = newHabbits;
            this.adress = adress1;
        }

        public void printShow()
        {
            string str = "Name= " + this.name + "\n" +
                "Surame= " + this.surname + "\n" +
                "Age= " + this.age + "\n" +
                "Height= " + this.height + "\n" +
                "Weight= " + this.weight + "\n" +
                "Habbits= " + this.habbits;
            Console.WriteLine(str);
        }

        public string toString()
        {
            string str = "Name= " + this.name + "\n" +
                "Surame= " + this.surname + "\n" +
                "Age= " + this.age + "\n" +
                "Height= " + this.height + "\n" +
                "Weight= " + this.weight + "\n" +
                "Habbits= " + this.habbits;
            return str;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
               age = value;
            }
        }
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
               weight = value;
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
               height = value;
            }
        }
        public bool Habbits
        {
            get
            {
                return habbits;
            }
            set
            {
                habbits = value;
            }
        }
    }
}