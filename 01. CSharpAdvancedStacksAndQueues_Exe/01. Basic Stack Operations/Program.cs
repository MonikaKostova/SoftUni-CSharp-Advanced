using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] values = Console.ReadLine()
                .Split()
                .Select(int.Parse) 
                .ToArray();

            int[] input = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();

            int valuesToPush = values[0];
            int valuesToPop = values[1];
            int lookUpValue = values[2];

            Stack<int> stack = new Stack<int>(input.Take(valuesToPush));

            while (stack.Count > 0 && valuesToPop > 0)
            {
                stack.Pop();
                valuesToPop --;
            }

            if (stack.Contains(lookUpValue))
            {
                Console.WriteLine("true");
            }
            else if(stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else 
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
