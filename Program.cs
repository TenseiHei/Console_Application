using System;

namespace Console_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asking the user to input te date.
            Console.WriteLine("What day is it today?" + "\n");

            // Getting the current date from the datetime object.
            DayOfWeek dow = DateTime.Now.DayOfWeek;

            //Using switch case to display the correct date.
            switch (dow)
                {
                    case DayOfWeek.Monday:
                    string M = "Monday";
                    string upcase = M.ToUpper();
                    string day = $"Today is: {upcase}";
                    Console.WriteLine(day + "\n");
                    break;

                    case DayOfWeek.Tuesday:
                    string T = "Tuesday";
                    string u = T.ToUpper();
                    string d = $"Today is: {u}";
                    Console.WriteLine(d + "\n");
                    break;

                    case DayOfWeek.Wednesday:
                    string W = "Wednesday";
                    string up = W.ToUpper();
                    string da = $"Today is: {up}";
                    Console.WriteLine(da + "\n");
                    break;

                    case DayOfWeek.Thursday:
                    string TH = "Thursday";
                    string upc = TH.ToUpper();
                    string ad = $"Today is: {upc}";
                    Console.WriteLine(ad + "\n");
                    break;

                    case DayOfWeek.Friday:
                    string F = "Friday";
                    string upca = F.ToUpper();
                    string fr = $"Today is: {upca}";
                    Console.WriteLine(fr + "\n");
                    break;

                    case DayOfWeek.Saturday:
                    string S = "Saturday";
                    string upcas = S.ToUpper();
                    string sa = $"Today is: {upcas}";
                    Console.WriteLine(sa + "\n");
                    break;

                    case DayOfWeek.Sunday:
                    string SU = "Sunday";
                    string upcased = SU.ToUpper();
                    string sun = $"Today is: {upcased}";
                    Console.WriteLine(sun + "\n");
                    break;
            }

            // Allows the user to read then terminate.
            Console.WriteLine("Press any key to terminate");
            Console.ReadLine();
        }
    }
}