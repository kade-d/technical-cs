using System.Collections.Generic;
using System;

namespace TechnicalCS.TechDemos.Printers
{

    public static class StackPrinter
    {

        public static void PrintAsStack<T>(this Stack<T> stack)
        {
            Console.WriteLine("-----");
            foreach (T item in stack)
            {
                Console.WriteLine("| " + item.ToString() + " |");
                Console.WriteLine("-----");
            }

        }
    }
}