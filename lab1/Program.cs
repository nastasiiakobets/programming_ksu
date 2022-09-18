using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Human one = new Human("Sonya", "JGf", 17, 1.56, 54, false, weadd);
            Human two = new Human("Roman", "Fallgt", 26, 1.9, 76, true, new Adress("Polish", "Hskuf", "Shin", 35));

            string result = one.toString();
            Console.WriteLine(result);

            two.toString();
        }

    }
}