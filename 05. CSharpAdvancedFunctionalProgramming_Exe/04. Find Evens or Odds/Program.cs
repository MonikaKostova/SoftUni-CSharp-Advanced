﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, List<int>> generateRange = (start, end) =>
            {
                List<int> range = new List<int>();

                for (int i = start; i <= end; i++)
                {
                    range.Add(i);
                }

                return range;
            };

            Func<string, int, bool> evenOddMatch = (condition, number) =>
            {
                if (condition == "even")
                {
                    return number % 2 == 0;
                }
                else
                {
                    return number % 2 != 0;
                }
            };

            int[] ranges = Console.ReadLine()
                           .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                           .Select(int.Parse)
                           .ToArray();

            string command = Console.ReadLine();

            List<int> numbers = generateRange(ranges[0], ranges[1]);

            foreach (var number in numbers)
            {
                if (evenOddMatch(command, number))
                {
                    Console.Write($"{number} ");
                }
            }
        }
    }
}
