﻿using System;

namespace ConsoleTestGit
{
    /// <summary>
    /// Основной класс программы.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Метод-точка входа в программу.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Ну натворили делов, блин");
            Console.WriteLine("Хрень какая то происходит");
			Console.WriteLine("Хрень какая то происходит в новой ветке.");
			Console.WriteLine("Все поправил.");
            Console.WriteLine("What is your name?");
            Console.WriteLine("I am Visual Studio!");
            Console.WriteLine("test");

            User.Notify += DisplayMessage;
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

        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
