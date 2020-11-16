using System;

namespace StarwarsStuff.Con
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person(){Name ="Bryan"};
            p.Name = "James";
            Console.WriteLine("Hello: " + p.Name);
        }
    }

    record Person
    {
        public string Name { get; set; }
    }
}
