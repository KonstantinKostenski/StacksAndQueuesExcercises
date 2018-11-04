using System;
using System.Collections.Generic;
using System.Linq;

namespace excercise_3
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Stack<int> numbersStack = new Stack<int>();

            for (int i = 0; i < N; i++)
            {
                int[] querry = Console.ReadLine().Split().Select(int.Parse).ToArray();
                switch (querry[0])
                {
                    case 1:
                        numbersStack.Push(querry[1]);
                        break;
                    case 2:
                        numbersStack.Pop();
                        break;
                    case 3:
                        Console.WriteLine(numbersStack.Max());
                        break;
                    default:
                        break;
                }

            }
        }
    }
}
