﻿using System;
using System.Linq;

namespace _04._Add_VAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal[] numbers = Console.ReadLine()
                                .Split(", ")
                                .Select(n => decimal.Parse(n))
                                .Select(n => n * 1.2m)
                                .ToArray();

            foreach (var number in numbers)
            {
                Console.WriteLine($"{number:f2}");
            }
        }

    }
}
