using System;

namespace ConsoleTestGit
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("What is your name?");
            Console.WriteLine("I am Visual Studio!");
            while (true)
            {
                Console.Write("My name is ");
                string name = Console.ReadLine();
                if (name == "Выход" || name == "выход" || name == "exit" || name == "Exit")
                    break;

                var user = new User();
                user.Name = name;
                Console.WriteLine($"Hello, {user.Name}!");
            }
            Console.WriteLine("Good bye!");
            Console.ReadKey();
        }
    }
}
