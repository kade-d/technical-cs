using System;
using System.Text;
using TechnicalCS.TechDemos.Util;

namespace TechnicalCS.TechDemos.Printers
{

    public static class ArrayPrinter
    {

        public static void Print(this int[] arr)
        {
            // Console.Write("\n| ");
            // foreach (T item in arr)
            // {
            //     Console.Write(item.ToString());
            //     Console.Write(" | ");
            // }
            // Console.WriteLine();
            Console.OutputEncoding = Encoding.UTF8;


            Console.WriteLine("┌─┐".Repeat(arr.Length));
            Console.WriteLine("│{0:d}│".RepeatFormat(arr.Length, arr));
            Console.WriteLine("└─┘".Repeat(arr.Length));

        }
    }
}