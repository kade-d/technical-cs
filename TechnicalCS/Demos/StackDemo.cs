using System;
using System.Collections.Generic;
using TechnicalCS.TechDemos.Printers;

namespace TechnicalCS.TechDemos
{
    class StackDemo : BaseTechDemo
    {
        public StackDemo() : base("Stack")
        {

        }

        override protected void Run()
        {
            Console.WriteLine("A stack is a LIFO data structure.");
            PrintSeparator();

            Normal();
        }

        private void Normal()
        {
            Console.WriteLine("You can push elements on the stack");

            Stack<int> stack = new Stack<int>();

            stack.Push(0);
            stack.Push(1);
            stack.Push(2);


            stack.PrintAsStack();
            PrintSeparator();

            Console.WriteLine("Popping items off the stack will remove the element that arrived LAST\n" +
                "Stack after popping: ");

            var popped = stack.Pop();

            stack.PrintAsStack();
            PrintSeparator();

            Console.WriteLine("The pop operation returns the element that was removed");

            Console.WriteLine("\"I was removed from the stack\" - " + popped);
        }

    }
}
