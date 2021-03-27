using System;
using System.Collections.Generic;
using TechnicalCS.TechDemos;

namespace TechnicalCS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BaseTechDemo> demos = new List<BaseTechDemo>() {
                new HashtableDemo(),
                new QueueDemo(),
                new StackDemo(),
                new BinarySearchTreeDemo(),
                new CountSortDemo()
            };
            while (true)
            {
                Console.WriteLine("Enter the number of the demo you want to see.");
                int i = 0;
                foreach (BaseTechDemo demo in demos)
                {
                    Console.WriteLine(i.ToString() + ") " + demo.DemoName);
                    i += 1;
                }
                int selection = -1;

                try
                {
                    selection = Convert.ToInt32(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Please enter an integer");
                }

                if (selection > -1 && selection <= demos.Count - 1)
                {
                    demos[selection].ExecuteDemo();
                }
            }

        }
    }
}
