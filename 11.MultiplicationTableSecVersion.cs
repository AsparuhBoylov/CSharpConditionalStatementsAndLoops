﻿using System;

namespace _10.MultiplicationTableSecV
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine($"{num} X {count} = {num * count}");
                count++;

            } while (count <= 10);
        }
    }
}
