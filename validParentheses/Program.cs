using System;
using System.Collections.Generic;

namespace validParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            if (IsValid(input))
                Console.WriteLine("valid");
            else
                Console.WriteLine("invalid");
        }

        private static bool IsValid(string input)
        {
            Stack<char> myStack = new Stack<char>();

            foreach(var item in input)
            {
                if((item=='(') || (item == '{') || (item == '['))
                {
                    myStack.Push(item);
                }
                else if((item == ')') || (item == '}') || (item == ']'))
                {
                    var pItem = myStack.Peek();

                    if (item == ')' && pItem == '(')
                        myStack.Pop();
                    else if (item == '}' && pItem == '{')
                        myStack.Pop();
                    else if (item == ']' && pItem == '[')
                        myStack.Pop();
                }
            }
            var result = myStack.Count == 0 ? true : false;
            return result;
        }
    }
}
