using System;

namespace _09.CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int count = 0;

            while (true)
            {
                string input = Console.ReadLine();

                try
                {
                   int number = int.Parse(input);
                    count++;
                }
                catch (Exception)
                {
                    Console.WriteLine(count);
                    break;
                }
            }
        }
    }
}
