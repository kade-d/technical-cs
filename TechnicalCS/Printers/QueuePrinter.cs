using System.Collections.Generic;
using System;

namespace TechnicalCS.TechDemos.Printers
{

    public static class QueuePrinter
    {

        public static void PrintAsQueue<T>(this Queue<T> queue)
        {
            Console.Write("\n| ");
            foreach (T item in queue)
            {
                Console.Write(item.ToString());
                Console.Write(" | ");
            }
            Console.WriteLine();

        }
    }
}