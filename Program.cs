using System;

namespace Console_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // We are asking the user to choose an option.
            Console.WriteLine("Choose between options 1, 2, 3, and 4." + "\n");
            int userOptions = Convert.ToInt32(Console.ReadLine());

            // Using switch case to output the correct option
            switch (userOptions)
            {
                case 1:
                    Console.WriteLine("\n");
                    // Request the user to input data.
                    Console.WriteLine("Input a word or sentence." + "\n");
                    // The data is stored in w.
                    string input = Console.ReadLine();
                    Console.WriteLine("\n");
                    // Giving the user options on casing.
                    Console.WriteLine("Do you want your input to be upper or lower case?");
                    Console.WriteLine("Indicate by typing (u) for upper or (l) for lower." + "\n");
                    // The users option is stored in "options".
                    string options = Console.ReadLine();

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
                    Console.WriteLine("\n");
                    Console.WriteLine($"Today is {DateTime.Today:D}. It is a beautiful {DateTime.Now.DayOfWeek}." + "\n");
                    break;

                    case 3:
                    Console.WriteLine("\n");
                    // Requesting the user's input.
                    Console.WriteLine("Please enter a number.");
                    // The data is stored in "num1".
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    // Requesting the user's input.
                    Console.WriteLine("Please enter another number.");
                    // The data is stored in "num1".
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    // Requesting the user's input.
                    Console.WriteLine("Please enter an arithmetic operator, either addition or subtraction.");
                    // The operator is stored in "arithmetic"".
                    var arithmetic = Console.ReadLine();
                    Console.WriteLine("\n");

                    // Addition.
                    int add = num1 + num2;
                    // Subtraction
                    int sub = num1 - num2;

                    // If the operator is "+" addition, else subtraction.
                    if (arithmetic == "+")
                    {
                        Console.WriteLine($"The result of adding {num1} and {num2} is {add}." + "\n");
                    }
                    else if (arithmetic == "-")
                    {
                        Console.WriteLine($"The result of subtracting {num1} and {num2} is {sub}." + "\n");
                    }
                    else
                    {
                        Console.WriteLine(arithmetic + " is not a valid operator! Please enter either plus or minus!");
                    }
                    break;

                    case 4:
                    Console.WriteLine("\n");
                    Console.WriteLine("This option is to terminate the program.");
                    break;

                    default:
                    Console.WriteLine("\n");
                    Console.WriteLine(userOptions + " is not a valid option");
                    break;
            }
            Console.WriteLine("\n");
            Console.WriteLine("Press any key to terminate");
            Console.ReadLine();
        }
    }
}