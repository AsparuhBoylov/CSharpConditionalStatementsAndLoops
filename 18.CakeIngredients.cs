using System;

namespace _07.CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while(command != "Bake!")
            {
                Console.WriteLine($"Adding ingridient {command}");
            }
        }
    }
}
