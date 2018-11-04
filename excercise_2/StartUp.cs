using System;
using System.Collections.Generic;
using System.Linq;

namespace excercise_2
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Stack<int> numbersStack = new Stack<int>();
            int[] commands = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int elementsToPush = commands[0];
            int elementsToPop = commands[1];
            int elementToFind = commands[2];
            for (int i = 0; i < elementsToPush; i++)
            {
                numbersStack.Push(numbers[i]);
            }
            for (int i = 0; i < elementsToPop; i++)
            {
                if (numbersStack.Count > 0)
                {
                    numbersStack.Pop();
                }
            }
            if (numbersStack.Contains(elementToFind))
            {
                Console.WriteLine("true");
            }
            else if (numbersStack.Count != 0)
            {
                Console.WriteLine(numbersStack.Min());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
