using System;
using System.Collections.Generic;
using System.Linq;

namespace excercise_7
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Stack<char> paranthesesStack = new Stack<char>();
            string parantheses = Console.ReadLine();
            char[] openingParantheses = new char[]
            {
                '{',
                '(',
                '['
            };
            bool isValid = true;
            for (int i = 0; i < parantheses.Length; i++)
            {
                char currentBracket = parantheses[i];
                if (openingParantheses.Contains(currentBracket))
                {
                    paranthesesStack.Push(currentBracket);
                    continue;
                }
                if (paranthesesStack.Count == 0)
                {
                    isValid = false;
                    break;
                }
                if (paranthesesStack.Peek() ==  '(' && currentBracket == ')')
                {
                    paranthesesStack.Pop();
                }
                else if (paranthesesStack.Peek() == '[' && currentBracket == ']')
                {
                    paranthesesStack.Pop();
                }
                else if (paranthesesStack.Peek() == '{' && currentBracket == '}')
                {
                    paranthesesStack.Pop();
                }
            }
            if (isValid && paranthesesStack.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }
}
