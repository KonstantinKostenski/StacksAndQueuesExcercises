using System;
using System.Collections.Generic;
using System.Linq;

namespace excercise_9
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfOpertions = int.Parse(Console.ReadLine());
            string text = String.Empty;
            Stack<string> stack = new Stack<string>(); 


            for (int i = 0; i < numberOfOpertions; i++)
            {
                string[] commands = Console.ReadLine().Split(' ').ToArray();

                switch (int.Parse(commands[0]))
                {
                    case 1:
                        stack.Push(text);
                        text += commands[1];
                        break;
                    case 2:
                        int count = int.Parse(commands[1]);
                        if (count > text.Length)
                        {
                            count = Math.Min(count, text.Length);
                        }
                        stack.Push(text);
                        text = text.Substring(0, text.Length - count);
                        break;
                    case 3:
                        Console.WriteLine(text[int.Parse(commands[1]) - 1]);
                        break;
                    case 4:
                        if (stack.Count != 0)
                        {
                            text = stack.Pop();
                        }
                        break;
                }
            }
        }
    }
}
