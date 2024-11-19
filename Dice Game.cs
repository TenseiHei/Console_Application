using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Application
{
    internal class Dice_Game
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            while (isRunning)
            {
                // Asking the user to select an option.
                Console.WriteLine("Select option 1 to roll the dice or option 2 to terminate the program!\n");

                // Validating the option.
                if (!int.TryParse(Console.ReadLine(), out int useroptions))
                {
                    Console.WriteLine("\nInvalid option. Please choose between the given options.");
                    continue;
                }

                // Using switch case.
                switch (useroptions)
                {
                    // This case generates a random number between 1 and 6.
                    case 1:
                        Random rnd = new Random();
                        int randomNumber = rnd.Next(1, 7);
                        Console.WriteLine($"\nDice Rolled: {randomNumber}");
                        break;

                    // This case ends the program.
                    case 2:
                        isRunning = false;
                        Console.WriteLine("\nSayonara! Till we meet again!");
                        break;

                    // This section catches integers not registered as options.
                    default:
                        Console.WriteLine("\n" + useroptions + " is not a valid option.");
                        break;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Press any key to terminate.");
            Console.ReadKey();
        }
    }
}



//class Program
//{
//    static int ReverseNumber(int number)
//    {
//        string numberStr = number.ToString();

//        string reversedStr = new string(numberStr.Reverse().ToArray());

//        int reversedNumber = int.Parse(reversedStr);

//        return reversedNumber;
//    }

//    static void Main()
//    {
//        int num = 12345;
//        int reversedNum = ReverseNumber(num);
//        Console.WriteLine("Original number: " + num);
//        Console.WriteLine("Reversed number: " + reversedNum);
//        Console.ReadLine();
//    }
//}


