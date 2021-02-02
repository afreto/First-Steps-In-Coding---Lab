using System;

namespace _09._Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double sqm = double.Parse(Console.ReadLine());
            double price = sqm * 7.61;
            double discount = price * 0.18;
            double total = price - discount;

            Console.WriteLine($"The final price is: {total} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
