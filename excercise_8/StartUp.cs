using System;
using System.Collections.Generic;

namespace excercise_8
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Stack<long> fibonacci = new Stack<long>();
            fibonacci.Push(0);
            fibonacci.Push(1);

            long N = long.Parse(Console.ReadLine());

            for (int i = 0; i < N - 1; i++)
            {
                long firstNumber = fibonacci.Pop();
                long secondNumber = fibonacci.Peek();

                fibonacci.Push(firstNumber);
                fibonacci.Push(firstNumber + secondNumber);
            }

            Console.WriteLine(fibonacci.Peek());
        }
    }
}
