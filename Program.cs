using System;

namespace Console_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // We ask the user to input their age.
            Console.WriteLine("How old are you?");

            // We convert from string type to int type.
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            // Displaying the users age.
            Console.WriteLine("Your age is " + age);
            Console.WriteLine("\n");
            
            // If age is less than or equal to 12
            if (age <= 12)
            {
                Console.WriteLine("You are a child :)");
            }
            // If age is less than or equal to 19
            else if (age <=19)
            {
                Console.WriteLine("You are a teenger... Your future is bright!");
            }
            // If age is above 19
            else
            {
                Console.WriteLine("You are an adult... You're in your prime!!");
            }
            
            Console.ReadLine();
        }
    }
}
