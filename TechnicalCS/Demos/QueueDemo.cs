using System;
using System.Collections.Generic;
using TechnicalCS.TechDemos.Printers;

namespace TechnicalCS.TechDemos
{
    class QueueDemo : BaseTechDemo
    {
        public QueueDemo() : base("Queue")
        {

        }

        override protected void Run()
        {
            Console.WriteLine("A queue is a FIFO data structure.");
            PrintSeparator();

            Normal();
        }

        private void Normal()
        {
            Console.WriteLine("You can enqueue elements in queues");

            Queue<int> queue = new Queue<int>();

            queue.Enqueue(0);
            queue.Enqueue(1);
            queue.Enqueue(2);

            queue.ToArray().Print();

            PrintSeparator();

            Console.WriteLine("Dequeueing will remove the element that arrived first");

            var dequeued = queue.Dequeue();

            queue.ToArray().Print();

            PrintSeparator();

            Console.WriteLine("The dequeue operation returns the element that was removed");

            Console.WriteLine("\"I was removed from the queue\" - " + dequeued);
        }

    }
}
