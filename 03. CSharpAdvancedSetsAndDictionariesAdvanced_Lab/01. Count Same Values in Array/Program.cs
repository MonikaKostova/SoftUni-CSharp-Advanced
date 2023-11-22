using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                      .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                      .Select(double.Parse)
                      .ToList();

            //2. речник
            Dictionary<double, int> numbersCount = new Dictionary<double, int>();

            foreach (double number in numbers)
            {
                if (!numbersCount.ContainsKey(number))
                {
                    //нямам запис с ключ даденото число -> това число го срещаме за първи път
                    numbersCount.Add(number, 1);
                }
                else
                {
                    //имам запис с ключ даденото число -> вече сме срещали числото
                    numbersCount[number]++;
                }
            }

            //число -> бр. срещания
            foreach (var entry in numbersCount)
            {
                //entry -> key(число) : value(бр. срещания)
                Console.WriteLine($"{entry.Key} - {entry.Value} times");
            }
        }
    }
}
