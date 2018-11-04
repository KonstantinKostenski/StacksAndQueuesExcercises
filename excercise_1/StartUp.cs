using System;
using System.Collections.Generic;
using System.Linq;

namespace excercise_1
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Stack<int> stackNumbers = new Stack<int>();
            foreach (var number in numbers)
            {
                stackNumbers.Push(number);
            }
            while (stackNumbers.Count > 0)
            {
                Console.Write(stackNumbers.Pop());
                Console.Write(' ');
            }
        }
    }
}
