using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string val;
            Console.Write("Enter Integer: ");
            val = Console.ReadLine();
            Console.WriteLine($"Hello {val}!");
        }
    }
}
