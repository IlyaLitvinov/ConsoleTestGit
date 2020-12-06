using System;

namespace ConsoleTestGit
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("What is your name?");
            Console.WriteLine("I am Visual Studio!");
            Console.Write("My name is ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
            Console.ReadKey();
        }
    }
}
