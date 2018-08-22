using System;

namespace _08.CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int productNum = int.Parse(Console.ReadLine());
            int cheeseCount = 0;
            int tomatoSauceCount = 0;
            int salamiCount = 0;
            int pepperCount = 0;
            int totalCalories = 0;

            for (int i = 0; i < productNum; i++)
            {
                string product = (Console.ReadLine()).ToLower();

                if (product.Equals("cheese"))
                {
                    cheeseCount++;
                }
                else if (product.Equals("tomato sauce"))
                {
                    tomatoSauceCount++;
                }
                else if (product.Equals("salami"))
                {
                    salamiCount++;
                }
                else if (product.Equals("pepper"))
                {
                    pepperCount++;
                }
            }
            totalCalories = (cheeseCount * 500) +
                    (tomatoSauceCount * 150) +
                    (salamiCount * 600) +
                    (pepperCount * 50);

            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
