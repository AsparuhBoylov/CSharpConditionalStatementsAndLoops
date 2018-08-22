using System;

namespace _09.MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
       
            while (counter < 10)
            {
                counter++;
                Console.WriteLine($"{n} X {counter} = {n * counter}");
            }
        }
    }
}
