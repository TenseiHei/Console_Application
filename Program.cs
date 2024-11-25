using System;

namespace Console_Application // Match the namespace of both files
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Ford = new Car();
            Ford.model = "Mustang";
            Ford.color = "red"; // This line uses the 'color' property
            Ford.year = 1969;

            Car Opel = new Car();
            Opel.model = "Astra";
            Opel.color = "white"; // This line uses the 'color' property
            Opel.year = 2005;

            Console.WriteLine("The " + Ford.model + " is " + Ford.color + " and it was made in the year " + Ford.year);
            Console.WriteLine("The " + Opel.model + " is " + Opel.color + " and it was made in the year " + Opel.year + "\n");

            Ford.fullThrottle();
            Console.ReadLine();
        }
    }
}

// 2 players. 20 Cardsc 1 Deck. 
// Using OOP
// Beginning of every round shuffle cards. Each player gets 10 cards each.
// Cards numbered 1-20, when cards shuffled, the numbers change.
// Each player does the sum of their first five cards
// Any players sum greater than 30 will receive a score of zero for that round, if less than 30, the sum is their score.
// Five rounds.
// After five rouunds, player with the highest score wins.
// Let's Go!!