using System;

namespace Console_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // We are asking the user to choose an option.
            Console.WriteLine("Choose between options 1, 2, 3, and 4" + "\n");
            int alpha = Convert.ToInt32(Console.ReadLine());

            // Using switch case to output the correct option
            switch (alpha)
            {
                case 1:
                    Console.WriteLine("\n");
                    // Request the user to input data.
                    Console.WriteLine("Input a word or sentence" + "\n");
                    // The data is stored in w.
                    string w = Console.ReadLine();
                    Console.WriteLine("\n");
                    // Giving the user options on casing.
                    Console.WriteLine("Do you want your input to be upper or lower case?");
                    Console.WriteLine("Indicate by typing (a) for upper or (b) for lower." + "\n");
                    // Option a is stored in ab.
                    string ab = "a";

                    // The data is converted to uppercase.
                    string upper = w.ToUpper();
                    // The data is converted to lowercase.
                    string lower = w.ToLower();

                    // If the option is "a" uppercase, else lowercase.
                    if (Console.ReadLine() == ab)
                    {
                        Console.WriteLine(upper + "\n");
                    }
                else
                    {
                        Console.WriteLine(lower + "\n");
                    }
                    break;

                    case 2:
                    Console.WriteLine("\n");
                    // Today's date.
                    DateTime date = DateTime.Today;
                    // What day it is today.
                    DayOfWeek dow = DateTime.Now.DayOfWeek;
                    // Using Interpolation.
                    string D = $"Today is {date}. It is a beautiful {dow}.";
                    Console.WriteLine(D + "\n");
                    break;

                    case 3:
                    Console.WriteLine("\n");
                    // Requesting the user's input.
                    Console.WriteLine("Please enter a number");
                    // Stored the data in a.
                    int a = Convert.ToInt32(Console.ReadLine());
                    // Requesting the user's input.
                    Console.WriteLine("Please enter another number");
                    // Stored the data in b.
                    int b = Convert.ToInt32(Console.ReadLine());
                    // Requesting the user's input.
                    Console.WriteLine("Please enter an arithmetic operator, either addition or subtraction");
                    // Stored the data in opr.
                    var opr = Console.ReadLine();
                    Console.WriteLine("\n");
                    // The arithmetic operator "+" is stored in o.
                    var o = "+";

                    // Addition.
                    int add = a + b;
                    // Subtraction
                    int sub = a - b;

                    string res = $"The result of adding {a} and {b} is {add}.";
                    string resu = $"The result of subtracting {a} and {b} is {sub}.";

                    // If the operator is "+" addition, else subtraction.
                    if (opr == o)
                    {
                        Console.WriteLine(res + "\n");
                    }
                    else
                    {
                        Console.WriteLine(resu + "\n");
                    }
                    break;

                    case 4:
                    break;
            }
            Console.WriteLine("\n");
            Console.WriteLine("Press any key to terminate");
            Console.ReadLine();
        }
    }
}