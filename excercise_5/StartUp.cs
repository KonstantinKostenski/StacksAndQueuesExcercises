using System;
using System.Collections.Generic;
using System.Linq;

namespace excercise_5
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            Queue<long> sequence = new Queue<long>();
            sequence.Enqueue(N);
            List<long> numbersToPrint = new List<long>();
            numbersToPrint.Add(N);

            for (int i = 0; i < 17; i++)
            {
                long currentNumber = sequence.Dequeue();
                long firstNumber = currentNumber + 1;
                long secondNumber = 2 * currentNumber + 1;
                long thirdNumber = currentNumber + 2;
                sequence.Enqueue(firstNumber);
                sequence.Enqueue(secondNumber);
                sequence.Enqueue(thirdNumber);

                numbersToPrint.Add(firstNumber);
                numbersToPrint.Add(secondNumber);
                numbersToPrint.Add(thirdNumber);
            }
            Console.WriteLine(string.Join(' ', numbersToPrint.Take(50)));


        }
    }
}
