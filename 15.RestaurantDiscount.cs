using System;

namespace _03.RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string discount = Console.ReadLine();          
            double price = 0.00;
            double discountPrice = 0.00;
            double percent = 0.00;
            double total = 0;
            double pricePerPerson = 0;

            if (people > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            if (people <= 50)
            {
                price += 2500.00;
                Console.WriteLine("We can offer you the Small Hall");
            }
            else if (people > 50 && people <= 100)
            {
                price += 5000.00;
                Console.WriteLine("We can offer you the Terrace");
            }
            else if (people > 100 && people <= 120)
            {
                price += 7500.00;
                Console.WriteLine("We can offer you the Great Hall");
            }
            switch (discount)
            {
                case "Normal":
                    discountPrice += 500.00;
                    percent += 0.05;
                    break;
                case "Gold":
                    discountPrice += 750.00;
                    percent += 0.10;
                    break;
                case "Platinum":
                    discountPrice += 1000.00;
                    percent += 0.15;
                    break;
            }

            total = price + discountPrice;
            total -= (total * percent);
            pricePerPerson = total / people;

            Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
           
        }
    }
}
