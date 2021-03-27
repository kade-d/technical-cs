using System;
using System.Collections;

namespace TechnicalCS.TechDemos
{
    class HashtableDemo : BaseTechDemo
    {
        public HashtableDemo() : base("Hashtable")
        {

        }

        override protected void Run()
        {
            Console.WriteLine("A hashtable is a collection of key/value pairs. " +
                "\nThe key is hashed to point to the index of the underlying array that contains the associated value.");
            PrintSeparator();
            Normal();
        }

        private void Normal()
        {
            Console.WriteLine("Here you can see the key/value pairs");

            Hashtable ht = new Hashtable();

            ht.Add("Kade", "Student");
            ht.Add("Tom", "Teacher");
            ht.Add("Jerry", "Doctor");

            PrintObject(ht);
        }

        private class TestClass
        {
            string Title;

            public TestClass(string title)
            {
                Title = title;
            }

            public override string ToString()
            {
                return "Class named: " + Title;
            }
        }
    }
}
