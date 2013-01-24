using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.CheckBrackets
{
    class CheckBrackets
    {
        static void Main(string[] args)
        {
            string expression = "((a+b)(c+d)) + (c - 1)";

            bool isValid = true;
            Stack<char> brackets = new Stack<char>();
            foreach (char c in expression)
            {
                if(c == '(')
                {
                    brackets.Push(c);
                }

                if(c == ')')
                {
                    if(brackets.Count == 0)
                    {
                        isValid = false;
                    }
                    else if(brackets.Peek() != '(')
                    {
                        isValid = false;
                    }
                    else
                    {
                        brackets.Pop();
                    }
                }
            }

            if(isValid)
            {
                Console.WriteLine("The brackets are put correctly");
            }
            else
            {
                Console.WriteLine("The brackets are NOT put correctly");
            }
        }
    }
}
