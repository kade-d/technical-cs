using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace TechnicalCS
{
    abstract class BaseTechDemo
    {
        public String DemoName { get; set; }

        public BaseTechDemo(String demoName)
        {
            DemoName = demoName;
        }

        protected JsonSerializerOptions options = new JsonSerializerOptions()
        {
            WriteIndented = true
        };

        protected void PrintStarting()
        {
            Console.Write("Running ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(DemoName);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" Demo\r\n");
            PrintSeparator();
        }

        protected void PrintSeparator()
        {
            Console.WriteLine(new String('─', 50));
        }

        protected void PrintObject(dynamic value)
        {
            var json = JsonConvert.SerializeObject(value, Formatting.Indented);
            Console.WriteLine(json);
        }

        public void ExecuteDemo()
        {
            PrintStarting();
            Run();
        }

        protected abstract void Run();
    }
}
