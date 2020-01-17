using System;

namespace NewMadLib
{
    class Program
    {
        static void Main(string[] args)
        {
            IntroToAdlib();

            Console.WriteLine(SetAnimal() + SetNoun0() + SetPlace() + SetPNoun() + SetAdj0());
            Console.ReadLine();



            //

            //

            //




        }
        //put story together
        //get variable
        //place w/ string interp

        public static void IntroToAdlib()
        {
            Console.WriteLine("Hey! Were going to make an aslib story!");
            Console.WriteLine("Please input the values asked for and lets see if our story is good or not");
            Console.WriteLine("Press enter when youre ready to make an awesome stroy");
            Console.ReadLine();
        }
        public static string SetAnimal()
        {
            Console.WriteLine("Type any animal");
            string animal = Console.ReadLine();
            //store input as var and return it to be use later
            Console.WriteLine($"Tommy the gangsta {animal} was waliking up the street to his");
            return animal;
        }







        public static string SetPlace()
        {
            Console.WriteLine("Next, give me somewhhere you would like to visit, a place");
            string place = Console.ReadLine();
            string placeString = "in the" + place;
            return placeString;
        }
        public static string SetPNoun()
        {
            Console.WriteLine("Type an animal");
            string PNoun = Console.ReadLine();
            string PNounString = "But just as he cane inside hhe saw that all his gangsta" + PNoun;
            return PNounString;
        }
        public static string SetNoun0()
        {
            Console.WriteLine("Type an animal");
            string GetNoun = Console.ReadLine();

            return GetNoun;

        }
        public static string SetNoun1()
        {
            Console.WriteLine("Type an animal");
            string GetNoun = Console.ReadLine();
            return GetNoun;

        }
        public static string GetNoun2()
        {
            Console.WriteLine("Type an animal");
            string GetNoun = Console.ReadLine();
            return GetNoun;

        }
        public static string GetNoun3()
        {
            Console.WriteLine("Type an animal");
            string GetNoun = Console.ReadLine();
            return GetNoun;

        }
        public static string GetNoun4()
        {
            Console.WriteLine("Type an animal");
            string GetNoun = Console.ReadLine();
            return GetNoun;
        }


        public static string SetAdj0()
        {
            Console.WriteLine("Type any Adjective");
            string adj = Console.ReadLine();

            string adjString = "had been replaced with" + adj;
            return adjString;
        }

        public static void Story()
        {
            Console.WriteLine();

        }
    }
}
