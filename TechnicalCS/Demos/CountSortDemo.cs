using System;
using System.Linq;
using TechnicalCS.TechDemos.Printers;
using TechnicalCS.TechDemos.Sorters;

namespace TechnicalCS.TechDemos
{
    class CountSortDemo : BaseTechDemo
    {
        public CountSortDemo() : base("Counting Sort")
        {

        }

        override protected void Run()
        {
            Console.WriteLine("Count sort is ..");
            PrintSeparator();

            Normal();
        }

        private void Normal()
        {
            int[] nums = new int[] { 9, 0, 6, 6, 1, 0, 5, 5, 2, 3 };

            Console.WriteLine("Unsorted input");
            nums.Print();

            Console.WriteLine("Counts");

            Enumerable.Range(0, nums.Length).ToArray().Print();

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            foreach (int i in nums)
            {
                Console.Write(" \u25BC ");
            }
            Console.WriteLine();

            nums.GetCounts().Print();

            Console.WriteLine("Sorted Input");
            nums.CountSort().Print();

        }

    }
}
