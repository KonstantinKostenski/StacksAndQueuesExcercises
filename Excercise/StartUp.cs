using System;
using System.Collections.Generic;
using System.Linq;

namespace excercise_4
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>();

            int[] commands = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] numbersArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int elementsToEnqueue = commands[0];
            int elemetsToDequeue = commands[1];
            int elementToCheck = commands[2];

            for (int i = 0; i < elementsToEnqueue; i++)
            {
                numbers.Enqueue(numbersArray[i]);
            }

            for (int i = 0; i < elemetsToDequeue; i++)
            {
                if (numbers.Count != 0)
                {
                    numbers.Dequeue();
                }
            }

            if (numbers.Contains(elementToCheck))
            {
                Console.WriteLine("true");
            }
            else if(!numbers.Contains(elementToCheck) && numbers.Count != 0)
            {
                Console.WriteLine(numbers.Min());
            }
            else if(numbers.Count == 0)
            {
                Console.WriteLine(0);
            }

        }
    }
}
