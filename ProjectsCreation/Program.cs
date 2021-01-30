using System;

namespace ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Вход
            //           От конзолата се четат 2 реда:
            //⦁	Името на архитекта - текст
            string architect = Console.ReadLine();
            //⦁	Брой на проектите - цяло число в интервала[0… 100]
            int projects = int.Parse(Console.ReadLine());
            int neededHours = projects * 3;
            //Изход
            //На конзолата се отпечатва:
            //⦁	"The architect {името на архитекта} will need {необходими часове} hours to complete {брой на проектите} project/s."
            Console.WriteLine($"The architect {architect} will need {neededHours} hours to complete {projects} project/s.");




        }
    }
}
