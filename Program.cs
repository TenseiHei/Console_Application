using System;

namespace Console_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asking the user to input te date.
            Console.WriteLine("What day is it today?" + "\n");

            //Using switch case to display the correct date.
            switch (DateTime.Now.DayOfWeek)
                {
                    case DayOfWeek.Monday:
                    Console.WriteLine($"Today is: {DayOfWeek.Monday.ToString().ToUpper()}" + "\n");
                    break;

                    case DayOfWeek.Tuesday:
                    Console.WriteLine($"Today is: {DayOfWeek.Tuesday.ToString().ToUpper()}" + "\n");
                    break;

                    case DayOfWeek.Wednesday:
                    Console.WriteLine($"Today is: {DayOfWeek.Wednesday.ToString().ToUpper()}" + "\n");
                    break;

                    case DayOfWeek.Thursday:
                    Console.WriteLine($"Today is: {DayOfWeek.Thursday.ToString().ToUpper()}" + "\n");
                    break;

                    case DayOfWeek.Friday:
                    Console.WriteLine($"Today is: {DayOfWeek.Friday.ToString().ToUpper()}" + "\n");
                    break;

                    case DayOfWeek.Saturday:
                    Console.WriteLine($"Today is: {DayOfWeek.Saturday.ToString().ToUpper()}" + "\n");
                    break;

                    case DayOfWeek.Sunday:
                    Console.WriteLine($"Today is: {DayOfWeek.Sunday.ToString().ToUpper()}" + "\n");
                    break;
            }

            // Allows the user to read then terminate.
            Console.WriteLine("Press any key to terminate");
            Console.ReadLine();
        }
    }
}