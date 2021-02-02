using System;

namespace _08._Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int otherAnimals = int.Parse(Console.ReadLine());
            double dogsFoodPrice = 2.50;
            double otherAnimalsFoodPrice = 4;
            double cost = (dogs * dogsFoodPrice) + (otherAnimals * otherAnimalsFoodPrice);
            Console.WriteLine($"{cost} lv.");
        }
    }
}
