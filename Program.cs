using System;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string userRolls;
            int dieSides;
            int timesRoll = 1;
            int firstDie;
            int secondDie;

            Console.WriteLine("Welcome to the Grand Circus Casino! Would you like to roll the dice? (y/n): ");
            userRolls = Console.ReadLine();

            while (userRolls.ToLower() != "y" && userRolls.ToLower() != "n")
            {
                Console.WriteLine("That is an invalid input.");
                userRolls = Console.ReadLine();
            }
            if (userRolls.ToLower() == "y")
            {
                do
                {
                    Console.WriteLine("How many sides should each die have? ");
                    userRolls = Console.ReadLine();

                    while (!int.TryParse(userRolls, out dieSides))
                    {
                        Console.WriteLine();
                        Console.WriteLine("That is not a valid input!" );
                        userRolls = Console.ReadLine();
                    }
                    firstDie = GetRandom(dieSides);
                    secondDie = GetRandom(dieSides);

                    Console.WriteLine("Roll " + timesRoll);
                    Console.WriteLine("Die One: " + firstDie);
                    Console.WriteLine("Die Two: " + secondDie);

                    Console.Write("Would you like to roll again? (y/n)");
                    userRolls = Console.ReadLine();
                    while (userRolls.ToLower() != "y" && userRolls.ToLower() != "n")
                    {
                        Console.WriteLine("That input is not valid!");
                        userRolls = Console.ReadLine();
                    }

                    timesRoll++;
                } while (userRolls.ToLower() == "y");
            }
            Console.WriteLine("Goodbye!");
        }
        public static int GetRandom(int dieSides)
        {
            Random rand = new Random();
            return rand.Next(1, dieSides);
        }
        
    }
}
