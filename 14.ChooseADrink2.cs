using System;

namespace _02.ChooseADrink2
{
    class Program
    {
        static void Main(string[] args)
        {
            string profesion = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price = 0;

            switch (profesion)
            {
                case "Athlete":                
                    price += 0.70;
                    break;
                case "Businessman":
                case "Businesswoman":                  
                    price += 1.00;
                    break;
                case "SoftUni Student":                  
                    price += 1.70;
                    break;
                default:                
                    price += 1.20;
                    break;
            }
            double totalPrice = quantity * price;
            Console.WriteLine($"The {profesion} has to pay {totalPrice:F2}.");
        }
    }
}
