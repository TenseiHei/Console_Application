using System;
using System.ComponentModel;
using System.Globalization;

namespace Console_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            while (isRunning)
            {
                // We are asking the user to choose an option.
                Console.WriteLine("Choose between options 1, 2, 3, and 4.\n");

                // Making sure the user can only input interger values.
                if (!int.TryParse(Console.ReadLine(), out int userOptions))
                {
                    Console.WriteLine("Invalid input. Read please!");
                    continue;
                }

                // Using switch case to output the correct option
                switch (userOptions)
                {
                    case 1:
                        // Request the user to input data.
                        Console.WriteLine("\nInput a word or sentence.\n");

                        // The data is stored in input.
                        string input = Console.ReadLine();

                        // Giving the user options on casing.
                        Console.WriteLine("\nDo you want your input to be upper or lower case?");
                        Console.WriteLine("Indicate by typing (u) for upper or (l) for lower.\n");

                        // The users option is stored in "options".
                        string options = Console.ReadLine()/*?.ToLower()*/;

                        // If the option is "u" uppercase, else lowercase.
                        if (options == "u")
                        {
                            Console.WriteLine(input.ToUpper() + "\n");
                        }
                        else if (options == "l")
                        {
                            Console.WriteLine(input.ToLower() + "\n");
                        }
                        else
                        {
                            Console.WriteLine(options + " is not a valid option!");
                        }
                        break;

                    case 2:
                        Console.WriteLine($"\nToday is {DateTime.Today:D}. It is a beautiful {DateTime.Now.DayOfWeek}.\n");
                        break;

                    case 3:
                        // Requesting the user's input for the first number.
                        Console.WriteLine("\nPlease enter a number.");
                        // The data is stored in "num1".
                        if (!int.TryParse(Console.ReadLine(), out int num1))
                        {
                            Console.WriteLine("Invalid input. Read please!");
                            break;
                        }

                        // Requesting the user's input for the second number.
                        Console.WriteLine("Please enter another number.");
                        // The data is stored in "num2".
                        if (!int.TryParse(Console.ReadLine(), out int num2))
                        {
                            Console.WriteLine("Invalid input. Read please!");
                            break;
                        }

                        // Requesting the user's input for the arithmetic operator.
                        Console.WriteLine("Please enter an arithmetic operator, either + for addition or - for subtraction.");
                        // The operator is stored in "arithmetic".
                        string arithmetic = Console.ReadLine();

                        // Based on the operator input, we will perform addition or subtraction.
                        if (arithmetic == "+")
                        {
                            int add = num1 + num2;
                            Console.WriteLine($"The result of adding {num1} and {num2} is {add}.\n");
                        }
                        else if (arithmetic == "-")
                        {
                            int sub = num1 - num2;
                            Console.WriteLine($"The result of subtracting {num1} and {num2} is {sub}.\n");
                        }
                        else
                        {
                            Console.WriteLine(arithmetic + " is not a valid operator! Please enter either + or -.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("\nExiting the program. Sayonara!");
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine(userOptions + " is not a valid option!");
                        break;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Press any key to terminate");
            Console.ReadKey();
        }
    }
}