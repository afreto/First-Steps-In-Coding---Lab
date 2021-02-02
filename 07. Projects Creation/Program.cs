using System;

namespace _07._Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string architect = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());
            int neededHours = projects * 3;
            Console.WriteLine($"The architect {architect} will need {neededHours} hours to complete {projects} project/s.");
        }
    }
}
