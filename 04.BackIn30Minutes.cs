using System;

namespace _03.BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int newTime = minutes + 30;

            if (newTime > 59)
            {
                hours++;
                newTime -= 60;
            }
            if (hours >= 24)
            {
                hours -= 24;
            }

            Console.WriteLine($"{hours}:{newTime:D2}");
            
        }
    }
}
