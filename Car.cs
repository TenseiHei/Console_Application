using System;

namespace Console_Application
{
    public class Car
    {
        public string model;
        public string color; // Ensure this property exists
        public int year;

        public void fullThrottle()
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
    }
}